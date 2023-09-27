using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableApp
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btnMain2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            Visible = false;
        }

        private void btnViewTimeTable2_Click(object sender, EventArgs e)
        {
            TimeTable timetable = new TimeTable();
            timetable.Show();
            Visible = false;
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

    }
}
