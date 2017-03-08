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
            // 
            // ctlSearchText
            // 
            this.ctlSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlSearchText.Location = new System.Drawing.Point(90, 50);
            this.ctlSearchText.Name = "ctlSearchText";
            this.ctlSearchText.Size = new System.Drawing.Size(506, 22);
            this.ctlSearchText.TabIndex = 4;
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
            // TextSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 515);
            this.Controls.Add(this.ctlSearch);
            this.Controls.Add(this.ctlSearchText);
            this.Controls.Add(this.lblSearchFor);
            this.Controls.Add(this.ctlBrowseFile);
            this.Controls.Add(this.ctlFileName);
            this.Controls.Add(this.lblFileName);
            this.Name = "TextSearchForm";
            this.Text = "Text Search";
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
    }
}

