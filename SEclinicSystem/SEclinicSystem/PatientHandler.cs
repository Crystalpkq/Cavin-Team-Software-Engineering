using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SEclinicSystem
{
    public class PatientHandler
    {
        public string searchPatient(Patient patient)
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
            else if (name != "" && dob != new DateTime())
            {
                //filter with name and dateOfBirth
                DataTable result = run.getLocalSQLData(@"SELECT top 1 [name], [dateOfBirth] FROM [Patient] a with(nolock)  where dateOfBirth  ='" + dob.Date.ToString() + "' and name ='" + name + "'order by patientID asc");

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
                DataTable result = run.getLocalSQLData(@"SELECT top 1 [name], [address] FROM [Patient] a with(nolock)  where address like '%" + address + "%' and name ='" + name + "'order by patientID asc");

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

        public void setID(string id = "", string name = "", DateTime DOB = new DateTime(), string address = "")
        {
            if (id != "")
            {
                GetPatientID = id;
            }
            else if (name != "" && DOB != new DateTime())
            {
                DataTable result = run.getLocalSQLData(@"SELECT top 1 [patientID] FROM [Patient] a with(nolock)  where dateOfBirth  ='" + DOB + "' and name ='" + name + "'order by patientID asc");
                if (result != null)
                {
                    if (result.Rows.Count > 0)
                    {
                        GetPatientID = result.Rows[0]["patientID"].ToString();
                    }
                }
            }
            else if (name != "" && address != "")
            {
                DataTable result = run.getLocalSQLData(@"SELECT top 1 [patientID] FROM [Patient] a with(nolock)  where address like '%" + address + "%' and name ='" + name + "'order by patientID asc");
                if (result != null)
                {
                    if (result.Rows.Count > 0)
                    {
                        GetPatientID = result.Rows[0]["patientID"].ToString();
                    }
                }
            }

        }

        public string getID()
        {
            return this.GetPatientID;
        }

        public string registerPatient(string name, string NRIC, DateTime DOB, string phoneNo, string email, string address, string gender)
        {
            string ID = "";
            string tempQuery = " INSERT INTO [Patient] ([name] ,[NRIC] ,[dateOfBirth] ,[phoneNo] ,[email] ,[address], [gender]) VALUES ('" + name + "','" + NRIC + "','" + DOB + "','" + phoneNo + "','" + email + "','" + address.Replace("'", "''").Replace("/", "//") + "','" + gender + "')";

            int result = run.WriteData(tempQuery);

            if (result > 0)
            {
                DataTable r = run.getLocalSQLData(@"SELECT top 1 [PatientID] FROM [Patient] a with(nolock)  where NRIC  ='" + NRIC + "'order by patientID asc");

                if (r.Rows.Count > 0)
                {
                    ID = r.Rows[0]["PatientID"].ToString();
                    return ID;
                }

            }
            else
            {
                return ID;
            }

            return ID;
        }

        public string updatePatientDetails(string ID, string name, string NRIC, DateTime DOB, string phoneNo, string email, string address, string gender)
        {
            string status = "N";
            string tempQuery = " INSERT INTO [Patient] ([name] ,[NRIC] ,[dateOfBirth] ,[phoneNo] ,[email] ,[address], [gender]) VALUES ('" + name + "','" + NRIC + "','" + DOB + "','" + phoneNo + "','" + email + "','" + address.Replace("'", "''").Replace("/", "//") + "','" + gender + "' where patientId ='" + ID + "')";

            int result = run.WriteData(tempQuery);

            if (result > 0)
            {
                return status = "Y";
            }
            else
            {
                return status;
            }

        }

    }
}
