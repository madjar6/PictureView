﻿using System;
using System.Collections.Generic;
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
            SqlConnection myConnection;
            
            try
            {
                myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ToString());
                myConnection.Open();
                return myConnection;
            }
            catch (Exception err)
            {
                LogErr.log(err.StackTrace + "++++++++" + err.Message, "GetSQLConnection");
                return null;
            }

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

        public List<string> LoadData()
        {
            List<string> lERP = new List<string>();

            try
            {
                using (SqlCommand cmd = GetSQLConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT distinct ItemId FROM[Analize].[dbo].[item_table]";
                    //cmd.ExecuteNonQuery();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lERP.Add(reader["ItemId"].ToString().ToUpper() + ".JPG");
                        }
                    }
                    GetSQLConnection().Close();
                }
            }
            catch(Exception err)
            {
                LogErr.log(err.StackTrace + "++++++++" + err.Message, "LoadData");
            }

            return lERP;
        }

    }

}
