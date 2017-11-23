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
    public partial class Main : Form
    {
        OverSurgerySystem system = new OverSurgerySystem();
        Staff staff = new Staff();

        public Main(string username)
        {
                 
            InitializeComponent();
            staff = system.credential(username);
            staffID.Text = staff.StaffID;
            staffName.Text = staff.FullName;
           // pictureBox1.Image = Image.FromFile("C:\Users\LENOVO\Desktop\ARU\Software Engineer\Cavin-Team-Software-Engineering\user.png");

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm form = new LoginForm();
            form.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
           
        }

        private void SearchPatient_Click(object sender, EventArgs e)
        {
            PatientSearch fPatientSearch = new PatientSearch();
            fPatientSearch.Show();
        }
    }
}
