namespace AudioBookRipper.WinFormsApp
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
            this.gbBook = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.dbDestination = new System.Windows.Forms.GroupBox();
            this.txtSaveToFolder = new System.Windows.Forms.TextBox();
            this.lblSaveToFolder = new System.Windows.Forms.Label();
            this.gbEncoding = new System.Windows.Forms.GroupBox();
            this.cbQuality = new System.Windows.Forms.ComboBox();
            this.lblQuality = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.gbBook.SuspendLayout();
            this.dbDestination.SuspendLayout();
            this.gbEncoding.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBook
            // 
            this.gbBook.Controls.Add(this.txtTitle);
            this.gbBook.Controls.Add(this.lblTitle);
            this.gbBook.Controls.Add(this.txtAuthor);
            this.gbBook.Controls.Add(this.lblAuthor);
            this.gbBook.Location = new System.Drawing.Point(12, 12);
            this.gbBook.Name = "gbBook";
            this.gbBook.Size = new System.Drawing.Size(278, 117);
            this.gbBook.TabIndex = 4;
            this.gbBook.TabStop = false;
            this.gbBook.Text = "Book";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(6, 83);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(265, 22);
            this.txtTitle.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(3, 63);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 17);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Title";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(6, 38);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(265, 22);
            this.txtAuthor.TabIndex = 5;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(3, 18);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(50, 17);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Author";
            // 
            // dbDestination
            // 
            this.dbDestination.Controls.Add(this.btnBrowse);
            this.dbDestination.Controls.Add(this.lblSaveToFolder);
            this.dbDestination.Controls.Add(this.txtSaveToFolder);
            this.dbDestination.Location = new System.Drawing.Point(12, 135);
            this.dbDestination.Name = "dbDestination";
            this.dbDestination.Size = new System.Drawing.Size(278, 108);
            this.dbDestination.TabIndex = 5;
            this.dbDestination.TabStop = false;
            this.dbDestination.Text = "Destination";
            // 
            // txtSaveToFolder
            // 
            this.txtSaveToFolder.Location = new System.Drawing.Point(6, 50);
            this.txtSaveToFolder.Name = "txtSaveToFolder";
            this.txtSaveToFolder.ReadOnly = true;
            this.txtSaveToFolder.Size = new System.Drawing.Size(265, 22);
            this.txtSaveToFolder.TabIndex = 0;
            // 
            // lblSaveToFolder
            // 
            this.lblSaveToFolder.AutoSize = true;
            this.lblSaveToFolder.Location = new System.Drawing.Point(6, 27);
            this.lblSaveToFolder.Name = "lblSaveToFolder";
            this.lblSaveToFolder.Size = new System.Drawing.Size(100, 17);
            this.lblSaveToFolder.TabIndex = 1;
            this.lblSaveToFolder.Text = "Save to Folder";
            // 
            // gbEncoding
            // 
            this.gbEncoding.Controls.Add(this.lblQuality);
            this.gbEncoding.Controls.Add(this.cbQuality);
            this.gbEncoding.Location = new System.Drawing.Point(12, 249);
            this.gbEncoding.Name = "gbEncoding";
            this.gbEncoding.Size = new System.Drawing.Size(278, 71);
            this.gbEncoding.TabIndex = 6;
            this.gbEncoding.TabStop = false;
            this.gbEncoding.Text = "Encoding Options";
            // 
            // cbQuality
            // 
            this.cbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuality.FormattingEnabled = true;
            this.cbQuality.Location = new System.Drawing.Point(6, 38);
            this.cbQuality.Name = "cbQuality";
            this.cbQuality.Size = new System.Drawing.Size(265, 24);
            this.cbQuality.TabIndex = 0;
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Location = new System.Drawing.Point(3, 18);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(52, 17);
            this.lblQuality.TabIndex = 1;
            this.lblQuality.Text = "Quality";
            // 
            // btnBegin
            // 
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBegin.Location = new System.Drawing.Point(12, 326);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(278, 49);
            this.btnBegin.TabIndex = 7;
            this.btnBegin.Text = "Begin Ripping";
            this.btnBegin.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(6, 78);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select the folder where you want to save the ripped audio files:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(302, 383);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.gbEncoding);
            this.Controls.Add(this.dbDestination);
            this.Controls.Add(this.gbBook);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 430);
            this.MinimumSize = new System.Drawing.Size(320, 430);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Audio Book Ripper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbBook.ResumeLayout(false);
            this.gbBook.PerformLayout();
            this.dbDestination.ResumeLayout(false);
            this.dbDestination.PerformLayout();
            this.gbEncoding.ResumeLayout(false);
            this.gbEncoding.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbBook;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.GroupBox dbDestination;
        private System.Windows.Forms.Label lblSaveToFolder;
        private System.Windows.Forms.TextBox txtSaveToFolder;
        private System.Windows.Forms.GroupBox gbEncoding;
        private System.Windows.Forms.ComboBox cbQuality;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

