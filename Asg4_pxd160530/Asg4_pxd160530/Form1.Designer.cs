﻿namespace Asg4_pxd160530
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctlFileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.fileSearchBackgroundWorker = new System.ComponentModel.BackgroundWorker();
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
            this.ctlSearchResultsListView.Location = new System.Drawing.Point(17, 83);
            this.ctlSearchResultsListView.MultiSelect = false;
            this.ctlSearchResultsListView.Name = "ctlSearchResultsListView";
            this.ctlSearchResultsListView.Size = new System.Drawing.Size(665, 420);
            this.ctlSearchResultsListView.TabIndex = 6;
            this.ctlSearchResultsListView.UseCompatibleStateImageBehavior = false;
            this.ctlSearchResultsListView.View = System.Windows.Forms.View.Details;
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(700, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusMessage
            // 
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // ctlFileOpenDialog
            // 
            this.ctlFileOpenDialog.FileName = "openFileDialog1";
            // 
            // fileSearchBackgroundWorker
            // 
            this.fileSearchBackgroundWorker.WorkerReportsProgress = true;
            this.fileSearchBackgroundWorker.WorkerSupportsCancellation = true;
            this.fileSearchBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.fileSearchBackgroundWorker_DoWork);
            this.fileSearchBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.fileSearchBackgroundWorker_ProgressChanged);
            // 
            // TextSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 532);
            this.Controls.Add(this.ctlSearchResultsListView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ctlSearch);
            this.Controls.Add(this.ctlSearchText);
            this.Controls.Add(this.lblSearchFor);
            this.Controls.Add(this.ctlBrowseFile);
            this.Controls.Add(this.ctlFileName);
            this.Controls.Add(this.lblFileName);
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusMessage;
        private System.Windows.Forms.ColumnHeader colLineNumber;
        private System.Windows.Forms.ColumnHeader colSearchMatchLine;
        private System.Windows.Forms.OpenFileDialog ctlFileOpenDialog;
        private System.ComponentModel.BackgroundWorker fileSearchBackgroundWorker;
    }
}

