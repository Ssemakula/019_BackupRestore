using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NotifyMethods.NotifyMessage;

namespace _019_BackupRestore
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }


        

        private void BackupButton_Click(object sender, EventArgs e)
        {
            //BackupDatabase();
            Form form = new BackupForm();
            form.ShowDialog();
            form.Dispose();
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            //BackupDatabase();
            Form form = new RestoreForm();
            form.ShowDialog();
            form.Dispose();
        }
    }
}
