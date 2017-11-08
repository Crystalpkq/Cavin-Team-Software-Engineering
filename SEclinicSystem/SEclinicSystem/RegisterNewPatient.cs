﻿using System;
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
        Patient patient = new Patient(); 

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

            string result = patient.registerPatient(txtPatientName.Text,txtNRIC.Text, dtpDOB.Value.Date.ToString(), txtPhoneNo.Text, txtEmail.Text, txtAddress.Text.Replace(Environment.NewLine, "\\n"), ddlGender.SelectedValue.ToString());

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
            else if (dtpDOB.Value.Date == DateTime.Now.Date)
            {
                MessageBox.Show("Please fill up patient's birth date.");
                dtpDOB.Focus();
                return false;
            }
            else if (ddlGender.SelectedIndex == 0)
            {
                MessageBox.Show("Please fill up patient's gender.");
                ddlGender.Focus();
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
