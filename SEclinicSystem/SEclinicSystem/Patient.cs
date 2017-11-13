using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SEclinicSystem
{
    public class Patient
    {
        OverSurgerySystem run = new OverSurgerySystem();
        string patientID;
        string name;
        DateTime dob;
        string address;

        public string PatientID { get => patientID; set => patientID = value; }
        public string Name { get => name; set => name = value; }
        public DateTime DOB { get => dob; set => dob = value; }
        public string Address { get => address; set => address = value; }        
         
    }
}
