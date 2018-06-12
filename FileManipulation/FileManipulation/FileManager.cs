using System;
using System.IO;
using System.Windows.Forms;

/// <summary>
/// Namespace Declaration
/// </summary>
namespace Project_3
{
    /// <summary>
    /// Class Declaration
    /// </summary>
    class FileManager
    {
        /// <summary>
        /// Declare variable
        /// </summary>
        private String _fileString;

        /// <summary>
        /// Declare Properties
        /// </summary>
        public String fileName { get; set; }
        public String[] fileContents { get; set; }
        public String[] outputFile { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public FileManager()
        {
            // Fill output array with initial Statitistics
            outputFile = new string[4] {
                "File conversion to lowercase not performed.\n",
                "Search for first alphabetical word not performed.\n" +
                "Search for last alphabetical word not performed.\n",
                "Search for longest word in file not performed\n",
                "Search for word with most vowels not performed.\n"};
        }

        /// <summary>
        /// Method to convert words to lowercase
        /// </summary>
        public void ConvertFileToLower()
        {
            // Check if filename is null or empty
            if (fileName == null || fileName == "")
            {
                // Show messagebox that there is nothing to convert
                MessageBox.Show("Nothing to convert!");

                // Escape the method
                return;
            }

            try
            {
                // Call method to set the file
                SetFileString();

                // Convert text to lowercase
                String convertedText = _fileString.ToLower();

                // Update output with notice of conversion result
                outputFile[0] = "[" + DateTime.Now.ToString() + "]" + " File successfully converted to lowercase!\n\n";

                // Notify user of Complete conversion and ask if they want to save it
                DialogResult result = MessageBox.Show("Conversion complete!\n\nDo you want to save changes to the original file?", "Save Changes", MessageBoxButtons.YesNo);

                // If user wants to save conversion to original file...
                if (result == DialogResult.Yes)
                {
                    // Save conversion to original file
                    File.WriteAllText(fileName, convertedText);
                }

            }
            catch (Exception ex)
            {
                // If failure occurs, update status array
                outputFile[0] = "[" + DateTime.Now.ToString() + "]" + " File conversion to lowercase failed.\n\n";

                // Show a messagebox with the error information
                MessageBox.Show("File conversion ecountered a problem.\n\n" + ex.Message);
            }
        }

        

        /// <summary>
        /// Method to store file as string
        /// </summary>
        public void SetFileString()
        {
            try
            {
                // Store file as string
                _fileString = File.ReadAllText(this.fileName);
            }
            catch (Exception ex)
            {
                // If there's a problem, inform user and abort action
                MessageBox.Show("File error.\n\n" + ex.Message);
            }
        }

        /// <summary>
        /// Method to set the file contents to the array
        /// </summary>
        public void SetFileContents()
        {
            // Setup the filestring (path)
            SetFileString();

            // Check to make sure the file exists
            if (_fileString != null || _fileString != "")
            {
                // Check to see if the 
                if (fileContents != null)
                {
                    // Reset the array
                    Array.Clear(fileContents, 0, fileContents.Length);
                }
                
                // Fill the array with the contents of the file
                fileContents = _fileString.Split(
                    new String[] { " ", "\r\n" },
                    StringSplitOptions.RemoveEmptyEntries);
            }
            else
            {
                // If failure occurs, warn user
                MessageBox.Show("Unable to continue. File may be empty or missing.");
            }

        }

        /// <summary>
        /// Method to get the first and last alphabetical words in the file
        /// </summary>
        public void GetFirstAndLastWords()
        {
            try
            {
                // Sort the array
                Array.Sort(fileContents);

                // Update output array with status
                outputFile[1] = "[" + DateTime.Now.ToString() + "]" +
                    " The first alphabatical word is: " + fileContents[0] + "\n\n" +
                    "The last alphabatical word is: " + fileContents[fileContents.Length - 1] + "\n\n";
            }
            catch (Exception ex)
            {
                // If any issues occur, update output array with status
                outputFile[1] = "[" + DateTime.Now.ToString() + "]" + " Failed to find words.\n";

                // Show message containing the reason for the error
                MessageBox.Show("Search for first and last words ecountered a problem.\n\n" + ex.Message);
            }
        }

        /// <summary>
        /// Method to search for the longest word in the file
        /// </summary>
        public void SearchForLongestWord(String[] array, ProgressBar progressBar)
        {
            string longestWord = array[0]; // Set longestWord to first element to start

            // Reset progress bar properties
            progressBar.Value = 0;
            progressBar.Maximum = array.Length;

            // loop through the array
            for (int i = 0; i < array.Length; i++)
            {
                // Set s to array index of i
                string currentWord = array[i];

                // current string is longer that the last reported longest word
                if (currentWord.Length > longestWord.Length)
                {
                    // set longestWord to s
                    longestWord = currentWord;

                    // Continue the loop with the next iteration
                    continue;
                }

                // Update the progress bar
                progressBar.Value = i;
            }

            // Reset the progress bar
            progressBar.Value = 0;

            // Update the output array with the status of the operation
            outputFile[2] = "[" + DateTime.Now.ToString() + "]" +
                " Longest word found: \n" + longestWord + " with a length 0f " +
                longestWord.Length + " characters.\n\n";
        }

        /// <summary>
        /// Method to search for work with most vowels
        /// </summary>
        public void SearchForWordWithMostVowels(String[] array, ProgressBar progressBar)
        {
            // Declare and initialize variables
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };    // set vowels to check
            string word = "";                               // Hold each word
            int highCount = -1;                             // Hold highest current count
            int newCount = 0;                               // Hold new count to test

            // Reset progress bar
            progressBar.Value = 0;
            progressBar.Maximum = array.Length;

            // Iterate through array
            for (int i = 0; i < array.Length; i++)
            {
                // Store string from array with index i in checkWord
                string checkWord = array[i];

                // Iterate through each character the string in checkWord
                foreach (char c in checkWord)
                {
                    // Iterate through the vowels
                    foreach (char v in vowels)
                    {
                        // Check vowel against the character currently in the parent
                        // loop
                        if (v == c)
                        {
                            // If it matches one of the characters, increase newCount
                            newCount++;
                        }
                    }
                }

                // Check count of vowels in current word to that of the previous word
                if (newCount > highCount)
                {
                    // If greater, set the new word to the highest word
                    word = checkWord;

                    // Replace the count to check against
                    highCount = newCount;
                }

                // Reset newCount to zero for new check
                newCount = 0;

                // update progress bar
                progressBar.Value = i;
            }

            // Clear the progress bar
            progressBar.Value = 0;

            // Update the output file with status of search
            outputFile[3] = "[" + DateTime.Now.ToString() + "]" + " Word with most vowels: \n" + word +
                " with a total count of: " + highCount;
        }

        /// <summary>
        /// Method to save statistics to a file
        /// </summary>
        public void SaveFileDialog()
        {
            // Declare and initialize object
            SaveFileDialog save = new SaveFileDialog();

            // Set a file name suggestion for user
            save.FileName = "Statistics.txt";

            // Set a filter so only txt files are avilable, but the user can choose any files
            save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            // Show the save file
            if (save.ShowDialog() == DialogResult.OK)
            {
                // Write to the new file
                File.WriteAllLines(save.FileName, outputFile);
            }
        }
    }
}
