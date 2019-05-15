using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PatternRecognition.FingerprintRecognition.Core;
using PatternRecognition.FingerprintRecognition.FeatureDisplay;
using System.Diagnostics;

namespace PatternRecognition.FingerprintRecognition.Applications
{
    public partial class FingeprintMatchingAlgorithmsForm : Form
    {
        public FingeprintMatchingAlgorithmsForm(IMatcher matcher, IResourceProvider resourceProvider, string resourcePath, string stmatcher, string stprovider)
        {
            InitializeComponent();
            this.matcher = matcher;
            provider = resourceProvider;
            this.resourcePath = resourcePath;
            repository = new ResourceRepository(resourcePath);
            txtMatcher.Text = stmatcher;
            txtFeatureProvider.Text = stprovider;
        }

        public FingeprintMatchingAlgorithmsForm()
        {
            // TODO: Complete member initialization
        }

        private void btnLoadQueryImg_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = resourcePath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Stopwatch
                Stopwatch st = new Stopwatch();
                st.Start();

                string shortFileName = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);

                try
                {
                    qFeatures = provider.GetResource(shortFileName, repository);
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to load features " + provider.GetSignature() + ". Try using different parameters.", "Feature Loading Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                qImage = ImageLoader.LoadImage(openFileDialog1.FileName);
                pbxQueryImg.Image = qImage;

                st.Stop();
                tm1 = st.Elapsed;
            }
        }

        private void btnLoadTemplateImg_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = resourcePath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stopwatch st = new Stopwatch();
                st.Start();

                string shortFileName = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                try
                {
                    tFeatures = provider.GetResource(shortFileName, repository);
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to load features " + provider.GetSignature() + ". Try using different parameters.", "Feature Loading Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tImage = ImageLoader.LoadImage(openFileDialog1.FileName);
                pbxTemplateImg.Image = tImage;

                st.Stop();
                tm2 = st.Elapsed;
            }
        }

        private void ShowResults(double matchingScore, List<MinutiaPair> matchingMtiae)
        {
            if (matchingScore == 0 || matchingMtiae == null)
                MessageBox.Show(string.Format("Similarity: {0}.", matchingScore));
            else
            {
                List<Minutia> qMtiae = new List<Minutia>();
                List<Minutia> tMtiae = new List<Minutia>();
                foreach (MinutiaPair mPair in matchingMtiae)
                {
                    qMtiae.Add(mPair.QueryMtia);
                    tMtiae.Add(mPair.TemplateMtia);
                }
                IFeatureDisplay<List<Minutia>> display = new MinutiaeDisplay();

                pbxQueryImg.Image = qImage.Clone() as Bitmap;
                Graphics g = Graphics.FromImage(pbxQueryImg.Image);
                display.Show(qMtiae, g);
                pbxQueryImg.Invalidate();

                pbxTemplateImg.Image = tImage.Clone() as Bitmap;
                g = Graphics.FromImage(pbxTemplateImg.Image);
                display.Show(tMtiae, g);
                pbxTemplateImg.Invalidate();

                MessageBox.Show(string.Format("Similarity: {0}. Matching minutiae: {1}.", matchingScore,
                                              matchingMtiae.Count));
            }
        }

        #region private fields

        private Bitmap qImage, tImage;

        private IResourceProvider provider;

        private ResourceRepository repository;

        private string resourcePath;

        private IMatcher matcher;

        private object qFeatures, tFeatures;

        public TimeSpan tm1, tm2, tm3, tm = new TimeSpan();

        #endregion

        private void btnMatch_Click(object sender, EventArgs e)
        {
            Stopwatch st=new Stopwatch();
            st.Start();

            if (qImage == null)
            {
                MessageBox.Show("Unable to match fingerprints: Unassigned query fingerprint!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tImage == null)
            {
                MessageBox.Show("Unable to match fingerprints: Unassigned template fingerprint!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Matching features
            List<MinutiaPair> matchingMtiae = null;
            double score;
            IMinutiaMatcher minutiaMatcher = matcher as IMinutiaMatcher;
            if (minutiaMatcher != null)
            {
                score = minutiaMatcher.Match(qFeatures, tFeatures, out matchingMtiae);

                st.Stop();
                tm3 = st.Elapsed;

                if (qFeatures is List<Minutia> && tFeatures is List<Minutia>)
                {
                    pbxQueryImg.Image = qImage.Clone() as Bitmap;
                    Graphics g1 = Graphics.FromImage(pbxQueryImg.Image);
                    ShowBlueMinutiae(qFeatures as List<Minutia>, g1);
                    //pbxQueryImg.Invalidate();

                    pbxTemplateImg.Image = tImage.Clone() as Bitmap;
                    Graphics g2 = Graphics.FromImage(pbxTemplateImg.Image);
                    ShowBlueMinutiae(tFeatures as List<Minutia>, g2);
                    //pbxTemplateImg.Invalidate();

                    if (score == 0 || matchingMtiae == null)
                        MessageBox.Show(string.Format("Similarity: {0}.", score));
                    else
                    {
                        List<Minutia> qMtiae = new List<Minutia>();
                        List<Minutia> tMtiae = new List<Minutia>();
                        foreach (MinutiaPair mPair in matchingMtiae)
                        {
                            qMtiae.Add(mPair.QueryMtia);
                            tMtiae.Add(mPair.TemplateMtia);
                        }
                        IFeatureDisplay<List<Minutia>> display = new MinutiaeDisplay();

                        display.Show(qMtiae, g1);
                        pbxQueryImg.Invalidate();

                        display.Show(tMtiae, g2);
                        pbxTemplateImg.Invalidate();

                        MessageBox.Show(string.Format("Similarity: {0}. Matching minutiae: {1}.", score, matchingMtiae.Count), "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    ShowResults(score, matchingMtiae);
            }
            else
                score = matcher.Match(qFeatures, tFeatures);

            ShowTime();
        }

        private void ShowTime()
        {
            tm = tm1 + tm2 + tm3;
            string st1, st2, st3, st;
            st1 = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", tm1.Hours, tm1.Minutes, tm1.Seconds, tm1.Milliseconds / 10);
            st2 = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", tm2.Hours, tm2.Minutes, tm2.Seconds, tm2.Milliseconds / 10);
            st3 = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", tm3.Hours, tm3.Minutes, tm3.Seconds, tm3.Milliseconds / 10);
            st = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", tm.Hours, tm.Minutes, tm.Seconds, tm.Milliseconds / 10);
            string note = "Query Fingerprint Extraction Time: " + st1 + "\nTemplate Fingerprint Extraction Time: " + st2 + "\nMatching Time: " + st3 + "\nTotal Time: " + st;
            MessageBox.Show(note, "Time information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowBlueMinutiae(List<Minutia> features, Graphics g)
        {
            int mtiaRadius = 6;
            int lineLength = 18;
            Pen pen = new Pen(Brushes.Blue) { Width = 3 };
            pen.Color = Color.LightBlue;

            Pen whitePen = new Pen(Brushes.Blue) { Width = 5 };
            whitePen.Color = Color.White;

            int i = 0;
            foreach (Minutia mtia in (IList<Minutia>)features)
            {
                g.DrawEllipse(whitePen, mtia.X - mtiaRadius, mtia.Y - mtiaRadius, 2 * mtiaRadius + 1, 2 * mtiaRadius + 1);
                g.DrawLine(whitePen, mtia.X, mtia.Y, Convert.ToInt32(mtia.X + lineLength * Math.Cos(mtia.Angle)), Convert.ToInt32(mtia.Y + lineLength * Math.Sin(mtia.Angle)));

                pen.Color = Color.LightBlue;

                g.DrawEllipse(pen, mtia.X - mtiaRadius, mtia.Y - mtiaRadius, 2 * mtiaRadius + 1, 2 * mtiaRadius + 1);
                g.DrawLine(pen, mtia.X, mtia.Y, Convert.ToInt32(mtia.X + lineLength * Math.Cos(mtia.Angle)), Convert.ToInt32(mtia.Y + lineLength * Math.Sin(mtia.Angle)));
                i++;
            }

            Minutia lastMtia = ((IList<Minutia>)features)[((IList<Minutia>)features).Count - 1];
            pen.Color = Color.LightBlue;
            g.DrawEllipse(pen, lastMtia.X - mtiaRadius, lastMtia.Y - mtiaRadius, 2 * mtiaRadius + 1, 2 * mtiaRadius + 1);
            g.DrawLine(pen, lastMtia.X, lastMtia.Y, Convert.ToInt32(lastMtia.X + lineLength * Math.Cos(lastMtia.Angle)), Convert.ToInt32(lastMtia.Y + lineLength * Math.Sin(lastMtia.Angle)));
        }

        private void VisualFingerprintMatchingFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}