namespace CST_150_Activity5
{
    partial class textProcFrm
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
            this.button1 = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.fileSelectLbl = new System.Windows.Forms.Label();
            this.lastItmLbl = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.lowerCaseLBl = new System.Windows.Forms.Label();
            this.textDocumentLstBx = new System.Windows.Forms.ListBox();
            this.firstItmLbl = new System.Windows.Forms.Label();
            this.firstItmLstBx = new System.Windows.Forms.ListBox();
            this.lastItmLstBx = new System.Windows.Forms.ListBox();
            this.mostVowLbl = new System.Windows.Forms.Label();
            this.mstVowelsLstBx = new System.Windows.Forms.ListBox();
            this.longestWordLbl = new System.Windows.Forms.Label();
            this.longestWordLstBx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse Files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(290, 540);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.browseFileBtn_Click);
            // 
            // fileSelectLbl
            // 
            this.fileSelectLbl.AutoSize = true;
            this.fileSelectLbl.Location = new System.Drawing.Point(12, 22);
            this.fileSelectLbl.Name = "fileSelectLbl";
            this.fileSelectLbl.Size = new System.Drawing.Size(150, 13);
            this.fileSelectLbl.TabIndex = 2;
            this.fileSelectLbl.Text = "Please select a file to process:";
            // 
            // lastItmLbl
            // 
            this.lastItmLbl.AutoSize = true;
            this.lastItmLbl.Location = new System.Drawing.Point(12, 401);
            this.lastItmLbl.Name = "lastItmLbl";
            this.lastItmLbl.Size = new System.Drawing.Size(52, 13);
            this.lastItmLbl.TabIndex = 4;
            this.lastItmLbl.Text = "Last item:";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // lowerCaseLBl
            // 
            this.lowerCaseLBl.AutoSize = true;
            this.lowerCaseLBl.Location = new System.Drawing.Point(12, 44);
            this.lowerCaseLBl.Name = "lowerCaseLBl";
            this.lowerCaseLBl.Size = new System.Drawing.Size(62, 13);
            this.lowerCaseLBl.TabIndex = 6;
            this.lowerCaseLBl.Text = "Lowercase:";
            // 
            // textDocumentLstBx
            // 
            this.textDocumentLstBx.FormattingEnabled = true;
            this.textDocumentLstBx.Location = new System.Drawing.Point(80, 44);
            this.textDocumentLstBx.Name = "textDocumentLstBx";
            this.textDocumentLstBx.Size = new System.Drawing.Size(547, 264);
            this.textDocumentLstBx.TabIndex = 7;
            // 
            // firstItmLbl
            // 
            this.firstItmLbl.AutoSize = true;
            this.firstItmLbl.Location = new System.Drawing.Point(12, 346);
            this.firstItmLbl.Name = "firstItmLbl";
            this.firstItmLbl.Size = new System.Drawing.Size(52, 13);
            this.firstItmLbl.TabIndex = 8;
            this.firstItmLbl.Text = "First Item:";
            // 
            // firstItmLstBx
            // 
            this.firstItmLstBx.FormattingEnabled = true;
            this.firstItmLstBx.Location = new System.Drawing.Point(80, 342);
            this.firstItmLstBx.Name = "firstItmLstBx";
            this.firstItmLstBx.Size = new System.Drawing.Size(120, 17);
            this.firstItmLstBx.TabIndex = 9;
            // 
            // lastItmLstBx
            // 
            this.lastItmLstBx.FormattingEnabled = true;
            this.lastItmLstBx.Location = new System.Drawing.Point(80, 397);
            this.lastItmLstBx.Name = "lastItmLstBx";
            this.lastItmLstBx.Size = new System.Drawing.Size(120, 17);
            this.lastItmLstBx.TabIndex = 10;
            // 
            // mostVowLbl
            // 
            this.mostVowLbl.AutoSize = true;
            this.mostVowLbl.Location = new System.Drawing.Point(12, 476);
            this.mostVowLbl.Name = "mostVowLbl";
            this.mostVowLbl.Size = new System.Drawing.Size(137, 13);
            this.mostVowLbl.TabIndex = 11;
            this.mostVowLbl.Text = "Word with the most vowels:";
            // 
            // mstVowelsLstBx
            // 
            this.mstVowelsLstBx.FormattingEnabled = true;
            this.mstVowelsLstBx.Location = new System.Drawing.Point(155, 472);
            this.mstVowelsLstBx.Name = "mstVowelsLstBx";
            this.mstVowelsLstBx.Size = new System.Drawing.Size(120, 17);
            this.mstVowelsLstBx.TabIndex = 12;
            // 
            // longestWordLbl
            // 
            this.longestWordLbl.AutoSize = true;
            this.longestWordLbl.Location = new System.Drawing.Point(12, 442);
            this.longestWordLbl.Name = "longestWordLbl";
            this.longestWordLbl.Size = new System.Drawing.Size(74, 13);
            this.longestWordLbl.TabIndex = 13;
            this.longestWordLbl.Text = "Longest word:";
            // 
            // longestWordLstBx
            // 
            this.longestWordLstBx.FormattingEnabled = true;
            this.longestWordLstBx.Location = new System.Drawing.Point(92, 438);
            this.longestWordLstBx.Name = "longestWordLstBx";
            this.longestWordLstBx.Size = new System.Drawing.Size(120, 17);
            this.longestWordLstBx.TabIndex = 14;
            // 
            // textProcFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 716);
            this.Controls.Add(this.longestWordLstBx);
            this.Controls.Add(this.longestWordLbl);
            this.Controls.Add(this.mstVowelsLstBx);
            this.Controls.Add(this.mostVowLbl);
            this.Controls.Add(this.lastItmLstBx);
            this.Controls.Add(this.firstItmLstBx);
            this.Controls.Add(this.firstItmLbl);
            this.Controls.Add(this.textDocumentLstBx);
            this.Controls.Add(this.lowerCaseLBl);
            this.Controls.Add(this.lastItmLbl);
            this.Controls.Add(this.fileSelectLbl);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.button1);
            this.Name = "textProcFrm";
            this.Text = "Text processing form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label fileSelectLbl;
        private System.Windows.Forms.Label lastItmLbl;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label lowerCaseLBl;
        private System.Windows.Forms.ListBox textDocumentLstBx;
        private System.Windows.Forms.Label firstItmLbl;
        private System.Windows.Forms.ListBox firstItmLstBx;
        private System.Windows.Forms.ListBox lastItmLstBx;
        private System.Windows.Forms.Label mostVowLbl;
        private System.Windows.Forms.ListBox mstVowelsLstBx;
        private System.Windows.Forms.Label longestWordLbl;
        private System.Windows.Forms.ListBox longestWordLstBx;
    }
}

