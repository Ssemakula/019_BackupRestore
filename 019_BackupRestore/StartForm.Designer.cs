namespace _019_BackupRestore
{
    partial class StartForm
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
            this.backupButton = new System.Windows.Forms.Button();
            this.restoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backupButton
            // 
            this.backupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupButton.Location = new System.Drawing.Point(75, 91);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(90, 89);
            this.backupButton.TabIndex = 0;
            this.backupButton.Text = "Backup!";
            this.backupButton.UseVisualStyleBackColor = true;
            this.backupButton.Click += new System.EventHandler(this.BackupButton_Click);
            // 
            // restoreButton
            // 
            this.restoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreButton.Location = new System.Drawing.Point(190, 91);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(90, 89);
            this.restoreButton.TabIndex = 1;
            this.restoreButton.Text = "Restore!";
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 471);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.backupButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "StartForm";
            this.Text = "Shop Pro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backupButton;
        private System.Windows.Forms.Button restoreButton;
    }
}

