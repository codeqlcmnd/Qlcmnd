using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using PatternRecognition.FingerprintRecognition.Core;
using PatternRecognition.FingerprintRecognition.ResourceProviders;

namespace PatternRecognition.FingerprintRecognition.Applications
{
    public partial class FingerprintVerificationForm : Form
    {
        public FingerprintVerificationForm()
        {
            InitializeComponent();

            var providerByFeatType = new Dictionary<Type, List<Type>>();
            var mtiaListExtractors = new List<Type>();
            var orImgExtractors = new List<Type>();
            var skImgExtractors = new List<Type>();
            var experiments = new List<Type>();

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

                            currInterface = type.GetInterface("IMatchingExperiment");
                            if (currInterface != null)
                            {
                                experiments.Add(type);
                                continue;
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
                }
            foreach (var pair in providersByMatcher)
            {
                var featType = pair.Key.GetInterface("IMatcher`1").GetGenericArguments()[0];
                foreach (var provider in providerByFeatType[featType])
                    pair.Value.Add(provider);
            }
            // Populating cbxMinutiaExtractor
            cbxExperiment.DataSource = experiments;
            cbxExperiment.DisplayMember = "Name";
            cbxExperiment.ValueMember = "Name";

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
            list.RemoveAt(1);
            
            cbxMatcher.DataSource = list;
            cbxMatcher.DisplayMember = "Name";
            cbxMatcher.ValueMember = "Name";

            tbxResources.Text="D:\\Processing\\Do an tot nghiep\\FingerprintRecognition\\FingerprintData";
        }

        private void btnFindResources_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxResources.Text = folderBrowserDialog1.SelectedPath;
            }
        }

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

                //--Richtextbox--

                Assembly thisAss = Assembly.GetExecutingAssembly();
                string dir = Path.GetDirectoryName(thisAss.Location);
                dir=dir.Remove(dir.Length - 12, 12);
                string file2 = cbxMatcher.Text.ToString();
                string pt = dir + "/Algorithm/" + file2 + ".rtf";
                rtbShow.LoadFile(pt);
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

        private void cbxExperiment_SelectedValueChanged(object sender, EventArgs e)
        {
            object selectedValue = ((ComboBox)sender).SelectedItem;
            if (selectedValue != null)
            {
                Type experimentType = (Type)selectedValue;
                experiment = Activator.CreateInstance(experimentType) as IMatchingExperiment;
            }
        }

        #region private fields

        private MinutiaListProvider mtiaListProvider = new MinutiaListProvider();

        private OrientationImageProvider orImgProvider = new OrientationImageProvider();

        private SkeletonImageProvider skImgProvider = new SkeletonImageProvider();

        private readonly Dictionary<Type, List<Type>> providersByMatcher = new Dictionary<Type, List<Type>>();

        private IMatcher matcher;

        private IMatchingExperiment experiment;

        private IResourceProvider resourceProvider;

        #endregion

      

        private void FMExperimenterForm_Load(object sender, EventArgs e)
        {
            rtbShow.ReadOnly = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVerification_Click(object sender, EventArgs e)
        {
            if (tbxResources.Text == "")
            {
                MessageBox.Show("Unable to perform visual matching: Unspecified resource path!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(tbxResources.Text))
            {
                MessageBox.Show("Unable to perform visual matching: Invalid resource path!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
            string stmatcher, stprovider;
            stmatcher = cbxMatcher.Text.ToString();
            stprovider = cbxFeatureProvider.Text.ToString();

            (new FingeprintMatchingAlgorithmsForm(matcher, resourceProvider, tbxResources.Text, stmatcher, stprovider)).ShowDialog();
        }

    }
}