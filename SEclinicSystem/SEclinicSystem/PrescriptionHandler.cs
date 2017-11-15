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

        public void retrivePrescription(Prescription prescription)
        {          

            DataTable result = run.getLocalSQLData(@"SELECT top 1 [appointmentID], [medicineID], [staffID], [patientID], [endDate] FROM [Prescription] a with(nolock)  where precriptionID  ='" + prescription.PrescriptionID + "' order by prescriptionID asc");

            if (result != null)
            {
                if (result.Rows.Count > 0)
                {
                    prescription.Appointment.AppointmentID = result.Rows[0]["appointmentID"].ToString();

                    DataTable dt = run.getLocalSQLData(@"SELECT top 1 [dateTime] FROM [Appointment] a with(nolock)  where appointmentID  ='" + prescription.Appointment.AppointmentID + "' order by appointmentID asc");

                    if(dt != null)
                    {
                        if (result.Rows.Count > 0)
                        {
                            prescription.Appointment.DateTime = (DateTime)result.Rows[0]["dateTime"];
                        }
                    }
                    
                    result.Columns.Add("medicineName", typeof(string)).SetOrdinal(2);

                    
                    foreach (DataRow row in result.Rows)
                    {
                        DataTable mn = run.getLocalSQLData(@"SELECT top 1 [medicineName] FROM [Medicine] a with(nolock)  where medicineID  ='" + row["medicineID"] + "' order by medicineID asc");
                        row["medicineName"] = mn.Rows[0]["medicineName"];   
                    }
                }
            }
        }

        public void extendPrescription(Prescription prescription)
        {
            MedicineHandler mh = new MedicineHandler();

            bool result = mh.checkPrescriptionLimit(prescription.Medicine);

            if(result == true)
            {
                
            }
            else if(result == false)
            {

            }
        }

        public void addPrescription(Prescription prescription)
        {
            DataTable result = run.getLocalSQLData(@"SELECT top 1 [appointmentID], [medicineID], [staffID], [patientID], [endDate] FROM [Prescription] a with(nolock)  where precriptionID  ='" + prescription.PrescriptionID + "' order by prescriptionID asc");

            if (result != null)
            {
                if (result.Rows.Count > 0)
                {
                    prescription.Appointment.AppointmentID = result.Rows[0]["appointmentID"].ToString();

                    DataTable dt = run.getLocalSQLData(@"SELECT top 1 [dateTime] FROM [Appointment] a with(nolock)  where appointmentID  ='" + prescription.Appointment.AppointmentID + "' order by appointmentID asc");

                    if (dt != null)
                    {
                        if (result.Rows.Count > 0)
                        {
                            prescription.Appointment.DateTime = (DateTime)result.Rows[0]["dateTime"];
                        }
                    }

                    result.Columns.Add("medicineName", typeof(string)).SetOrdinal(2);


                    foreach (DataRow row in result.Rows)
                    {
                        DataTable mn = run.getLocalSQLData(@"SELECT top 1 [medicineName] FROM [Medicine] a with(nolock)  where medicineID  ='" + row["medicineID"] + "' order by medicineID asc");
                        row["medicineName"] = mn.Rows[0]["medicineName"];
                    }
                }
            }
        }

    }
}
