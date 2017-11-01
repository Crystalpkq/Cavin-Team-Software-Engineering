using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SEclinicSystem
{
    class Patient
    {
        OverSurgerySystem run;

        public string searchPatient(string patientID = "", string name = "", string dateOfBirth = "", string address = "")
        {
            if (patientID != "")
            {
                //filter with patientID
                DataTable result = run.getLocalSQLData(@"SELECT top 1 [patientID] FROM [Patient] a with(nolock)  where patientID  ='" + patientID + "' order by patientID asc");

                if (result != null)
                {
                    if (result.Rows.Count > 0)
                    {
                        return "Yes";
                    }
                    else
                    {                        
                        return "No";
                    }
                }
                else
                { 
                    return "No";
                }
            }        
            else if (name != "" && dateOfBirth != "")
            {
                //filter with name and dateOfBirth
                DataTable result = run.getLocalSQLData(@"SELECT top 1 [name], [dateOfBirth] FROM [Patient] a with(nolock)  where dateOfBirth  ='" + Convert.ToDateTime(dateOfBirth) + "' and name ='"+ name +"'order by patientID asc");

                if (result != null)
                {
                    if (result.Rows.Count > 0)
                    {
                        return "Yes";
                    }
                    else
                    {
                        return "No";
                    }
                }
                else
                {
                    return "No";
                }
            }
            else if (name != "" && address != "")
            {
                //filter with name and address
                DataTable result = run.getLocalSQLData(@"SELECT top 1 [name], [address] FROM [Patient] a with(nolock)  where address  ='" + address + "' and name ='" + name + "'order by patientID asc");

                if (result != null)
                {
                    if (result.Rows.Count > 0)
                    {
                        return "Yes";
                    }
                    else
                    {
                        return "No";
                    }
                }
                else
                {
                    return "No";
                }
            }
            else
            {
                //no result
                return "No";
            }                
            
        }

        public string getID(string name = "", string DOB = "", string address = "")
        {
            string id = "";

            if (name != "" && DOB != "")
            {
                DataTable result = run.getLocalSQLData(@"SELECT top 1 [patientID] FROM [Patient] a with(nolock)  where dateOfBirth  ='" + DOB + "' and name ='" + name + "'order by patientID asc");
                if (result != null)
                {
                    if (result.Rows.Count > 0)
                    {
                        id = result.Rows[0]["patientID"].ToString();
                        return id;
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            else if (name != "" && address != "")
            {
                DataTable result = run.getLocalSQLData(@"SELECT top 1 [patientID] FROM [Patient] a with(nolock)  where address  ='" + address + "' and name ='" + name + "'order by patientID asc");
                if (result != null)
                {
                    if (result.Rows.Count > 0)
                    {
                        id = result.Rows[0]["patientID"].ToString();
                        return id;
                    }
                    else
                    {
                        return "";
                    }
                }
            }

            return id;

        }

        public string registerPatient(string name, string NRIC, string DOB, string phoneNo, string email, string address, string gender)
        {
            string tempQuery = " INSERT INTO [Patient] ([name] ,[NRIC] ,[dateOfBirth] ,[phoneNo] ,[email] ,[address], [gender] VALUES ('" + name + "','" + NRIC + "','" + DOB + "','" + phoneNo + "','" + email + "','" + address.Replace("'", "''").Replace("/", "//") + "','" + gender + "')";

            int result = run.WriteData(tempQuery);

            if (result > 0)
            {
                DataTable r = run.getLocalSQLData(@"SELECT top 1 [PatientID] FROM [Patient] a with(nolock)  where NRIC  ='" + NRIC + "'order by patientID asc");

                if (r.Rows.Count > 0)
                {
                    string ID = r.Rows[0]["PatientID"].ToString();
                    return ID;
                }

            }
            else
            {
                return "";
            }

            return "";
        }

        private bool scheduleAppointment()
        {
            return true;
        }
         
    }
}
