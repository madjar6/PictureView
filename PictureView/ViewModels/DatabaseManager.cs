using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PictureView.ViewModels
{
    public class DatabaseManager
    {
        public DatabaseManager()
        { }

        public SqlConnection GetSQLConnection()
        {
            //LogError logErr = new LogError();

            SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ToString());
            //SqlConnection myConnection = new SqlConnection("Server = localhost\\SQLEXPRESS; Database = Working; Trusted_Connection = True;");
            //MessageBox.Show(ConfigurationManager.ConnectionStrings["Connection"].ToString());

            try
            {
                myConnection.Open();
                //MessageBox.Show("DB is opened");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error in application. Please view log file.");
                //System.Windows.MessageBox.Show("Error in application. Please view log file.");
                //logErr.LogErrorToFile(err.StackTrace + "++++++++" + err.Message, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }

            return myConnection;
        }

        public void SaveData(string pName, string pPath, string pResolution)
        {
            using (SqlCommand cmd = GetSQLConnection().CreateCommand())
            {
                //cmd.CommandText = "Insert into PICTURE (Name) Values ('" + pName + "')";
                cmd.CommandText = "Insert into PICTURE (Name, Path, TimeStampInsert, Resolution) Values (@Name, @Path, @TimeStampInsert, @Resolution)";
                cmd.Parameters.AddWithValue("@Name", pName);
                cmd.Parameters.AddWithValue("@Path", pPath);
                cmd.Parameters.AddWithValue("@TimeStampInsert", DateTime.Now.ToString());
                cmd.Parameters.AddWithValue("@Resolution", pResolution);
                //cmd.Parameters.AddWithValue("TimeStampRead", pTimeStamp.ToString("dd/MM/yyyy HH:mm:ss"));

                cmd.ExecuteNonQuery();
                GetSQLConnection().Close();
            }
        }
    }

}
