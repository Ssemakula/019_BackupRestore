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

        void BackupDatabase()
        {
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand();
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection();
            string qryText;

            connection.ConnectionString = _019_BackupRestore.Properties.Settings.Default.LoginLessonConnectionString;
            command.Connection = connection;
            qryText = @"BACKUP DATABASE [phone_book_Lesson] TO  DISK = N'C:\DatabasesHold\Backups\phone_book_Lesson3.bak' 
                    WITH NOFORMAT, INIT,  NAME = N'phone_book_Lesson-Full Database Backup', 
                    SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            try
            {
                command.CommandTimeout = 30; //This is the default so it is a bit unnecessary other than an example
                connection.Open();
                command.CommandText = qryText;
                command.ExecuteNonQuery();
                connection.Close();
                Notify("Backup successful");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        void RestoreDatabase()
        {
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand();
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection();
            string qryText;

            connection.ConnectionString = _019_BackupRestore.Properties.Settings.Default.LoginLessonConnectionString;
            command.Connection = connection;
            // Think of setting it to choose file
            qryText = @"USE [master]
                        ALTER DATABASE [phone_book_Lesson] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
                        RESTORE DATABASE [phone_book_Lesson] 
                        	FROM  DISK = N'C:\DatabasesHold\Backups\phone_book_Lesson3.bak' 
                        	WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 5
                        ALTER DATABASE [phone_book_Lesson] SET MULTI_USER";
            try
            {
                command.CommandTimeout = 30; //This is the default so it is a bit unnecessary other than an example
                connection.Open();
                command.CommandText = qryText;
                command.ExecuteNonQuery();
                connection.Close();
                Notify("Restore successful");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BackupButton_Click(object sender, EventArgs e)
        {
            BackupDatabase();
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            RestoreDatabase();
        }
    }
}
