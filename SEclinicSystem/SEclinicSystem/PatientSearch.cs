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

        Patient patient = new Patient();        

        public PatientSearch()
        {
            InitializeComponent();
            ResetForm();
        }

        //Search button
        private void button1_Click(object sender, EventArgs e)
        {
            string result;

            if(comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a register method and fill in the fields.");
            }
            //search by ID
            else if (comboBox1.SelectedIndex == 1)
            {
                if (txtPatientID.Text != "")
                {
                    result = patient.searchPatient(txtPatientID.Text, null, null, null);

                    if (result == "Yes")
                    {
                        patient.setID(txtPatientID.Text, null, new DateTime(), null);
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
            }
            //search by name & DOB
            else if(comboBox1.SelectedIndex == 2)
            {
                if (txtPatientName.Text != "" && dtpDOB.Value.Date != DateTime.Now.Date)
                {
                    result = patient.searchPatient(null, txtPatientName.Text, dtpDOB.Value.Date.ToString(), null);

                    if (result == "Yes")
                    {
                        patient.setID(null, txtPatientName.Text, dtpDOB.Value.Date, null);                       
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
            }            
            //search by name & address
            else if(comboBox1.SelectedIndex == 3)
            {
                if (txtPatientName.Text != "" && txtAddress.Text != "")
                {
                    result = patient.searchPatient(null, txtPatientName.Text, null, txtAddress.Text.Replace(Environment.NewLine, "\\n"));

                    if (result == "Yes")
                    {
                        patient.setID(null, txtPatientName.Text, new DateTime(), txtAddress.Text.Replace(Environment.NewLine, "\\n"));                        
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
            comboBox1.Items.Clear();
            comboBox1.Items.Insert(0, "- Select a search method -");
            comboBox1.Items.Insert(1, "Patient ID");
            comboBox1.Items.Insert(2, "Patient Name & Date of Birth");
            comboBox1.Items.Insert(3, "Patient Name & Address");
            
            txtPatientID.Text = "";
            txtPatientID.Enabled = false;
            txtPatientName.Text = "";
            txtPatientName.Enabled = false;
            txtAddress.Text = "";
            txtAddress.Enabled = false;
            dtpDOB.Value = DateTime.Now;
            dtpDOB.Enabled = false;
        }

        //search patient by
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                txtPatientID.Enabled = false;
                txtPatientName.Enabled = false;
                txtAddress.Enabled = false;
                dtpDOB.Enabled = false;
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                txtPatientID.Enabled = true;
                txtPatientName.Enabled = false;
                txtAddress.Enabled = false;
                dtpDOB.Enabled = false;
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                txtPatientID.Enabled = false;
                txtPatientName.Enabled = true;
                txtAddress.Enabled = false;
                dtpDOB.Enabled = true;
            }
            else if(comboBox1.SelectedIndex == 3)
            {
                txtPatientID.Enabled = false;
                txtPatientName.Enabled = true;
                txtAddress.Enabled = true;
                dtpDOB.Enabled = false;
            }
        }
    }
}
