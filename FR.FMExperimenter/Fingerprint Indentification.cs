using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using PatternRecognition.FingerprintRecognition.Core;
using PatternRecognition.FingerprintRecognition.ResourceProviders;
using BusinessLogic;
using System.Data;
using System.Threading;

namespace PatternRecognition.FingerprintRecognition.Applications
{
    public partial class FMExperimenterForm : Form
    {
        public FMExperimenterForm()
        {
            InitializeComponent();

            var providerByFeatType = new Dictionary<Type, List<Type>>();
            var mtiaListExtractors = new List<Type>();
            var orImgExtractors = new List<Type>();
            var skImgExtractors = new List<Type>();

            Assembly thisAss = Assembly.GetExecutingAssembly();
            string dir = Path.GetDirectoryName(thisAss.Location);

            foreach (string fileName in Directory.GetFiles(dir))
                try
                {
                    Assembly currAssembly = Assembly.LoadFile(fileName);
                    foreach (Type type in currAssembly.GetExportedTypes())
                        if (type.IsClass && !type.IsAbstract)
                        {
                            var currInterface = type.GetInterface("IFeatureExtractor`1");
                            if (currInterface != null)
                            {
                                var featType = currInterface.GetGenericArguments()[0];
                                if (featType == typeof(List<Minutia>))
                                {
                                    mtiaListExtractors.Add(type);
                                    continue;
                                }

                                if (featType == typeof(OrientationImage))
                                {
                                    orImgExtractors.Add(type);
                                    continue;
                                }

                                if (featType == typeof(SkeletonImage))
                                {
                                    skImgExtractors.Add(type);
                                    continue;
                                }
                            }

                            currInterface = type.GetInterface("IResourceProvider`1");
                            if (currInterface != null)
                            {
                                var featType = currInterface.GetGenericArguments()[0];
                                if (!providerByFeatType.ContainsKey(featType))
                                    providerByFeatType.Add(featType, new List<Type>());
                                providerByFeatType[featType].Add(type);
                                continue;
                            }

                            currInterface = type.GetInterface("IMatcher`1");
                            if (currInterface != null && !providersByMatcher.ContainsKey(type))
                                providersByMatcher.Add(type, new List<Type>());
                        }
                }
                catch
                {
                };

            foreach (var pair in providersByMatcher)
            {
                var featType = pair.Key.GetInterface("IMatcher`1").GetGenericArguments()[0];
                foreach (var provider in providerByFeatType[featType])
                    pair.Value.Add(provider);
            }

            // Populating cbxMinutiaExtractor
            cbxMinutiaExtractor.DataSource = mtiaListExtractors;
            cbxMinutiaExtractor.DisplayMember = "Name";
            cbxMinutiaExtractor.ValueMember = "Name";

            // Populating cbxMinutiaExtractor
            cbxOrientationImageExtractor.DataSource = orImgExtractors;
            cbxOrientationImageExtractor.DisplayMember = "Name";
            cbxOrientationImageExtractor.ValueMember = "Name";

            // Populating cbxMinutiaExtractor
            cbxSkeletonImageExtractor.DataSource = skImgExtractors;
            cbxSkeletonImageExtractor.DisplayMember = "Name";
            cbxSkeletonImageExtractor.ValueMember = "Name";

            // Populating cbxMatcher
            List<Type> list = new List<Type>(providersByMatcher.Keys);
            if(list.Count>0)
                list.RemoveAt(1);
            cbxMatcher.DataSource = list;
            cbxMatcher.DisplayMember = "Name";
            cbxMatcher.ValueMember = "Name";

            tbxResources.Text="F:\\Code Quan\\Fingerprint Identification Program\\FingerprintData";
        }

        Business fingerprintdata = new Business();


        #region private fields

        private MinutiaListProvider mtiaListProvider = new MinutiaListProvider();

        private OrientationImageProvider orImgProvider = new OrientationImageProvider();

        private SkeletonImageProvider skImgProvider = new SkeletonImageProvider();

        private readonly Dictionary<Type, List<Type>> providersByMatcher = new Dictionary<Type, List<Type>>();

        private IMatcher matcher;

        private IResourceProvider resourceProvider;

        private string resourcePath;

        #endregion


        private void FMExperimenterForm_Load(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();
            datatable = fingerprintdata.SelectFromFingerprintData();
            dtgFingerprintData.DataSource = datatable;

            
            dtgFingerprintData.ReadOnly = true;
            dtgFingerprintData.Columns[0].HeaderText = "Record ID";
            dtgFingerprintData.Columns[1].HeaderText = "Full Name";
            dtgFingerprintData.Columns[2].HeaderText = "Information";
            dtgFingerprintData.Columns[3].HeaderText = "Fingerprint Image";
            dtgFingerprintData.Columns[4].HeaderText = "Fingerprint Path";
            dtgFingerprintData.Columns[5].HeaderText = "Status";
            dtgFingerprintData.AutoResizeColumns();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void dtgFingerprintData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id, fullname, information, fingerprint, fingerpath;
                int row, colums;
                row = e.RowIndex;
                colums = e.ColumnIndex;
                id = dtgFingerprintData[1, row].Value.ToString();
                fullname = dtgFingerprintData[2, row].Value.ToString();
                information = dtgFingerprintData[3, row].Value.ToString();
                fingerprint = dtgFingerprintData[4, row].Value.ToString();
                fingerpath = dtgFingerprintData[5, row].Value.ToString();
            }
            catch
            { };
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = fingerprintdata.SelectFromFingerprintData();
            dtgFingerprintData.DataSource = data;

