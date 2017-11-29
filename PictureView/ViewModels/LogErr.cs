using System;
using System.IO;
using System.Windows.Forms;

namespace PictureView.ViewModels
{
    public class LogErr
    {
        public LogErr()
        {
        }

        //Procedura koja vrši upis greške u .err fajl
        public static void log(string greska, string proces)
        {
            DateTime VarDatumVrijeme = DateTime.Now;
            string dDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\" + "PictureView.err", true);
            sw.WriteLine("***Greska u procesu: " + proces + " " + VarDatumVrijeme);
            sw.WriteLine("***" + greska);
            sw.WriteLine("------------------------------------------------------------------------");
            sw.Close();
        }
    }
}
