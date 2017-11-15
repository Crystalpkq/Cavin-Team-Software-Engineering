using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SEclinicSystem
{
    class PatientHandler
    {
        OverSurgerySystem run = new OverSurgerySystem();

        public string searchPatient(Patient patient)
        {
            if (patient.PatientID != "")
            {
                //filter with patientID
                DataTable result = run.getLocalSQLData(@"SELECT top 1 [patientID] FROM [Patient] a with(nolock)  where patientID  ='" + patient.PatientID + "' order by patientID asc");

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
            else if (patient.Name != "" && patient.DOB != new DateTime())
            {
                //filter with name and dateOfBirth
                DataTable result = run.getLocalSQLData(@"SELECT top 1 [name], [dateOfBirth] FROM [Patient] a with(nolock)  where dateOfBirth  ='" + patient.DOB.Date.ToString() + "' and name ='" + patient.Name + "'order by patientID asc");

                if (result != null)
                {
                    if (result.Rows.Count > 0)
                    {
                        patient.PatientID = result.Rows[0]["patientID"].ToString();
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
            else if (patient.Name != "" && patient.Address != "")
            {
                //filter with name and address
                DataTable result = run.getLocalSQLData(@"SELECT top 1 [name], [address] FROM [Patient] a with(nolock)  where address like '%" + patient.Address + "%' and name ='" + patient.Name + "'order by patientID asc");

                if (result != null)
                {
                    if (result.Rows.Count > 0)
                    {
                        patient.PatientID = result.Rows[0]["patientID"].ToString();
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

        public void generateID(Patient patient)
        {
            if (patient.Name != "" && patient.DOB != new DateTime())
            {
                DataTable result = run.getLocalSQLData(@"SELECT top 1 [patientID] FROM [Patient] a with(nolock)  where dateOfBirth  ='" + patient.DOB + "' and name ='" + patient.Name + "'order by patientID asc");
                if (result != null)
                {
                    if (result.Rows.Count > 0)
                    {
                        patient.PatientID = result.Rows[0]["patientID"].ToString();
                    }
                }
            }
            else if (patient.Name != "" && patient.Address != "")
            {
                DataTable result = run.getLocalSQLData(@"SELECT top 1 [patientID] FROM [Patient] a with(nolock)  where address like '%" + patient.Address + "%' and name ='" + patient.Name + "'order by patientID asc");
                if (result != null)
                {
                    if (result.Rows.Count > 0)
                    {
                        patient.PatientID = result.Rows[0]["patientID"].ToString();
                    }
                }
            }

        }
        
        public string registerPatient(Patient patient)
        {            
            string ID = "";
            string tempQuery = " INSERT INTO [Patient] ([name] ,[NRIC] ,[dateOfBirth] ,[phoneNo] ,[email] ,[address], [gender]) VALUES ('" + patient.Name + "','" + patient.NRIC + "','" + patient.DOB.ToString() + "','" + patient.PhoneNo + "','" + patient.Email + "','" + patient.Address.Replace("'", "''").Replace("/", "//") + "','" + patient.Gender + "')";

            int result = run.WriteData(tempQuery);

            if (result > 0)
            {
                DataTable r = run.getLocalSQLData(@"SELECT top 1 [PatientID] FROM [Patient] a with(nolock)  where NRIC  ='" + patient.NRIC + "'order by patientID asc");

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

        public string updatePatientDetails(Patient patient)
        {
            string status = "N";
            string tempQuery = " INSERT INTO [Patient] ([name] ,[NRIC] ,[dateOfBirth] ,[phoneNo] ,[email] ,[address], [gender]) VALUES ('" + patient.Name + "','" + patient.NRIC + "','" + patient.DOB.ToString() + "','" + patient.PhoneNo + "','" + patient.Email + "','" + patient.Address.Replace("'", "''").Replace("/", "//") + "','" + patient.Gender + "' where patientId ='" + patient.PatientID + "')";

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
