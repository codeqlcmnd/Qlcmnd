using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PatternRecognition.FingerprintRecognition.Core;
using PatternRecognition.FingerprintRecognition.FeatureDisplay;
using System.Diagnostics;
using System.Threading;
using System.Data;
using System.Reflection;
using BusinessLogic;

namespace PatternRecognition.FingerprintRecognition.Applications
{
    public partial class frmIndetificationMatching : Form
    {
        public frmIndetificationMatching(IMatcher matcher, IResourceProvider resourceProvider, string resourcePath, string MatchingAlgorithm, DataTable fingertable)
        {
            InitializeComponent();
            this.matcher = matcher;
            provider = resourceProvider;
            this.resourcePath = resourcePath;
            FingerData = fingertable;
            repository = new ResourceRepository(resourcePath);

            tbxMatchingAlgorithm.Text = MatchingAlgorithm.ToString();

            sizerow = Int32.Parse(FingerData.Rows.Count.ToString());
            tbxSizeRow.Text = sizerow.ToString();
            tbxSizeRow.ReadOnly = true;

            tbxRecordID.ReadOnly = true;
            tbxFullname.ReadOnly = true;
            tbxInformation.ReadOnly = true;
            tbxFingerprintImage.ReadOnly = true;
            tbxTimeDetect.ReadOnly = true;
            tbxTimeFinish.ReadOnly = true;
            tbxTimeperRecord.ReadOnly = true;
            tbxMatchingAlgorithm.ReadOnly = true;
            tbxSimilarity.ReadOnly = true;
        }


        private void btnLoadQueryImg_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = resourcePath;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string shortFileName = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                string query_path = Path.GetDirectoryName(openFileDialog1.FileName);
                repository_query = new ResourceRepository(query_path);
                try
                {
                    qFeatures = provider.GetResource(shortFileName, repository_query);
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to load features " + provider.GetSignature() + ". Try using different parameters.", "Feature Loading Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                qImage = ImageLoader.LoadImage(openFileDialog1.FileName);
                pbxQueryImg.Image = qImage;
                tbxQueryImagePath.Text = openFileDialog1.FileName.ToString();
                tbxQueryImagePath.ReadOnly = true;
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

            //    MessageBox.Show(string.Format("Similarity: {0}. Matching minutiae: {1}.", matchingScore, matchingMtiae.Count));
            }
        }

        #region private fields

        private Bitmap qImage, tImage;

        private IResourceProvider provider;

        private ResourceRepository repository, repository_query;

        private string resourcePath;

        private IMatcher matcher;

        private DataTable FingerData;

        private object qFeatures, tFeatures;

        public TimeSpan TimeDetect, TimeFinish = new TimeSpan();

        #endregion


        private void ShowTime()
        {
            string Detect, Finish;
            Detect = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", TimeDetect.Hours, TimeDetect.Minutes, TimeDetect.Seconds, TimeDetect.Milliseconds / 10);
            Finish = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", TimeFinish.Hours, TimeFinish.Minutes, TimeFinish.Seconds, TimeFinish.Milliseconds / 10);

            string note1 = "Time to Detect Record: " + Detect;
            string note2 = "Time to Finish Indentification: " + Finish;
         //   MessageBox.Show(string.Format("{0}\n{1}", note1, note2), "Time Execute", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tbxTimeDetect.Text = Detect;
            tbxTimeFinish.Text = Finish;

            TimeSpan TimeperRecord, SummaryTime = new TimeSpan();
            SummaryTime = TimeDetect + TimeFinish;
            TimeperRecord = new TimeSpan(SummaryTime.Ticks / Int32.Parse(tbxSizeRow.Text));

            string perRecord = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", TimeperRecord.Hours, TimeperRecord.Minutes, TimeperRecord.Seconds, TimeperRecord.Milliseconds / 10);
            tbxTimeperRecord.Text = perRecord.ToString();
            tbxSimilarity.Text = stScore;
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

        private int sizerow;

        private string stScore;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMatchInDatabase_Click(object sender, EventArgs e)
        {
            if (qImage == null)
            {
                MessageBox.Show("Unable to match fingerprints: Unassigned query fingerprint!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Stopwatch stDetect = new Stopwatch();
            Stopwatch stFinish = new Stopwatch();
            stDetect.Start();
            stFinish.Start();
            
            IMinutiaMatcher minutiaMatcher = matcher as IMinutiaMatcher;
            if (minutiaMatcher != null)
            {
                List<MinutiaPair> matchingMtiae = null;

                string filename, shortFileName;
                double score=0.0, maxScore = 0.0;
                int idIndex = -1;

                for (int i = 0; i < sizerow; i++)
                {
                    filename = FingerData.Rows[i][4].ToString();
                    shortFileName = Path.GetFileNameWithoutExtension(filename);
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
                    //-----------------------------

                    matchingMtiae = null;
                    try
                    {
                        score = minutiaMatcher.Match(qFeatures, tFeatures, out matchingMtiae);
                    }
                    catch (Exception superE)
                    { 
                        //Phat hien van tay giong 100%
                        maxScore = 100.0;
                        idIndex = i;
                        try
                        {
                            stDetect.Stop();
                            TimeDetect = stDetect.Elapsed;
                        }
                        catch
                        { 
                            //For second time
                        }
                        //break;
                    }

                    if (score > maxScore)
                    {
                        try
                        {
                            stDetect.Stop();
                            TimeDetect = stDetect.Elapsed;
                        }
                        catch
                        {
                            //For second time
                        }
                        maxScore = score;
                        idIndex = i;
                    }
                }

                stFinish.Stop();
                TimeFinish = stFinish.Elapsed;

                //Print output
                tbxRecordID.Text = FingerData.Rows[idIndex][0].ToString();
                tbxFullname.Text = FingerData.Rows[idIndex][1].ToString();
                tbxInformation.Text = FingerData.Rows[idIndex][2].ToString();
                tbxFingerprintImage.Text = FingerData.Rows[idIndex][3].ToString();

                filename = FingerData.Rows[idIndex][4].ToString();
                shortFileName = Path.GetFileNameWithoutExtension(filename);

                tFeatures = provider.GetResource(shortFileName, repository);
                tImage = ImageLoader.LoadImage(filename);
                pbxTemplateImg.Image = tImage;

                matchingMtiae = null;
                double score2 = minutiaMatcher.Match(qFeatures, tFeatures, out matchingMtiae);
                stScore = score2.ToString();

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

                    if (score2 == 0 || matchingMtiae == null)
                        MessageBox.Show(string.Format("Similarity: {0}.", score2));
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

                        MessageBox.Show(string.Format("Full name: {0}\nInformation: {1}\nSimilarity: {2}. Matching minutiae: {3}.", tbxFullname.Text.ToString(), tbxInformation.Text.ToString(), score2, matchingMtiae.Count), "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(string.Format("Full name: {0}\nInformation: {1}\nSimilarity: {2}. Matching minutiae: {3}.", tbxFullname.Text.ToString(), tbxInformation.Text.ToString(), score2, matchingMtiae.Count), "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   ShowResults(score2, matchingMtiae);
                }
            }
            else
            {
                double score = matcher.Match(qFeatures, tFeatures);
            }
            ShowTime();
        }
    }
}