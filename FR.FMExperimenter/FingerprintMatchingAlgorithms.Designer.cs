namespace PatternRecognition.FingerprintRecognition.Applications
{
    partial class FingeprintMatchingAlgorithmsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbxQueryFingerprint = new System.Windows.Forms.GroupBox();
            this.pnlQueryImage = new System.Windows.Forms.Panel();
            this.pbxQueryImg = new System.Windows.Forms.PictureBox();
            this.pnlQueryButtons = new System.Windows.Forms.Panel();
            this.btnLoadQueryImg = new System.Windows.Forms.Button();
            this.gbxTemplateFingerprint = new System.Windows.Forms.GroupBox();
            this.pnlTemplateImage = new System.Windows.Forms.Panel();
            this.pbxTemplateImg = new System.Windows.Forms.PictureBox();
            this.pnlTemplateButtons = new System.Windows.Forms.Panel();
            this.btnLoadTemplateImg = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnMatch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatcher = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.txtFeatureProvider = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbxQueryFingerprint.SuspendLayout();
            this.pnlQueryImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQueryImg)).BeginInit();
            this.pnlQueryButtons.SuspendLayout();
            this.gbxTemplateFingerprint.SuspendLayout();
            this.pnlTemplateImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTemplateImg)).BeginInit();
            this.pnlTemplateButtons.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbxQueryFingerprint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbxTemplateFingerprint);
            this.splitContainer1.Size = new System.Drawing.Size(1339, 867);
            this.splitContainer1.SplitterDistance = 665;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // gbxQueryFingerprint
            // 
            this.gbxQueryFingerprint.Controls.Add(this.pnlQueryImage);
            this.gbxQueryFingerprint.Controls.Add(this.pnlQueryButtons);
            this.gbxQueryFingerprint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxQueryFingerprint.Location = new System.Drawing.Point(0, 0);
            this.gbxQueryFingerprint.Margin = new System.Windows.Forms.Padding(4);
            this.gbxQueryFingerprint.Name = "gbxQueryFingerprint";
            this.gbxQueryFingerprint.Padding = new System.Windows.Forms.Padding(4);
            this.gbxQueryFingerprint.Size = new System.Drawing.Size(665, 867);
            this.gbxQueryFingerprint.TabIndex = 0;
            this.gbxQueryFingerprint.TabStop = false;
            this.gbxQueryFingerprint.Text = "Query Fingerprint";
            // 
            // pnlQueryImage
            // 
            this.pnlQueryImage.AutoScroll = true;
            this.pnlQueryImage.Controls.Add(this.pbxQueryImg);
            this.pnlQueryImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQueryImage.Location = new System.Drawing.Point(4, 19);
            this.pnlQueryImage.Margin = new System.Windows.Forms.Padding(4);
            this.pnlQueryImage.Name = "pnlQueryImage";
            this.pnlQueryImage.Size = new System.Drawing.Size(657, 800);
            this.pnlQueryImage.TabIndex = 0;
            // 
            // pbxQueryImg
            // 
            this.pbxQueryImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxQueryImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxQueryImg.Location = new System.Drawing.Point(11, 13);
            this.pbxQueryImg.Margin = new System.Windows.Forms.Padding(2);
            this.pbxQueryImg.Name = "pbxQueryImg";
            this.pbxQueryImg.Size = new System.Drawing.Size(632, 774);
            this.pbxQueryImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxQueryImg.TabIndex = 0;
            this.pbxQueryImg.TabStop = false;
            // 
            // pnlQueryButtons
            // 
            this.pnlQueryButtons.Controls.Add(this.btnLoadQueryImg);
            this.pnlQueryButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlQueryButtons.Location = new System.Drawing.Point(4, 819);
            this.pnlQueryButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlQueryButtons.Name = "pnlQueryButtons";
            this.pnlQueryButtons.Size = new System.Drawing.Size(657, 44);
            this.pnlQueryButtons.TabIndex = 1;
            // 
            // btnLoadQueryImg
            // 
            this.btnLoadQueryImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadQueryImg.Location = new System.Drawing.Point(525, 8);
            this.btnLoadQueryImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadQueryImg.Name = "btnLoadQueryImg";
            this.btnLoadQueryImg.Size = new System.Drawing.Size(128, 28);
            this.btnLoadQueryImg.TabIndex = 0;
            this.btnLoadQueryImg.Text = "Load Query";
            this.btnLoadQueryImg.UseVisualStyleBackColor = true;
            this.btnLoadQueryImg.Click += new System.EventHandler(this.btnLoadQueryImg_Click);
            // 
            // gbxTemplateFingerprint
            // 
            this.gbxTemplateFingerprint.Controls.Add(this.pnlTemplateImage);
            this.gbxTemplateFingerprint.Controls.Add(this.pnlTemplateButtons);
            this.gbxTemplateFingerprint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxTemplateFingerprint.Location = new System.Drawing.Point(0, 0);
            this.gbxTemplateFingerprint.Margin = new System.Windows.Forms.Padding(4);
            this.gbxTemplateFingerprint.Name = "gbxTemplateFingerprint";
            this.gbxTemplateFingerprint.Padding = new System.Windows.Forms.Padding(4);
            this.gbxTemplateFingerprint.Size = new System.Drawing.Size(669, 867);
            this.gbxTemplateFingerprint.TabIndex = 1;
            this.gbxTemplateFingerprint.TabStop = false;
            this.gbxTemplateFingerprint.Text = "Template Fingerprint";
            // 
            // pnlTemplateImage
            // 
            this.pnlTemplateImage.AutoScroll = true;
            this.pnlTemplateImage.Controls.Add(this.pbxTemplateImg);
            this.pnlTemplateImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTemplateImage.Location = new System.Drawing.Point(4, 19);
            this.pnlTemplateImage.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTemplateImage.Name = "pnlTemplateImage";
            this.pnlTemplateImage.Size = new System.Drawing.Size(661, 800);
            this.pnlTemplateImage.TabIndex = 2;
            // 
            // pbxTemplateImg
            // 
            this.pbxTemplateImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxTemplateImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxTemplateImg.Location = new System.Drawing.Point(14, 13);
            this.pbxTemplateImg.Margin = new System.Windows.Forms.Padding(2);
            this.pbxTemplateImg.Name = "pbxTemplateImg";
            this.pbxTemplateImg.Size = new System.Drawing.Size(638, 774);
            this.pbxTemplateImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTemplateImg.TabIndex = 1;
            this.pbxTemplateImg.TabStop = false;
            // 
            // pnlTemplateButtons
            // 
            this.pnlTemplateButtons.Controls.Add(this.btnLoadTemplateImg);
            this.pnlTemplateButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTemplateButtons.Location = new System.Drawing.Point(4, 819);
            this.pnlTemplateButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTemplateButtons.Name = "pnlTemplateButtons";
            this.pnlTemplateButtons.Size = new System.Drawing.Size(661, 44);
            this.pnlTemplateButtons.TabIndex = 3;
            // 
            // btnLoadTemplateImg
            // 
            this.btnLoadTemplateImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadTemplateImg.Location = new System.Drawing.Point(533, 8);
            this.btnLoadTemplateImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadTemplateImg.Name = "btnLoadTemplateImg";
            this.btnLoadTemplateImg.Size = new System.Drawing.Size(119, 28);
            this.btnLoadTemplateImg.TabIndex = 2;
            this.btnLoadTemplateImg.Text = "Load Template";
            this.btnLoadTemplateImg.UseVisualStyleBackColor = true;
            this.btnLoadTemplateImg.Click += new System.EventHandler(this.btnLoadTemplateImg_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image Files|*.tif;*.bmp;*.jpg";
            // 
            // btnMatch
            // 
            this.btnMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMatch.AutoSize = true;
            this.btnMatch.Location = new System.Drawing.Point(874, 28);
            this.btnMatch.Margin = new System.Windows.Forms.Padding(4);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(100, 28);
            this.btnMatch.TabIndex = 6;
            this.btnMatch.Text = "Match";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Algorithm:";
            // 
            // txtMatcher
            // 
            this.txtMatcher.Location = new System.Drawing.Point(15, 34);
            this.txtMatcher.Name = "txtMatcher";
            this.txtMatcher.Size = new System.Drawing.Size(282, 22);
            this.txtMatcher.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.AutoSize = true;
            this.btnBack.Location = new System.Drawing.Point(1060, 28);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.AllowDrop = true;
            this.pnlBottom.Controls.Add(this.btnBack);
            this.pnlBottom.Controls.Add(this.txtFeatureProvider);
            this.pnlBottom.Controls.Add(this.txtMatcher);
            this.pnlBottom.Controls.Add(this.label2);
            this.pnlBottom.Controls.Add(this.label1);
            this.pnlBottom.Controls.Add(this.btnMatch);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 867);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1339, 71);
            this.pnlBottom.TabIndex = 0;
            // 
            // txtFeatureProvider
            // 
            this.txtFeatureProvider.Location = new System.Drawing.Point(375, 34);
            this.txtFeatureProvider.Name = "txtFeatureProvider";
            this.txtFeatureProvider.Size = new System.Drawing.Size(282, 22);
            this.txtFeatureProvider.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Feature Provider:";
            // 
            // FingeprintMatchingAlgorithmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 938);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlBottom);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FingeprintMatchingAlgorithmsForm";
            this.Text = "Fingeprint Matching Algorithms";
            this.Load += new System.EventHandler(this.VisualFingerprintMatchingFrm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbxQueryFingerprint.ResumeLayout(false);
            this.pnlQueryImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxQueryImg)).EndInit();
            this.pnlQueryButtons.ResumeLayout(false);
            this.gbxTemplateFingerprint.ResumeLayout(false);
            this.pnlTemplateImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTemplateImg)).EndInit();
            this.pnlTemplateButtons.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox gbxQueryFingerprint;
        private System.Windows.Forms.Panel pnlQueryImage;
        private System.Windows.Forms.PictureBox pbxQueryImg;
        private System.Windows.Forms.Panel pnlQueryButtons;
        private System.Windows.Forms.Button btnLoadQueryImg;
        private System.Windows.Forms.GroupBox gbxTemplateFingerprint;
        private System.Windows.Forms.Panel pnlTemplateImage;
        private System.Windows.Forms.PictureBox pbxTemplateImg;
        private System.Windows.Forms.Panel pnlTemplateButtons;
        private System.Windows.Forms.Button btnLoadTemplateImg;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatcher;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TextBox txtFeatureProvider;
        private System.Windows.Forms.Label label2;
    }
}