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
            this.bProcessFiles = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bSelectFiles = new System.Windows.Forms.Button();
            this.fbdArchiveLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMessage = new System.Windows.Forms.Label();
            this.chkAsync = new System.Windows.Forms.CheckBox();
            this.bOrderStatusTest = new System.Windows.Forms.Button();
            this.bGetItem = new System.Windows.Forms.Button();
            this.bGetAllItems = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bProcessFiles
            // 
            this.bProcessFiles.Location = new System.Drawing.Point(12, 77);
            this.bProcessFiles.Name = "bProcessFiles";
            this.bProcessFiles.Size = new System.Drawing.Size(123, 23);
            this.bProcessFiles.TabIndex = 1;
            this.bProcessFiles.Text = "Process Files";
            this.bProcessFiles.UseVisualStyleBackColor = true;
            this.bProcessFiles.Click += new System.EventHandler(this.bProcessFiles_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.Filter = "xml Files|*.xml|txt files|*.txt";
            this.openFileDialog1.Multiselect = true;
            // 
            // bSelectFiles
            // 
            this.bSelectFiles.Location = new System.Drawing.Point(12, 48);
            this.bSelectFiles.Name = "bSelectFiles";
            this.bSelectFiles.Size = new System.Drawing.Size(123, 23);
            this.bSelectFiles.TabIndex = 2;
            this.bSelectFiles.Text = "Select files to import";
            this.bSelectFiles.UseVisualStyleBackColor = true;
            this.bSelectFiles.Click += new System.EventHandler(this.bSelectFiles_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConfiguration});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(595, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuConfiguration
            // 
            this.menuConfiguration.Name = "menuConfiguration";
            this.menuConfiguration.Size = new System.Drawing.Size(93, 20);
            this.menuConfiguration.Text = "Configuration";
            this.menuConfiguration.Click += new System.EventHandler(this.menuConfiguration_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(156, 86);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 4;
            // 
            // chkAsync
            // 
            this.chkAsync.AutoSize = true;
            this.chkAsync.Checked = true;
            this.chkAsync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAsync.Location = new System.Drawing.Point(12, 106);
            this.chkAsync.Name = "chkAsync";
            this.chkAsync.Size = new System.Drawing.Size(55, 17);
            this.chkAsync.TabIndex = 5;
            this.chkAsync.Text = "Async";
            this.chkAsync.UseVisualStyleBackColor = true;
            // 
            // bOrderStatusTest
            // 
            this.bOrderStatusTest.Location = new System.Drawing.Point(307, 48);
            this.bOrderStatusTest.Name = "bOrderStatusTest";
            this.bOrderStatusTest.Size = new System.Drawing.Size(131, 23);
            this.bOrderStatusTest.TabIndex = 6;
            this.bOrderStatusTest.Text = "Order Status Test";
            this.bOrderStatusTest.UseVisualStyleBackColor = true;
            this.bOrderStatusTest.Click += new System.EventHandler(this.bOrderStatusTest_Click);
            // 
            // bGetItem
            // 
            this.bGetItem.Location = new System.Drawing.Point(307, 78);
            this.bGetItem.Name = "bGetItem";
            this.bGetItem.Size = new System.Drawing.Size(75, 23);
            this.bGetItem.TabIndex = 7;
            this.bGetItem.Text = "Get Item";
            this.bGetItem.UseVisualStyleBackColor = true;
            this.bGetItem.Click += new System.EventHandler(this.bGetItem_Click);
            // 
            // bGetAllItems
            // 
            this.bGetAllItems.Location = new System.Drawing.Point(388, 78);
            this.bGetAllItems.Name = "bGetAllItems";
            this.bGetAllItems.Size = new System.Drawing.Size(75, 23);
            this.bGetAllItems.TabIndex = 8;
            this.bGetAllItems.Text = "Get All Items";
            this.bGetAllItems.UseVisualStyleBackColor = true;
            this.bGetAllItems.Click += new System.EventHandler(this.bGetAllItems_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 128);
            this.Controls.Add(this.bGetAllItems);
            this.Controls.Add(this.bGetItem);
            this.Controls.Add(this.bOrderStatusTest);
            this.Controls.Add(this.chkAsync);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.bSelectFiles);
            this.Controls.Add(this.bProcessFiles);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "File Upload";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bProcessFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bSelectFiles;
        private System.Windows.Forms.FolderBrowserDialog fbdArchiveLocation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuConfiguration;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.CheckBox chkAsync;
        private System.Windows.Forms.Button bOrderStatusTest;
        private System.Windows.Forms.Button bGetItem;
        private System.Windows.Forms.Button bGetAllItems;
    }
}