            dtgFingerprintData.AutoResizeColumns();
            dtgFingerprintData.ReadOnly = true;
            dtgFingerprintData.Columns[0].HeaderText = "Record ID";
            dtgFingerprintData.Columns[1].HeaderText = "Full Name";
            dtgFingerprintData.Columns[2].HeaderText = "Information";
            dtgFingerprintData.Columns[3].HeaderText = "Fingerprint Image";
            dtgFingerprintData.Columns[4].HeaderText = "Fingerprint Path";
            dtgFingerprintData.Columns[5].HeaderText = "Status";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int row = dtgFingerprintData.CurrentCell.RowIndex;
            int id = Int32.Parse(dtgFingerprintData[0, row].Value.ToString());

            DialogResult result = MessageBox.Show("Do you want to delete this Record", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                fingerprintdata.DeleteFromFingerprintData(id);
                MessageBox.Show("Delete Sucessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnRefresh_Click(null, null);
        }


        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            frmNewRecord newrecord = new frmNewRecord();
            newrecord.ShowDialog();
            btnRefresh_Click(null, null);
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            int row = dtgFingerprintData.CurrentCell.RowIndex;
            string filename = dtgFingerprintData[4, row].Value.ToString();

            DataTable datatable = new DataTable();
            datatable = fingerprintdata.SelectFromFingerprintData();
            DataRow datarow = datatable.NewRow();

            datarow[0] = dtgFingerprintData[0, row].Value.ToString();
            datarow[1] = dtgFingerprintData[1, row].Value.ToString();
            datarow[2] = dtgFingerprintData[2, row].Value.ToString();
            datarow[3] = dtgFingerprintData[3, row].Value.ToString();
            datarow[4] = dtgFingerprintData[4, row].Value.ToString();
            datarow[5] = dtgFingerprintData[5, row].Value.ToString();

            resourcePath = tbxResources.Text.ToString();

            if (resourcePath == "")
            {
                MessageBox.Show("Unable to perform visual matching: Unspecified resource path!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(resourcePath))
            {
                MessageBox.Show("Unable to perform visual matching: Invalid resource path!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Type resourceType = resourceProvider.GetType();
                foreach (PropertyInfo propertyInfo in resourceType.GetProperties())
                {
                    var currInterface = propertyInfo.PropertyType.GetInterface("IResourceProvider`1");
                    if (currInterface != null)
                    {
                        var featType = currInterface.GetGenericArguments()[0];
                        if (featType == typeof(OrientationImage))
                        {
                            resourceType.InvokeMember(propertyInfo.Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty, null, resourceProvider, new object[] { orImgProvider });
                            continue;
                        }
                        if (featType == typeof(List<Minutia>))
                        {
                            resourceType.InvokeMember(propertyInfo.Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty, null, resourceProvider, new object[] { mtiaListProvider });
                            continue;
                        }
                        if (featType == typeof(SkeletonImage))
                        {
                            resourceType.InvokeMember(propertyInfo.Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty, null, resourceProvider, new object[] { skImgProvider });
                            continue;
                        }
                    }

                    if (propertyInfo.CanWrite)
                    {
                        currInterface = propertyInfo.PropertyType;
                        if (currInterface.Name == "IFeatureExtractor`1")
                        {
                            var featType = currInterface.GetGenericArguments()[0];
                            if (featType == typeof(OrientationImage))
                            {
                                resourceProvider = orImgProvider;
                                continue;
                            }
                            if (featType == typeof(List<Minutia>))
                            {
                                resourceProvider = mtiaListProvider;
                                continue;
                            }
                            if (featType == typeof(SkeletonImage))
                            {
                                resourceProvider = skImgProvider;
                                continue;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            { }


            Assembly thisAss = Assembly.GetExecutingAssembly();
            string dir = Path.GetDirectoryName(thisAss.Location);

            for (int i = 1; i <= 2; i++)
            {
                dir = Directory.GetParent(dir).FullName;
            }
            string databasepath = dir + "\\FingerprintData\\";
            (new frmRecord_Detail(matcher, resourceProvider, databasepath, datarow)).ShowDialog();

          //  btnRefresh_Click(null, null);
        }

        private void btnIndentification_Click(object sender, EventArgs e)
        {
            resourcePath = tbxResources.Text.ToString();

            if (resourcePath == "")
            {
                MessageBox.Show("Unable to perform visual matching: Unspecified resource path!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(resourcePath))
            {
                MessageBox.Show("Unable to perform visual matching: Invalid resource path!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Type resourceType = resourceProvider.GetType();
                foreach (PropertyInfo propertyInfo in resourceType.GetProperties())
                {
                    var currInterface = propertyInfo.PropertyType.GetInterface("IResourceProvider`1");
                    if (currInterface != null)
                    {
                        var featType = currInterface.GetGenericArguments()[0];
                        if (featType == typeof(OrientationImage))
                        {
                            resourceType.InvokeMember(propertyInfo.Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty, null, resourceProvider, new object[] { orImgProvider });
                            continue;
                        }
                        if (featType == typeof(List<Minutia>))
                        {
                            resourceType.InvokeMember(propertyInfo.Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty, null, resourceProvider, new object[] { mtiaListProvider });
                            continue;
                        }
                        if (featType == typeof(SkeletonImage))
                        {
                            resourceType.InvokeMember(propertyInfo.Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty, null, resourceProvider, new object[] { skImgProvider });
                            continue;
                        }
                    }

                    if (propertyInfo.CanWrite)
                    {
                        currInterface = propertyInfo.PropertyType;
                        if (currInterface.Name == "IFeatureExtractor`1")
                        {
                            var featType = currInterface.GetGenericArguments()[0];
                            if (featType == typeof(OrientationImage))
                            {
                                resourceProvider = orImgProvider;
                                continue;
                            }
                            if (featType == typeof(List<Minutia>))
                            {
                                resourceProvider = mtiaListProvider;
                                continue;
                            }
                            if (featType == typeof(SkeletonImage))
                            {
                                resourceProvider = skImgProvider;
                                continue;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }

            string matchingalgorithm = cbxMatcher.Text.ToString();

            DataTable datatable = new DataTable();
            datatable = fingerprintdata.SelectFromFingerprintData();

            Assembly thisAss = Assembly.GetExecutingAssembly();
            string dir = Path.GetDirectoryName(thisAss.Location);

            for (int i = 1; i <= 2; i++)
            {
                dir = Directory.GetParent(dir).FullName;
            }
            string databasepath = dir + "\\FingerprintData\\";

            (new frmIndetificationMatching(matcher, resourceProvider, databasepath, matchingalgorithm, datatable)).ShowDialog();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxResources.Text = folderBrowserDialog1.SelectedPath;
                tbxResources.ReadOnly = true;
            }
        }
        //---------------

        private void cbxMatcher_SelectedValueChanged(object sender, EventArgs e)
        {
            object selectedValue = ((ComboBox)sender).SelectedItem;
            if (selectedValue != null)
            {
                Type matcherType = (Type)selectedValue;
                matcher = Activator.CreateInstance(matcherType) as IMatcher;

                cbxFeatureProvider.DataSource = providersByMatcher[matcherType];
                cbxFeatureProvider.DisplayMember = "Name";
                cbxFeatureProvider.ValueMember = "Name";

                cbxMatcher_Enter(sender, e);
            }
        }

        private void cbxFeatureProvider_SelectedValueChanged(object sender, EventArgs e)
        {
            object selectedValue = ((ComboBox)sender).SelectedItem;
            if (selectedValue != null)
            {
                Type providerType = (Type)selectedValue;
                resourceProvider = Activator.CreateInstance(providerType) as IResourceProvider;
                cbxFeatureProvider_Enter(sender, e);
            }
        }

        private void cbxFeatureProvider_Enter(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = resourceProvider;
        }

        private void cbxMatcher_Enter(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = matcher;
        }

        private void cbxMinutiaExtractor_SelectedValueChanged(object sender, EventArgs e)
        {
            object selectedValue = ((ComboBox)sender).SelectedItem;
            if (selectedValue != null)
            {
                Type extractorType = (Type)selectedValue;
                mtiaListProvider.MinutiaListExtractor = Activator.CreateInstance(extractorType) as IFeatureExtractor<List<Minutia>>;
                cbxMinutiaExtractor_Enter(sender, e);
            }
        }

        private void cbxMinutiaExtractor_Enter(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = mtiaListProvider.MinutiaListExtractor;
        }

        private void cbxOrientationImageExtractor_SelectedValueChanged(object sender, EventArgs e)
        {
            object selectedValue = ((ComboBox)sender).SelectedItem;
            if (selectedValue != null)
            {
                Type extractorType = (Type)selectedValue;
                orImgProvider.OrientationImageExtractor = Activator.CreateInstance(extractorType) as IFeatureExtractor<OrientationImage>;
                cbxOrientationImageExtractor_Enter(sender, e);
            }
        }

        private void cbxOrientationImageExtractor_Enter(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = orImgProvider.OrientationImageExtractor;
        }

        private void cbxSkeletonImageExtractor_SelectedValueChanged(object sender, EventArgs e)
        {
            object selectedValue = ((ComboBox)sender).SelectedItem;
            if (selectedValue != null)
            {
                Type extractorType = (Type)selectedValue;
                skImgProvider.SkeletonImageExtractor = Activator.CreateInstance(extractorType) as IFeatureExtractor<SkeletonImage>;
                cbxSkeletonImageExtractor_Enter(sender, e);
            }
        }

        private void cbxSkeletonImageExtractor_Enter(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = skImgProvider.SkeletonImageExtractor;
        }


    }
}