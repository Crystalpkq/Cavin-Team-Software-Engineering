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

        public PrescriptionSearchAdd()
        {
            InitializeComponent();
            setDataGridTable();
            lblText.Visible = false;
            dataGridView1.Visible = true;            
        }

        //search Text Box
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable result = run.getLocalSQLData(@"select disctinct a.[prescriptionID], a.[appointmentID], b.[dateTime], a.[patientID],a.[staffID] FROM [Prescription] a with (nolock) left join [Appointment] with (nolock) on a.appointmentID = b.appointmentID   where prescriptionID LIKE '%"+ textBox1.Text +"%' order by prescriptionID asc");

            if (result != null)
            {
                if (result.Rows.Count > 0)
                {
                    lblText.Visible = false;
                    dataGridView1.Visible = true;

                    int x = 0;
                    while (x <= result.Rows.Count - 1)
                    {
                        DataTable pn = run.getLocalSQLData("select [patientName] FROM [Patient] where patientID = '" + result.Rows[x]["patientID"].ToString() + "' order by patientID asc");
                        DataTable gpn = run.getLocalSQLData("select [staffName] FROM [Staff] where staffID = '" + result.Rows[x]["staffID"].ToString() + "' order by staffID asc");

                        DataGridViewLinkColumn linkCell = new DataGridViewLinkColumn();
                        linkCell.UseColumnTextForLinkValue = true;
                        linkCell.LinkBehavior = LinkBehavior.SystemDefault;
                        linkCell.Name = "PrescriptionID";
                        linkCell.LinkColor = Color.Blue;
                        linkCell.Text = result.Rows[x]["prescriptionID"].ToString();
                        linkCell.UseColumnTextForLinkValue = true;

                        dataGridView1.Rows.Add(linkCell, result.Rows[x]["dateTime"].ToString(), pn.Rows[0]["patientName"].ToString(), gpn.Rows[0]["staffName"].ToString());
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Prescription prescription = new Prescription();

            if (e.ColumnIndex == 0)
            {
                prescription.PrescriptionID = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Hide();
                var pd = new PrescriptionDetails();
                pd.Show();
            }
        }


        public void setDataGridTable()
        {
            dataGridView1.Columns.Add("prescriptionID", "Prescription ID");
            dataGridView1.Columns.Add("dateTime", "AppointmemtTime");
            dataGridView1.Columns.Add("patientName", "Patient Name");
            dataGridView1.Columns.Add("staffName", "General Practitioner");

        }

        private void btnAddNewPrescription_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pd = new PrescriptionDetails();
            pd.Show();
        }
    }
}
