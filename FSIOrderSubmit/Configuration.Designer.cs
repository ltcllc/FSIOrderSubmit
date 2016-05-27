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
            this.bSaveConfiguration = new System.Windows.Forms.Button();
            this.bSelectArchiveLocation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbArchiveFolderLocation = new System.Windows.Forms.TextBox();
            this.cbTestMode = new System.Windows.Forms.CheckBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.bSelectLogFileLocation = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bSaveConfiguration
            // 
            this.bSaveConfiguration.Location = new System.Drawing.Point(190, 339);
            this.bSaveConfiguration.Name = "bSaveConfiguration";
            this.bSaveConfiguration.Size = new System.Drawing.Size(143, 23);
            this.bSaveConfiguration.TabIndex = 6;
            this.bSaveConfiguration.Text = "Save Configuration";
            this.bSaveConfiguration.UseVisualStyleBackColor = true;
            this.bSaveConfiguration.Click += new System.EventHandler(this.bSaveConfiguration_Click);
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
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(190, 227);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(495, 20);
            this.textBox6.TabIndex = 24;
            this.textBox6.Text = global::FSIOrderSubmit.Properties.Settings.Default.LiveCreateOrderRequestUri;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(190, 200);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(494, 20);
            this.textBox5.TabIndex = 23;
            this.textBox5.Text = global::FSIOrderSubmit.Properties.Settings.Default.LiveOrderServiceApiKey;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(190, 174);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(493, 20);
            this.textBox4.TabIndex = 22;
            this.textBox4.Text = global::FSIOrderSubmit.Properties.Settings.Default.LiveOrderServiceBaseAddress;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(190, 148);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(493, 20);
            this.textBox3.TabIndex = 21;
            this.textBox3.Text = global::FSIOrderSubmit.Properties.Settings.Default.TestCreateOrderRequestUri;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(492, 20);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = global::FSIOrderSubmit.Properties.Settings.Default.TestOrderServiceApiKey;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(492, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = global::FSIOrderSubmit.Properties.Settings.Default.TestOrderServiceBaseAddress;
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
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FSIOrderSubmit.Properties.Settings.Default, "LogFileFolderLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox7.Location = new System.Drawing.Point(190, 253);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(492, 20);
            this.textBox7.TabIndex = 25;
            this.textBox7.Text = global::FSIOrderSubmit.Properties.Settings.Default.LogFileFolderLocation;
            // 
            // bSelectLogFileLocation
            // 
            this.bSelectLogFileLocation.Location = new System.Drawing.Point(696, 253);
            this.bSelectLogFileLocation.Name = "bSelectLogFileLocation";
            this.bSelectLogFileLocation.Size = new System.Drawing.Size(75, 23);
            this.bSelectLogFileLocation.TabIndex = 26;
            this.bSelectLogFileLocation.Text = "Browse";
            this.bSelectLogFileLocation.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Log files folder";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(190, 280);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(492, 20);
            this.textBox8.TabIndex = 28;
            this.textBox8.Text = global::FSIOrderSubmit.Properties.Settings.Default.TestOrderStatusRequestUri;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Test Order Status URI";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Live Order Status URI";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(190, 306);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(492, 20);
            this.textBox9.TabIndex = 31;
            this.textBox9.Text = global::FSIOrderSubmit.Properties.Settings.Default.LiveOrderStatusRequestUri;
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 374);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bSelectLogFileLocation);
            this.Controls.Add(this.textBox7);
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
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button bSelectLogFileLocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
    }
}