using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEclinicSystem
{
    public class Prescription
    {        
        private string prescriptionID;
        private Appointment appointment;
        private Medicine medicine;
        private GeneralPractitioner staff;
        private Patient patient;
        
        public string PrescriptionID { get => prescriptionID; set => prescriptionID = value; }
        public Medicine Medicine { get => medicine; set => medicine = value; }
        public Patient Patient { get => patient; set => patient = value; }
        internal Appointment Appointment { get => appointment; set => appointment = value; }
        internal GeneralPractitioner Staff { get => staff; set => staff = value; }
    }

    
}
