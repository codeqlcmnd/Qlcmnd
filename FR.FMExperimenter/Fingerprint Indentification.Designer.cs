namespace PatternRecognition.FingerprintRecognition.Applications
{
    partial class FMExperimenterForm
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtgFingerprintData = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnNewRecord = new System.Windows.Forms.Button();
            this.btnIndentification = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbxProperties = new System.Windows.Forms.GroupBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.lblFeatureProvider = new System.Windows.Forms.Label();
            this.cbxFeatureProvider = new System.Windows.Forms.ComboBox();
            this.lblMatcher = new System.Windows.Forms.Label();
            this.cbxMatcher = new System.Windows.Forms.ComboBox();
            this.cbxSkeletonImageExtractor = new System.Windows.Forms.ComboBox();
            this.cbxOrientationImageExtractor = new System.Windows.Forms.ComboBox();
            this.cbxMinutiaExtractor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxResources = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFingerprintData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbxProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "D:\\Fingerprints\\Resources\\FVC2004";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1045, 603);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 28);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtgFingerprintData
            // 
            this.dtgFingerprintData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFingerprintData.Location = new System.Drawing.Point(12, 125);
            this.dtgFingerprintData.Name = "dtgFingerprintData";
            this.dtgFingerprintData.RowTemplate.Height = 24;
            this.dtgFingerprintData.Size = new System.Drawing.Size(1158, 471);
            this.dtgFingerprintData.TabIndex = 38;
            this.dtgFingerprintData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFingerprintData_CellDoubleClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(903, 603);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(98, 29);
            this.btnRefresh.TabIndex = 39;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(312, 603);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 29);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(175, 603);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(98, 29);
            this.btnDetail.TabIndex = 41;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnNewRecord
            // 
            this.btnNewRecord.Location = new System.Drawing.Point(12, 603);
            this.btnNewRecord.Name = "btnNewRecord";
            this.btnNewRecord.Size = new System.Drawing.Size(121, 29);
            this.btnNewRecord.TabIndex = 42;
            this.btnNewRecord.Text = "Add";
            this.btnNewRecord.UseVisualStyleBackColor = true;
            this.btnNewRecord.Click += new System.EventHandler(this.btnNewRecord_Click);
            // 
            // btnIndentification
            // 
            this.btnIndentification.Location = new System.Drawing.Point(449, 603);
            this.btnIndentification.Name = "btnIndentification";
            this.btnIndentification.Size = new System.Drawing.Size(121, 29);
            this.btnIndentification.TabIndex = 45;
            this.btnIndentification.Text = "Identification";
            this.btnIndentification.UseVisualStyleBackColor = true;
            this.btnIndentification.Click += new System.EventHandler(this.btnIndentification_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbxProperties);
            this.groupBox1.Controls.Add(this.lblFeatureProvider);
            this.groupBox1.Controls.Add(this.cbxFeatureProvider);
            this.groupBox1.Controls.Add(this.lblMatcher);
            this.groupBox1.Controls.Add(this.cbxMatcher);
            this.groupBox1.Controls.Add(this.cbxSkeletonImageExtractor);
            this.groupBox1.Controls.Add(this.cbxOrientationImageExtractor);
            this.groupBox1.Controls.Add(this.cbxMinutiaExtractor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxResources);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1158, 109);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Form";
            // 
            // gbxProperties
            // 
            this.gbxProperties.Controls.Add(this.propertyGrid1);
            this.gbxProperties.Location = new System.Drawing.Point(663, 94);
            this.gbxProperties.Margin = new System.Windows.Forms.Padding(4);
            this.gbxProperties.Name = "gbxProperties";
            this.gbxProperties.Padding = new System.Windows.Forms.Padding(4);
            this.gbxProperties.Size = new System.Drawing.Size(38, 33);
            this.gbxProperties.TabIndex = 42;
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
            // 
            // lblFeatureProvider
            // 
            this.lblFeatureProvider.AutoSize = true;
            this.lblFeatureProvider.Location = new System.Drawing.Point(491, 72);
            this.lblFeatureProvider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeatureProvider.Name = "lblFeatureProvider";
            this.lblFeatureProvider.Size = new System.Drawing.Size(114, 17);
            this.lblFeatureProvider.TabIndex = 41;
            this.lblFeatureProvider.Text = "Feature Provider";
            // 
            // cbxFeatureProvider
            // 
            this.cbxFeatureProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFeatureProvider.FormattingEnabled = true;
            this.cbxFeatureProvider.Location = new System.Drawing.Point(626, 69);
            this.cbxFeatureProvider.Margin = new System.Windows.Forms.Padding(4);
            this.cbxFeatureProvider.Name = "cbxFeatureProvider";
            this.cbxFeatureProvider.Size = new System.Drawing.Size(297, 24);
            this.cbxFeatureProvider.TabIndex = 40;
            this.cbxFeatureProvider.SelectedValueChanged += new System.EventHandler(this.cbxFeatureProvider_SelectedValueChanged);
            this.cbxFeatureProvider.Enter += new System.EventHandler(this.cbxFeatureProvider_Enter);
            // 
            // lblMatcher
            // 
            this.lblMatcher.AutoSize = true;
            this.lblMatcher.Location = new System.Drawing.Point(11, 72);
            this.lblMatcher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatcher.Name = "lblMatcher";
            this.lblMatcher.Size = new System.Drawing.Size(200, 17);
            this.lblMatcher.TabIndex = 39;
            this.lblMatcher.Text = "Fingerprint Matching Algorithm";
            // 
            // cbxMatcher
            // 
            this.cbxMatcher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMatcher.FormattingEnabled = true;
            this.cbxMatcher.Location = new System.Drawing.Point(234, 69);
            this.cbxMatcher.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMatcher.Name = "cbxMatcher";
            this.cbxMatcher.Size = new System.Drawing.Size(149, 24);
            this.cbxMatcher.TabIndex = 38;
            this.cbxMatcher.SelectedValueChanged += new System.EventHandler(this.cbxMatcher_SelectedValueChanged);
            this.cbxMatcher.Enter += new System.EventHandler(this.cbxMatcher_Enter);
            // 
            // cbxSkeletonImageExtractor
            // 
            this.cbxSkeletonImageExtractor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSkeletonImageExtractor.FormattingEnabled = true;
            this.cbxSkeletonImageExtractor.Location = new System.Drawing.Point(710, 101);
            this.cbxSkeletonImageExtractor.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSkeletonImageExtractor.Name = "cbxSkeletonImageExtractor";
            this.cbxSkeletonImageExtractor.Size = new System.Drawing.Size(29, 24);
            this.cbxSkeletonImageExtractor.Sorted = true;
            this.cbxSkeletonImageExtractor.TabIndex = 37;
            this.cbxSkeletonImageExtractor.Visible = false;
            this.cbxSkeletonImageExtractor.SelectedValueChanged += new System.EventHandler(this.cbxSkeletonImageExtractor_SelectedValueChanged);
            this.cbxSkeletonImageExtractor.Enter += new System.EventHandler(this.cbxSkeletonImageExtractor_Enter);
            // 
            // cbxOrientationImageExtractor
            // 
            this.cbxOrientationImageExtractor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrientationImageExtractor.FormattingEnabled = true;
            this.cbxOrientationImageExtractor.Location = new System.Drawing.Point(626, 101);
            this.cbxOrientationImageExtractor.Margin = new System.Windows.Forms.Padding(4);
            this.cbxOrientationImageExtractor.Name = "cbxOrientationImageExtractor";
            this.cbxOrientationImageExtractor.Size = new System.Drawing.Size(25, 24);
            this.cbxOrientationImageExtractor.Sorted = true;
            this.cbxOrientationImageExtractor.TabIndex = 36;
            this.cbxOrientationImageExtractor.Visible = false;
            this.cbxOrientationImageExtractor.SelectedValueChanged += new System.EventHandler(this.cbxOrientationImageExtractor_SelectedValueChanged);
            this.cbxOrientationImageExtractor.Enter += new System.EventHandler(this.cbxOrientationImageExtractor_Enter);
            // 
            // cbxMinutiaExtractor
            // 
            this.cbxMinutiaExtractor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMinutiaExtractor.FormattingEnabled = true;
            this.cbxMinutiaExtractor.Location = new System.Drawing.Point(752, 99);
            this.cbxMinutiaExtractor.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMinutiaExtractor.Name = "cbxMinutiaExtractor";
            this.cbxMinutiaExtractor.Size = new System.Drawing.Size(33, 24);
            this.cbxMinutiaExtractor.Sorted = true;
            this.cbxMinutiaExtractor.TabIndex = 35;
            this.cbxMinutiaExtractor.Visible = false;
            this.cbxMinutiaExtractor.SelectedValueChanged += new System.EventHandler(this.cbxMinutiaExtractor_SelectedValueChanged);
            this.cbxMinutiaExtractor.Enter += new System.EventHandler(this.cbxMinutiaExtractor_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Resources";
            // 
            // tbxResources
            // 
            this.tbxResources.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxResources.Location = new System.Drawing.Point(117, 25);
            this.tbxResources.Margin = new System.Windows.Forms.Padding(4);
            this.tbxResources.Name = "tbxResources";
            this.tbxResources.Size = new System.Drawing.Size(1034, 22);
            this.tbxResources.TabIndex = 33;
            this.tbxResources.Text = "D:\\Migue\\Code\\FingerprintRecognition\\CodeProject\\Fingerprint databases\\FVC2004\\DB" +
    "1_A";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(1070, 55);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(81, 28);
            this.btnBrowse.TabIndex = 32;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // FMExperimenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 644);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIndentification);
            this.Controls.Add(this.btnNewRecord);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dtgFingerprintData);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FMExperimenterForm";
            this.Text = "Fingerprint Indentification Program";
            this.Load += new System.EventHandler(this.FMExperimenterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFingerprintData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxProperties.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dtgFingerprintData;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnNewRecord;
        private System.Windows.Forms.Button btnIndentification;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbxProperties;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Label lblFeatureProvider;
        private System.Windows.Forms.ComboBox cbxFeatureProvider;
        private System.Windows.Forms.Label lblMatcher;
        private System.Windows.Forms.ComboBox cbxMatcher;
        private System.Windows.Forms.ComboBox cbxSkeletonImageExtractor;
        private System.Windows.Forms.ComboBox cbxOrientationImageExtractor;
        private System.Windows.Forms.ComboBox cbxMinutiaExtractor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxResources;
        private System.Windows.Forms.Button btnBrowse;
    }
}