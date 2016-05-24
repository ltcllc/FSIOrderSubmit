namespace FSIOrderSubmit
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
            this.cbTestMode = new System.Windows.Forms.CheckBox();
            this.bProcessFiles = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bSelectFiles = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTestMode
            // 
            this.cbTestMode.AutoSize = true;
            this.cbTestMode.Checked = global::FSIOrderSubmit.Properties.Settings.Default.TestMode;
            this.cbTestMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTestMode.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::FSIOrderSubmit.Properties.Settings.Default, "TestMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbTestMode.Location = new System.Drawing.Point(13, 13);
            this.cbTestMode.Name = "cbTestMode";
            this.cbTestMode.Size = new System.Drawing.Size(77, 17);
            this.cbTestMode.TabIndex = 0;
            this.cbTestMode.Text = "Test Mode";
            this.cbTestMode.UseVisualStyleBackColor = true;
            // 
            // bProcessFiles
            // 
            this.bProcessFiles.Location = new System.Drawing.Point(34, 151);
            this.bProcessFiles.Name = "bProcessFiles";
            this.bProcessFiles.Size = new System.Drawing.Size(75, 23);
            this.bProcessFiles.TabIndex = 1;
            this.bProcessFiles.Text = "Process Files";
            this.bProcessFiles.UseVisualStyleBackColor = true;
            this.bProcessFiles.Click += new System.EventHandler(this.bProcessFiles_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt files|*.txt|xml Files|*.xml";
            this.openFileDialog1.Multiselect = true;
            // 
            // bSelectFiles
            // 
            this.bSelectFiles.Location = new System.Drawing.Point(34, 105);
            this.bSelectFiles.Name = "bSelectFiles";
            this.bSelectFiles.Size = new System.Drawing.Size(75, 23);
            this.bSelectFiles.TabIndex = 2;
            this.bSelectFiles.Text = "Select Files";
            this.bSelectFiles.UseVisualStyleBackColor = true;
            this.bSelectFiles.Click += new System.EventHandler(this.bSelectFiles_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FSIOrderSubmit.Properties.Resources.FSILogoText20year;
            this.pictureBox1.Location = new System.Drawing.Point(212, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 81);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 324);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bSelectFiles);
            this.Controls.Add(this.bProcessFiles);
            this.Controls.Add(this.cbTestMode);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileUpload";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbTestMode;
        private System.Windows.Forms.Button bProcessFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bSelectFiles;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

