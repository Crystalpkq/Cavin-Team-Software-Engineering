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
    public partial class RegisterNewPatient : Form
    {
        Patient patient;

        public RegisterNewPatient()
        {
            InitializeComponent();
        }

        //create new patient
        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (!checkValidation())
            {
                return;
            }

            string result = patient.registerPatient(txtPatientName.Text,txtNRIC.Text, txtDOB.Text, txtPhoneNo.Text, txtEmail.Text, txtAddress.Text.Replace(Environment.NewLine, "\\n"), txtGender.Text);

            if (result != "")
            {
                
                MessageBox.Show("This patient has successfully registered in the system. \n PatientID is "+ result +" .");
                Clear();
                this.Hide();
                var PatientSearch = new PatientSearch();
                PatientSearch.Show();

            }
            else
            {
                MessageBox.Show("Failed");
                Clear();
            }
        }

        public bool checkValidation()
        {
            bool validation = true;

            if (txtPatientName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill up patient's name.");
                txtPatientName.Focus();
                return false;
            }
            else if (txtNRIC.Text.Trim() == "")
            {
                MessageBox.Show("Please fill up patient's NRIC.");
                txtNRIC.Focus();
                return false;
            }
            else if (txtDOB.Text.Trim() == "")
            {
                MessageBox.Show("Please fill up patient's birth date.");
                txtDOB.Focus();
                return false;
            }
            else if (txtGender.Text.Trim() == "")
            {
                MessageBox.Show("Please fill up patient's gender.");
                txtGender.Focus();
                return false;
            }
            else if (txtPhoneNo.Text.Trim() == "")
            {
                MessageBox.Show("Please fill up patient's contact number.");
                txtPhoneNo.Focus();
                return false;
            }
            else if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Please fill up patient's email address.");
                txtEmail.Focus();
                return false;
            }
            else if (txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("Please fill up patient's address.");
                txtAddress.Focus();
                return false;
            }

            return validation;
        }

        public void Clear()
        {
            txtPatientName.Text = "";
            txtNRIC.Text = "";
            txtDOB.Text = "";
            txtGender.Text = "";
            txtPhoneNo.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
