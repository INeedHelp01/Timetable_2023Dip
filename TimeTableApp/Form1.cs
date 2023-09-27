using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlConnector;

namespace TimeTableApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string myConnectionString = "server=127.0.0.1;uid=root;" +
    "pwd=r3wG!Y$!jPoe57;database=TimeTable";
        MySql.Data.MySqlClient.MySqlConnection conn;

        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                Console.WriteLine("connected");
                MySql.Data.MySqlClient.MySqlCommand command = new 
                    MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM lecturer", conn);
                MySql.Data.MySqlClient.MySqlDataReader reader = command.ExecuteReader();

                List<string> teachers = new List<string>();
                while (reader.Read())
                {
                    teachers.Add(reader["lecturer_id"].ToString());
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine("oops");
            }

        }

    }
}
