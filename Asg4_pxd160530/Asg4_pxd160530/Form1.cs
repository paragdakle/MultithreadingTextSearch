using Asg4_pxd160530.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asg4_pxd160530
{
    public partial class TextSearchForm : Form
    {
        bool isSearchOn;
        Queue<SearchResult> resultsQueue;
        string searchString;
        const int fileOpenError = -1;
        StringComparison comparison;

        public TextSearchForm()
        {
            InitializeComponent();
        }

        private void initializeForm()
        {
            ctlSearch.Enabled = false;
            ctlSearchText.Text = "";
            ctlFileName.Text = "";
            ctlSearchResultsListView.Items.Clear();
            isSearchOn = false;
            ctlClear.Enabled = true;
            ctlSearchIgnoreCase.Enabled = true;
            resultsQueue.Clear();
            ctlResultPreview.Text = "Select result to preview";
            ctlSearchProgress.Visible = false;
            showMessage("Select file to search");
        }

        /// <summary>
        /// Method displays the given message in the status bar. 
        /// It also resets the text color to Black indicating a normal message is being displayed.
        /// </summary>
        /// <param name="message">Message to display</param>
        private void showMessage(String message)
        {
            lblStatusMessage.Text = message;
        }

        private void TextSearchForm_Load(object sender, EventArgs e)
        {
            resultsQueue = new Queue<SearchResult>();
            initializeForm();
        }

        private void ctlBrowseFile_Click(object sender, EventArgs e)
        {
            DialogResult result = ctlFileOpenDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (!String.IsNullOrWhiteSpace(ctlFileOpenDialog.FileName))
                {
                    ctlFileName.Text = ctlFileOpenDialog.FileName;
                }
                else
                {
                    showMessage("Kindly select a valid file to search!");
                }
            }
        }

        private void ctlText_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(ctlFileName.Text)
                && !String.IsNullOrWhiteSpace(ctlSearchText.Text) 
                && System.IO.File.Exists(ctlFileName.Text)
                && !isSearchOn)
            {
                ctlSearch.Enabled = true;
            }
            else
            {
                ctlSearch.Enabled = false;
            }
        }

        private void ctlSearch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(ctlFileName.Text)
                && !String.IsNullOrWhiteSpace(ctlSearchText.Text)
                && System.IO.File.Exists(ctlFileName.Text))
            {
                if (!isSearchOn)
                {
                    ctlResultPreview.Text = "Select result to preview";
                    ctlSearchResultsListView.Items.Clear();
                    searchString = ctlSearchText.Text;
                    ctlFileName.Enabled = false;
                    ctlSearchText.Enabled = false;
                    ctlBrowseFile.Enabled = false;
                    ctlClear.Enabled = false;
                    ctlSearchIgnoreCase.Enabled = false;
                    ctlSearch.Text = "Cancel";
                    showMessage("Starting search...");
                    isSearchOn = true;
                    fileSearchBackgroundWorker.RunWorkerAsync();
                }
                else
                {
                    showMessage("Cancelling Search...");
                    isSearchOn = false;
                    ctlSearch.Enabled = false;
                    fileSearchBackgroundWorker.CancelAsync();
                }
            }
            else
            {
                showMessage("Kindly select a valid file to search or check search text!");
            }
        }

        private void fileSearchBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            FileReader reader = new FileReader(ctlFileName.Text);
            if(reader.openFile())
            {
                string fileLine = "";
                long bytesRead = 0;
                int counter = 0;
                fileSearchBackgroundWorker.ReportProgress(0);
                comparison = ctlSearchIgnoreCase.Checked ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;
                while (true)
                {
                    Thread.Sleep(10);
                    if (fileSearchBackgroundWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        fileSearchBackgroundWorker.ReportProgress(0);
                        return;
                    }
                    fileLine = reader.readFromFile();
                    counter++;
                    if (fileLine == null) break;
                    bytesRead += fileLine.Length;
                    fileLine = fileLine.Trim();
                    if (fileLine.IndexOf(searchString, comparison) >= 0)
                    {
                        resultsQueue.Enqueue(new SearchResult(fileLine, counter));
                    }
                    fileSearchBackgroundWorker.ReportProgress(Convert.ToInt32((bytesRead * 100) / reader.fileSize));
                }
                fileSearchBackgroundWorker.ReportProgress(100);
                reader.closeFile();
            }
            else
            {
                fileSearchBackgroundWorker.ReportProgress(fileOpenError);
            }
        }

        private void fileSearchBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(e.ProgressPercentage == fileOpenError)
            {
                showMessage("Error opening file");
                return;
            }
            if(e.ProgressPercentage == 0)
            {
                showMessage("Searching...");
                ctlSearchProgress.Visible = true;
            }
            if (resultsQueue.Count > 0)
            {
                SearchResult result = resultsQueue.Dequeue();
                string[] row = { Convert.ToString(result.lineNumber), result.matchLine };
                var listViewItem = new ListViewItem(row);
                ctlSearchResultsListView.Items.Add(listViewItem);
            }
            ctlSearchProgress.Value = e.ProgressPercentage;
        }

        private void fileSearchBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string messagePrefix = isSearchOn ? "Search complete! " : "Search terminated! ";
            if(ctlSearchResultsListView.Items.Count > 0)
            {
                showMessage(messagePrefix + Convert.ToString(ctlSearchResultsListView.Items.Count) + " match(es) found!");
            }
            else
            {
                showMessage(messagePrefix + "No match found!");
            }
            ctlSearchProgress.Value = 0;
            ctlSearchProgress.Visible = false;
            ctlFileName.Enabled = true;
            ctlSearchText.Enabled = true;
            ctlBrowseFile.Enabled = true;
            ctlSearch.Enabled = true;
            ctlClear.Enabled = true;
            ctlSearchIgnoreCase.Enabled = true;
            ctlSearch.Text = "Search";
            isSearchOn = false;
        }

        private void ctlClear_Click(object sender, EventArgs e)
        {
            initializeForm();
        }

        private void ctlSearchResultsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection records = ctlSearchResultsListView.SelectedItems;
            if (records.Count == 0)
            {
                ctlResultPreview.Text = "Select result to preview";
            }
            foreach (ListViewItem item in records)
            {
                ctlResultPreview.Text = item.SubItems[1].Text;
                styleText();
            }
        }

        private void styleText()
        {
            int len = searchString.Length;
            int i = ctlResultPreview.Text.IndexOf(searchString, comparison);
            while (i >= 0)
            {
                ctlResultPreview.Select(i, len);
                ctlResultPreview.SelectionFont = new Font(ctlResultPreview.SelectionFont, FontStyle.Bold);
                i = ctlResultPreview.Text.IndexOf(searchString, i + len, comparison);
            }
            ctlResultPreview.SelectionLength = 0;
        }
    }

    class SearchResult
    {
        public string matchLine { get; }
        public int lineNumber { get; }

        public SearchResult(string line, int lineNumber)
        {
            this.matchLine = line;
            this.lineNumber = lineNumber;
        }
    }
}
