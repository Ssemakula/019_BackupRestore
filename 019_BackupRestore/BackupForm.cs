using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _019_BackupRestore
{
    public partial class BackupForm : Form
    {
        public BackupForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            string folderName;
            string filename, builderName;

            try
            {
                dialog.ShowDialog();
                folderName = dialog.SelectedPath;
                builderName = DateTime.Now.ToString("yyyyMMddHHmm");
                filename = folderName + "\\Pon" + builderName + ".pbk";
                this.fileTextBox.Text = filename;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
