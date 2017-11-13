using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.Configuration;
using System.IO;


namespace SEclinicSystem
{
    class OverSurgerySystem
    {

        private bool login(string loginID, string password)
        {
            return true;
        }

        //retrive data
        public DataTable getLocalSQLData(string query)
        {
            try
            {

                string c = "Integrated Security=SSPI;Persist Security Info=False;Data Source=.\\SQLEXPRESS;Initial Catalog=OverSurgery;";

                using (SqlConnection conn = new SqlConnection(c))
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.CommandTimeout = 0;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    //  Log("WEB", "getLocalSQLData", "query: " + query);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Log("OverSurgery", "getLocalSQLData", "query: " + query + " ; Err :" + ex.ToString());
                //  MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            { }
        }

        //write data
        public int WriteData(string query)
        {
           
            try
            {
                string c = "Integrated Security=SSPI;Persist Security Info=False;Data Source=.\\SQLEXPRESS;Initial Catalog=OverSurgery;";

                using (SqlConnection conn = new SqlConnection(c))
                {
                    int x = 0;

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;

                    cmd.CommandTimeout = 0;

                    x = cmd.ExecuteNonQuery(); //returns row affected

                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }

                    conn.Dispose();

                    return x;
                }
            }
            catch (Exception ex)
            {
                Log("WEB", "WriteDBLog", "Err :" + ex.ToString());
                return 0;
            }
            finally
            {
            }

        }

        //write Log file
        public void Log(string filename, string functionName, string msg)
        {
            try
            {
               //filePath of the Log folder
                string filepath = "C:\\Users\\cryst\\Documents\\Cavin-Team-Software-Engineering\\SEclinicSystem\\Log";
                string logtime = DateTime.Now.ToString("yyyy_MM_dd");

                if (!Directory.Exists(filepath)) Directory.CreateDirectory(filepath);

                msg = String.Format("{0,-25}", DateTime.Now.ToString()) + " : " + String.Format("{0,-30}", functionName) + " : " + msg;

                //check log file size, generate new once reach 10mb, only if file exist
                if (File.Exists(filepath + filename + "_" + logtime + ".txt"))
                {
                    FileInfo fInfo = new FileInfo(filepath + filename + "_" + logtime + ".txt");
                    //long fSize = fInfo.Length;
                    if (fInfo.Length >= 10485760)
                    {
                        File.Move(filepath + filename + "_" + logtime + ".txt", filepath + filename + DateTime.Now.ToString("yyyy_MM_dd_hhmmss") + ".txt");
                    }
                }

                StreamWriter sw = new StreamWriter(filepath + filename + "_" + logtime + ".txt", true);
                sw.WriteLine(msg);
                // sw.WriteLine("");    //add extra line 
                sw.Flush();
                sw.Close();

                sw = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { }
        }


        private void checkAndPrintResult()
        {

        }

        private void extendPrinscription()
        {

        }
    }


}

