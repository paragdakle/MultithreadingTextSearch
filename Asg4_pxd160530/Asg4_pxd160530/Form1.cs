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
            resultsQueue.Clear();
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
            initializeForm();
            resultsQueue = new Queue<SearchResult>();
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
                    searchString = ctlSearchText.Text;
                    ctlFileName.Enabled = false;
                    ctlSearchText.Enabled = false;
                    showMessage("Starting search...");
                    fileSearchBackgroundWorker.RunWorkerAsync();
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
                int counter = 0;

                while (true)
                {
                    Thread.Sleep(100);
                    if (fileSearchBackgroundWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        fileSearchBackgroundWorker.ReportProgress(0);
                        return;
                    }
                    fileLine = reader.readFromFile();
                    if (fileLine == null) break;
                    fileSearchBackgroundWorker.ReportProgress(++counter);
                }
                reader.closeFile();
            }
        }

        private void fileSearchBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            showMessage(Convert.ToString(e.ProgressPercentage));
        }
    }

    class SearchResult
    {
        string matchLine { get; set; }
        int lineNumber { get; set; }
    }
}
