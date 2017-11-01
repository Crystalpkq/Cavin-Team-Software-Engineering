using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEclinicSystem
{
    public partial class PatientSearch : Form
    {

        Patient patient;

        public static string patientID = "";
        public static string patientName = "";
        public static string DOB = "";
        public static string address = "";

        public PatientSearch()
        {
            InitializeComponent();
            ResetForm();
        }

        //Search button
        private void button1_Click(object sender, EventArgs e)
        {
            string result;

            if (txtPatientID.Text != "" && txtPatientName.Text != "" && txtAddress.Text != "" && txtDOB.Text != "")
            {
                MessageBox.Show("Search only PatientID OR Patient Name and Address OR Name and Date Of Birth!");
            }
            //search by ID
            else if (txtPatientID.Text != "")
            {
                result = patient.searchPatient(txtPatientID.Text,null,null,null);

                if(result == "Yes")
                {
                    patientID = txtPatientID.Text; 
                    this.Hide();
                    var PatientMain = new PatientMain();
                    PatientMain.Show();
                }
                else if(result == "No")
                {
                    MessageBox.Show("Patient Not Found");
                    ResetForm();
                    
                }
            }
            //search by name & DOB
            else if (txtPatientName.Text != "" && txtDOB.Text != "")
            {
                result = patient.searchPatient(null, txtPatientName.Text, txtDOB.Text, null);

                if (result == "Yes")
                {
                    patientID = patient.getID(txtPatientName.Text, txtDOB.Text,null);
                    this.Hide();
                    var PatientMain = new PatientMain();
                    PatientMain.Show();
                }
                else if (result == "No")
                {
                    MessageBox.Show("Patient Not Found");
                    ResetForm();

                }
            }
            //search by name & address
            else if (txtPatientName.Text != "" && txtAddress.Text != "")
            {
                result = patient.searchPatient(null, txtPatientName.Text, null, txtAddress.Text.Replace(Environment.NewLine, "\\n"));

                if (result == "Yes")
                {
                    patientID = patient.getID(txtPatientName.Text, null, txtAddress.Text.Replace(Environment.NewLine, "\\n"));
                    this.Hide();
                    var PatientMain = new PatientMain();
                    PatientMain.Show();                    
                }
                else if (result == "No")
                {
                    MessageBox.Show("Patient Not Found");
                    ResetForm();

                }
            }
            else if (txtPatientID.Text == "" || txtPatientName.Text == "" || txtAddress.Text == "" || txtDOB.Text == "")
            {
                MessageBox.Show("Please fill in PatientID OR Patient Name and Address OR Name and Date Of Birth!");
                ResetForm();
            }
        }

        //Cancel button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        //register new patient
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var RegisterNewPatient = new RegisterNewPatient();           
            RegisterNewPatient.Show();
        }

        private void ResetForm()
        {
            txtPatientID.Text = "";
            txtPatientName.Text = "";
            txtAddress.Text = "";
            txtDOB.Text = "";
        }

    }
}
