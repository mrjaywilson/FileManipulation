using System;
using System.Windows.Forms;

/// <summary>
/// Namespace Declaration
/// </summary>
namespace Project_3
{
    /// <summary>
    /// Class Declaration
    /// </summary>
    public partial class frmProjectThree : Form
    {
        /// <summary>
        /// Delcare and initialize objects for use
        /// </summary>
        OpenFileDialog openFile = new OpenFileDialog();
        FileManager fileManager = new FileManager();

        /// <summary>
        /// Main method of program
        /// </summary>
        public frmProjectThree()
        {
            // Initialize form and controls.
            InitializeComponent();
        }

        /// <summary>
        /// Method to Exit the program.
        /// </summary>
        private void mnuExit_Click(object sender, EventArgs e)
        {
            // Exit the program.
            Application.Exit();
        }

        /// <summary>
        /// Method to access a path for a file to open.
        /// </summary>
        private void mnuOpen_Click(object sender, EventArgs e)
        {
            // Open the file dialog for choosing a file
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Get the file name and pat and store it
                    fileManager.fileName = openFile.FileName;

                    // Inform user of status.
                    rtbStatus.Text = "File loaded successfully.";

                    // Unlock the buttons
                    btnConvertToLowerCase.Enabled = true;
                    btnGetFLWords.Enabled = true;
                    btnGetLongestWord.Enabled = true;
                    btnGetVowelWord.Enabled = true;
                }
                // If it fails...
                catch (Exception ex)
                {
                    // Update status window
                    rtbStatus.Text = "Failed to open file!\n\n" + ex.Message;
                }
            }
        }

        /// <summary>
        /// Button to convert all items in a file to lowercase
        /// </summary>
        private void btnConvertToLowerCase_Click(object sender, EventArgs e)
        {
            // Call method to convert text in file to lowercase
            fileManager.ConvertFileToLower();

            // Update status window with results
            rtbStatus.Text = fileManager.outputFile[0];
        }

        /// <summary>
        /// Button to retrieve the alphabetical first and last words of the file.
        /// </summary>
        private void btnGetFLWords_Click(object sender, EventArgs e)
        {
            // Setup an array with the content if the file
            fileManager.SetFileContents();

            // Method to get the first and last word, alphabetically
            fileManager.GetFirstAndLastWords();

            // Update the status with result
            rtbStatus.Text = fileManager.outputFile[1];
        }

        /// <summary>
        /// Button to get the longest word in the file
        /// </summary>
        private void btnGetLongestWord_Click(object sender, EventArgs e)
        {
            // Setup an array with the content if the file
            fileManager.SetFileContents();

            // If the file contents are not empty, then perform the search
            if (fileManager.fileContents != null)
            {
                // Search the filecontents for the longset wor
                fileManager.SearchForLongestWord(fileManager.fileContents, progressBar);

                // Out results to the console to the user
                rtbStatus.Text = fileManager.outputFile[2];
            }
            else
            {
                // Inform the user of the file is empty
                rtbStatus.Text = "Cannont perform that action because the requested file is empty!";
            }
        }

        /// <summary>
        /// Button to get the word with the most vowels
        /// </summary>
        private void btnGetVowelWord_Click(object sender, EventArgs e)
        {
            // Setup an array with the content if the file
            fileManager.SetFileContents();

            // Check if the file is empty
            if (fileManager.fileContents != null)
            {
                // If not... Search for the work with the most vowels
                fileManager.SearchForWordWithMostVowels(fileManager.fileContents, progressBar);

                // Update status of the search
                rtbStatus.Text = fileManager.outputFile[3];
            }
            else
            {
                // If empty, let user know
                rtbStatus.Text = "Cannont perform that action because the requested file is empty!";
            }
        }

        /// <summary>
        /// Button to save statistics of operations to a file
        /// </summary>
        private void mnuSave_Click(object sender, EventArgs e)
        {
            // Method to save the stats to a file
            fileManager.SaveFileDialog();
        }
    }
}
