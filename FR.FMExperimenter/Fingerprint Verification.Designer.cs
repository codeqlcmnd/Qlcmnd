namespace PatternRecognition.FingerprintRecognition.Applications
{
    partial class FingerprintVerificationForm
    {
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbxResources = new System.Windows.Forms.TextBox();
            this.btnFindResources = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cbxMinutiaExtractor = new System.Windows.Forms.ComboBox();
            this.cbxOrientationImageExtractor = new System.Windows.Forms.ComboBox();
            this.cbxSkeletonImageExtractor = new System.Windows.Forms.ComboBox();
            this.lblMatcher = new System.Windows.Forms.Label();
            this.cbxMatcher = new System.Windows.Forms.ComboBox();
            this.lblFeatureProvider = new System.Windows.Forms.Label();
            this.cbxFeatureProvider = new System.Windows.Forms.ComboBox();
            this.gbxProperties = new System.Windows.Forms.GroupBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.cbxExperiment = new System.Windows.Forms.ComboBox();
            this.btnVerification = new System.Windows.Forms.Button();
            this.rtbShow = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Resources";
            // 
            // tbxResources
            // 
            this.tbxResources.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxResources.Location = new System.Drawing.Point(17, 47);
            this.tbxResources.Margin = new System.Windows.Forms.Padding(4);
            this.tbxResources.Name = "tbxResources";
            this.tbxResources.Size = new System.Drawing.Size(675, 22);
            this.tbxResources.TabIndex = 15;
            this.tbxResources.Text = "D:\\Migue\\Code\\FingerprintRecognition\\CodeProject\\Fingerprint databases\\FVC2004\\DB" +
    "1_A";
            // 
            // btnFindResources
            // 
            this.btnFindResources.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindResources.Location = new System.Drawing.Point(612, 77);
            this.btnFindResources.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindResources.Name = "btnFindResources";
            this.btnFindResources.Size = new System.Drawing.Size(81, 28);
            this.btnFindResources.TabIndex = 14;
            this.btnFindResources.Text = "Browse";
            this.btnFindResources.UseVisualStyleBackColor = true;
            this.btnFindResources.Click += new System.EventHandler(this.btnFindResources_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "D:\\Fingerprints\\Resources\\FVC2004";
            // 
            // cbxMinutiaExtractor
            // 
            this.cbxMinutiaExtractor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMinutiaExtractor.FormattingEnabled = true;
            this.cbxMinutiaExtractor.Location = new System.Drawing.Point(556, 125);
            this.cbxMinutiaExtractor.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMinutiaExtractor.Name = "cbxMinutiaExtractor";
            this.cbxMinutiaExtractor.Size = new System.Drawing.Size(33, 24);
            this.cbxMinutiaExtractor.Sorted = true;
            this.cbxMinutiaExtractor.TabIndex = 17;
            this.cbxMinutiaExtractor.Visible = false;
            this.cbxMinutiaExtractor.SelectedValueChanged += new System.EventHandler(this.cbxMinutiaExtractor_SelectedValueChanged);
            this.cbxMinutiaExtractor.Enter += new System.EventHandler(this.cbxMinutiaExtractor_Enter);
            // 
            // cbxOrientationImageExtractor
            // 
            this.cbxOrientationImageExtractor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrientationImageExtractor.FormattingEnabled = true;
            this.cbxOrientationImageExtractor.Location = new System.Drawing.Point(597, 156);
            this.cbxOrientationImageExtractor.Margin = new System.Windows.Forms.Padding(4);
            this.cbxOrientationImageExtractor.Name = "cbxOrientationImageExtractor";
            this.cbxOrientationImageExtractor.Size = new System.Drawing.Size(25, 24);
            this.cbxOrientationImageExtractor.Sorted = true;
            this.cbxOrientationImageExtractor.TabIndex = 19;
            this.cbxOrientationImageExtractor.Visible = false;
            this.cbxOrientationImageExtractor.SelectedValueChanged += new System.EventHandler(this.cbxOrientationImageExtractor_SelectedValueChanged);
            this.cbxOrientationImageExtractor.Enter += new System.EventHandler(this.cbxOrientationImageExtractor_Enter);
            // 
            // cbxSkeletonImageExtractor
            // 
            this.cbxSkeletonImageExtractor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSkeletonImageExtractor.FormattingEnabled = true;
            this.cbxSkeletonImageExtractor.Location = new System.Drawing.Point(597, 125);
            this.cbxSkeletonImageExtractor.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSkeletonImageExtractor.Name = "cbxSkeletonImageExtractor";
            this.cbxSkeletonImageExtractor.Size = new System.Drawing.Size(29, 24);
            this.cbxSkeletonImageExtractor.Sorted = true;
            this.cbxSkeletonImageExtractor.TabIndex = 21;
            this.cbxSkeletonImageExtractor.Visible = false;
            this.cbxSkeletonImageExtractor.SelectedValueChanged += new System.EventHandler(this.cbxSkeletonImageExtractor_SelectedValueChanged);
            this.cbxSkeletonImageExtractor.Enter += new System.EventHandler(this.cbxSkeletonImageExtractor_Enter);
            // 
            // lblMatcher
            // 
            this.lblMatcher.AutoSize = true;
            this.lblMatcher.Location = new System.Drawing.Point(14, 111);
            this.lblMatcher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatcher.Name = "lblMatcher";
            this.lblMatcher.Size = new System.Drawing.Size(200, 17);
            this.lblMatcher.TabIndex = 24;
            this.lblMatcher.Text = "Fingerprint Matching Algorithm";
            // 
            // cbxMatcher
            // 
            this.cbxMatcher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMatcher.FormattingEnabled = true;
            this.cbxMatcher.Location = new System.Drawing.Point(235, 108);
            this.cbxMatcher.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMatcher.Name = "cbxMatcher";
            this.cbxMatcher.Size = new System.Drawing.Size(297, 24);
            this.cbxMatcher.TabIndex = 23;
            this.cbxMatcher.SelectedValueChanged += new System.EventHandler(this.cbxMatcher_SelectedValueChanged);
            this.cbxMatcher.Enter += new System.EventHandler(this.cbxMatcher_Enter);
            // 
            // lblFeatureProvider
            // 
            this.lblFeatureProvider.AutoSize = true;
            this.lblFeatureProvider.Location = new System.Drawing.Point(14, 156);
            this.lblFeatureProvider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeatureProvider.Name = "lblFeatureProvider";
            this.lblFeatureProvider.Size = new System.Drawing.Size(114, 17);
            this.lblFeatureProvider.TabIndex = 30;
            this.lblFeatureProvider.Text = "Feature Provider";
            // 
            // cbxFeatureProvider
            // 
            this.cbxFeatureProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFeatureProvider.FormattingEnabled = true;
            this.cbxFeatureProvider.Location = new System.Drawing.Point(235, 153);
            this.cbxFeatureProvider.Margin = new System.Windows.Forms.Padding(4);
            this.cbxFeatureProvider.Name = "cbxFeatureProvider";
            this.cbxFeatureProvider.Size = new System.Drawing.Size(297, 24);
            this.cbxFeatureProvider.TabIndex = 29;
            this.cbxFeatureProvider.SelectedValueChanged += new System.EventHandler(this.cbxFeatureProvider_SelectedValueChanged);
            this.cbxFeatureProvider.Enter += new System.EventHandler(this.cbxFeatureProvider_Enter);
            // 
            // gbxProperties
            // 
            this.gbxProperties.Controls.Add(this.propertyGrid1);
            this.gbxProperties.Location = new System.Drawing.Point(634, 137);
            this.gbxProperties.Margin = new System.Windows.Forms.Padding(4);
            this.gbxProperties.Name = "gbxProperties";
            this.gbxProperties.Padding = new System.Windows.Forms.Padding(4);
            this.gbxProperties.Size = new System.Drawing.Size(38, 33);
            this.gbxProperties.TabIndex = 31;
            this.gbxProperties.TabStop = false;
            this.gbxProperties.Text = "Properties";
            this.gbxProperties.Visible = false;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(4, 19);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(4);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(30, 10);
            this.propertyGrid1.TabIndex = 0;
            this.propertyGrid1.Visible = false;
            // 
            // cbxExperiment
            // 
            this.cbxExperiment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExperiment.FormattingEnabled = true;
            this.cbxExperiment.Location = new System.Drawing.Point(556, 157);
            this.cbxExperiment.Margin = new System.Windows.Forms.Padding(4);
            this.cbxExperiment.Name = "cbxExperiment";
            this.cbxExperiment.Size = new System.Drawing.Size(33, 24);
            this.cbxExperiment.Sorted = true;
            this.cbxExperiment.TabIndex = 32;
            this.cbxExperiment.Visible = false;
            this.cbxExperiment.SelectedValueChanged += new System.EventHandler(this.cbxExperiment_SelectedValueChanged);
            // 
            // btnVerification
            // 
            this.btnVerification.Location = new System.Drawing.Point(429, 451);
            this.btnVerification.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerification.Name = "btnVerification";
            this.btnVerification.Size = new System.Drawing.Size(124, 28);
            this.btnVerification.TabIndex = 34;
            this.btnVerification.Text = "Verification";
            this.btnVerification.UseVisualStyleBackColor = true;
            this.btnVerification.Click += new System.EventHandler(this.btnVerification_Click);
            // 
            // rtbShow
            // 
            this.rtbShow.Location = new System.Drawing.Point(17, 193);
            this.rtbShow.Name = "rtbShow";
            this.rtbShow.Size = new System.Drawing.Size(676, 251);
            this.rtbShow.TabIndex = 35;
            this.rtbShow.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(569, 451);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 28);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FingerprintVerificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 489);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rtbShow);
            this.Controls.Add(this.cbxExperiment);
            this.Controls.Add(this.gbxProperties);
            this.Controls.Add(this.btnVerification);
            this.Controls.Add(this.lblFeatureProvider);
            this.Controls.Add(this.cbxFeatureProvider);
            this.Controls.Add(this.lblMatcher);
            this.Controls.Add(this.cbxMatcher);
            this.Controls.Add(this.cbxSkeletonImageExtractor);
            this.Controls.Add(this.cbxOrientationImageExtractor);
            this.Controls.Add(this.cbxMinutiaExtractor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxResources);
            this.Controls.Add(this.btnFindResources);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FingerprintVerificationForm";
            this.Text = "Fingerprint Verification";
            this.Load += new System.EventHandler(this.FMExperimenterForm_Load);
            this.gbxProperties.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxResources;
        private System.Windows.Forms.Button btnFindResources;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox cbxMinutiaExtractor;
        private System.Windows.Forms.ComboBox cbxOrientationImageExtractor;
        private System.Windows.Forms.ComboBox cbxSkeletonImageExtractor;
        private System.Windows.Forms.Label lblMatcher;
        private System.Windows.Forms.ComboBox cbxMatcher;
        private System.Windows.Forms.Label lblFeatureProvider;
        private System.Windows.Forms.ComboBox cbxFeatureProvider;
        private System.Windows.Forms.GroupBox gbxProperties;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ComboBox cbxExperiment;
        private System.Windows.Forms.Button btnVerification;
        private System.Windows.Forms.RichTextBox rtbShow;
        private System.Windows.Forms.Button btnClose;
    }
}