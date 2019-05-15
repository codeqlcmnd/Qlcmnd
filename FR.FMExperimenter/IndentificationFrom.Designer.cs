namespace PatternRecognition.FingerprintRecognition.Applications
{
    partial class frmIndetificationMatching
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
            this.tbxSizeRow = new System.Windows.Forms.TextBox();
            this.tbxMatchingAlgorithm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbxQueryFingerprint = new System.Windows.Forms.GroupBox();
            this.pnlQueryImage = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxQueryImagePath = new System.Windows.Forms.TextBox();
            this.btnMatchInDatabase = new System.Windows.Forms.Button();
            this.btnLoadQueryImg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxQueryImg = new System.Windows.Forms.PictureBox();
            this.gbxTemplateFingerprint = new System.Windows.Forms.GroupBox();
            this.pnlTemplateImage = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSimilarity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxTimeFinish = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxTimeDetect = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxTimeperRecord = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxFingerprintImage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxInformation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxFullname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxRecordID = new System.Windows.Forms.TextBox();
            this.pbxTemplateImg = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbxQueryFingerprint.SuspendLayout();
            this.pnlQueryImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQueryImg)).BeginInit();
            this.gbxTemplateFingerprint.SuspendLayout();
            this.pnlTemplateImage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTemplateImg)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSizeRow
            // 
            this.tbxSizeRow.Location = new System.Drawing.Point(122, 457);
            this.tbxSizeRow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxSizeRow.Name = "tbxSizeRow";
            this.tbxSizeRow.Size = new System.Drawing.Size(56, 20);
            this.tbxSizeRow.TabIndex = 17;
            // 
            // tbxMatchingAlgorithm
            // 
            this.tbxMatchingAlgorithm.Location = new System.Drawing.Point(122, 429);
            this.tbxMatchingAlgorithm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxMatchingAlgorithm.Name = "tbxMatchingAlgorithm";
            this.tbxMatchingAlgorithm.Size = new System.Drawing.Size(109, 20);
            this.tbxMatchingAlgorithm.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 429);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thuật toán:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbxQueryFingerprint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbxTemplateFingerprint);
            this.splitContainer1.Size = new System.Drawing.Size(960, 561);
            this.splitContainer1.SplitterDistance = 468;
            this.splitContainer1.TabIndex = 1;
            // 
            // gbxQueryFingerprint
            // 
            this.gbxQueryFingerprint.Controls.Add(this.pnlQueryImage);
            this.gbxQueryFingerprint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxQueryFingerprint.Location = new System.Drawing.Point(0, 0);
            this.gbxQueryFingerprint.Name = "gbxQueryFingerprint";
            this.gbxQueryFingerprint.Size = new System.Drawing.Size(468, 561);
            this.gbxQueryFingerprint.TabIndex = 0;
            this.gbxQueryFingerprint.TabStop = false;
            this.gbxQueryFingerprint.Text = "Nhập vân tay";
            // 
            // pnlQueryImage
            // 
            this.pnlQueryImage.AutoScroll = true;
            this.pnlQueryImage.Controls.Add(this.btnBack);
            this.pnlQueryImage.Controls.Add(this.label4);
            this.pnlQueryImage.Controls.Add(this.tbxQueryImagePath);
            this.pnlQueryImage.Controls.Add(this.btnMatchInDatabase);
            this.pnlQueryImage.Controls.Add(this.tbxSizeRow);
            this.pnlQueryImage.Controls.Add(this.btnLoadQueryImg);
            this.pnlQueryImage.Controls.Add(this.label2);
            this.pnlQueryImage.Controls.Add(this.pbxQueryImg);
            this.pnlQueryImage.Controls.Add(this.tbxMatchingAlgorithm);
            this.pnlQueryImage.Controls.Add(this.label1);
            this.pnlQueryImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQueryImage.Location = new System.Drawing.Point(3, 16);
            this.pnlQueryImage.Name = "pnlQueryImage";
            this.pnlQueryImage.Size = new System.Drawing.Size(462, 542);
            this.pnlQueryImage.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.AutoSize = true;
            this.btnBack.Location = new System.Drawing.Point(280, 505);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 460);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Records";
            // 
            // tbxQueryImagePath
            // 
            this.tbxQueryImagePath.Location = new System.Drawing.Point(12, 393);
            this.tbxQueryImagePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxQueryImagePath.Name = "tbxQueryImagePath";
            this.tbxQueryImagePath.Size = new System.Drawing.Size(448, 20);
            this.tbxQueryImagePath.TabIndex = 20;
            // 
            // btnMatchInDatabase
            // 
            this.btnMatchInDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMatchInDatabase.AutoSize = true;
            this.btnMatchInDatabase.Location = new System.Drawing.Point(67, 505);
            this.btnMatchInDatabase.Name = "btnMatchInDatabase";
            this.btnMatchInDatabase.Size = new System.Drawing.Size(163, 23);
            this.btnMatchInDatabase.TabIndex = 6;
            this.btnMatchInDatabase.Text = "Ghép nối";
            this.btnMatchInDatabase.UseVisualStyleBackColor = true;
            this.btnMatchInDatabase.Click += new System.EventHandler(this.btnMatchInDatabase_Click);
            // 
            // btnLoadQueryImg
            // 
            this.btnLoadQueryImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadQueryImg.Location = new System.Drawing.Point(361, 424);
            this.btnLoadQueryImg.Name = "btnLoadQueryImg";
            this.btnLoadQueryImg.Size = new System.Drawing.Size(98, 23);
            this.btnLoadQueryImg.TabIndex = 0;
            this.btnLoadQueryImg.Text = "Nhập vân tay";
            this.btnLoadQueryImg.UseVisualStyleBackColor = true;
            this.btnLoadQueryImg.Click += new System.EventHandler(this.btnLoadQueryImg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 460);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "CSDL:";
            // 
            // pbxQueryImg
            // 
            this.pbxQueryImg.Location = new System.Drawing.Point(12, 11);
            this.pbxQueryImg.Name = "pbxQueryImg";
            this.pbxQueryImg.Size = new System.Drawing.Size(447, 370);
            this.pbxQueryImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxQueryImg.TabIndex = 0;
            this.pbxQueryImg.TabStop = false;
            // 
            // gbxTemplateFingerprint
            // 
            this.gbxTemplateFingerprint.Controls.Add(this.pnlTemplateImage);
            this.gbxTemplateFingerprint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxTemplateFingerprint.Location = new System.Drawing.Point(0, 0);
            this.gbxTemplateFingerprint.Name = "gbxTemplateFingerprint";
            this.gbxTemplateFingerprint.Size = new System.Drawing.Size(488, 561);
            this.gbxTemplateFingerprint.TabIndex = 1;
            this.gbxTemplateFingerprint.TabStop = false;
            this.gbxTemplateFingerprint.Text = "Kết quả";
            // 
            // pnlTemplateImage
            // 
            this.pnlTemplateImage.AutoScroll = true;
            this.pnlTemplateImage.Controls.Add(this.groupBox1);
            this.pnlTemplateImage.Controls.Add(this.label8);
            this.pnlTemplateImage.Controls.Add(this.tbxFingerprintImage);
            this.pnlTemplateImage.Controls.Add(this.label7);
            this.pnlTemplateImage.Controls.Add(this.tbxInformation);
            this.pnlTemplateImage.Controls.Add(this.label6);
            this.pnlTemplateImage.Controls.Add(this.tbxFullname);
            this.pnlTemplateImage.Controls.Add(this.label5);
            this.pnlTemplateImage.Controls.Add(this.tbxRecordID);
            this.pnlTemplateImage.Controls.Add(this.pbxTemplateImg);
            this.pnlTemplateImage.Location = new System.Drawing.Point(3, 15);
            this.pnlTemplateImage.Name = "pnlTemplateImage";
            this.pnlTemplateImage.Size = new System.Drawing.Size(476, 542);
            this.pnlTemplateImage.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxSimilarity);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbxTimeFinish);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbxTimeDetect);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbxTimeperRecord);
            this.groupBox1.Location = new System.Drawing.Point(10, 455);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(456, 80);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian ghép nối";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Similarity";
            // 
            // tbxSimilarity
            // 
            this.tbxSimilarity.Location = new System.Drawing.Point(79, 52);
            this.tbxSimilarity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxSimilarity.Name = "tbxSimilarity";
            this.tbxSimilarity.Size = new System.Drawing.Size(69, 20);
            this.tbxSimilarity.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(235, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Time Finish";
            // 
            // tbxTimeFinish
            // 
            this.tbxTimeFinish.Location = new System.Drawing.Point(308, 17);
            this.tbxTimeFinish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxTimeFinish.Name = "tbxTimeFinish";
            this.tbxTimeFinish.Size = new System.Drawing.Size(137, 20);
            this.tbxTimeFinish.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Time Detect";
            // 
            // tbxTimeDetect
            // 
            this.tbxTimeDetect.Location = new System.Drawing.Point(79, 17);
            this.tbxTimeDetect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxTimeDetect.Name = "tbxTimeDetect";
            this.tbxTimeDetect.Size = new System.Drawing.Size(137, 20);
            this.tbxTimeDetect.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Time per Record";
            // 
            // tbxTimeperRecord
            // 
            this.tbxTimeperRecord.Location = new System.Drawing.Point(308, 52);
            this.tbxTimeperRecord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxTimeperRecord.Name = "tbxTimeperRecord";
            this.tbxTimeperRecord.Size = new System.Drawing.Size(137, 20);
            this.tbxTimeperRecord.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 427);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Quê quán";
            // 
            // tbxFingerprintImage
            // 
            this.tbxFingerprintImage.Location = new System.Drawing.Point(331, 424);
            this.tbxFingerprintImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxFingerprintImage.Name = "tbxFingerprintImage";
            this.tbxFingerprintImage.Size = new System.Drawing.Size(137, 20);
            this.tbxFingerprintImage.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 396);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Số CMND";
            // 
            // tbxInformation
            // 
            this.tbxInformation.Location = new System.Drawing.Point(331, 393);
            this.tbxInformation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxInformation.Name = "tbxInformation";
            this.tbxInformation.Size = new System.Drawing.Size(137, 20);
            this.tbxInformation.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 427);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Họ và tên";
            // 
            // tbxFullname
            // 
            this.tbxFullname.Location = new System.Drawing.Point(65, 424);
            this.tbxFullname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxFullname.Name = "tbxFullname";
            this.tbxFullname.Size = new System.Drawing.Size(137, 20);
            this.tbxFullname.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 396);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mã tờ khai";
            // 
            // tbxRecordID
            // 
            this.tbxRecordID.Location = new System.Drawing.Point(65, 393);
            this.tbxRecordID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxRecordID.Name = "tbxRecordID";
            this.tbxRecordID.Size = new System.Drawing.Size(137, 20);
            this.tbxRecordID.TabIndex = 21;
            // 
            // pbxTemplateImg
            // 
            this.pbxTemplateImg.Location = new System.Drawing.Point(8, 11);
            this.pbxTemplateImg.Name = "pbxTemplateImg";
            this.pbxTemplateImg.Size = new System.Drawing.Size(458, 370);
            this.pbxTemplateImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTemplateImg.TabIndex = 1;
            this.pbxTemplateImg.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image Files|*.tif;*.bmp;*.jpg";
            // 
            // frmIndetificationMatching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 561);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmIndetificationMatching";
            this.Text = "Ghép nối chỉ bản";
            this.Load += new System.EventHandler(this.VisualFingerprintMatchingFrm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbxQueryFingerprint.ResumeLayout(false);
            this.pnlQueryImage.ResumeLayout(false);
            this.pnlQueryImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQueryImg)).EndInit();
            this.gbxTemplateFingerprint.ResumeLayout(false);
            this.pnlTemplateImage.ResumeLayout(false);
            this.pnlTemplateImage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTemplateImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbxQueryFingerprint;
        private System.Windows.Forms.Panel pnlQueryImage;
        private System.Windows.Forms.GroupBox gbxTemplateFingerprint;
        private System.Windows.Forms.PictureBox pbxQueryImg;
        private System.Windows.Forms.Panel pnlTemplateImage;
        private System.Windows.Forms.PictureBox pbxTemplateImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox tbxMatchingAlgorithm;
        private System.Windows.Forms.TextBox tbxSizeRow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxQueryImagePath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxFingerprintImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxInformation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxFullname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxRecordID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLoadQueryImg;
        private System.Windows.Forms.Button btnMatchInDatabase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxTimeFinish;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxTimeDetect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxTimeperRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSimilarity;
    }
}