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
            this.numStartWithDiscNumber = new System.Windows.Forms.NumericUpDown();
            this.lblStartWithDiscNumber = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.dbDestination = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblSaveToFolder = new System.Windows.Forms.Label();
            this.txtSaveToFolder = new System.Windows.Forms.TextBox();
            this.gbEncoding = new System.Windows.Forms.GroupBox();
            this.lblQuality = new System.Windows.Forms.Label();
            this.cbQuality = new System.Windows.Forms.ComboBox();
            this.btnBegin = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTrackProgress = new System.Windows.Forms.Label();
            this.pbTrackProgress = new System.Windows.Forms.ProgressBar();
            this.lblDiscProgress = new System.Windows.Forms.Label();
            this.pbDiscProgress = new System.Windows.Forms.ProgressBar();
            this.gbProgress = new System.Windows.Forms.GroupBox();
            this.gbBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartWithDiscNumber)).BeginInit();
            this.dbDestination.SuspendLayout();
            this.gbEncoding.SuspendLayout();
            this.gbProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBook
            // 
            this.gbBook.Controls.Add(this.numStartWithDiscNumber);
            this.gbBook.Controls.Add(this.lblStartWithDiscNumber);
            this.gbBook.Controls.Add(this.txtTitle);
            this.gbBook.Controls.Add(this.lblTitle);
            this.gbBook.Controls.Add(this.txtAuthor);
            this.gbBook.Controls.Add(this.lblAuthor);
            this.gbBook.Location = new System.Drawing.Point(12, 12);
            this.gbBook.Name = "gbBook";
            this.gbBook.Size = new System.Drawing.Size(598, 79);
            this.gbBook.TabIndex = 4;
            this.gbBook.TabStop = false;
            this.gbBook.Text = "Book";
            // 
            // numStartWithDiscNumber
            // 
            this.numStartWithDiscNumber.Location = new System.Drawing.Point(427, 44);
            this.numStartWithDiscNumber.Name = "numStartWithDiscNumber";
            this.numStartWithDiscNumber.Size = new System.Drawing.Size(165, 22);
            this.numStartWithDiscNumber.TabIndex = 9;
            this.numStartWithDiscNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblStartWithDiscNumber
            // 
            this.lblStartWithDiscNumber.AutoSize = true;
            this.lblStartWithDiscNumber.Location = new System.Drawing.Point(424, 23);
            this.lblStartWithDiscNumber.Name = "lblStartWithDiscNumber";
            this.lblStartWithDiscNumber.Size = new System.Drawing.Size(151, 17);
            this.lblStartWithDiscNumber.TabIndex = 8;
            this.lblStartWithDiscNumber.Text = "Start with Disc Number";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(214, 43);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(165, 22);
            this.txtTitle.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(211, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 17);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Title";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(9, 43);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(165, 22);
            this.txtAuthor.TabIndex = 5;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(6, 23);
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
            this.dbDestination.Location = new System.Drawing.Point(12, 97);
            this.dbDestination.Name = "dbDestination";
            this.dbDestination.Size = new System.Drawing.Size(598, 86);
            this.dbDestination.TabIndex = 5;
            this.dbDestination.TabStop = false;
            this.dbDestination.Text = "Destination";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(517, 50);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
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
            // txtSaveToFolder
            // 
            this.txtSaveToFolder.Location = new System.Drawing.Point(9, 50);
            this.txtSaveToFolder.Name = "txtSaveToFolder";
            this.txtSaveToFolder.ReadOnly = true;
            this.txtSaveToFolder.Size = new System.Drawing.Size(502, 22);
            this.txtSaveToFolder.TabIndex = 0;
            // 
            // gbEncoding
            // 
            this.gbEncoding.Controls.Add(this.lblQuality);
            this.gbEncoding.Controls.Add(this.cbQuality);
            this.gbEncoding.Location = new System.Drawing.Point(12, 189);
            this.gbEncoding.Name = "gbEncoding";
            this.gbEncoding.Size = new System.Drawing.Size(598, 71);
            this.gbEncoding.TabIndex = 6;
            this.gbEncoding.TabStop = false;
            this.gbEncoding.Text = "Encoding Options";
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
            // cbQuality
            // 
            this.cbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuality.FormattingEnabled = true;
            this.cbQuality.Location = new System.Drawing.Point(9, 38);
            this.cbQuality.Name = "cbQuality";
            this.cbQuality.Size = new System.Drawing.Size(583, 24);
            this.cbQuality.TabIndex = 0;
            // 
            // btnBegin
            // 
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnBegin.Location = new System.Drawing.Point(12, 266);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(151, 32);
            this.btnBegin.TabIndex = 7;
            this.btnBegin.Text = "Begin Ripping";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select the folder where you want to save the ripped audio files:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(169, 266);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 32);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTrackProgress
            // 
            this.lblTrackProgress.AutoSize = true;
            this.lblTrackProgress.Location = new System.Drawing.Point(6, 21);
            this.lblTrackProgress.Name = "lblTrackProgress";
            this.lblTrackProgress.Size = new System.Drawing.Size(44, 17);
            this.lblTrackProgress.TabIndex = 0;
            this.lblTrackProgress.Text = "Track";
            // 
            // pbTrackProgress
            // 
            this.pbTrackProgress.Location = new System.Drawing.Point(9, 42);
            this.pbTrackProgress.Name = "pbTrackProgress";
            this.pbTrackProgress.Size = new System.Drawing.Size(583, 23);
            this.pbTrackProgress.TabIndex = 1;
            // 
            // lblDiscProgress
            // 
            this.lblDiscProgress.AutoSize = true;
            this.lblDiscProgress.Location = new System.Drawing.Point(6, 72);
            this.lblDiscProgress.Name = "lblDiscProgress";
            this.lblDiscProgress.Size = new System.Drawing.Size(35, 17);
            this.lblDiscProgress.TabIndex = 2;
            this.lblDiscProgress.Text = "Disc";
            // 
            // pbDiscProgress
            // 
            this.pbDiscProgress.Location = new System.Drawing.Point(9, 93);
            this.pbDiscProgress.Name = "pbDiscProgress";
            this.pbDiscProgress.Size = new System.Drawing.Size(583, 23);
            this.pbDiscProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbDiscProgress.TabIndex = 3;
            // 
            // gbProgress
            // 
            this.gbProgress.Controls.Add(this.lblTrackProgress);
            this.gbProgress.Controls.Add(this.pbDiscProgress);
            this.gbProgress.Controls.Add(this.pbTrackProgress);
            this.gbProgress.Controls.Add(this.lblDiscProgress);
            this.gbProgress.Location = new System.Drawing.Point(12, 305);
            this.gbProgress.Name = "gbProgress";
            this.gbProgress.Size = new System.Drawing.Size(598, 132);
            this.gbProgress.TabIndex = 9;
            this.gbProgress.TabStop = false;
            this.gbProgress.Text = "Progress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(622, 443);
            this.Controls.Add(this.gbProgress);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.gbEncoding);
            this.Controls.Add(this.dbDestination);
            this.Controls.Add(this.gbBook);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 490);
            this.MinimumSize = new System.Drawing.Size(640, 490);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Audio Book Ripper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbBook.ResumeLayout(false);
            this.gbBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartWithDiscNumber)).EndInit();
            this.dbDestination.ResumeLayout(false);
            this.dbDestination.PerformLayout();
            this.gbEncoding.ResumeLayout(false);
            this.gbEncoding.PerformLayout();
            this.gbProgress.ResumeLayout(false);
            this.gbProgress.PerformLayout();
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
        private System.Windows.Forms.NumericUpDown numStartWithDiscNumber;
        private System.Windows.Forms.Label lblStartWithDiscNumber;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTrackProgress;
        private System.Windows.Forms.ProgressBar pbTrackProgress;
        private System.Windows.Forms.Label lblDiscProgress;
        private System.Windows.Forms.ProgressBar pbDiscProgress;
        private System.Windows.Forms.GroupBox gbProgress;
    }
}

