namespace FSIOrderSubmit
{
    partial class Configuration
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
            this.tbArchiveFolderLocation = new System.Windows.Forms.TextBox();
            this.bSaveConfiguration = new System.Windows.Forms.Button();
            this.cbTestMode = new System.Windows.Forms.CheckBox();
            this.bSelectArchiveLocation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbArchiveFolderLocation
            // 
            this.tbArchiveFolderLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FSIOrderSubmit.Properties.Settings.Default, "ArchiveFolderLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbArchiveFolderLocation.Location = new System.Drawing.Point(191, 70);
            this.tbArchiveFolderLocation.Name = "tbArchiveFolderLocation";
            this.tbArchiveFolderLocation.Size = new System.Drawing.Size(493, 20);
            this.tbArchiveFolderLocation.TabIndex = 3;
            this.tbArchiveFolderLocation.Text = global::FSIOrderSubmit.Properties.Settings.Default.ArchiveFolderLocation;
            // 
            // bSaveConfiguration
            // 
            this.bSaveConfiguration.Location = new System.Drawing.Point(191, 252);
            this.bSaveConfiguration.Name = "bSaveConfiguration";
            this.bSaveConfiguration.Size = new System.Drawing.Size(143, 23);
            this.bSaveConfiguration.TabIndex = 6;
            this.bSaveConfiguration.Text = "Save Configuration";
            this.bSaveConfiguration.UseVisualStyleBackColor = true;
            this.bSaveConfiguration.Click += new System.EventHandler(this.bSaveConfiguration_Click);
            // 
            // cbTestMode
            // 
            this.cbTestMode.AutoSize = true;
            this.cbTestMode.Checked = global::FSIOrderSubmit.Properties.Settings.Default.TestMode;
            this.cbTestMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTestMode.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::FSIOrderSubmit.Properties.Settings.Default, "TestMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbTestMode.Location = new System.Drawing.Point(191, 47);
            this.cbTestMode.Name = "cbTestMode";
            this.cbTestMode.Size = new System.Drawing.Size(77, 17);
            this.cbTestMode.TabIndex = 0;
            this.cbTestMode.Text = "Test Mode";
            this.cbTestMode.UseVisualStyleBackColor = true;
            // 
            // bSelectArchiveLocation
            // 
            this.bSelectArchiveLocation.Location = new System.Drawing.Point(696, 70);
            this.bSelectArchiveLocation.Name = "bSelectArchiveLocation";
            this.bSelectArchiveLocation.Size = new System.Drawing.Size(75, 23);
            this.bSelectArchiveLocation.TabIndex = 5;
            this.bSelectArchiveLocation.Text = "Browse";
            this.bSelectArchiveLocation.UseVisualStyleBackColor = true;
            this.bSelectArchiveLocation.Click += new System.EventHandler(this.bSelectArchiveLocation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Archive Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Test Service Base Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Test Service ApiKey";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Test Create Order URI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Live Service Base Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Live Service ApiKey";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Live Create Order URI";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(492, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = global::FSIOrderSubmit.Properties.Settings.Default.TestOrderServiceBaseAddress;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(492, 20);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = global::FSIOrderSubmit.Properties.Settings.Default.TestOrderServiceApiKey;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(190, 148);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(493, 20);
            this.textBox3.TabIndex = 21;
            this.textBox3.Text = global::FSIOrderSubmit.Properties.Settings.Default.TestCreateOrderRequestUri;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(190, 174);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(493, 20);
            this.textBox4.TabIndex = 22;
            this.textBox4.Text = global::FSIOrderSubmit.Properties.Settings.Default.LiveOrderServiceBaseAddress;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(190, 200);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(494, 20);
            this.textBox5.TabIndex = 23;
            this.textBox5.Text = global::FSIOrderSubmit.Properties.Settings.Default.LiveOrderServiceApiKey;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(189, 226);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(495, 20);
            this.textBox6.TabIndex = 24;
            this.textBox6.Text = global::FSIOrderSubmit.Properties.Settings.Default.LiveCreateOrderRequestUri;
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 288);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbArchiveFolderLocation);
            this.Controls.Add(this.bSaveConfiguration);
            this.Controls.Add(this.cbTestMode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSelectArchiveLocation);
            this.Name = "Configuration";
            this.Text = "Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbArchiveFolderLocation;
        private System.Windows.Forms.Button bSaveConfiguration;
        private System.Windows.Forms.CheckBox cbTestMode;
        private System.Windows.Forms.Button bSelectArchiveLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}