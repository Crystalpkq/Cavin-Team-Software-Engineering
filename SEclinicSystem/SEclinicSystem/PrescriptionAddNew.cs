using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace SEclinicSystem
{
    public partial class PrescriptionAddNew : Form
    {
        OverSurgerySystem run = new OverSurgerySystem();
        Prescription prescription = new Prescription();
        PrescriptionHandler ph = new PrescriptionHandler();

        public PrescriptionAddNew(Patient patient)
        {
            prescription.Patient.PatientID = patient.PatientID;
            InitializeComponent();
            clearList();
            setPatientName();
            setMedicineList();
        }

        private void PrescriptionAddNew_Load(object sender, EventArgs e)
        {                        
            string resp = run.connect();
            AutoCompleteStringCollection patientNameCollection = new AutoCompleteStringCollection();
            AutoCompleteStringCollection gpNameCollection = new AutoCompleteStringCollection();

            if (resp == "Done")
            {
                SqlCommand cmd = new SqlCommand(@"select [staffName] FROM [Staff] order by staffName asc", run.getConn());
                SqlDataReader reader = cmd.ExecuteReader();                
                while (reader.Read())
                {
                    gpNameCollection.Add(reader.GetString(0));
                }                
                txtGPName.AutoCompleteCustomSource = gpNameCollection;

                run.closeConnection();
            }         

         }

        //set the medicine datagridview
        private void setMedicineList()
        {         
            DataTable medicineDT = run.getLocalSQLData("SELECT [medicineID], [medicineName], [dosage], [consumption], [description] FROM [Medicine] ORDER BY [medicineID] ASC");

            if (medicineDT.Rows.Count > 0)
            {               
                dataGridView1.DataSource = medicineDT;
            }

            DataGridViewCheckBoxColumn checkMedicine = new DataGridViewCheckBoxColumn();
            checkMedicine.Name = "select";
            checkMedicine.HeaderText = "Select";
            checkMedicine.Width = 50;
            checkMedicine.ReadOnly = false;
            checkMedicine.FillWeight = 10;
            dataGridView1.Columns.Add(checkMedicine);
        }

        private void btnCreatePrescription_Click(object sender, EventArgs e)
        {
            int rowkena = 0;

            if (!checkValidation())
            {
                return;
            }
            
            prescription.Appointment.AppointmentID = txtAppointmentID.Text.ToString();

            DataTable gp = run.getLocalSQLData("SELECT [staffID] FROM [Staff] WHERE [Name] = '" + txtGPName.Text.ToString() + "' ORDER BY [staffID] ASC");
            prescription.Staff.StaffID = gp.Rows[0]["staffID"].ToString();

            prescription.EndDate = dtpEndDate.Value.Date;

            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {

                if (Convert.ToBoolean(dataGridView1.Rows[j].Cells[5].Value) == true)
                {
                    prescription.Medicine.MedicineID = dataGridView1.Rows[j].Cells[0].Value.ToString();
                    rowkena = ph.addPrescription(prescription);
                }            
                
            }

            if (rowkena > 0)
            {
                MessageBox.Show("New prescription is successfully created!");
                clearList();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Insert failed!");
            }            
            
        }

        //check validation for each input
        private bool checkValidation()
        {
            bool validation = true;

            //patient name validation
            if (txtPatientName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill up patient's name.");
                txtPatientName.Focus();
                return false;
            }
            else if (txtPatientName.Text.Trim() != "")
            {
                Regex emp1 = new Regex("^[a-z-A-Z]+$");

                if (!emp1.IsMatch(txtPatientName.Text))
                {
                    MessageBox.Show("Only ALPHABETIC letters");
                    txtPatientName.Focus();
                    return false;
                }
            }
            //GP Name validation
            else if (txtGPName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill up GP's name.");
                txtGPName.Focus();
                return false;
            }
            else if (txtGPName.Text.Trim() != "")
            {
                Regex emp1 = new Regex("^[a-z-A-Z]+$");

                if (!emp1.IsMatch(txtGPName.Text))
                {
                    MessageBox.Show("Only ALPHABETIC letters");
                    txtGPName.Focus();
                    return false;
                }
            }           
            // Appointment ID validation
            else if (txtAppointmentID.Text.Trim() == "")
            {
                MessageBox.Show("Please fill up apponintment ID.");
                txtAppointmentID.Focus();
                return false;
            }
            // End date validation
            else if(dtpEndDate.Value.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("Invalid date!");
                dtpEndDate.Focus();
                return false;
            }
            //must have one checkbox checked
            else 
            {
                int checkedBox = 0;

                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    if (Convert.ToBoolean(dataGridView1.Rows[j].Cells[5].Value) == true)
                    {
                        checkedBox = checkedBox + 1;                       
                    }
                }

                if (checkedBox == 0)
                {
                    return false;
                }
                else if (checkedBox > 0)
                {
                    return validation;
                }
            }

            return validation;
        }

        //reset list
        private void clearList()
        {
            txtPatientName.Text = "";
            txtGPName.Text = "";
            txtAppointmentID.Text = "";
            dtpEndDate.Value = DateTime.Now;            
        }
        
        //set txtPatientName textbox value (patient's name)
        private void setPatientName()
        {
            DataTable dt = run.getLocalSQLData("SELECT [patientName] FROM [Patient] WHERE patientId = '"+prescription.Patient.PatientID+"' ORDER BY [patientID] ASC");

            if (dt.Rows.Count > 0)
            {
                prescription.Patient.Name = dt.Rows[0]["patientName"].ToString();
                txtPatientName.Text = prescription.Patient.Name;
            }
            
        }

        //back button
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

