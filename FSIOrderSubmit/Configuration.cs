using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSIOrderSubmit
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
        }

        private void bSelectArchiveLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select the Archive folder";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tbArchiveFolderLocation.Text = fbd.SelectedPath;
            }
        }

        private void bSaveConfiguration_Click(object sender, EventArgs e)
        {
            FSIOrderSubmit.Properties.Settings.Default.Save();
        }
    }
}
