using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using PatternRecognition.FingerprintRecognition.Core;
using PatternRecognition.FingerprintRecognition.ResourceProviders;
using BusinessLogic;

namespace PatternRecognition.FingerprintRecognition.Applications
{
    public partial class frmNewRecord : Form
    {
        public frmNewRecord()
        {
            InitializeComponent();
            Assembly thisAss = Assembly.GetExecutingAssembly();
            string dir = Path.GetDirectoryName(thisAss.Location);

            for (int i = 1; i <= 4; i++)
            {
                dir = Directory.GetParent(dir).FullName;
            }

            opfFingerprintImage.InitialDirectory = dir;
        }

        Business fingerprintdata = new Business();


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewRecord_Load(object sender, EventArgs e)
        {
            tbxFullname.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fullname, information, fingerprint;
            fullname = tbxFullname.Text;
            information = tbxInformation.Text;
            fingerprint = Path.GetFileName(opfFingerprintImage.FileName);

            //Copy to database
            string source, destination;
            source = opfFingerprintImage.FileName;

            Assembly thisAss = Assembly.GetExecutingAssembly();
            string dir = Path.GetDirectoryName(thisAss.Location);

            for (int i = 1; i <= 2; i++)
            {
                dir = Directory.GetParent(dir).FullName;
            }
            destination = dir + "\\FingerprintData\\" + fingerprint;
            try
            {
                File.Copy(source, destination);
            }
            catch
            {
                //File exists
            };

            string fingerpath = destination;
            string status = "Null";

            fingerprintdata.InsertIntoFingerprintData(fullname, information, fingerprint, fingerpath, status);
            MessageBox.Show("Insert Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRefresh_Click(null, null);
        }

        private Bitmap img;

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbxFingerprint.Clear();
            tbxFullname.Clear();
            tbxInformation.Clear();
            pbxFingerprint.Image = null;
            tbxFullname.Focus();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                if (opfFingerprintImage.ShowDialog() == DialogResult.OK)
                {
                    tbxFingerprint.Text = opfFingerprintImage.FileName.ToString();
                    img = ImageLoader.LoadImage(opfFingerprintImage.FileName);
                    pbxFingerprint.Image = img;
                }
            }
            catch
            { };
        }

    }
}
