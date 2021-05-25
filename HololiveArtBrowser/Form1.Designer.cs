
namespace HololiveArtBrowser
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lewdnessDropdown = new System.Windows.Forms.ComboBox();
            this.lewdnessLabel = new System.Windows.Forms.Label();
            this.tagsTextBox = new System.Windows.Forms.TextBox();
            this.tagsLabel = new System.Windows.Forms.Label();
            this.totalResultsLabel = new System.Windows.Forms.Label();
            this.noticeLabel1 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(12, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(542, 103);
            this.button1.TabIndex = 0;
            this.button1.Text = "Find Art";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(59, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1203, 541);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lewdnessDropdown
            // 
            this.lewdnessDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lewdnessDropdown.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lewdnessDropdown.FormattingEnabled = true;
            this.lewdnessDropdown.Items.AddRange(new object[] {
            "Safe",
            "Questionable",
            "Explicit",
            "Any"});
            this.lewdnessDropdown.Location = new System.Drawing.Point(560, 580);
            this.lewdnessDropdown.Name = "lewdnessDropdown";
            this.lewdnessDropdown.Size = new System.Drawing.Size(121, 24);
            this.lewdnessDropdown.TabIndex = 2;
            this.lewdnessDropdown.SelectedItem = "Safe";
            // 
            // lewdnessLabel
            // 
            this.lewdnessLabel.AutoSize = true;
            this.lewdnessLabel.Location = new System.Drawing.Point(561, 560);
            this.lewdnessLabel.Name = "lewdnessLabel";
            this.lewdnessLabel.Size = new System.Drawing.Size(82, 17);
            this.lewdnessLabel.TabIndex = 3;
            this.lewdnessLabel.Text = "Image Type";
            // 
            // tagsTextBox
            // 
            this.tagsTextBox.Location = new System.Drawing.Point(560, 639);
            this.tagsTextBox.Name = "tagsTextBox";
            this.tagsTextBox.Size = new System.Drawing.Size(742, 22);
            this.tagsTextBox.TabIndex = 4;
            // 
            // tagsLabel
            // 
            this.tagsLabel.AutoSize = true;
            this.tagsLabel.Location = new System.Drawing.Point(560, 616);
            this.tagsLabel.Name = "tagsLabel";
            this.tagsLabel.Size = new System.Drawing.Size(308, 17);
            this.tagsLabel.TabIndex = 5;
            this.tagsLabel.Text = "Extra Tags (Seperate With Comma, No Spaces)";
            // 
            // totalResultsLabel
            // 
            this.totalResultsLabel.AutoSize = true;
            this.totalResultsLabel.Location = new System.Drawing.Point(1146, 560);
            this.totalResultsLabel.Name = "totalResultsLabel";
            this.totalResultsLabel.Size = new System.Drawing.Size(107, 17);
            this.totalResultsLabel.TabIndex = 6;
            this.totalResultsLabel.Text = "Total Results: 0";
            // 
            // noticeLabel1
            // 
            this.noticeLabel1.AutoSize = true;
            this.noticeLabel1.Location = new System.Drawing.Point(1113, 580);
            this.noticeLabel1.Name = "noticeLabel1";
            this.noticeLabel1.Size = new System.Drawing.Size(189, 51);
            this.noticeLabel1.TabIndex = 7;
            this.noticeLabel1.Text = "(The Lower This Number Is, \r\nThe More Likely You Are To \r\nFind Duplicate Artwork)" +
    "\r\n";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(1268, 251);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(34, 87);
            this.nextButton.TabIndex = 8;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(12, 251);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(34, 87);
            this.previousButton.TabIndex = 9;
            this.previousButton.Text = "<";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1314, 674);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.noticeLabel1);
            this.Controls.Add(this.totalResultsLabel);
            this.Controls.Add(this.tagsLabel);
            this.Controls.Add(this.tagsTextBox);
            this.Controls.Add(this.lewdnessLabel);
            this.Controls.Add(this.lewdnessDropdown);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hololive Art Browser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox lewdnessDropdown;
        private System.Windows.Forms.Label lewdnessLabel;
        private System.Windows.Forms.TextBox tagsTextBox;
        private System.Windows.Forms.Label tagsLabel;
        private System.Windows.Forms.Label totalResultsLabel;
        private System.Windows.Forms.Label noticeLabel1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
    }
}

