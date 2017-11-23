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
    public partial class PatientMain : Form
    {
        OverSurgerySystem run = new OverSurgerySystem();
        Patient p = new Patient();

        public PatientMain(Patient patient)
        {
            p = patient;
            InitializeComponent();
            setValue();
        }

        //set patient's details
        private void setValue()
        {
            string tempQuery = "select [name], [NRIC], [dateOfBirth], [phoneNo], [email], [address], [gender] FROM [Patient] where patientId = '" + p.PatientID + "'";

            DataTable result = run.getLocalSQLData(tempQuery);

            if(result.Rows.Count > 0)
            {
                lblPatientID.Text = p.PatientID;
                lblPatientName.Text = result.Rows[0]["name"].ToString();
                lblNRIC.Text = result.Rows[0]["NRIC"].ToString();
                lblGender.Text = result.Rows[0]["gender"].ToString();
                lblDOB.Text = result.Rows[0]["dateOfBirth"].ToString();
                lblPhoneNo.Text = result.Rows[0]["phoneNo"].ToString();
                lblEmail.Text = result.Rows[0]["email"].ToString();
                lblAddress.Text = result.Rows[0]["address"].ToString().Replace("\r\n",Environment.NewLine);
                               
                p.Name = result.Rows[0]["name"].ToString();
                p.NRIC = result.Rows[0]["NRIC"].ToString();
                p.Gender = result.Rows[0]["gender"].ToString();
                p.DOB = (DateTime)result.Rows[0]["dateOfBirth"];
                p.PhoneNo = result.Rows[0]["phoneNo"].ToString();
                p.Email = result.Rows[0]["email"].ToString();
                p.Address = result.Rows[0]["address"].ToString().Replace("\r\n", Environment.NewLine);
            }
        }

        //back to patient search
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var PatientSearch = new PatientSearch();
            PatientSearch.Show();
        }

        //update patient's details
        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            var UP = new UpdatePatient(p);
            UP.Show();
        }

        //add prescription
        private void button2_Click(object sender, EventArgs e)
        {           
            var anp = new PrescriptionAddNew(p);
            anp.Show();
        }

        //search prescription
        private void button1_Click(object sender, EventArgs e)
        {
            var sp = new PrescriptionSearchAdd(p);
            sp.Show();
        }
    }
}
