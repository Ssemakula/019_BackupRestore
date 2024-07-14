using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LogicMethods.LogicMethods;
using static NotifyMethods.NotifyMessage;

namespace _019_BackupRestore
{
    public partial class BackupForm : Form
    {
        private static string lastSelectedPath = string.Empty;

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

            if(IsTrue(lastSelectedPath))
            {
                dialog.SelectedPath = lastSelectedPath;
            }
            dialog.Description = "Select Backup folder";
            try
            {
                dialog.ShowDialog();
                folderName = dialog.SelectedPath;
                if (!IsTrue(folderName))
                {
                    return;
                }
                lastSelectedPath = dialog.SelectedPath;
                builderName = DateTime.Now.ToString("yyyyMMddHHmmss"); 

                /* -----------Thoughts---------------
                 * Check for empty dir???
                 * option could be create a backup dir in startup
                 * or create one in application directory
                 * or the local/application directory
                 * alternatively reject which I don't think is ideal
                 */

                if(!IsTrue(folderName))
                    folderName = GetDefaultBackupDir();
                filename = folderName + "\\Pon" + builderName + ".pbk"; 
                this.fileTextBox.Text = filename;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private string GetDefaultBackupDir()
        {
            string defaultDir;
            string path = Directory.GetCurrentDirectory(); //Use environment perhaps?

            defaultDir = path + "\\backup";
            /*if (!Directory.Exists(defaultDir))
            {
                Directory.CreateDirectory(defaultDir);
            }*/
            return defaultDir;
        }


        bool BackupDatabase(string filename)
        {
            if(!IsTrue(filename))
            {
                Notify("No destination specified", "Phonebook Backup");
                return false;
            }

            bool result = false;
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand();
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection();
            string qryText;
            string timeStamp = DateTime.Now.ToString("yyyyMMddHHmmss");

            connection.ConnectionString = _019_BackupRestore.Properties.Settings.Default.LoginLessonConnectionString;
            command.Connection = connection;
            qryText = $@"BACKUP DATABASE [phone_book_Lesson] TO  DISK = N'{filename}' 
                    WITH NOFORMAT, INIT,  NAME = N'phone_book_Lesson_{timeStamp}', 
                    SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            try
            {
                command.CommandTimeout = 30; //This is the default so it is a bit unnecessary other than an example
                connection.Open();
                command.CommandText = qryText;
                command.ExecuteNonQuery();
                connection.Close();
                FileInfo fi = new FileInfo(filename);
                if (fi.Exists && fi.Length > 0)
                {
                    Notify("Backup successful", "Phonebook Backup");
                    result = true;
                }
                else
                {
                    Notify("Backup failed", "Phonebook Backup");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        private void BackupButton_Click(object sender, EventArgs e)
        {
            if (BackupDatabase(this.fileTextBox.Text))
                ExitButton_Click(sender, e);
        }
    }
}
