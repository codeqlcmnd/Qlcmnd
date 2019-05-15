namespace PatternRecognition.FingerprintRecognition.Applications
{
    partial class frmRecord_Detail
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxFingerpath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxRecordID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxFingerprint = new System.Windows.Forms.TextBox();
            this.tbxInformation = new System.Windows.Forms.TextBox();
            this.tbxFullname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(285, 595);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 31);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(125, 595);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(88, 31);
            this.btnExtract.TabIndex = 20;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxStatus);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxFingerpath);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxRecordID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxFingerprint);
            this.groupBox1.Controls.Add(this.tbxInformation);
            this.groupBox1.Controls.Add(this.tbxFullname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 199);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Record Detail";
            // 
            // tbxStatus
            // 
            this.tbxStatus.Location = new System.Drawing.Point(353, 26);
            this.tbxStatus.Name = "tbxStatus";
            this.tbxStatus.Size = new System.Drawing.Size(99, 22);
            this.tbxStatus.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 72;
            this.label6.Text = "Status";
            // 
            // tbxFingerpath
            // 
            this.tbxFingerpath.Location = new System.Drawing.Point(102, 162);
            this.tbxFingerpath.Name = "tbxFingerpath";
            this.tbxFingerpath.Size = new System.Drawing.Size(350, 22);
            this.tbxFingerpath.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 68;
            this.label5.Text = "Source";
            // 
            // tbxRecordID
            // 
            this.tbxRecordID.Location = new System.Drawing.Point(102, 26);
            this.tbxRecordID.Name = "tbxRecordID";
            this.tbxRecordID.Size = new System.Drawing.Size(99, 22);
            this.tbxRecordID.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "Record ID";
            // 
            // tbxFingerprint
            // 
            this.tbxFingerprint.Location = new System.Drawing.Point(102, 129);
            this.tbxFingerprint.Name = "tbxFingerprint";
            this.tbxFingerprint.Size = new System.Drawing.Size(350, 22);
            this.tbxFingerprint.TabIndex = 65;
            // 
            // tbxInformation
            // 
            this.tbxInformation.Location = new System.Drawing.Point(102, 92);
            this.tbxInformation.Name = "tbxInformation";
            this.tbxInformation.Size = new System.Drawing.Size(350, 22);
            this.tbxInformation.TabIndex = 64;
            // 
            // tbxFullname
            // 
            this.tbxFullname.Location = new System.Drawing.Point(102, 58);
            this.tbxFullname.Name = "tbxFullname";
            this.tbxFullname.Size = new System.Drawing.Size(350, 22);
            this.tbxFullname.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 62;
            this.label3.Text = "Fingerprint";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Fullname";
            // 
            // frmRecord_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 639);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmRecord_Detail";
            this.Text = "Record Detail";
            this.Load += new System.EventHandler(this.Record_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxFingerpath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxRecordID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxFingerprint;
        private System.Windows.Forms.TextBox tbxInformation;
        private System.Windows.Forms.TextBox tbxFullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}