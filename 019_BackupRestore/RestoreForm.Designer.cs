namespace _019_BackupRestore
{
    partial class RestoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestoreForm));
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.tip2Label = new System.Windows.Forms.Label();
            this.tip1Label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.restoreButton = new System.Windows.Forms.Button();
            this.pleaseWaitPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.messagePanel.SuspendLayout();
            this.pleaseWaitPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileTextBox
            // 
            this.fileTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.fileTextBox.Location = new System.Drawing.Point(103, 116);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.ReadOnly = true;
            this.fileTextBox.Size = new System.Drawing.Size(421, 20);
            this.fileTextBox.TabIndex = 5;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(22, 114);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "Select File";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // messagePanel
            // 
            this.messagePanel.BackColor = System.Drawing.Color.YellowGreen;
            this.messagePanel.Controls.Add(this.tip2Label);
            this.messagePanel.Controls.Add(this.tip1Label);
            this.messagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.messagePanel.Location = new System.Drawing.Point(0, 0);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(546, 100);
            this.messagePanel.TabIndex = 6;
            // 
            // tip2Label
            // 
            this.tip2Label.Location = new System.Drawing.Point(22, 33);
            this.tip2Label.Name = "tip2Label";
            this.tip2Label.Size = new System.Drawing.Size(502, 32);
            this.tip2Label.TabIndex = 1;
            this.tip2Label.Text = "Tip 2:";
            // 
            // tip1Label
            // 
            this.tip1Label.Location = new System.Drawing.Point(22, 13);
            this.tip1Label.Name = "tip1Label";
            this.tip1Label.Size = new System.Drawing.Size(502, 20);
            this.tip1Label.TabIndex = 0;
            this.tip1Label.Text = "Tip 1:";
            // 
            // button1
            // 
            this.button1.Image = global::_019_BackupRestore.Properties.Resources.help_icon;
            this.button1.Location = new System.Drawing.Point(372, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "Help?";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Image = global::_019_BackupRestore.Properties.Resources.exit_square_icon;
            this.exitButton.Location = new System.Drawing.Point(197, 163);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(151, 55);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // restoreButton
            // 
            this.restoreButton.Image = global::_019_BackupRestore.Properties.Resources.backup_backups_daily_data_database_icon;
            this.restoreButton.Location = new System.Drawing.Point(22, 163);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(151, 55);
            this.restoreButton.TabIndex = 7;
            this.restoreButton.Text = "Restore && Exit";
            this.restoreButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.restoreButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // pleaseWaitPanel
            // 
            this.pleaseWaitPanel.BackColor = System.Drawing.Color.Silver;
            this.pleaseWaitPanel.Controls.Add(this.label2);
            this.pleaseWaitPanel.Controls.Add(this.label1);
            this.pleaseWaitPanel.Location = new System.Drawing.Point(178, 77);
            this.pleaseWaitPanel.Name = "pleaseWaitPanel";
            this.pleaseWaitPanel.Size = new System.Drawing.Size(190, 89);
            this.pleaseWaitPanel.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Restoring database.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please wait....";
            // 
            // RestoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 243);
            this.Controls.Add(this.pleaseWaitPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.messagePanel);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.browseButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RestoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restore";
            this.Load += new System.EventHandler(this.RestoreForm_Load);
            this.messagePanel.ResumeLayout(false);
            this.pleaseWaitPanel.ResumeLayout(false);
            this.pleaseWaitPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Label tip2Label;
        private System.Windows.Forms.Label tip1Label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.Panel pleaseWaitPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}