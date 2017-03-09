namespace Asg4_pxd160530
{
    partial class TextSearchForm
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
            this.lblFileName = new System.Windows.Forms.Label();
            this.ctlFileName = new System.Windows.Forms.TextBox();
            this.ctlBrowseFile = new System.Windows.Forms.Button();
            this.ctlSearch = new System.Windows.Forms.Button();
            this.ctlSearchText = new System.Windows.Forms.TextBox();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.ctlSearchResultsListView = new System.Windows.Forms.ListView();
            this.colLineNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSearchMatchLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctlFileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.fileSearchBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.lblStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEmpty = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctlSearchProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.ctlSearchIgnoreCase = new System.Windows.Forms.CheckBox();
            this.ctlClear = new System.Windows.Forms.Button();
            this.lblPreviewHeader = new System.Windows.Forms.Label();
            this.ctlResultPreview = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(14, 16);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(70, 16);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "File Name";
            // 
            // ctlFileName
            // 
            this.ctlFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlFileName.Location = new System.Drawing.Point(90, 13);
            this.ctlFileName.Name = "ctlFileName";
            this.ctlFileName.Size = new System.Drawing.Size(506, 22);
            this.ctlFileName.TabIndex = 1;
            this.ctlFileName.TextChanged += new System.EventHandler(this.ctlText_TextChanged);
            // 
            // ctlBrowseFile
            // 
            this.ctlBrowseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlBrowseFile.Location = new System.Drawing.Point(607, 12);
            this.ctlBrowseFile.Name = "ctlBrowseFile";
            this.ctlBrowseFile.Size = new System.Drawing.Size(75, 24);
            this.ctlBrowseFile.TabIndex = 2;
            this.ctlBrowseFile.Text = "Browse";
            this.ctlBrowseFile.UseVisualStyleBackColor = true;
            this.ctlBrowseFile.Click += new System.EventHandler(this.ctlBrowseFile_Click);
            // 
            // ctlSearch
            // 
            this.ctlSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlSearch.Location = new System.Drawing.Point(607, 49);
            this.ctlSearch.Name = "ctlSearch";
            this.ctlSearch.Size = new System.Drawing.Size(75, 24);
            this.ctlSearch.TabIndex = 5;
            this.ctlSearch.Text = "Search";
            this.ctlSearch.UseVisualStyleBackColor = true;
            this.ctlSearch.Click += new System.EventHandler(this.ctlSearch_Click);
            // 
            // ctlSearchText
            // 
            this.ctlSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlSearchText.Location = new System.Drawing.Point(90, 50);
            this.ctlSearchText.Name = "ctlSearchText";
            this.ctlSearchText.Size = new System.Drawing.Size(506, 22);
            this.ctlSearchText.TabIndex = 4;
            this.ctlSearchText.TextChanged += new System.EventHandler(this.ctlText_TextChanged);
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.AutoSize = true;
            this.lblSearchFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchFor.Location = new System.Drawing.Point(14, 53);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(72, 16);
            this.lblSearchFor.TabIndex = 3;
            this.lblSearchFor.Text = "Search for:";
            // 
            // ctlSearchResultsListView
            // 
            this.ctlSearchResultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLineNumber,
            this.colSearchMatchLine});
            this.ctlSearchResultsListView.FullRowSelect = true;
            this.ctlSearchResultsListView.Location = new System.Drawing.Point(17, 83);
            this.ctlSearchResultsListView.MultiSelect = false;
            this.ctlSearchResultsListView.Name = "ctlSearchResultsListView";
            this.ctlSearchResultsListView.Size = new System.Drawing.Size(665, 420);
            this.ctlSearchResultsListView.TabIndex = 6;
            this.ctlSearchResultsListView.UseCompatibleStateImageBehavior = false;
            this.ctlSearchResultsListView.View = System.Windows.Forms.View.Details;
            this.ctlSearchResultsListView.SelectedIndexChanged += new System.EventHandler(this.ctlSearchResultsListView_SelectedIndexChanged);
            // 
            // colLineNumber
            // 
            this.colLineNumber.Text = "Line Number";
            this.colLineNumber.Width = 94;
            // 
            // colSearchMatchLine
            // 
            this.colSearchMatchLine.Text = "Match line";
            this.colSearchMatchLine.Width = 567;
            // 
            // ctlFileOpenDialog
            // 
            this.ctlFileOpenDialog.DefaultExt = "\"*.txt\"";
            this.ctlFileOpenDialog.Filter = "Text files|*.txt";
            // 
            // fileSearchBackgroundWorker
            // 
            this.fileSearchBackgroundWorker.WorkerReportsProgress = true;
            this.fileSearchBackgroundWorker.WorkerSupportsCancellation = true;
            this.fileSearchBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.fileSearchBackgroundWorker_DoWork);
            this.fileSearchBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.fileSearchBackgroundWorker_ProgressChanged);
            this.fileSearchBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.fileSearchBackgroundWorker_RunWorkerCompleted);
            // 
            // lblStatusMessage
            // 
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusMessage,
            this.lblEmpty,
            this.ctlSearchProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(911, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEmpty
            // 
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(794, 17);
            this.lblEmpty.Spring = true;
            // 
            // ctlSearchProgress
            // 
            this.ctlSearchProgress.Name = "ctlSearchProgress";
            this.ctlSearchProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // ctlSearchIgnoreCase
            // 
            this.ctlSearchIgnoreCase.AutoSize = true;
            this.ctlSearchIgnoreCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlSearchIgnoreCase.Location = new System.Drawing.Point(701, 52);
            this.ctlSearchIgnoreCase.Name = "ctlSearchIgnoreCase";
            this.ctlSearchIgnoreCase.Size = new System.Drawing.Size(96, 20);
            this.ctlSearchIgnoreCase.TabIndex = 8;
            this.ctlSearchIgnoreCase.Text = "Match case";
            this.ctlSearchIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // ctlClear
            // 
            this.ctlClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlClear.Location = new System.Drawing.Point(701, 12);
            this.ctlClear.Name = "ctlClear";
            this.ctlClear.Size = new System.Drawing.Size(75, 23);
            this.ctlClear.TabIndex = 9;
            this.ctlClear.Text = "Clear";
            this.ctlClear.UseVisualStyleBackColor = true;
            this.ctlClear.Click += new System.EventHandler(this.ctlClear_Click);
            // 
            // lblPreviewHeader
            // 
            this.lblPreviewHeader.AutoSize = true;
            this.lblPreviewHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviewHeader.Location = new System.Drawing.Point(698, 83);
            this.lblPreviewHeader.Name = "lblPreviewHeader";
            this.lblPreviewHeader.Size = new System.Drawing.Size(106, 18);
            this.lblPreviewHeader.TabIndex = 10;
            this.lblPreviewHeader.Text = "Result Preview";
            // 
            // ctlResultPreview
            // 
            this.ctlResultPreview.BackColor = System.Drawing.SystemColors.Control;
            this.ctlResultPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctlResultPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlResultPreview.Location = new System.Drawing.Point(701, 113);
            this.ctlResultPreview.Name = "ctlResultPreview";
            this.ctlResultPreview.ReadOnly = true;
            this.ctlResultPreview.Size = new System.Drawing.Size(198, 390);
            this.ctlResultPreview.TabIndex = 11;
            this.ctlResultPreview.Text = "";
            // 
            // TextSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 532);
            this.Controls.Add(this.lblPreviewHeader);
            this.Controls.Add(this.ctlClear);
            this.Controls.Add(this.ctlSearchIgnoreCase);
            this.Controls.Add(this.ctlSearchResultsListView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ctlSearch);
            this.Controls.Add(this.ctlSearchText);
            this.Controls.Add(this.lblSearchFor);
            this.Controls.Add(this.ctlBrowseFile);
            this.Controls.Add(this.ctlFileName);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.ctlResultPreview);
            this.Name = "TextSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Search";
            this.Load += new System.EventHandler(this.TextSearchForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox ctlFileName;
        private System.Windows.Forms.Button ctlBrowseFile;
        private System.Windows.Forms.Button ctlSearch;
        private System.Windows.Forms.TextBox ctlSearchText;
        private System.Windows.Forms.Label lblSearchFor;
        private System.Windows.Forms.ListView ctlSearchResultsListView;
        private System.Windows.Forms.ColumnHeader colLineNumber;
        private System.Windows.Forms.ColumnHeader colSearchMatchLine;
        private System.Windows.Forms.OpenFileDialog ctlFileOpenDialog;
        private System.ComponentModel.BackgroundWorker fileSearchBackgroundWorker;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusMessage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEmpty;
        private System.Windows.Forms.ToolStripProgressBar ctlSearchProgress;
        private System.Windows.Forms.CheckBox ctlSearchIgnoreCase;
        private System.Windows.Forms.Button ctlClear;
        private System.Windows.Forms.Label lblPreviewHeader;
        private System.Windows.Forms.RichTextBox ctlResultPreview;
    }
}

