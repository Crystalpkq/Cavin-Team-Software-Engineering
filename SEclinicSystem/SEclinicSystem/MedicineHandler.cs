using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SEclinicSystem
{
    public class MedicineHandler
    {
        OverSurgerySystem run = new OverSurgerySystem();

        public DataTable checkMedicineDetails(Medicine medicine)
        {
            DataTable result = run.getLocalSQLData(@"SELECT top 1 [medicineName], [dosage], [consumption], [unlimitedPrescription], [description] FROM [Patient] a with(nolock)  where medicineID  ='" + medicine.MedicineID + "' order by patientID asc");

            if (result != null)
            {
                if (result.Rows.Count > 0)
                {
                    medicine.MedicineName = result.Rows[0]["medicineName"].ToString();                    
                    medicine.Dosage = result.Rows[0]["dosage"].ToString();
                    medicine.Consumption = result.Rows[0]["consumption"].ToString();
                    medicine.Description = result.Rows[0]["description"].ToString();
                    medicine.UnlimitedPrescription = (bool)result.Rows[0]["UnlimitedPrescription"];

                    return result;
                }
                else
                {
                    return result;
                }
            }
            else
            {
                return new DataTable();
            }
        }     


    }
}
