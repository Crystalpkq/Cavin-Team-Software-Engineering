using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SEclinicSystem
{
    public partial class RegisterNewPatient : Form
    {
        Patient patient = new Patient();
        PatientHandler ph = new PatientHandler();

        public RegisterNewPatient()
        {
            InitializeComponent();
            ddlGender.Items.Clear();
            ddlGender.Items.Insert(0, "- Select a gender -");
            ddlGender.Items.Insert(1, "Male");
            ddlGender.Items.Insert(2, "Female");
        }

        //create new patient
        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (!checkValidation())
            {
                return;
            }

            patient.Name = txtPatientName.Text;
            patient.NRIC = txtNRIC1.Text + "-" + txtNRIC2.Text + "-" + txtNRIC3.Text;
            patient.DOB = dtpDOB.Value.Date;
            patient.PhoneNo = txtPhoneNo.Text;
            patient.Email = txtEmail.Text;
            patient.Address = txtAddress.Text.Replace(Environment.NewLine, "\\n");
            patient.Gender = ddlGender.SelectedValue.ToString();

            string result = ph.registerPatient(patient);
            
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
            }
        }

        public bool checkValidation()
        {
            bool validation = true;

            //patient name validation
            if (txtPatientName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill up patient's name.");
                txtPatientName.Focus();
                return false;
            }
            else if(txtPatientName.Text.Trim() != "")
            {
                Regex emp1 = new Regex("^[a-z-A-Z]+$");

                if (!emp1.IsMatch(txtPatientName.Text))
                {
                    MessageBox.Show("Only ALPHABETIC letters");
                    txtPatientName.Focus();
                    return false;
                }
            }
            //NRIC validation
            else if (txtNRIC1.Text.Trim() == "")
            {
                MessageBox.Show("Please fill up patient's NRIC column 1.");
                txtNRIC1.Focus();
                return false;
            }
            else if (txtNRIC2.Text.Trim() == "")
            {
                MessageBox.Show("Please fill up patient's NRIC column 2.");
                txtNRIC1.Focus();
                return false;
            }
            else if (txtNRIC3.Text.Trim() == "")
            {
                MessageBox.Show("Please fill up patient's NRIC column 3.");
                txtNRIC1.Focus();
                return false;
            }
            else if (txtNRIC1.Text.Trim() != "")
            {
                Regex emp1 = new Regex("^[0-9]");

                if(txtNRIC1.Text.Length < 6)
                {
                    MessageBox.Show("Need 6 digits");
                    txtNRIC1.Focus();
                    return false;
                }
                else if (!emp1.IsMatch(txtNRIC1.Text))
                {
                    MessageBox.Show("Only numeric number");
                    txtNRIC1.Focus();
                    return false;
                }
            }
            else if (txtNRIC2.Text.Trim() != "")
            {
                Regex emp1 = new Regex("^[0-9]");

                if (txtNRIC2.Text.Length < 2)
                {
                    MessageBox.Show("Need 2 digits");
                    txtNRIC2.Focus();
                    return false;
                }
                else if (!emp1.IsMatch(txtNRIC2.Text))
                {
                    MessageBox.Show("Only numeric number");
                    txtNRIC2.Focus();
                    return false;
                }
            }
            else if (txtNRIC3.Text.Trim() != "")
            {
                Regex emp1 = new Regex("^[0-9]");

                if (txtNRIC3.Text.Length < 6)
                {
                    MessageBox.Show("Need 6 digits");
                    txtNRIC3.Focus();
                    return false;
                }
                else if (!emp1.IsMatch(txtNRIC3.Text))
                {
                    MessageBox.Show("Only numeric number");
                    txtNRIC3.Focus();
                    return false;
                }
            }
            // Date of birth validation
            else if (dtpDOB.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Invalid date.");
                dtpDOB.Focus();
                return false;
            }
            // Gender validation
            else if (ddlGender.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a patient's gender.");
                ddlGender.Focus();
                return false;
            }
            //Phone number validation
            else if (txtPhoneNo.Text.Trim() == "")
            {
                MessageBox.Show("Please fill up patient's contact number.");
                txtPhoneNo.Focus();
                return false;
            }
            else if (txtPhoneNo.Text.Trim() != "")
            {
                Regex emp1 = new Regex("^[0-9]");

                if(txtPhoneNo.Text.Length < 10)
                {
                    MessageBox.Show("Minimum 10 digits");
                    txtPhoneNo.Focus();
                    return false;
                }
                else if (!emp1.IsMatch(txtPhoneNo.Text))
                {
                    MessageBox.Show("Only numeric letters");
                    txtPhoneNo.Focus();
                    return false;
                }                
            }
            // Email validation
            else if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Please fill up patient's email address.");
                txtEmail.Focus();
                return false;
            }
            else if(txtEmail.Text.Trim() != "")
            {
                Regex emp1 = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

                if (!emp1.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("Invalid email aadress");
                    txtEmail.Focus();
                    return false;
                }
                
            }
            // Address validation
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
            txtNRIC1.Text = "";
            txtNRIC2.Text = "";
            txtNRIC3.Text = "";
            dtpDOB.Value = DateTime.Now.Date;
            ddlGender.SelectedIndex = 0;
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
