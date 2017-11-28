namespace PictureView
{
    partial class PictureView
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
            this.tbFolder = new System.Windows.Forms.TextBox();
            this.btnSource = new System.Windows.Forms.Button();
            this.fbSource = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.lvResults = new System.Windows.Forms.ListView();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.btnSize = new System.Windows.Forms.Button();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.btnSourceFile = new System.Windows.Forms.Button();
            this.fdSource = new System.Windows.Forms.OpenFileDialog();
            this.btnSaveToDatabae = new System.Windows.Forms.Button();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbFolder
            // 
            this.tbFolder.Location = new System.Drawing.Point(61, 32);
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.Size = new System.Drawing.Size(336, 20);
            this.tbFolder.TabIndex = 0;
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(403, 29);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(30, 23);
            this.btnSource.TabIndex = 1;
            this.btnSource.Text = "...";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Analyze";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lvResults
            // 
            this.lvResults.GridLines = true;
            this.lvResults.Location = new System.Drawing.Point(61, 112);
            this.lvResults.Name = "lvResults";
            this.lvResults.Size = new System.Drawing.Size(372, 295);
            this.lvResults.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvResults.TabIndex = 4;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            // 
            // tbNotes
            // 
            this.tbNotes.Enabled = false;
            this.tbNotes.Location = new System.Drawing.Point(61, 440);
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(556, 20);
            this.tbNotes.TabIndex = 5;
            // 
            // btnSize
            // 
            this.btnSize.Location = new System.Drawing.Point(491, 70);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(126, 29);
            this.btnSize.TabIndex = 6;
            this.btnSize.Text = "Picture Size";
            this.btnSize.UseVisualStyleBackColor = true;
            this.btnSize.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(61, 78);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(336, 20);
            this.tbFile.TabIndex = 7;
            // 
            // btnSourceFile
            // 
            this.btnSourceFile.Location = new System.Drawing.Point(403, 76);
            this.btnSourceFile.Name = "btnSourceFile";
            this.btnSourceFile.Size = new System.Drawing.Size(30, 23);
            this.btnSourceFile.TabIndex = 8;
            this.btnSourceFile.Text = "...";
            this.btnSourceFile.UseVisualStyleBackColor = true;
            this.btnSourceFile.Click += new System.EventHandler(this.btnSourceFile_Click);
            // 
            // fdSource
            // 
            this.fdSource.FileName = "openFileDialog1";
            // 
            // btnSaveToDatabae
            // 
            this.btnSaveToDatabae.Location = new System.Drawing.Point(491, 112);
            this.btnSaveToDatabae.Name = "btnSaveToDatabae";
            this.btnSaveToDatabae.Size = new System.Drawing.Size(126, 29);
            this.btnSaveToDatabae.TabIndex = 10;
            this.btnSaveToDatabae.Text = "Save to DB";
            this.btnSaveToDatabae.UseVisualStyleBackColor = true;
            this.btnSaveToDatabae.Click += new System.EventHandler(this.btnSaveToDatabae_Click);
            // 
            // tbCount
            // 
            this.tbCount.Enabled = false;
            this.tbCount.Location = new System.Drawing.Point(491, 387);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(126, 20);
            this.tbCount.TabIndex = 11;
            // 
            // PictureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 472);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.btnSaveToDatabae);
            this.Controls.Add(this.btnSourceFile);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.btnSize);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.lvResults);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSource);
            this.Controls.Add(this.tbFolder);
            this.Name = "PictureView";
            this.Text = "PictureView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFolder;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.FolderBrowserDialog fbSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvResults;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Button btnSize;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Button btnSourceFile;
        private System.Windows.Forms.OpenFileDialog fdSource;
        private System.Windows.Forms.Button btnSaveToDatabae;
        private System.Windows.Forms.TextBox tbCount;
    }
}

