using Asg4_pxd160530.Entity;
using Asg4_pxd160530.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Asg4_pxd160530
{
    /// <remarks>
    /// Author: Parag Pravin Dakle
    /// Course: Human Computer Interaction CS 6326 Spring 2017
    /// Net ID: pxd160530
    /// 
    /// The program accepts a file and search parameter to search in the file. The central idea of the program is to learn threading in C#.
    /// </remarks>
    /// <summary>
    /// <c>partial class TextSearchForm</c>
    /// This class consists of methods and event handlers interacting with the UI and consuming other lower layer classes.
    /// </summary>
    public partial class TextSearchForm : Form
    {
        bool isSearchOn;
        Queue<SearchResult> resultsQueue;
        string searchString;
        const int FILE_OPEN_ERROR = -1;
        const int FILE_SEARCH_THREAD_SLEEP = 100;
        StringComparison comparison;

        /// <summary>
        /// Default constructor of the main class.
        /// </summary>
        public TextSearchForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method initializes the form by resetting all the controls. 
        /// Creates a new <c>Buyer</c> object.
        /// Disables all buttons.
        /// Gives the focus to the first control.
        /// </summary>
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
            ctlBrowseFile.Focus();
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

        /// <summary>
        /// Form load event handler method.
        /// Initializes the form controls <see cref="TextSearchForm.initializeForm"/>;
        /// Show the default start status message <see cref="TextSearchForm.showMessage(string)"/>.
        /// </summary>
        /// <param name="sender">The object whose on load event is being handled</param>
        /// <param name="e">EventArgs object.</param>
        private void TextSearchForm_Load(object sender, EventArgs e)
        {
            resultsQueue = new Queue<SearchResult>();
            initializeForm();
        }

        /// <summary>
        /// Open file browse button click event handler method.
        /// Starts the OpenFileDialog and get the file path of the file selected.
        /// Displayes this path in a TextBox.
        /// </summary>
        /// <param name="sender">The object whose click event is being handled</param>
        /// <param name="e">EventArgs object.</param>
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

        /// <summary>
        /// TextChange event handler method.
        /// Checks if the file path and search term has been filled. 
        /// If yes then enables the Search Button else disables the button.
        /// </summary>
        /// <param name="sender">The object whose TextChange event is being handled</param>
        /// <param name="e">EventArgs object.</param>
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

        /// <summary>
        /// Search/Cancel button click event handler method.
        /// If operation is Search:
        /// Checks if all the required parameters are present for searching a file.
        /// Updates enable property of various form control, clears results list view and changes the Search Button to Cancel Button.
        /// Starts the background worker async task.
        /// Displays appropriate status message.
        /// If operation is Cancel:
        /// Displays appropriate status message.
        /// Updates operation parameter and disables the Cancel button.
        /// Sends a cancel task request to the background worker async task.
        /// </summary>
        /// <param name="sender">The object whose click event is being handled</param>
        /// <param name="e">EventArgs object.</param>
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

        /// <summary>
        /// DoWork event handler for the background worker.
        /// Method performs the actial file search operation.
        /// On finding a search match, pushes the result to the queue and calls the ReportProgress method of the background worker. <see cref="BackgroundWorker.ReportProgress(int)"/>
        /// </summary>
        /// <param name="sender">The background worker whose event is being handled</param>
        /// <param name="e">The <c>DoWorkEventArgs</c> object</param>
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
                    Thread.Sleep(FILE_SEARCH_THREAD_SLEEP);
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
                fileSearchBackgroundWorker.ReportProgress(FILE_OPEN_ERROR);
            }
        }

        /// <summary>
        /// ProgressChanged event handler for the background worker.
        /// Method removed a search result from the results queue and adds it to the results list view.
        /// Also updates the progress bar.
        /// </summary>
        /// <param name="sender">The background worker whose event is being handled</param>
        /// <param name="e">The <c>ProgressChangedEventArgs</c> object</param>
        private void fileSearchBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(e.ProgressPercentage == FILE_OPEN_ERROR)
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

        /// <summary>
        /// RunWorkerCompleted event handler for the background worker.
        /// Method shows the appropriate search completion message and performs post search form control handling.
        /// </summary>
        /// <param name="sender">The background worker whose event is being handled</param>
        /// <param name="e">The <c>RunWorkerCompletedEventArgs</c> object</param>
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

        /// <summary>
        /// Clear form button click event handler method.
        /// Initializes the form again <see cref="TextSearchForm.initializeForm"/>
        /// </summary>
        /// <param name="sender">The object whose click event is being handled</param>
        /// <param name="e">EventArgs object.</param>
        private void ctlClear_Click(object sender, EventArgs e)
        {
            initializeForm();
        }

        /// <summary>
        /// ListView selected item index change event handler method.
        /// Loads the search result line text in the preview area.
        /// Clears the preview area if a result is deselected.
        /// </summary>
        /// <param name="sender">The object whose selected index change event is being handled</param>
        /// <param name="e">EventArgs object.</param>
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

        /// <summary>
        /// Method styles the text of the Search Result Preview control by making the search term bold in the line preview.
        /// </summary>
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

}
