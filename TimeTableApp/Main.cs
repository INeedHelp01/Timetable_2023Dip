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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            Visible = false;
        }

        private void btnViewTimeTable1_Click(object sender, EventArgs e)
        {
            TimeTable timeTable = new TimeTable();  
            timeTable.Show();
            Visible = false;
        }

        public void btnExit1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
