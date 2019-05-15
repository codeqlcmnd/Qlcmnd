namespace Fingerprint_Identification_Algorithms
{
    partial class FingerprintIdentificationAlgorithms
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
            this.btnNewProfile = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            this.cbxExperiment = new System.Windows.Forms.ComboBox();
            this.cbxMinutiaExtractor = new System.Windows.Forms.ComboBox();
            this.cbxOrientationImageExtractor = new System.Windows.Forms.ComboBox();
            this.cbxSkeletonImageExtractor = new System.Windows.Forms.ComboBox();
            this.cbxMatcher = new System.Windows.Forms.ComboBox();
            this.cbxFeatureProvider = new System.Windows.Forms.ComboBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.gbxProperties = new System.Windows.Forms.GroupBox();
            this.txtNote1 = new System.Windows.Forms.TextBox();
            this.txtNote2 = new System.Windows.Forms.TextBox();
            this.txtNote3 = new System.Windows.Forms.TextBox();
            this.gbxProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewProfile
            // 
            this.btnNewProfile.Location = new System.Drawing.Point(75, 58);
            this.btnNewProfile.Name = "btnNewProfile";
            this.btnNewProfile.Size = new System.Drawing.Size(98, 29);
            this.btnNewProfile.TabIndex = 0;
            this.btnNewProfile.Text = "New Profile";
            this.btnNewProfile.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(236, 58);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(98, 29);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(181, 12);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(630, 22);
            this.txtShow.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(749, 67);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 29);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(387, 58);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 29);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(536, 58);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(98, 29);
            this.btnExtract.TabIndex = 6;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // cbxExperiment
            // 
            this.cbxExperiment.FormattingEnabled = true;
            this.cbxExperiment.Location = new System.Drawing.Point(900, 173);
            this.cbxExperiment.Name = "cbxExperiment";
            this.cbxExperiment.Size = new System.Drawing.Size(41, 24);
            this.cbxExperiment.TabIndex = 7;
            this.cbxExperiment.SelectedValueChanged += new System.EventHandler(this.cbxExperiment_SelectedValueChanged);
            // 
            // cbxMinutiaExtractor
            // 
            this.cbxMinutiaExtractor.FormattingEnabled = true;
            this.cbxMinutiaExtractor.Location = new System.Drawing.Point(900, 203);
            this.cbxMinutiaExtractor.Name = "cbxMinutiaExtractor";
            this.cbxMinutiaExtractor.Size = new System.Drawing.Size(41, 24);
            this.cbxMinutiaExtractor.TabIndex = 8;
            this.cbxMinutiaExtractor.SelectedValueChanged += new System.EventHandler(this.cbxMinutiaExtractor_SelectedValueChanged);
            this.cbxMinutiaExtractor.Enter += new System.EventHandler(this.cbxMinutiaExtractor_Enter);
            // 
            // cbxOrientationImageExtractor
            // 
            this.cbxOrientationImageExtractor.FormattingEnabled = true;
            this.cbxOrientationImageExtractor.Location = new System.Drawing.Point(900, 233);
            this.cbxOrientationImageExtractor.Name = "cbxOrientationImageExtractor";
            this.cbxOrientationImageExtractor.Size = new System.Drawing.Size(41, 24);
            this.cbxOrientationImageExtractor.TabIndex = 9;
            this.cbxOrientationImageExtractor.SelectedValueChanged += new System.EventHandler(this.cbxOrientationImageExtractor_SelectedValueChanged);
            this.cbxOrientationImageExtractor.Enter += new System.EventHandler(this.cbxOrientationImageExtractor_Enter);
            // 
            // cbxSkeletonImageExtractor
            // 
            this.cbxSkeletonImageExtractor.FormattingEnabled = true;
            this.cbxSkeletonImageExtractor.Location = new System.Drawing.Point(900, 263);
            this.cbxSkeletonImageExtractor.Name = "cbxSkeletonImageExtractor";
            this.cbxSkeletonImageExtractor.Size = new System.Drawing.Size(41, 24);
            this.cbxSkeletonImageExtractor.TabIndex = 10;
            this.cbxSkeletonImageExtractor.SelectedValueChanged += new System.EventHandler(this.cbxSkeletonImageExtractor_SelectedValueChanged);
            this.cbxSkeletonImageExtractor.Enter += new System.EventHandler(this.cbxSkeletonImageExtractor_Enter);
            // 
            // cbxMatcher
            // 
            this.cbxMatcher.FormattingEnabled = true;
            this.cbxMatcher.Location = new System.Drawing.Point(900, 293);
            this.cbxMatcher.Name = "cbxMatcher";
            this.cbxMatcher.Size = new System.Drawing.Size(41, 24);
            this.cbxMatcher.TabIndex = 11;
            this.cbxMatcher.SelectedValueChanged += new System.EventHandler(this.cbxMatcher_SelectedValueChanged);
            this.cbxMatcher.Enter += new System.EventHandler(this.cbxMatcher_Enter);
            // 
            // cbxFeatureProvider
            // 
            this.cbxFeatureProvider.FormattingEnabled = true;
            this.cbxFeatureProvider.Location = new System.Drawing.Point(900, 323);
            this.cbxFeatureProvider.Name = "cbxFeatureProvider";
            this.cbxFeatureProvider.Size = new System.Drawing.Size(41, 24);
            this.cbxFeatureProvider.TabIndex = 12;
            this.cbxFeatureProvider.SelectedValueChanged += new System.EventHandler(this.cbxFeatureProvider_SelectedValueChanged);
            this.cbxFeatureProvider.Enter += new System.EventHandler(this.cbxFeatureProvider_Enter);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(28, 23);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(49, 37);
            this.propertyGrid1.TabIndex = 13;
            // 
            // gbxProperties
            // 
            this.gbxProperties.Controls.Add(this.propertyGrid1);
            this.gbxProperties.Location = new System.Drawing.Point(910, 58);
            this.gbxProperties.Name = "gbxProperties";
            this.gbxProperties.Size = new System.Drawing.Size(122, 77);
            this.gbxProperties.TabIndex = 14;
            this.gbxProperties.TabStop = false;
            this.gbxProperties.Text = "groupBox1";
            // 
            // txtNote1
            // 
            this.txtNote1.Location = new System.Drawing.Point(101, 459);
            this.txtNote1.Name = "txtNote1";
            this.txtNote1.Size = new System.Drawing.Size(630, 22);
            this.txtNote1.TabIndex = 15;
            // 
            // txtNote2
            // 
            this.txtNote2.Location = new System.Drawing.Point(101, 509);
            this.txtNote2.Name = "txtNote2";
            this.txtNote2.Size = new System.Drawing.Size(630, 22);
            this.txtNote2.TabIndex = 16;
            // 
            // txtNote3
            // 
            this.txtNote3.Location = new System.Drawing.Point(807, 446);
            this.txtNote3.Name = "txtNote3";
            this.txtNote3.Size = new System.Drawing.Size(153, 22);
            this.txtNote3.TabIndex = 17;
            // 
            // FingerprintIdentificationAlgorithms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 543);
            this.Controls.Add(this.txtNote3);
            this.Controls.Add(this.txtNote2);
            this.Controls.Add(this.txtNote1);
            this.Controls.Add(this.gbxProperties);
            this.Controls.Add(this.cbxFeatureProvider);
            this.Controls.Add(this.cbxMatcher);
            this.Controls.Add(this.cbxSkeletonImageExtractor);
            this.Controls.Add(this.cbxOrientationImageExtractor);
            this.Controls.Add(this.cbxMinutiaExtractor);
            this.Controls.Add(this.cbxExperiment);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnNewProfile);
            this.Name = "FingerprintIdentificationAlgorithms";
            this.Text = "Fingerprint Identification Algorithms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxProperties.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewProfile;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.ComboBox cbxExperiment;
        private System.Windows.Forms.ComboBox cbxMinutiaExtractor;
        private System.Windows.Forms.ComboBox cbxOrientationImageExtractor;
        private System.Windows.Forms.ComboBox cbxSkeletonImageExtractor;
        private System.Windows.Forms.ComboBox cbxMatcher;
        private System.Windows.Forms.ComboBox cbxFeatureProvider;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.GroupBox gbxProperties;
        private System.Windows.Forms.TextBox txtNote1;
        private System.Windows.Forms.TextBox txtNote2;
        private System.Windows.Forms.TextBox txtNote3;
    }
}

