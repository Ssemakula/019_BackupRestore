using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LogicMethods.LogicMethods;
using static NotifyMethods.NotifyMessage;

namespace _019_BackupRestore
{
    public partial class RestoreForm : Form
    {
        public RestoreForm()
        {
            InitializeComponent();
        }

        private void RestoreForm_Load(object sender, EventArgs e)
        {
            tip2Label.Text =
                @"Tip 2: Don't put the backup on the Windows drive root folder, or My Documents, or the Desktop" +
                "\n" +
                @"         as it will cause an error";
            tip1Label.Text =
                @"Tip 1: If you burned the file to a CD, be sure to copy it to the hard drive before doing the restore";
            restoreButton.Enabled = false;
            pleaseWaitPanel.Visible = false;

        }

        bool DatabaseExists ()
        {
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand();
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection();
            string qryText;
            bool successState = false;

            connection.ConnectionString = _019_BackupRestore.Properties.Settings.Default.LoginLessonConnectionString;
            command.Connection = connection;
            qryText = @"SELECT database_ID FROM sys.databases WHERE name = 'phone_book_Lesson'";
            try
            {
                connection.Open();
                command.CommandText = qryText;
                long whatever; //debug item
                whatever = command.ExecuteNonQuery(); //Need to check why -1
                //if (whatever > 0) 
                    successState = true;
                connection.Close(); //Make sure connection is closed before next operation
            }
            catch (SqlException )
            {
                Notify("Database timeout");
                successState = false;
            }
            catch (InvalidOperationException)
            {
                Notify("Invalid Operation. Contact database administrator");
                successState = false;
            }
            catch (Exception)
            {
                successState = false;
            }

            return successState;
        }

        bool RestoreDatabase(string filename)
        {
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand();
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection();
            string qryText;
            bool successState = false;
            long fileSize;

            pleaseWaitPanel.Visible = true;
            pleaseWaitPanel.Refresh();
            try
            {
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(filename);
                fileSize = fileInfo.Length;
            }
            catch (Exception ex)
            {
                fileSize = -1;
            }

            if(fileSize <= 0)
            {
                MessageBox.Show("Invalid or corrupt backup file");
                return successState;
            }

            if (!DatabaseExists())
            {
                pleaseWaitPanel.Visible = false;
                Notify("Database does not exist");
                return successState;
            }

            connection.ConnectionString = _019_BackupRestore.Properties.Settings.Default.LoginLessonConnectionString;
            command.Connection = connection;

            qryText = $@"USE [master]
                        ALTER DATABASE [phone_book_Lesson] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
                        RESTORE DATABASE [phone_book_Lesson] 
                        	FROM  DISK = N'{filename}' 
                        	WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 5
                        ALTER DATABASE [phone_book_Lesson] SET MULTI_USER";
            try
            {
                command.CommandTimeout = 30; //This is the default so it is a bit unnecessary other than an example
                connection.Open();
                command.CommandText = qryText;
                command.ExecuteNonQuery();
                connection.Close();
                pleaseWaitPanel.Visible = false;
                successState = true;
                Notify("Restore successful");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            pleaseWaitPanel.Visible = false;
            return successState;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            string filename;

            dialog.AddExtension = true;
            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;
            dialog.DefaultExt = ".pbk";
            dialog.Filter = "Backup files |*.pbk";
            try
            {
                dialog.ShowDialog();
                filename = dialog.FileName;
                if (IsTrue(filename))
                {
                    this.fileTextBox.Text = filename;
                    restoreButton.Enabled = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            if(RestoreDatabase(this.fileTextBox.Text))
                ExitButton_Click(sender, e);
        }
    }
}
