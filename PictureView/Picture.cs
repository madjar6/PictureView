//51.255.92.206
//sv_images_ftp
//Nfd59VYd4836rc9v8yj0Mo

//buzz_images_ftp
//NObf5d9f7YVxrbbu3d0

using PictureView.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PictureView
{
    public partial class PictureView : Form
    {
        public PictureView()
        {
            InitializeComponent();

            Util myFunctions = new Util();

            //kupljenje neophodnih parametara za slanje emaila
            tbMailServer.Text = myFunctions.FindBookmarkMail("MAILSERVER");
            tbMailServerPort.Text = myFunctions.FindBookmarkMail("MAILPORT");
            tbFrom.Text = myFunctions.FindBookmarkMail("MAILFROM");
            tbFromName.Text = myFunctions.FindBookmarkMail("MAILFROMNAME");
            tbTo.Text = myFunctions.FindBookmarkMail("MAILTO");
            tbSubject.Text = myFunctions.FindBookmarkMail("MAILSUBJECT");
            tbBody.Text = myFunctions.FindBookmarkMail("MAILBODY01");


            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1 && args[1].ToString().ToLower() == "sportvisionbih")
            {
                //Step01:btnScanFTP_Click
                lSource = Util.scanFTP(tbFTPIP1.Text, tbFTPUser1.Text, tbFTPPassword1.Text);
                //lSource = Util.scanFTP(lFTPIP, lFTPUser, lFTPPassword);

                //Step02:btnScanDestination_Click
                lDestination = Util.scanDestination(tbDestination.Text, "jpg");

                //Step03:btnDifference_Click
                lDiff = Util.DifferenceSourceDestination(lSource, lDestination);

                //Step04:btnERPItem_Click
                DatabaseManager dbManager = new DatabaseManager();
                lERPItem = dbManager.LoadData();
                
                //Step05:btnDifferenceERP_Click
                lFTP = Util.DifferenceERPDifference(lERPItem, lDiff);

                //Step06:btnDownloadFTP_Click
                int i = Util.DownloadFromFTP(lSource, lFTP, tbFTPUser1.Text, tbFTPPassword1.Text, tbDestinationFTP.Text);

                //Step07:btnResizePicture_Click
                int j = Util.ResizePicture(tbDestinationFTP.Text, "jpg", tbResizePicture.Text, Convert.ToInt32(tbResWidth.Text), Convert.ToInt32(tbResHeight.Text));
                int k = Util.CopyResizedPicture(tbResizePicture.Text, tbDestination.Text, "jpg");

                myToAL.Add(tbTo.Text);
                myFunctions.SendMail(tbFrom.Text, tbFromName.Text, myToAL, tbSubject.Text + " SportVision", tbBody.Text + " " + k.ToString());

                Environment.Exit(0);
            }

            if (args.Length > 1 && args[1].ToString().ToLower() == "buzz")
            {
                //Step01:btnScanFTP_Click
                lSource = Util.scanFTP(tbFTPIP.Text, tbFTPUser.Text, tbFTPPassword.Text);
                //lSource = Util.scanFTP(lFTPIP, lFTPUser, lFTPPassword);

                //Step02:btnScanDestination_Click
                lDestination = Util.scanDestination(tbDestination.Text, "jpg");
                
                //Step03:btnDifference_Click
                lDiff = Util.DifferenceSourceDestination(lSource, lDestination);
                
                //Step04:btnERPItem_Click
                DatabaseManager dbManager = new DatabaseManager();
                lERPItem = dbManager.LoadData();
                
                //Step05:btnDifferenceERP_Click
                lFTP = Util.DifferenceERPDifference(lERPItem, lDiff);
                
                //Step06:btnDownloadFTP_Click
                int i = Util.DownloadFromFTP(lSource, lFTP, tbFTPUser.Text, tbFTPPassword.Text, tbDestinationFTP.Text);
                
                //Step07:btnResizePicture_Click
                int j = Util.ResizePicture(tbDestinationFTP.Text, "jpg", tbResizePicture.Text, Convert.ToInt32(tbResWidth.Text), Convert.ToInt32(tbResHeight.Text));
                int k = Util.CopyResizedPicture(tbResizePicture.Text, tbDestination.Text, "jpg");

                myToAL.Add(tbTo.Text);
                myFunctions.SendMail(tbFrom.Text, tbFromName.Text, myToAL, tbSubject.Text + " BUZZ", tbBody.Text + " " + k.ToString());

                Environment.Exit(0);
            }
        }

        public int Count = 0;
        List<string> lDestination = new List<string>();
        List<Tuple<string, string>> lSource = new List<Tuple<string, string>>();
        List<string> lDiff = new List<string>();
        List<string> lERPItem = new List<string>();
        List<string> lFTP = new List<string>();
        List<string> lFTPDownload = new List<string>();
        List<string> lMissingPicture = new List<string>();
        List<string> lCopyPicture = new List<string>();
        String lFTPIP;
        String lFTPUser;
        String lFTPPassword;
        ArrayList myToAL = new ArrayList();

        private void btnSource_Click(object sender, EventArgs e)
        {
            DialogResult result = fbSource.ShowDialog();

            if (result == DialogResult.OK)
            {
                tbFolder.Text = fbSource.SelectedPath;
            }
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            if (tbFolder.Text == string.Empty)
            {
                MessageBox.Show("Folder is empty");
                return;
            }

            tbNotes.Text = "In progress...";
            tbNotes.Refresh();
            lvResults.Clear();

            var di = new DirectoryInfo(tbFolder.Text);
            var extensionCounts = di.EnumerateFiles("*.*", SearchOption.AllDirectories)
                                    .GroupBy(x => x.Extension)
                                    .Select(g => new { Extension = g.Key, Count = g.Count() })
                                    .ToList();

            lvResults.View = View.Details;
            lvResults.Columns.Add("Ext");
            lvResults.Columns.Add("Count");
            lvResults.FullRowSelect = true;

            foreach (var group in extensionCounts)
            {
                ListViewItem item = new ListViewItem(group.Extension);
                item.SubItems.Add(group.Count.ToString());

                lvResults.Items.Add(item);
            }
            tbNotes.Text = "End";
            tbNotes.Refresh();
        }

        private void btnSourceFile_Click(object sender, EventArgs e)
        {
            DialogResult result = fdSource.ShowDialog();


            if (result == DialogResult.OK)
            {
                tbFile.Text = fdSource.FileName;
            }
        }

        private void btnSaveToDatabae_Click(object sender, EventArgs e)
        {
            int Count = 0;
            DatabaseManager dbManager = new DatabaseManager();
            DirectoryInfo d = new DirectoryInfo(tbFolder.Text);
            FileInfo[] Files = d.GetFiles("*.jpg");
            foreach (FileInfo file in Files)
            {
                Image img = Image.FromFile(file.FullName);

                dbManager.SaveData(file.Name, file.DirectoryName, img.Width + "x" + img.Height);
                Count += 1;
                tbCount.Text = Count.ToString();
                tbCount.Refresh();
            }
            tbNotes.Text = "Inserted in DB";
            tbNotes.Refresh();
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            DialogResult result = fbSource.ShowDialog();


            if (result == DialogResult.OK)
            {
                tbResults.Text = fbSource.SelectedPath;
            }
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            DialogResult result = fbSource.ShowDialog();


            if (result == DialogResult.OK)
            {
                tbDestination.Text = fbSource.SelectedPath;
            }
        }

        private void btnScanDestination_Click(object sender, EventArgs e)
        {
            SetNotes("Started Scan Destination");

            lDestination = Util.scanDestination(tbDestination.Text, "jpg");

            tbCountDestination.Text = lDestination.Count.ToString();

            SetNotes("Scan Destination END");
        }

        private void btnScanFTP_Click(object sender, EventArgs e)
        {
            if(rbBUZZ.Checked == false && rbSV.Checked == false)
            {
                MessageBox.Show("You must check FTP");
                return;
            }

            if (rbBUZZ.Checked == true)
            {
                if (tbFTPIP.Text == string.Empty || tbFTPUser.Text == string.Empty || tbFTPPassword.Text == string.Empty)
                {
                    MessageBox.Show("You must enter parameter for connection to BUZZ FTP");
                    return;
                }
            }
            else if (rbSV.Checked == true)
            {
                if (tbFTPIP1.Text == string.Empty || tbFTPUser1.Text == string.Empty || tbFTPPassword1.Text == string.Empty)
                {
                    MessageBox.Show("You must enter parameter for connection to SportVision FTP");
                    return;
                }
            }

            SetNotes("Started Scan FTP");

            lSource = Util.scanFTP(lFTPIP, lFTPUser, lFTPPassword);

            tbCountFTP.Text = lSource.Count.ToString();

            SetNotes("Scan FTP END");
        }

        private void btnDifference_Click(object sender, EventArgs e)
        {
            SetNotes("Started Difference FTP-Dest ");

            lDiff = Util.DifferenceSourceDestination(lSource, lDestination);

            tbCountDifference.Text = lDiff.Count.ToString();

            SetNotes("Difference FTP-Dest END");
        }

        private void btnERPItem_Click(object sender, EventArgs e)
        {
            SetNotes("Started ERP Item");

            DatabaseManager dbManager = new DatabaseManager();
            lERPItem = dbManager.LoadData();
            tbCountERPItem.Text = lERPItem.Count.ToString();

            SetNotes("ERP Item END");
        }

        private void btnDifferenceERP_Click(object sender, EventArgs e)
        {
            SetNotes("Started Difference ERP");

            lFTP = Util.DifferenceERPDifference(lERPItem, lDiff);

            tbCountFromFTP.Text = lFTP.Count.ToString();

            SetNotes("Difference ERP END");
        }

        //obrisati postojeće slike u ovom katalogu
        private void btnDownloadFTP_Click(object sender, EventArgs e)
        {
            SetNotes("Started Download FTP");

            tbCountDownloadFromFTP.Text = Util.DownloadFromFTP(lSource, lFTP, lFTPUser, lFTPPassword, tbDestinationFTP.Text).ToString();

            SetNotes("Download FTP END");
        }

        private void btnFTP_Click(object sender, EventArgs e)
        {
            DialogResult result = fbSource.ShowDialog();

            if (result == DialogResult.OK)
            {
                tbDestinationFTP.Text = fbSource.SelectedPath;
            }
        }

        private void btnResizedPicture_Click(object sender, EventArgs e)
        {
            DialogResult result = fbSource.ShowDialog();


            if (result == DialogResult.OK)
            {
                tbResizePicture.Text = fbSource.SelectedPath;
            }
        }

        //obrisati postojeće slike u ovom katalogu
        private void btnResizePicture_Click(object sender, EventArgs e)
        {
            SetNotes("Started Resize picture");

            tbCountResizedPicture.Text = Util.ResizePicture(tbDestinationFTP.Text, "jpg", tbResizePicture.Text, Convert.ToInt32(tbResWidth.Text), Convert.ToInt32(tbResHeight.Text)).ToString();

            SetNotes("Resize picture END");
        }

        private void btnMissingPicture_Click(object sender, EventArgs e)
        {
            tbNotesSynchronization.Text = "Started";
            tbNotesSynchronization.Refresh();

            lMissingPicture = lERPItem.Except(lDestination).ToList();
            File.WriteAllLines("C:\\Temp\\Test1234.txt", lMissingPicture);

            tbCountMissingPicture.Text = lMissingPicture.Count.ToString();

            tbNotesSynchronization.Text = "END";
            tbNotesSynchronization.Refresh();
        }

        private void rbBUZZ_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBUZZ.Checked)
            {
                    lFTPIP = tbFTPIP.Text;
                    lFTPUser = tbFTPUser.Text;
                    lFTPPassword = tbFTPPassword.Text;
            }
        }

        private void rbSV_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSV.Checked)
            {
                lFTPIP = tbFTPIP1.Text;
                lFTPUser = tbFTPUser1.Text;
                lFTPPassword = tbFTPPassword1.Text;
            }
        }

        private void btnCopyResizedPicture_Click(object sender, EventArgs e)
        {
            SetNotes("Started Copy picture");

            tbCountCopyResizedPicture.Text = Util.CopyResizedPicture(tbResizePicture.Text, tbDestination.Text, "jpg").ToString();

            SetNotes("Copy picture END");
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            Util myFunct = new Util();
            ArrayList myToAL = new ArrayList();
            String mailTo;

            try
            {
                mailTo = tbTo.Text;
                string[] clan1 = mailTo.Split(new char[] { ';' });

                foreach (string clan in clan1)
                {
                    if (clan != string.Empty)
                    {
                        myToAL.Add(clan);
                    }
                }

                myFunct.SendMail(tbFrom.Text, tbFromName.Text, myToAL, tbSubject.Text, tbBody.Text);
                tbSendMail.Text = "Poslat mail.";
            }
            catch (Exception err)
            {
                LogErr.log(err.StackTrace + "++++++++" + err.Message, "btnSendMail_Click");
            }
        }

        private void tcMail_Selecting(object sender, TabControlCancelEventArgs e)
        {
            tbBody.Text += tbCountCopyResizedPicture.Text;
        }

        private void SetNotes(string Text)
        {
            if (Text != string.Empty)
            {
                tbNotesSynchronization.Text = Text;
                tbNotesSynchronization.Refresh();
            }
        }
    }
}
