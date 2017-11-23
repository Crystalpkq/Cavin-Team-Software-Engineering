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
    public partial class PrescriptionSearchAdd : Form
    {
        OverSurgerySystem run = new OverSurgerySystem();
        Prescription prescription = new Prescription();
        Patient p = new Patient();

        public PrescriptionSearchAdd(Patient patient)
        {
            p = patient;
            InitializeComponent();
            setDataGridTable();
            lblText.Visible = false;
            dataGridView1.Visible = true;            
        }

        //search Text Box
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable result = run.getLocalSQLData(@"select disctinct a.[prescriptionID], a.[appointmentID], b.[date], a.[staffID] FROM [Prescription] a with (nolock) left join [Appointment] with (nolock) on a.appointmentID = b.appointmentID   where patientID ='"+p.PatientID+"' AND prescriptionID LIKE '%"+ textBox1.Text +"%' order by prescriptionID asc");

            if (result != null)
            {
                if (result.Rows.Count > 0)
                {
                    lblText.Visible = false;
                    dataGridView1.Visible = true;

                    int x = 0;
                    while (x <= result.Rows.Count - 1)
                    {
                        DataTable pn = run.getLocalSQLData("select [patientName] FROM [Patient] where patientID = '" + p.PatientID + "' order by patientID asc");
                        DataTable gpn = run.getLocalSQLData("select [staffName] FROM [Staff] where staffID = '" + result.Rows[x]["staffID"].ToString() + "' order by staffID asc");

                        DataGridViewLinkColumn linkCell = new DataGridViewLinkColumn();
                        linkCell.UseColumnTextForLinkValue = true;
                        linkCell.LinkBehavior = LinkBehavior.SystemDefault;
                        linkCell.Name = "PrescriptionID";
                        linkCell.LinkColor = Color.Blue;
                        linkCell.Text = result.Rows[x]["prescriptionID"].ToString();
                        linkCell.UseColumnTextForLinkValue = true;

                        dataGridView1.Rows.Add(linkCell, result.Rows[x]["date"].ToString(), pn.Rows[0]["patientName"].ToString(), gpn.Rows[0]["staffName"].ToString());
                        x++;
                    }                
                    
                }
                else
                {
                    lblText.Visible = true;
                    dataGridView1.Visible = false;
                }
                
            }
            
        }

        //link cell - click the id then will show the prescription details
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.ColumnIndex == 0)
            {
                prescription.PrescriptionID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                prescription.Appointment.Date = (DateTime)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                prescription.Staff.FullName = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                DataTable result = run.getLocalSQLData(@"select disctinct [prescriptionID], [appointmentID], [staffID], [endDate] FROM [Prescription] a with(nolock) where ptientId = '"+p.PatientID+"' AND prescriptionID = '"+ prescription.PrescriptionID +"' order by prescriptionID asc");
                prescription.Staff.StaffID = result.Rows[0]["staffID"].ToString();
                prescription.Appointment.AppointmentID = result.Rows[0]["appointmentID"].ToString();
                prescription.Patient.PatientID = p.PatientID;
                prescription.EndDate = (DateTime)result.Rows[0]["endDate"];

                this.Hide();
                var pd = new PrescriptionDetails(prescription);
                pd.Show();
            }
        }

        //set datatable
        public void setDataGridTable()
        {
            dataGridView1.Columns.Add("prescriptionID", "Prescription ID");
            dataGridView1.Columns.Add("dateTime", "AppointmentTime");
            dataGridView1.Columns.Add("patientName", "Patient Name");
            dataGridView1.Columns.Add("staffName", "General Practitioner");

        }        

        //back to Patient Main
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
