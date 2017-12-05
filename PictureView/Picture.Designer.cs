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
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.lvResults = new System.Windows.Forms.ListView();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.btnSourceFile = new System.Windows.Forms.Button();
            this.fdSource = new System.Windows.Forms.OpenFileDialog();
            this.btnSaveToDatabae = new System.Windows.Forms.Button();
            this.tbResults = new System.Windows.Forms.TextBox();
            this.btnResults = new System.Windows.Forms.Button();
            this.tcMail = new System.Windows.Forms.TabControl();
            this.tbPictureView1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPictureView2 = new System.Windows.Forms.TabPage();
            this.tbCountCopyResizedPicture = new System.Windows.Forms.TextBox();
            this.btnCopyResizedPicture = new System.Windows.Forms.Button();
            this.rbSV = new System.Windows.Forms.RadioButton();
            this.rbBUZZ = new System.Windows.Forms.RadioButton();
            this.tbFTPPassword1 = new System.Windows.Forms.TextBox();
            this.tbFTPUser1 = new System.Windows.Forms.TextBox();
            this.tbFTPIP1 = new System.Windows.Forms.TextBox();
            this.tbCountMissingPicture = new System.Windows.Forms.TextBox();
            this.btnMissingPicture = new System.Windows.Forms.Button();
            this.tbCountResizedPicture = new System.Windows.Forms.TextBox();
            this.tbResHeight = new System.Windows.Forms.TextBox();
            this.tbResWidth = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnResizedPicture = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbResizePicture = new System.Windows.Forms.TextBox();
            this.btnResizePicture = new System.Windows.Forms.Button();
            this.tbCountDownloadFromFTP = new System.Windows.Forms.TextBox();
            this.btnFTP = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDestinationFTP = new System.Windows.Forms.TextBox();
            this.btnDownloadFTP = new System.Windows.Forms.Button();
            this.tbCountFromFTP = new System.Windows.Forms.TextBox();
            this.tbCountERPItem = new System.Windows.Forms.TextBox();
            this.btnDifferenceERP = new System.Windows.Forms.Button();
            this.btnERPItem = new System.Windows.Forms.Button();
            this.tbCountDifference = new System.Windows.Forms.TextBox();
            this.tbCountDestination = new System.Windows.Forms.TextBox();
            this.tbCountFTP = new System.Windows.Forms.TextBox();
            this.btnDifference = new System.Windows.Forms.Button();
            this.btnScanFTP = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFTPPassword = new System.Windows.Forms.TextBox();
            this.tbFTPUser = new System.Windows.Forms.TextBox();
            this.tbFTPIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNotesSynchronization = new System.Windows.Forms.TextBox();
            this.btnScanDestination = new System.Windows.Forms.Button();
            this.btnDestination = new System.Windows.Forms.Button();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbSendMail = new System.Windows.Forms.TextBox();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.tbBody = new System.Windows.Forms.TextBox();
            this.labBody = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.labSubject = new System.Windows.Forms.Label();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.labTo = new System.Windows.Forms.Label();
            this.tbFromName = new System.Windows.Forms.TextBox();
            this.labFromName = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.labFrom = new System.Windows.Forms.Label();
            this.labMailServerPort = new System.Windows.Forms.Label();
            this.tbMailServerPort = new System.Windows.Forms.TextBox();
            this.tbMailServer = new System.Windows.Forms.TextBox();
            this.labMailServer = new System.Windows.Forms.Label();
            this.tbDestinationMissing = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDestinationMissing = new System.Windows.Forms.Button();
            this.tcMail.SuspendLayout();
            this.tbPictureView1.SuspendLayout();
            this.tbPictureView2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFolder
            // 
            this.tbFolder.Location = new System.Drawing.Point(76, 46);
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.Size = new System.Drawing.Size(462, 20);
            this.tbFolder.TabIndex = 0;
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(544, 47);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(30, 23);
            this.btnSource.TabIndex = 1;
            this.btnSource.Text = "...";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(612, 41);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(130, 30);
            this.btnAnalyze.TabIndex = 2;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // lvResults
            // 
            this.lvResults.GridLines = true;
            this.lvResults.Location = new System.Drawing.Point(76, 114);
            this.lvResults.Name = "lvResults";
            this.lvResults.Size = new System.Drawing.Size(498, 461);
            this.lvResults.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvResults.TabIndex = 4;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            // 
            // tbNotes
            // 
            this.tbNotes.Enabled = false;
            this.tbNotes.Location = new System.Drawing.Point(76, 595);
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(662, 20);
            this.tbNotes.TabIndex = 5;
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(76, 82);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(462, 20);
            this.tbFile.TabIndex = 7;
            // 
            // btnSourceFile
            // 
            this.btnSourceFile.Location = new System.Drawing.Point(544, 82);
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
            this.btnSaveToDatabae.Location = new System.Drawing.Point(468, 541);
            this.btnSaveToDatabae.Name = "btnSaveToDatabae";
            this.btnSaveToDatabae.Size = new System.Drawing.Size(126, 29);
            this.btnSaveToDatabae.TabIndex = 10;
            this.btnSaveToDatabae.Text = "Save to DB";
            this.btnSaveToDatabae.UseVisualStyleBackColor = true;
            this.btnSaveToDatabae.Visible = false;
            this.btnSaveToDatabae.Click += new System.EventHandler(this.btnSaveToDatabae_Click);
            // 
            // tbResults
            // 
            this.tbResults.Location = new System.Drawing.Point(335, 550);
            this.tbResults.Name = "tbResults";
            this.tbResults.Size = new System.Drawing.Size(91, 20);
            this.tbResults.TabIndex = 13;
            this.tbResults.Visible = false;
            // 
            // btnResults
            // 
            this.btnResults.Location = new System.Drawing.Point(432, 547);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(30, 23);
            this.btnResults.TabIndex = 14;
            this.btnResults.Text = "...";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Visible = false;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // tcMail
            // 
            this.tcMail.Controls.Add(this.tbPictureView1);
            this.tcMail.Controls.Add(this.tbPictureView2);
            this.tcMail.Controls.Add(this.tabPage1);
            this.tcMail.Location = new System.Drawing.Point(0, 0);
            this.tcMail.Name = "tcMail";
            this.tcMail.SelectedIndex = 0;
            this.tcMail.Size = new System.Drawing.Size(776, 647);
            this.tcMail.TabIndex = 17;
            this.tcMail.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcMail_Selecting);
            // 
            // tbPictureView1
            // 
            this.tbPictureView1.Controls.Add(this.label2);
            this.tbPictureView1.Controls.Add(this.label1);
            this.tbPictureView1.Controls.Add(this.tbFolder);
            this.tbPictureView1.Controls.Add(this.btnSource);
            this.tbPictureView1.Controls.Add(this.tbFile);
            this.tbPictureView1.Controls.Add(this.btnSourceFile);
            this.tbPictureView1.Controls.Add(this.lvResults);
            this.tbPictureView1.Controls.Add(this.btnAnalyze);
            this.tbPictureView1.Controls.Add(this.tbNotes);
            this.tbPictureView1.Location = new System.Drawing.Point(4, 22);
            this.tbPictureView1.Name = "tbPictureView1";
            this.tbPictureView1.Padding = new System.Windows.Forms.Padding(3);
            this.tbPictureView1.Size = new System.Drawing.Size(768, 621);
            this.tbPictureView1.TabIndex = 0;
            this.tbPictureView1.Text = "Analyze";
            this.tbPictureView1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Folder";
            // 
            // tbPictureView2
            // 
            this.tbPictureView2.Controls.Add(this.btnDestinationMissing);
            this.tbPictureView2.Controls.Add(this.label11);
            this.tbPictureView2.Controls.Add(this.tbDestinationMissing);
            this.tbPictureView2.Controls.Add(this.tbCountCopyResizedPicture);
            this.tbPictureView2.Controls.Add(this.btnCopyResizedPicture);
            this.tbPictureView2.Controls.Add(this.rbSV);
            this.tbPictureView2.Controls.Add(this.rbBUZZ);
            this.tbPictureView2.Controls.Add(this.tbFTPPassword1);
            this.tbPictureView2.Controls.Add(this.tbFTPUser1);
            this.tbPictureView2.Controls.Add(this.tbFTPIP1);
            this.tbPictureView2.Controls.Add(this.tbCountMissingPicture);
            this.tbPictureView2.Controls.Add(this.btnMissingPicture);
            this.tbPictureView2.Controls.Add(this.tbCountResizedPicture);
            this.tbPictureView2.Controls.Add(this.tbResHeight);
            this.tbPictureView2.Controls.Add(this.tbResWidth);
            this.tbPictureView2.Controls.Add(this.label10);
            this.tbPictureView2.Controls.Add(this.btnResizedPicture);
            this.tbPictureView2.Controls.Add(this.label9);
            this.tbPictureView2.Controls.Add(this.tbResizePicture);
            this.tbPictureView2.Controls.Add(this.btnResizePicture);
            this.tbPictureView2.Controls.Add(this.tbCountDownloadFromFTP);
            this.tbPictureView2.Controls.Add(this.btnFTP);
            this.tbPictureView2.Controls.Add(this.label8);
            this.tbPictureView2.Controls.Add(this.tbDestinationFTP);
            this.tbPictureView2.Controls.Add(this.btnDownloadFTP);
            this.tbPictureView2.Controls.Add(this.tbCountFromFTP);
            this.tbPictureView2.Controls.Add(this.tbCountERPItem);
            this.tbPictureView2.Controls.Add(this.btnDifferenceERP);
            this.tbPictureView2.Controls.Add(this.btnERPItem);
            this.tbPictureView2.Controls.Add(this.tbCountDifference);
            this.tbPictureView2.Controls.Add(this.tbCountDestination);
            this.tbPictureView2.Controls.Add(this.tbCountFTP);
            this.tbPictureView2.Controls.Add(this.btnDifference);
            this.tbPictureView2.Controls.Add(this.btnScanFTP);
            this.tbPictureView2.Controls.Add(this.label7);
            this.tbPictureView2.Controls.Add(this.label6);
            this.tbPictureView2.Controls.Add(this.label5);
            this.tbPictureView2.Controls.Add(this.tbFTPPassword);
            this.tbPictureView2.Controls.Add(this.tbFTPUser);
            this.tbPictureView2.Controls.Add(this.tbFTPIP);
            this.tbPictureView2.Controls.Add(this.label4);
            this.tbPictureView2.Controls.Add(this.label3);
            this.tbPictureView2.Controls.Add(this.tbNotesSynchronization);
            this.tbPictureView2.Controls.Add(this.btnScanDestination);
            this.tbPictureView2.Controls.Add(this.btnDestination);
            this.tbPictureView2.Controls.Add(this.tbDestination);
            this.tbPictureView2.Controls.Add(this.tbCount);
            this.tbPictureView2.Controls.Add(this.btnResults);
            this.tbPictureView2.Controls.Add(this.tbResults);
            this.tbPictureView2.Controls.Add(this.btnSaveToDatabae);
            this.tbPictureView2.Location = new System.Drawing.Point(4, 22);
            this.tbPictureView2.Name = "tbPictureView2";
            this.tbPictureView2.Padding = new System.Windows.Forms.Padding(3);
            this.tbPictureView2.Size = new System.Drawing.Size(768, 621);
            this.tbPictureView2.TabIndex = 1;
            this.tbPictureView2.Text = "Synchronization";
            this.tbPictureView2.UseVisualStyleBackColor = true;
            // 
            // tbCountCopyResizedPicture
            // 
            this.tbCountCopyResizedPicture.Enabled = false;
            this.tbCountCopyResizedPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCountCopyResizedPicture.Location = new System.Drawing.Point(626, 422);
            this.tbCountCopyResizedPicture.Name = "tbCountCopyResizedPicture";
            this.tbCountCopyResizedPicture.Size = new System.Drawing.Size(126, 29);
            this.tbCountCopyResizedPicture.TabIndex = 60;
            // 
            // btnCopyResizedPicture
            // 
            this.btnCopyResizedPicture.Location = new System.Drawing.Point(474, 421);
            this.btnCopyResizedPicture.Name = "btnCopyResizedPicture";
            this.btnCopyResizedPicture.Size = new System.Drawing.Size(130, 30);
            this.btnCopyResizedPicture.TabIndex = 59;
            this.btnCopyResizedPicture.Text = "Copy picture";
            this.btnCopyResizedPicture.UseVisualStyleBackColor = true;
            this.btnCopyResizedPicture.Click += new System.EventHandler(this.btnCopyResizedPicture_Click);
            // 
            // rbSV
            // 
            this.rbSV.AutoSize = true;
            this.rbSV.Location = new System.Drawing.Point(226, 5);
            this.rbSV.Name = "rbSV";
            this.rbSV.Size = new System.Drawing.Size(78, 17);
            this.rbSV.TabIndex = 58;
            this.rbSV.TabStop = true;
            this.rbSV.Text = "SportVision";
            this.rbSV.UseVisualStyleBackColor = true;
            this.rbSV.CheckedChanged += new System.EventHandler(this.rbSV_CheckedChanged);
            // 
            // rbBUZZ
            // 
            this.rbBUZZ.AutoSize = true;
            this.rbBUZZ.Location = new System.Drawing.Point(100, 5);
            this.rbBUZZ.Name = "rbBUZZ";
            this.rbBUZZ.Size = new System.Drawing.Size(54, 17);
            this.rbBUZZ.TabIndex = 57;
            this.rbBUZZ.TabStop = true;
            this.rbBUZZ.Text = "BUZZ";
            this.rbBUZZ.UseVisualStyleBackColor = true;
            this.rbBUZZ.CheckedChanged += new System.EventHandler(this.rbBUZZ_CheckedChanged);
            // 
            // tbFTPPassword1
            // 
            this.tbFTPPassword1.Location = new System.Drawing.Point(226, 80);
            this.tbFTPPassword1.Name = "tbFTPPassword1";
            this.tbFTPPassword1.PasswordChar = '*';
            this.tbFTPPassword1.Size = new System.Drawing.Size(120, 20);
            this.tbFTPPassword1.TabIndex = 56;
            // 
            // tbFTPUser1
            // 
            this.tbFTPUser1.Location = new System.Drawing.Point(226, 54);
            this.tbFTPUser1.Name = "tbFTPUser1";
            this.tbFTPUser1.Size = new System.Drawing.Size(120, 20);
            this.tbFTPUser1.TabIndex = 55;
            // 
            // tbFTPIP1
            // 
            this.tbFTPIP1.Location = new System.Drawing.Point(226, 28);
            this.tbFTPIP1.Name = "tbFTPIP1";
            this.tbFTPIP1.Size = new System.Drawing.Size(120, 20);
            this.tbFTPIP1.TabIndex = 54;
            // 
            // tbCountMissingPicture
            // 
            this.tbCountMissingPicture.Enabled = false;
            this.tbCountMissingPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCountMissingPicture.Location = new System.Drawing.Point(626, 469);
            this.tbCountMissingPicture.Name = "tbCountMissingPicture";
            this.tbCountMissingPicture.Size = new System.Drawing.Size(126, 29);
            this.tbCountMissingPicture.TabIndex = 53;
            // 
            // btnMissingPicture
            // 
            this.btnMissingPicture.Location = new System.Drawing.Point(474, 471);
            this.btnMissingPicture.Name = "btnMissingPicture";
            this.btnMissingPicture.Size = new System.Drawing.Size(130, 30);
            this.btnMissingPicture.TabIndex = 52;
            this.btnMissingPicture.Text = "Missing Picture";
            this.btnMissingPicture.UseVisualStyleBackColor = true;
            this.btnMissingPicture.Click += new System.EventHandler(this.btnMissingPicture_Click);
            // 
            // tbCountResizedPicture
            // 
            this.tbCountResizedPicture.Enabled = false;
            this.tbCountResizedPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCountResizedPicture.Location = new System.Drawing.Point(626, 355);
            this.tbCountResizedPicture.Name = "tbCountResizedPicture";
            this.tbCountResizedPicture.Size = new System.Drawing.Size(126, 29);
            this.tbCountResizedPicture.TabIndex = 51;
            // 
            // tbResHeight
            // 
            this.tbResHeight.Location = new System.Drawing.Point(163, 402);
            this.tbResHeight.Name = "tbResHeight";
            this.tbResHeight.Size = new System.Drawing.Size(57, 20);
            this.tbResHeight.TabIndex = 50;
            // 
            // tbResWidth
            // 
            this.tbResWidth.Location = new System.Drawing.Point(100, 402);
            this.tbResWidth.Name = "tbResWidth";
            this.tbResWidth.Size = new System.Drawing.Size(57, 20);
            this.tbResWidth.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Resolution";
            // 
            // btnResizedPicture
            // 
            this.btnResizedPicture.Location = new System.Drawing.Point(438, 360);
            this.btnResizedPicture.Name = "btnResizedPicture";
            this.btnResizedPicture.Size = new System.Drawing.Size(30, 23);
            this.btnResizedPicture.TabIndex = 47;
            this.btnResizedPicture.Text = "...";
            this.btnResizedPicture.UseVisualStyleBackColor = true;
            this.btnResizedPicture.Click += new System.EventHandler(this.btnResizedPicture_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Resized picture";
            // 
            // tbResizePicture
            // 
            this.tbResizePicture.Location = new System.Drawing.Point(100, 363);
            this.tbResizePicture.Name = "tbResizePicture";
            this.tbResizePicture.Size = new System.Drawing.Size(336, 20);
            this.tbResizePicture.TabIndex = 45;
            // 
            // btnResizePicture
            // 
            this.btnResizePicture.Location = new System.Drawing.Point(474, 357);
            this.btnResizePicture.Name = "btnResizePicture";
            this.btnResizePicture.Size = new System.Drawing.Size(130, 30);
            this.btnResizePicture.TabIndex = 44;
            this.btnResizePicture.Text = "Resize picture";
            this.btnResizePicture.UseVisualStyleBackColor = true;
            this.btnResizePicture.Click += new System.EventHandler(this.btnResizePicture_Click);
            // 
            // tbCountDownloadFromFTP
            // 
            this.tbCountDownloadFromFTP.Enabled = false;
            this.tbCountDownloadFromFTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCountDownloadFromFTP.Location = new System.Drawing.Point(626, 308);
            this.tbCountDownloadFromFTP.Name = "tbCountDownloadFromFTP";
            this.tbCountDownloadFromFTP.Size = new System.Drawing.Size(126, 29);
            this.tbCountDownloadFromFTP.TabIndex = 43;
            // 
            // btnFTP
            // 
            this.btnFTP.Location = new System.Drawing.Point(438, 312);
            this.btnFTP.Name = "btnFTP";
            this.btnFTP.Size = new System.Drawing.Size(30, 23);
            this.btnFTP.TabIndex = 42;
            this.btnFTP.Text = "...";
            this.btnFTP.UseVisualStyleBackColor = true;
            this.btnFTP.Click += new System.EventHandler(this.btnFTP_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Destination FTP";
            // 
            // tbDestinationFTP
            // 
            this.tbDestinationFTP.Location = new System.Drawing.Point(100, 310);
            this.tbDestinationFTP.Name = "tbDestinationFTP";
            this.tbDestinationFTP.Size = new System.Drawing.Size(336, 20);
            this.tbDestinationFTP.TabIndex = 40;
            // 
            // btnDownloadFTP
            // 
            this.btnDownloadFTP.Location = new System.Drawing.Point(474, 310);
            this.btnDownloadFTP.Name = "btnDownloadFTP";
            this.btnDownloadFTP.Size = new System.Drawing.Size(130, 30);
            this.btnDownloadFTP.TabIndex = 39;
            this.btnDownloadFTP.Text = "Download FTP";
            this.btnDownloadFTP.UseVisualStyleBackColor = true;
            this.btnDownloadFTP.Click += new System.EventHandler(this.btnDownloadFTP_Click);
            // 
            // tbCountFromFTP
            // 
            this.tbCountFromFTP.Enabled = false;
            this.tbCountFromFTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCountFromFTP.Location = new System.Drawing.Point(626, 264);
            this.tbCountFromFTP.Name = "tbCountFromFTP";
            this.tbCountFromFTP.Size = new System.Drawing.Size(126, 29);
            this.tbCountFromFTP.TabIndex = 38;
            // 
            // tbCountERPItem
            // 
            this.tbCountERPItem.Enabled = false;
            this.tbCountERPItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCountERPItem.Location = new System.Drawing.Point(626, 214);
            this.tbCountERPItem.Name = "tbCountERPItem";
            this.tbCountERPItem.Size = new System.Drawing.Size(126, 29);
            this.tbCountERPItem.TabIndex = 37;
            // 
            // btnDifferenceERP
            // 
            this.btnDifferenceERP.Location = new System.Drawing.Point(474, 263);
            this.btnDifferenceERP.Name = "btnDifferenceERP";
            this.btnDifferenceERP.Size = new System.Drawing.Size(130, 30);
            this.btnDifferenceERP.TabIndex = 36;
            this.btnDifferenceERP.Text = "Difference ERP";
            this.btnDifferenceERP.UseVisualStyleBackColor = true;
            this.btnDifferenceERP.Click += new System.EventHandler(this.btnDifferenceERP_Click);
            // 
            // btnERPItem
            // 
            this.btnERPItem.Location = new System.Drawing.Point(474, 214);
            this.btnERPItem.Name = "btnERPItem";
            this.btnERPItem.Size = new System.Drawing.Size(130, 30);
            this.btnERPItem.TabIndex = 35;
            this.btnERPItem.Text = "ERP Item";
            this.btnERPItem.UseVisualStyleBackColor = true;
            this.btnERPItem.Click += new System.EventHandler(this.btnERPItem_Click);
            // 
            // tbCountDifference
            // 
            this.tbCountDifference.Enabled = false;
            this.tbCountDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCountDifference.Location = new System.Drawing.Point(626, 166);
            this.tbCountDifference.Name = "tbCountDifference";
            this.tbCountDifference.Size = new System.Drawing.Size(126, 29);
            this.tbCountDifference.TabIndex = 34;
            // 
            // tbCountDestination
            // 
            this.tbCountDestination.Enabled = false;
            this.tbCountDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCountDestination.Location = new System.Drawing.Point(626, 111);
            this.tbCountDestination.Name = "tbCountDestination";
            this.tbCountDestination.Size = new System.Drawing.Size(126, 29);
            this.tbCountDestination.TabIndex = 33;
            // 
            // tbCountFTP
            // 
            this.tbCountFTP.Enabled = false;
            this.tbCountFTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCountFTP.Location = new System.Drawing.Point(626, 71);
            this.tbCountFTP.Name = "tbCountFTP";
            this.tbCountFTP.Size = new System.Drawing.Size(126, 29);
            this.tbCountFTP.TabIndex = 32;
            // 
            // btnDifference
            // 
            this.btnDifference.Location = new System.Drawing.Point(474, 165);
            this.btnDifference.Name = "btnDifference";
            this.btnDifference.Size = new System.Drawing.Size(130, 30);
            this.btnDifference.TabIndex = 31;
            this.btnDifference.Text = "Difference FTP-Dest";
            this.btnDifference.UseVisualStyleBackColor = true;
            this.btnDifference.Click += new System.EventHandler(this.btnDifference_Click);
            // 
            // btnScanFTP
            // 
            this.btnScanFTP.Location = new System.Drawing.Point(474, 70);
            this.btnScanFTP.Name = "btnScanFTP";
            this.btnScanFTP.Size = new System.Drawing.Size(130, 30);
            this.btnScanFTP.TabIndex = 30;
            this.btnScanFTP.Text = "Scan FTP";
            this.btnScanFTP.UseVisualStyleBackColor = true;
            this.btnScanFTP.Click += new System.EventHandler(this.btnScanFTP_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "IP";
            // 
            // tbFTPPassword
            // 
            this.tbFTPPassword.Location = new System.Drawing.Point(100, 80);
            this.tbFTPPassword.Name = "tbFTPPassword";
            this.tbFTPPassword.PasswordChar = '*';
            this.tbFTPPassword.Size = new System.Drawing.Size(120, 20);
            this.tbFTPPassword.TabIndex = 26;
            // 
            // tbFTPUser
            // 
            this.tbFTPUser.Location = new System.Drawing.Point(100, 54);
            this.tbFTPUser.Name = "tbFTPUser";
            this.tbFTPUser.Size = new System.Drawing.Size(120, 20);
            this.tbFTPUser.TabIndex = 25;
            // 
            // tbFTPIP
            // 
            this.tbFTPIP.Location = new System.Drawing.Point(100, 28);
            this.tbFTPIP.Name = "tbFTPIP";
            this.tbFTPIP.Size = new System.Drawing.Size(120, 20);
            this.tbFTPIP.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "FTP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Destination";
            // 
            // tbNotesSynchronization
            // 
            this.tbNotesSynchronization.Enabled = false;
            this.tbNotesSynchronization.Location = new System.Drawing.Point(90, 595);
            this.tbNotesSynchronization.Name = "tbNotesSynchronization";
            this.tbNotesSynchronization.Size = new System.Drawing.Size(662, 20);
            this.tbNotesSynchronization.TabIndex = 21;
            // 
            // btnScanDestination
            // 
            this.btnScanDestination.Location = new System.Drawing.Point(474, 113);
            this.btnScanDestination.Name = "btnScanDestination";
            this.btnScanDestination.Size = new System.Drawing.Size(130, 30);
            this.btnScanDestination.TabIndex = 20;
            this.btnScanDestination.Text = "Scan Destination";
            this.btnScanDestination.UseVisualStyleBackColor = true;
            this.btnScanDestination.Click += new System.EventHandler(this.btnScanDestination_Click);
            // 
            // btnDestination
            // 
            this.btnDestination.Location = new System.Drawing.Point(438, 116);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(30, 23);
            this.btnDestination.TabIndex = 19;
            this.btnDestination.Text = "...";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(100, 116);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(336, 20);
            this.tbDestination.TabIndex = 18;
            // 
            // tbCount
            // 
            this.tbCount.Enabled = false;
            this.tbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCount.Location = new System.Drawing.Point(626, 560);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(126, 29);
            this.tbCount.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbSendMail);
            this.tabPage1.Controls.Add(this.btnSendMail);
            this.tabPage1.Controls.Add(this.tbBody);
            this.tabPage1.Controls.Add(this.labBody);
            this.tabPage1.Controls.Add(this.tbSubject);
            this.tabPage1.Controls.Add(this.labSubject);
            this.tabPage1.Controls.Add(this.tbTo);
            this.tabPage1.Controls.Add(this.labTo);
            this.tabPage1.Controls.Add(this.tbFromName);
            this.tabPage1.Controls.Add(this.labFromName);
            this.tabPage1.Controls.Add(this.tbFrom);
            this.tabPage1.Controls.Add(this.labFrom);
            this.tabPage1.Controls.Add(this.labMailServerPort);
            this.tabPage1.Controls.Add(this.tbMailServerPort);
            this.tabPage1.Controls.Add(this.tbMailServer);
            this.tabPage1.Controls.Add(this.labMailServer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 621);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Mail";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbSendMail
            // 
            this.tbSendMail.Location = new System.Drawing.Point(584, 591);
            this.tbSendMail.Name = "tbSendMail";
            this.tbSendMail.ReadOnly = true;
            this.tbSendMail.Size = new System.Drawing.Size(169, 20);
            this.tbSendMail.TabIndex = 25;
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(604, 525);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(130, 60);
            this.btnSendMail.TabIndex = 24;
            this.btnSendMail.Text = "Send";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // tbBody
            // 
            this.tbBody.Location = new System.Drawing.Point(87, 163);
            this.tbBody.Multiline = true;
            this.tbBody.Name = "tbBody";
            this.tbBody.Size = new System.Drawing.Size(491, 452);
            this.tbBody.TabIndex = 23;
            // 
            // labBody
            // 
            this.labBody.AutoSize = true;
            this.labBody.Location = new System.Drawing.Point(41, 171);
            this.labBody.Name = "labBody";
            this.labBody.Size = new System.Drawing.Size(31, 13);
            this.labBody.TabIndex = 22;
            this.labBody.Text = "Body";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(87, 127);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(310, 20);
            this.tbSubject.TabIndex = 21;
            // 
            // labSubject
            // 
            this.labSubject.AutoSize = true;
            this.labSubject.Location = new System.Drawing.Point(38, 127);
            this.labSubject.Name = "labSubject";
            this.labSubject.Size = new System.Drawing.Size(43, 13);
            this.labSubject.TabIndex = 20;
            this.labSubject.Text = "Subject";
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(434, 61);
            this.tbTo.Multiline = true;
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(310, 55);
            this.tbTo.TabIndex = 19;
            // 
            // labTo
            // 
            this.labTo.AutoSize = true;
            this.labTo.Location = new System.Drawing.Point(408, 79);
            this.labTo.Name = "labTo";
            this.labTo.Size = new System.Drawing.Size(20, 13);
            this.labTo.TabIndex = 18;
            this.labTo.Text = "To";
            // 
            // tbFromName
            // 
            this.tbFromName.Location = new System.Drawing.Point(87, 96);
            this.tbFromName.Name = "tbFromName";
            this.tbFromName.Size = new System.Drawing.Size(310, 20);
            this.tbFromName.TabIndex = 17;
            // 
            // labFromName
            // 
            this.labFromName.AutoSize = true;
            this.labFromName.Location = new System.Drawing.Point(20, 104);
            this.labFromName.Name = "labFromName";
            this.labFromName.Size = new System.Drawing.Size(61, 13);
            this.labFromName.TabIndex = 16;
            this.labFromName.Text = "From Name";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(87, 62);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(310, 20);
            this.tbFrom.TabIndex = 15;
            // 
            // labFrom
            // 
            this.labFrom.AutoSize = true;
            this.labFrom.Location = new System.Drawing.Point(51, 69);
            this.labFrom.Name = "labFrom";
            this.labFrom.Size = new System.Drawing.Size(30, 13);
            this.labFrom.TabIndex = 14;
            this.labFrom.Text = "From";
            // 
            // labMailServerPort
            // 
            this.labMailServerPort.AutoSize = true;
            this.labMailServerPort.Location = new System.Drawing.Point(402, 36);
            this.labMailServerPort.Name = "labMailServerPort";
            this.labMailServerPort.Size = new System.Drawing.Size(26, 13);
            this.labMailServerPort.TabIndex = 13;
            this.labMailServerPort.Text = "Port";
            // 
            // tbMailServerPort
            // 
            this.tbMailServerPort.Location = new System.Drawing.Point(434, 29);
            this.tbMailServerPort.Name = "tbMailServerPort";
            this.tbMailServerPort.Size = new System.Drawing.Size(100, 20);
            this.tbMailServerPort.TabIndex = 12;
            // 
            // tbMailServer
            // 
            this.tbMailServer.Location = new System.Drawing.Point(87, 27);
            this.tbMailServer.Name = "tbMailServer";
            this.tbMailServer.Size = new System.Drawing.Size(310, 20);
            this.tbMailServer.TabIndex = 3;
            // 
            // labMailServer
            // 
            this.labMailServer.AutoSize = true;
            this.labMailServer.Location = new System.Drawing.Point(23, 34);
            this.labMailServer.Name = "labMailServer";
            this.labMailServer.Size = new System.Drawing.Size(58, 13);
            this.labMailServer.TabIndex = 2;
            this.labMailServer.Text = "Mail server";
            this.labMailServer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbDestinationMissing
            // 
            this.tbDestinationMissing.Location = new System.Drawing.Point(100, 477);
            this.tbDestinationMissing.Name = "tbDestinationMissing";
            this.tbDestinationMissing.Size = new System.Drawing.Size(336, 20);
            this.tbDestinationMissing.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-3, 480);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 62;
            this.label11.Text = "Destination Missing";
            // 
            // btnDestinationMissing
            // 
            this.btnDestinationMissing.Location = new System.Drawing.Point(438, 474);
            this.btnDestinationMissing.Name = "btnDestinationMissing";
            this.btnDestinationMissing.Size = new System.Drawing.Size(30, 23);
            this.btnDestinationMissing.TabIndex = 63;
            this.btnDestinationMissing.Text = "...";
            this.btnDestinationMissing.UseVisualStyleBackColor = true;
            this.btnDestinationMissing.Click += new System.EventHandler(this.btnDestinationMissing_Click);
            // 
            // PictureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 649);
            this.Controls.Add(this.tcMail);
            this.Name = "PictureView";
            this.Text = "PictureView v1.0";
            this.tcMail.ResumeLayout(false);
            this.tbPictureView1.ResumeLayout(false);
            this.tbPictureView1.PerformLayout();
            this.tbPictureView2.ResumeLayout(false);
            this.tbPictureView2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbFolder;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.FolderBrowserDialog fbSource;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.ListView lvResults;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Button btnSourceFile;
        private System.Windows.Forms.OpenFileDialog fdSource;
        private System.Windows.Forms.Button btnSaveToDatabae;
        private System.Windows.Forms.TextBox tbResults;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.TabControl tcMail;
        private System.Windows.Forms.TabPage tbPictureView1;
        private System.Windows.Forms.TabPage tbPictureView2;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.Button btnScanDestination;
        private System.Windows.Forms.TextBox tbNotesSynchronization;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFTPPassword;
        private System.Windows.Forms.TextBox tbFTPUser;
        private System.Windows.Forms.TextBox tbFTPIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnScanFTP;
        private System.Windows.Forms.Button btnDifference;
        private System.Windows.Forms.TextBox tbCountFTP;
        private System.Windows.Forms.TextBox tbCountDestination;
        private System.Windows.Forms.TextBox tbCountDifference;
        private System.Windows.Forms.Button btnERPItem;
        private System.Windows.Forms.Button btnDifferenceERP;
        private System.Windows.Forms.TextBox tbCountERPItem;
        private System.Windows.Forms.TextBox tbCountFromFTP;
        private System.Windows.Forms.Button btnDownloadFTP;
        private System.Windows.Forms.TextBox tbDestinationFTP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFTP;
        private System.Windows.Forms.TextBox tbCountDownloadFromFTP;
        private System.Windows.Forms.Button btnResizePicture;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbResizePicture;
        private System.Windows.Forms.Button btnResizedPicture;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbResHeight;
        private System.Windows.Forms.TextBox tbResWidth;
        private System.Windows.Forms.TextBox tbCountResizedPicture;
        private System.Windows.Forms.Button btnMissingPicture;
        private System.Windows.Forms.TextBox tbCountMissingPicture;
        private System.Windows.Forms.TextBox tbFTPPassword1;
        private System.Windows.Forms.TextBox tbFTPUser1;
        private System.Windows.Forms.TextBox tbFTPIP1;
        private System.Windows.Forms.RadioButton rbBUZZ;
        private System.Windows.Forms.RadioButton rbSV;
        private System.Windows.Forms.Button btnCopyResizedPicture;
        private System.Windows.Forms.TextBox tbCountCopyResizedPicture;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbMailServer;
        private System.Windows.Forms.Label labMailServer;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label labSubject;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Label labTo;
        private System.Windows.Forms.TextBox tbFromName;
        private System.Windows.Forms.Label labFromName;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Label labFrom;
        private System.Windows.Forms.Label labMailServerPort;
        private System.Windows.Forms.TextBox tbMailServerPort;
        private System.Windows.Forms.TextBox tbBody;
        private System.Windows.Forms.Label labBody;
        private System.Windows.Forms.TextBox tbSendMail;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.TextBox tbDestinationMissing;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDestinationMissing;
    }
}

