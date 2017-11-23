using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEclinicSystem
{
    class Log
    {

        //write Log file
        public void writeLog(string filename, string functionName, string msg)
        {
            try
            {
                //filePath of the Log folder
                string filepath = "C:\\Users\\LENOVO\\Desktop\\ARU\\Software Engineer\\Cavin-Team-Software-Engineering\\SEclinicSystem\\log\\";
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


    }
}
