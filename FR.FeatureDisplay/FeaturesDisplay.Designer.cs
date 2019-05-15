namespace PatternRecognition.FingerprintRecognition.Applications
{
    partial class FeatureDisplayForm
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
            this.cbxFeatureDisplayers = new System.Windows.Forms.ComboBox();
            this.cbxFeatureExtractors = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnShowFeatures = new System.Windows.Forms.Button();
            this.lblFeatDisplay = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxFeatureDisplayers
            // 
            this.cbxFeatureDisplayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFeatureDisplayers.FormattingEnabled = true;
            this.cbxFeatureDisplayers.Location = new System.Drawing.Point(219, 556);
            this.cbxFeatureDisplayers.Margin = new System.Windows.Forms.Padding(4);
            this.cbxFeatureDisplayers.Name = "cbxFeatureDisplayers";
            this.cbxFeatureDisplayers.Size = new System.Drawing.Size(249, 24);
            this.cbxFeatureDisplayers.Sorted = true;
            this.cbxFeatureDisplayers.TabIndex = 0;
            this.cbxFeatureDisplayers.SelectedValueChanged += new System.EventHandler(this.cbxFeatureTypes_SelectedValueChanged);
            // 
            // cbxFeatureExtractors
            // 
            this.cbxFeatureExtractors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFeatureExtractors.FormattingEnabled = true;
            this.cbxFeatureExtractors.Location = new System.Drawing.Point(576, 559);
            this.cbxFeatureExtractors.Margin = new System.Windows.Forms.Padding(4);
            this.cbxFeatureExtractors.Name = "cbxFeatureExtractors";
            this.cbxFeatureExtractors.Size = new System.Drawing.Size(10, 24);
            this.cbxFeatureExtractors.Sorted = true;
            this.cbxFeatureExtractors.TabIndex = 2;
            this.cbxFeatureExtractors.Visible = false;
            this.cbxFeatureExtractors.SelectedValueChanged += new System.EventHandler(this.cbxFeatureExtractors_SelectedValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image Files (*.bmp;*.gif;*.jpg;*.png;*.tif)|*.bmp;*.gif;*.jpg;*.png;*.tif";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnLoad);
            this.panel3.Controls.Add(this.btnShowFeatures);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(602, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(571, 596);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fingerprint Feature";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 498);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(404, 553);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(92, 553);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 28);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnShowFeatures
            // 
            this.btnShowFeatures.Location = new System.Drawing.Point(252, 553);
            this.btnShowFeatures.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowFeatures.Name = "btnShowFeatures";
            this.btnShowFeatures.Size = new System.Drawing.Size(100, 28);
            this.btnShowFeatures.TabIndex = 1;
            this.btnShowFeatures.Text = "Show";
            this.btnShowFeatures.UseVisualStyleBackColor = true;
            this.btnShowFeatures.Click += new System.EventHandler(this.btnShowFeatures_Click);
            // 
            // lblFeatDisplay
            // 
            this.lblFeatDisplay.AutoSize = true;
            this.lblFeatDisplay.Location = new System.Drawing.Point(77, 559);
            this.lblFeatDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeatDisplay.Name = "lblFeatDisplay";
            this.lblFeatDisplay.Size = new System.Drawing.Size(107, 17);
            this.lblFeatDisplay.TabIndex = 3;
            this.lblFeatDisplay.Text = "Feature Display";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblFeatDisplay);
            this.panel2.Controls.Add(this.cbxFeatureExtractors);
            this.panel2.Controls.Add(this.cbxFeatureDisplayers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 596);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Query Fingerprint";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(14, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(572, 498);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // FeatureDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 596);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FeatureDisplayForm";
            this.Text = "Feature Display";
            this.Load += new System.EventHandler(this.frmFeaturesDisplay_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxFeatureDisplayers;
        private System.Windows.Forms.ComboBox cbxFeatureExtractors;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnShowFeatures;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblFeatDisplay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}