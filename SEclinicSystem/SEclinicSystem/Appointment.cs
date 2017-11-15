using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEclinicSystem
{
    public class Appointment
    {
        private string appointmentID;
        private DateTime dateTime;
        private Patient patient;
        private GeneralPractitioner gp;
        private string status;

        public string AppointmentID { get => appointmentID; set => appointmentID = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
        public Patient Patient { get => patient; set => patient = value; }
        public string Status { get => status; set => status = value; }
        internal GeneralPractitioner Gp { get => gp; set => gp = value; }
    }
}
