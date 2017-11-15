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
        private string patientID;
        private string name;
        private DateTime dob;
        private string address;
        private string nric;
        private string phoneNo;
        private string email;
        private string gender;

        public string PatientID { get => patientID; set => patientID = value; }
        public string Name { get => name; set => name = value; }
        public DateTime DOB { get => dob; set => dob = value; }
        public string Address { get => address; set => address = value; }
        public string NRIC { get => nric; set => nric = value; }
        public string PhoneNo { get => phoneNo; set => phoneNo = value; }
        public string Email { get => email; set => email = value; }
        public string Gender { get => gender; set => gender = value; }
    }
}
