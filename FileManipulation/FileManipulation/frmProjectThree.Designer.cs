namespace Project_3
{
    partial class frmProjectThree
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
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConvertToLowerCase = new System.Windows.Forms.Button();
            this.btnGetFLWords = new System.Windows.Forms.Button();
            this.btnGetLongestWord = new System.Windows.Forms.Button();
            this.btnGetVowelWord = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.rtbStatus = new System.Windows.Forms.RichTextBox();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStrip
            // 
            this.mnuStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(593, 24);
            this.mnuStrip.TabIndex = 0;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuSave,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(180, 22);
            this.mnuOpen.Text = "Open File...";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(180, 22);
            this.mnuSave.Text = "Save Statistics...";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // btnConvertToLowerCase
            // 
            this.btnConvertToLowerCase.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConvertToLowerCase.Enabled = false;
            this.btnConvertToLowerCase.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConvertToLowerCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertToLowerCase.Location = new System.Drawing.Point(12, 45);
            this.btnConvertToLowerCase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConvertToLowerCase.Name = "btnConvertToLowerCase";
            this.btnConvertToLowerCase.Size = new System.Drawing.Size(161, 22);
            this.btnConvertToLowerCase.TabIndex = 1;
            this.btnConvertToLowerCase.Text = "Convert File To Lowercase";
            this.btnConvertToLowerCase.UseVisualStyleBackColor = false;
            this.btnConvertToLowerCase.Click += new System.EventHandler(this.btnConvertToLowerCase_Click);
            // 
            // btnGetFLWords
            // 
            this.btnGetFLWords.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGetFLWords.Enabled = false;
            this.btnGetFLWords.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGetFLWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetFLWords.Location = new System.Drawing.Point(12, 74);
            this.btnGetFLWords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetFLWords.Name = "btnGetFLWords";
            this.btnGetFLWords.Size = new System.Drawing.Size(161, 22);
            this.btnGetFLWords.TabIndex = 2;
            this.btnGetFLWords.Text = "Get First and Last Words";
            this.btnGetFLWords.UseVisualStyleBackColor = false;
            this.btnGetFLWords.Click += new System.EventHandler(this.btnGetFLWords_Click);
            // 
            // btnGetLongestWord
            // 
            this.btnGetLongestWord.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGetLongestWord.Enabled = false;
            this.btnGetLongestWord.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGetLongestWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetLongestWord.Location = new System.Drawing.Point(12, 103);
            this.btnGetLongestWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetLongestWord.Name = "btnGetLongestWord";
            this.btnGetLongestWord.Size = new System.Drawing.Size(161, 22);
            this.btnGetLongestWord.TabIndex = 3;
            this.btnGetLongestWord.Text = "Get Longest Word";
            this.btnGetLongestWord.UseVisualStyleBackColor = false;
            this.btnGetLongestWord.Click += new System.EventHandler(this.btnGetLongestWord_Click);
            // 
            // btnGetVowelWord
            // 
            this.btnGetVowelWord.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGetVowelWord.Enabled = false;
            this.btnGetVowelWord.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGetVowelWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetVowelWord.Location = new System.Drawing.Point(12, 132);
            this.btnGetVowelWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetVowelWord.Name = "btnGetVowelWord";
            this.btnGetVowelWord.Size = new System.Drawing.Size(161, 22);
            this.btnGetVowelWord.TabIndex = 4;
            this.btnGetVowelWord.Text = "Get Word With Most Vowels";
            this.btnGetVowelWord.UseVisualStyleBackColor = false;
            this.btnGetVowelWord.Click += new System.EventHandler(this.btnGetVowelWord_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 174);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(161, 22);
            this.progressBar.TabIndex = 5;
            // 
            // rtbStatus
            // 
            this.rtbStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtbStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbStatus.Location = new System.Drawing.Point(185, 35);
            this.rtbStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.Size = new System.Drawing.Size(396, 162);
            this.rtbStatus.TabIndex = 6;
            this.rtbStatus.Text = "";
            // 
            // frmProjectThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(593, 209);
            this.Controls.Add(this.rtbStatus);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnGetVowelWord);
            this.Controls.Add(this.btnGetLongestWord);
            this.Controls.Add(this.btnGetFLWords);
            this.Controls.Add(this.btnConvertToLowerCase);
            this.Controls.Add(this.mnuStrip);
            this.MainMenuStrip = this.mnuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProjectThree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Manipulation - Project 3";
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button btnConvertToLowerCase;
        private System.Windows.Forms.Button btnGetFLWords;
        private System.Windows.Forms.Button btnGetLongestWord;
        private System.Windows.Forms.Button btnGetVowelWord;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RichTextBox rtbStatus;
    }
}

