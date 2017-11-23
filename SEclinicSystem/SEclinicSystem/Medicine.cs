using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEclinicSystem
{
    public class Medicine
    {
        private string medicineID;
        private string medicineName;
        private string dosage;
        private string consumption;
        private bool unlimitedPrescription;
        private string description;

        public string MedicineID { get => medicineID; set => medicineID = value; }
        public string MedicineName { get => medicineName; set => medicineName = value; }
        public string Dosage { get => dosage; set => dosage = value; }
        public string Consumption { get => consumption; set => consumption = value; }
        public bool UnlimitedPrescription { get => unlimitedPrescription; set => unlimitedPrescription = value; }
        public string Description { get => description; set => description = value; }
    }
}
