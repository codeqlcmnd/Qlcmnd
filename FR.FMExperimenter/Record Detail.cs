using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatternRecognition.FingerprintRecognition.Core;
using PatternRecognition.FingerprintRecognition.FeatureDisplay;
using PatternRecognition.FingerprintRecognition.ResourceProviders;
using System.Diagnostics;
using BusinessLogic;
using System.IO;
using System.Reflection;

namespace PatternRecognition.FingerprintRecognition.Applications
{
    public partial class frmRecord_Detail : Form
    {
        public frmRecord_Detail(IMatcher matcher, IResourceProvider resourceProvider, string resourcePath, DataRow datarow)
        {
            InitializeComponent();

            this.matcher = matcher;
            provider = resourceProvider;
            this.resourcePath = resourcePath;
            repository = new ResourceRepository(resourcePath);

            tbxRecordID.ReadOnly = true;
            tbxFullname.ReadOnly = true;
            tbxInformation.ReadOnly = true;
            tbxFingerprint.ReadOnly = true;
            tbxFingerpath.ReadOnly = true;
            tbxStatus.ReadOnly = true;

            tbxRecordID.Text = datarow[0].ToString();
            tbxFullname.Text = datarow[1].ToString();
            tbxInformation.Text = datarow[2].ToString();
            tbxFingerprint.Text = datarow[3].ToString();
            tbxFingerpath.Text = datarow[4].ToString();
            tbxStatus.Text = datarow[5].ToString();

            Image img = Image.FromFile(tbxFingerpath.Text.ToString());
            pictureBox1.Image = img;
        }

        #region private fields

        private IResourceProvider provider;

        private ResourceRepository repository;

        private string resourcePath;

        private IMatcher matcher;

        private object Features;

        #endregion

        private void Record_Detail_Load(object sender, EventArgs e)
        {
           
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
           string Filename = tbxFingerpath.Text.ToString();
           string shortFileName = Path.GetFileNameWithoutExtension(Filename);

                try
                {
                    Features = provider.GetResource(shortFileName, repository);
                    FingerprintData fingerprintdata = new FingerprintData();
                    int id = Int32.Parse(tbxRecordID.Text);
                    fingerprintdata.UpdateIntoFingerprintData(id);
                    tbxStatus.Text = "Extracted";

                    MessageBox.Show("Image Extracted", "Noticication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch (Exception)
                {
                   
                    return;
                }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
