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
                    lScanFTP.Add(new Tuple<string, string>(newFiles[j].ToUpper(), fld + newFiles[j].ToUpper()));
                }
            }
            return lScanFTP;
        }
#endregion

#region Scan Destination
        public static List<string> scanDestination(string Path, string Extension)
        {
            List<string> lScanDestination = new List<string>();

            DirectoryInfo d = new DirectoryInfo(Path);
            FileInfo[] Files = d.GetFiles("*." + Extension);
            foreach (FileInfo file in Files)
            {
                lScanDestination.Add(file.Name.ToUpper());
            }

            return lScanDestination;
        }
#endregion

#region Difference Source<->Destination
        public static List<string> DifferenceSourceDestination(List<Tuple<string, string>> Source, List<string> Destination)
        {
            return Source.Select(t => t.Item1).Except(Destination).ToList();
        }
        #endregion

#region Difference ERP<->Difference
        public static List<string> DifferenceERPDifference(List<string> ERP, List<string> Difference)
        {
            return ERP.Intersect(Difference).ToList();
        }

#endregion

#region Download from FTP
        public static int DownloadFromFTP(List<Tuple<string, string>> Source, List<string> Difference, String User, String Pass, String Path)
        {
            var query = Source.Where(t => Difference.Contains(t.Item1));

            int Count = 0;
            using (WebClient ftpClient = new WebClient())
            {
                ftpClient.Credentials = new NetworkCredential(User, Pass);

                foreach (var element in query)
                {
                    ftpClient.DownloadFile(element.Item2, Path + "\\" + element.Item1);
                    Count += 1;
                }
            }

            return Count;

        }
#endregion

#region Resize picture
        public static int ResizePicture(String PathPicture, String Extension, String PathResize, int Width, int Height)
        {
            int Count = 0;

            DirectoryInfo d1 = new DirectoryInfo(PathPicture);
            FileInfo[] Files = d1.GetFiles("*." + Extension);
            foreach (FileInfo file in Files)
            {
                Util.SaveImage(file.FullName, file.Name, PathResize, Width, Height);
                Count += 1;
            }

            return Count;
        }
        #endregion

#region Copy resized picture
        public static int CopyResizedPicture(String Source, String Destination, String Extension)
        {
            int Count = 0;

            DirectoryInfo d1 = new DirectoryInfo(Source);
            FileInfo[] Files = d1.GetFiles("*." + Extension);

            foreach (FileInfo file in Files)
            {
                File.Copy(file.FullName, Destination + "\\" + file.Name, true);
                Count += 1;
            }
            return Count;
        }
        #endregion

        //metoda koja iz MailSettings.ini fajla čita parametre neophodne za slanje maila
        public string FindBookmarkMail(string Parametar)
        {
            LogErr mylog = new LogErr();
            string[] bookmark = File.ReadAllLines(Application.StartupPath + "\\" + "MailSettings.ini");
            string uslov;
            string rezultat = "";

            try
            {
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
                mylog.log(err.StackTrace + "++++++++" + err.Message, "FindBookmarkMail");
                //throw;
            }
            return rezultat;
        }//FindBookmarkMail

        //metoda koja vrši slanje email poruke
        public void SendMail(string from, string fromName, ArrayList to, string subject, string messageBody)
        {
            SmtpClient emailClient;
            LogErr mylog = new LogErr();
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

                //emailClient.Credentials = new System.Net.NetworkCredential("no-reply@sportvision.ba", "no-reply");
                emailClient.Credentials = new System.Net.NetworkCredential(FindBookmarkMail("MAILUSER"), FindBookmarkMail("MAILPASSWORD"));
                emailClient.Send(message);
                //MessageBox.Show("Poslato");

            }
            catch (Exception err)
            {
                mylog.log(err.StackTrace + "++++++++" + err.Message, "SendMail");
                //throw;
            }
        }//SendMail


    }
}
