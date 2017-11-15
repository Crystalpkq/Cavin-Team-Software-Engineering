using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEclinicSystem
{
    public partial class AppointmentMain : Form
    {
        OverSurgerySystem dbCon = new OverSurgerySystem();
        int result;


        public AppointmentMain()
        {
            InitializeComponent();
            gpNames();
            fillTime();
            fillRemark();
        }

        public void gpNames()
        {
            gpName.Items.Add("doctor1");
        }

        public void fillTime()
        {
            //int minutes = DateTime.Now.Minute;
            //int adjust = 10 - (minutes % 10);
            // Timer.Interval = adjust * 60 * 1000;

            var start = DateTime.ParseExact("09:00", "HH:mm",CultureInfo.InvariantCulture);
            var clockQuery = from offset in Enumerable.Range(0,37)
                             select start.AddMinutes(20 * offset);

            foreach (var time in clockQuery)
                timeList.Items.Add(time.ToString("hh:mm tt"));
        }

        public void fillRemark()
        {
            remark.Items.Add("immediate");
        }

        private void createApt_Click(object sender, EventArgs e)
        {
            if (remark.Text == "immediate")
            {
                result = dbCon.WriteData("INSERT INTO Appointment(staffID, startTime, startDate, Cstatus, remark) VALUES('1', '" + timeList.SelectedItem + "','" + date.Value.ToShortDateString() + "', 'pending', '" + remark.SelectedItem + "')");
  
            }
            else
            {

            }
        }
    }
}
