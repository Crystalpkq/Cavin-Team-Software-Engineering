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

namespace SEclinicSystem
{
    public partial class PrescriptionAddNew : Form
    {
        OverSurgerySystem run = new OverSurgerySystem();

        public PrescriptionAddNew()
        {
            InitializeComponent();
        }

        private void PrescriptionAddNew_Load(object sender, EventArgs e)
        {                        
            string resp = run.connect();

            if(resp == "Done")
            {
                SqlCommand cmd = new SqlCommand(@"select [patientName] FROM [Patient] order by patientName asc", run.getConn());
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (reader.Read())
                {
                    MyCollection.Add(reader.GetString(0));
                }
                txtPatientName.AutoCompleteCustomSource = MyCollection;
                run.closeConnection();
            }         

         }           
        
    }
}

