using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace PictureView.ViewModels
{
    public class Util
    {
       public static LogErr mylog = new LogErr();

        #region Resize image

        public static void SaveImage(string imagePath, string savedName, string savedPath, int width = 0, int height = 0)
        {
            Image originalImage = Image.FromFile(imagePath);
            string filePath = savedPath + "\\" + savedName;

            if (width > 0 && height > 0)
            {
                Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                Image imageToSave = originalImage.GetThumbnailImage(width, height, myCallback, IntPtr.Zero);
                imageToSave.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            else
            {
                originalImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private static bool ThumbnailCallback() { return false; }

#endregion

#region Scan FTP
        public static List<Tuple<string, string>> scanFTP(String FtpUri, String User, String Pass)
        {
            List<Tuple<string, string>> lScanFTP = new List<Tuple<string, string>>();

            if (FtpUri == string.Empty || User == string.Empty || Pass == string.Empty)
            {
                MessageBox.Show("You must enter parameter for connection on FTP");
                return lScanFTP;
            }

            try
            {
                Queue<String> folders = new Queue<String>();
                folders.Enqueue("ftp://" + FtpUri + "/");

                while (folders.Count > 0)
                {
                    String fld = folders.Dequeue();
                    List<String> newFiles = new List<String>();

                    FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(fld);
                    ftp.Credentials = new NetworkCredential(User, Pass);
                    ftp.UsePassive = false;
                    ftp.Method = WebRequestMethods.Ftp.ListDirectory;
                    using (StreamReader resp = new StreamReader(ftp.GetResponse().GetResponseStream()))
                    {
                        String line = resp.ReadLine();
                        while (line != null)
                        {
                            newFiles.Add(line.Trim());
                            line = resp.ReadLine();
                        }
                    }

                    ftp = (FtpWebRequest)FtpWebRequest.Create(fld);
                    ftp.Credentials = new NetworkCredential(User, Pass);
                    ftp.UsePassive = false;
                    ftp.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                    using (StreamReader resp = new StreamReader(ftp.GetResponse().GetResponseStream()))
                    {
                        String line = resp.ReadLine();
                        while (line != null)
                        {
                            if (line.Trim().ToLower().StartsWith("d") || line.Contains(" <DIR> "))
                            {
                                String dir = newFiles.First(x => line.EndsWith(x));
                                newFiles.Remove(dir);
                                folders.Enqueue(fld + dir + "/");
                            }
                            line = resp.ReadLine();
                        }
                    }

                    for (int j = 0; j < newFiles.Count; j++)
                    {
                        lScanFTP.Add(new Tuple<string, string>(newFiles[j], fld + newFiles[j]));
                    }
                }
            }

            catch(Exception err)
            {
                LogErr.log(err.StackTrace + "++++++++" + err.Message, "scanFTP");
            }

            return lScanFTP;
        }
#endregion

#region Scan Destination
        public static List<string> scanDestination(string Path, string Extension)
        {
            List<string> lScanDestination = new List<string>();

            if (Path == string.Empty)
            {
                MessageBox.Show("Destination folder is empty.");
                return lScanDestination;
            }

            if (!Directory.Exists(Path))
            {
                MessageBox.Show("Destination doesn't exists");
                return lScanDestination;
            }

            try
            {
                DirectoryInfo d = new DirectoryInfo(Path);
                FileInfo[] Files = d.GetFiles("*." + Extension);
                foreach (FileInfo file in Files)
                {
                    lScanDestination.Add(file.Name);
                }
            }
            catch(Exception err)
            {
                LogErr.log(err.StackTrace + "++++++++" + err.Message, "scanDestination");
            }

            return lScanDestination;
        }
#endregion

#region Difference Source<->Destination
        public static List<string> DifferenceSourceDestination(List<Tuple<string, string>> Source, List<string> Destination)
        {
            if (Source.Count() == 0)
            {
                MessageBox.Show("Source folder is empty.");
                return null;
            }

            try
            {
                return Source.Select(t => t.Item1).Except(Destination).ToList();
            }
            catch(Exception err)
            {
                LogErr.log(err.StackTrace + "++++++++" + err.Message, "DifferenceSourceDestination");
                return null;
            }
            
        }
        #endregion

#region Difference ERP<->Difference
        public static List<string> DifferenceERPDifference(List<string> ERP, List<string> Difference)
        {
            try
            {
                return ERP.Intersect(Difference).ToList();
            }
            catch(Exception err)
            {
                LogErr.log(err.StackTrace + "++++++++" + err.Message, "DifferenceERPDifference");
                return null;
            }
        }

#endregion

#region Download from FTP
        public static int DownloadFromFTP(List<Tuple<string, string>> Source, List<string> Difference, String User, String Pass, String Path)
        {
            int Count = 0;

            if (Path == string.Empty)
            {
                MessageBox.Show("Destination FTP is empty");
                return 0;
            }

            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }


            if (User == string.Empty || Pass == string.Empty)
            {
                MessageBox.Show("Incorrect FTP connection parameter");
                return 0;
            }

            if (Source.Count == 0)
            {
                return 0;
            }

            try
            {
                Array.ForEach(Directory.GetFiles(Path), File.Delete);

                var query = Source.Where(t => Difference.Contains(t.Item1));

                using (WebClient ftpClient = new WebClient())
                {
                    ftpClient.Credentials = new NetworkCredential(User, Pass);

                    foreach (var element in query)
                    {
                        //MessageBox.Show(element.Item2);
                        //MessageBox.Show(Path + "\\" + element.Item1);

                        ftpClient.DownloadFile(element.Item2, Path + "\\" + element.Item1);
                        Count += 1;
                    }
                }

                return Count;
            }
            catch(Exception err)
            {
                LogErr.log(err.StackTrace + "++++++++" + err.Message, "DownloadFromFTP");
                return -1;
            }

        }
#endregion

#region Resize picture
        public static int ResizePicture(String PathPicture, String Extension, String PathResize, int Width, int Height)
        {
            int Count = 0;

            if (PathResize == string.Empty)
            {
                MessageBox.Show("Resized picture is empty");
                return 0;
            }

            if (!Directory.Exists(PathResize))
            {
                MessageBox.Show("Resized picture folder doesn't exists");
                return 0;
            }

            if (PathPicture == string.Empty)
            {
                MessageBox.Show("Destination FTP is empty");
                return 0;
            }

            if (!Directory.Exists(PathPicture))
            {
                MessageBox.Show("Destination FTP folder doesn't exists");
            }

            if (Width == null || Width == 0 || Height == null || Height == 0)
            {
                MessageBox.Show("Invalid resolution");
                return 0;
            }

            try
            {
                Array.ForEach(Directory.GetFiles(PathResize), File.Delete);

                DirectoryInfo d1 = new DirectoryInfo(PathPicture);
                FileInfo[] Files = d1.GetFiles("*." + Extension);
                foreach (FileInfo file in Files)
                {
                    Util.SaveImage(file.FullName, file.Name, PathResize, Width, Height);
                    Count += 1;
                }

                return Count;
            }
            catch(Exception err)
            {
                LogErr.log(err.StackTrace + "++++++++" + err.Message, "ResizePicture");
                return 0;
            }

        }
#endregion

#region Copy resized picture
        public static int CopyResizedPicture(String Source, String Destination, String Extension)
        {
            int Count = 0;

            try
            {
                DirectoryInfo d1 = new DirectoryInfo(Source);
                FileInfo[] Files = d1.GetFiles("*." + Extension);

                foreach (FileInfo file in Files)
                {
                    File.Copy(file.FullName, Destination + "\\" + file.Name, true);
                    Count += 1;
                }
                return Count;
            }
            catch(Exception err)
            {
                LogErr.log(err.StackTrace + "++++++++" + err.Message, "CopyResizedPicture");
                return 0;
            }
        }
#endregion

#region Find bookmark from .ini file        
        public string FindBookmarkMail(string Parametar)
        {
            string[] bookmark;
            string uslov;
            string rezultat = "";

            try
            {
                bookmark = File.ReadAllLines(Application.StartupPath + "\\" + "MailSettings.ini");

                foreach (var onebookmark in bookmark)
                {
                    if (onebookmark.StartsWith(uslov = Parametar + "="))
                    {
                        rezultat = onebookmark.Substring(uslov.Length, onebookmark.Length - uslov.Length);
                    }
                }
            }
            catch (Exception err)
            {
                LogErr.log(err.StackTrace + "++++++++" + err.Message, "FindBookmarkMail");
                //throw;
            }
            return rezultat;
        }
        #endregion

        #region Send mail
        //metoda koja vrši slanje email poruke
        public void SendMail(string from, string fromName, ArrayList to, string subject, string messageBody)
        {
            SmtpClient emailClient;
            try
            {
                emailClient = new SmtpClient(FindBookmarkMail("MAILSERVER"));
                emailClient.Port = Convert.ToInt32(FindBookmarkMail("MAILPORT"));

                // Prepare the MailMessage contents
                MailMessage message = new MailMessage();
                message.Subject = subject;
                message.Body = messageBody;

                MailAddress fromAddress = new MailAddress(from, fromName);
                message.From = fromAddress;

                // Set the receivers' addresses
                foreach (string address in to)
                    message.To.Add(new MailAddress(address));

                // set the encoding for the message body
                //message.BodyEncoding = System.Text.Encoding.UTF8;
                //message.SubjectEncoding = System.Text.Encoding.UTF8;

                emailClient.Credentials = new System.Net.NetworkCredential(FindBookmarkMail("MAILUSER"), FindBookmarkMail("MAILPASSWORD"));
                emailClient.Send(message);

            }
            catch (Exception err)
            {
                LogErr.log(err.StackTrace + "++++++++" + err.Message, "SendMail");
                //throw;
            }
        }//SendMail
#endregion


    }
}
