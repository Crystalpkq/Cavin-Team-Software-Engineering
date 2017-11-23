using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SEclinicSystem
{
    public class PrescriptionHandler
    {
        OverSurgerySystem run = new OverSurgerySystem();

        /*
        public DataTable retrivePrescription(Prescription prescription)
        {        

            DataTable result = run.getLocalSQLData(@"select [medicineID] FROM [Prescription] a with (nolock) where prescriptionID = '%" + prescription.PrescriptionID + "%' order by prescriptionID asc");
            DataTable dt = new DataTable();
            dt.Columns.Add("MedicineID", typeof(string));
            dt.Columns.Add("MedicineName", typeof(string));
            dt.Columns.Add("Dosage", typeof(string));
            dt.Columns.Add("Comsumption", typeof(string));
            dt.Columns.Add("Description", typeof(string));

            if (result != null)
            {
                if (result.Rows.Count > 0)
                {

                    for(int i = 0; i < result.Rows.Count; i++)
                    {
                        DataTable mn = run.getLocalSQLData(@"SELECT top 1 [medicineID], [medicineName], [dosage], [comsumption], [description] FROM [Medicine] a with(nolock)  where medicineID  ='" + result.Rows[0]["medicineID"].ToString() + "' order by medicineID asc");
                        dt.Rows.Add(mn.Rows[i]["medicineID"].ToString(), mn.Rows[i]["medicineName"].ToString(), mn.Rows[i]["dosage"].ToString(), mn.Rows[i]["comsumption"].ToString(), mn.Rows[i]["description"].ToString());   
                    }

                    return result;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        */

       //extend prescription method
        public int extendPrescription(Prescription prescription)
        {
            string rrsql = "INSERT INTO [Prescription] ([appointmentID],[medicineID],[staffID],[patientID],[endDate]) VALUES ('" + prescription.Appointment.AppointmentID + "','" + prescription.Medicine.MedicineID + "','" + prescription.Staff.StaffID + "','" + prescription.Patient.PatientID + "','" + prescription.EndDate.Date + "')";
            return run.WriteData(rrsql);
        }

        //check prescription limit method for each medicine
        public bool checkPrescriptionLimit(Prescription prescription)
        {
            DataTable result = run.getLocalSQLData(@"SELECT top 1 [UnlimitedPrescription], [endDate] FROM [Medicine] a with(nolock)  where medicineID  ='" + prescription.Medicine.MedicineID + "' order by medicineID asc");

            if (result != null)
            {
                if (result.Rows.Count > 0)
                {
                    prescription.Medicine.UnlimitedPrescription = (bool)result.Rows[0]["unlimitedPrescription"];

                    if(prescription.Medicine.UnlimitedPrescription == false)
                    {
                        TimeSpan ts = (DateTime)result.Rows[0]["unlimitedPrescription"] - DateTime.Now.Date;

                        if(ts.Days <= 30)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }                        
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        // add prescription method
        public int addPrescription(Prescription prescription)
        {
            string rrsql = "INSERT INTO [Prescription] ([appointmentID],[medicineID],[staffID],[patientID],[endDate]) VALUES ('" + prescription.Appointment.AppointmentID + "','" + prescription.Medicine.MedicineID + "','" + prescription.Staff.StaffID + "','" + prescription.Patient.PatientID + "','" + prescription.EndDate.Date + "')";
            return run.WriteData(rrsql);            
        }

    }
}
