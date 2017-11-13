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
        Patient patient = new Patient();

        public PatientMain()
        {
            InitializeComponent();

            setValue();
        }

        private void setValue()
        {
            string tempQuery = "select [name], [NRIC], [dateOfBirth], [phoneNo], [email], [address], [gender] FROM [Patient] where patientId = '" + patient.getID() + "'";

            DataTable result = run.getLocalSQLData(tempQuery);

            if(result.Rows.Count > 0)
            {
                lblPatientID.Text = patient.getID();
                lblPatientName.Text = result.Rows[0]["name"].ToString();
                lblNRIC.Text = result.Rows[0]["NRIC"].ToString();
                lblGender.Text = result.Rows[0]["gender"].ToString();
                lblDOB.Text = result.Rows[0]["dateOfBirth"].ToString();
                lblPhoneNo.Text = result.Rows[0]["phoneNo"].ToString();
                lblEmail.Text = result.Rows[0]["email"].ToString();
                lblAddress.Text = result.Rows[0]["address"].ToString().Replace("\r\n",Environment.NewLine);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var PatientSearch = new PatientSearch();
            PatientSearch.Show();
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            var UP = new UpdatePatient();
            UP.Show();
        }
    }
}
