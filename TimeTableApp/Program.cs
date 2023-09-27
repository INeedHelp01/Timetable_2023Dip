using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlConnector;

namespace TimeTableApp
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public List<Lecturer> lecturers = new List<Lecturer>();

        public string myConnectionString = "server=127.0.0.1;uid=root;" +
    "pwd=r3wG!Y$!jPoe57;database=TimeTable";
        MySql.Data.MySqlClient.MySqlConnection conn;
        public void loadLecturer()
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

               
                string id;
                string firstName;
                string lastName;

                while (reader.Read())
                {
                    id = reader["lecturerID"].ToString();
                    firstName = reader["firstName"].ToString();
                    lastName = reader["lastName"].ToString();
                    Lecturer lecturerTemp = new Lecturer(id, firstName, lastName);
                    lecturers.Add(lecturerTemp);
                }
                Console.WriteLine(lecturers[1].getName()); ;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine("Not Connected");
            }
           
        }
        public List<subject> Subjects = new List<subject>();
        public void loadSubject()
        {
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                Console.WriteLine("connected");
                MySql.Data.MySqlClient.MySqlCommand command = new
                    MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM subject", conn);
                MySql.Data.MySqlClient.MySqlDataReader reader = command.ExecuteReader();


                string subjectID;
                string subjectName;
                string roomID;

                while (reader.Read())
                {
                    subjectID = reader["subjectID"].ToString();
                    subjectName = reader["subjectName"].ToString();
                    roomID = reader["room_roomID"].ToString();
                    subject subjectTemp = new subject(subjectID, subjectName, roomID);
                    Subjects.Add(subjectTemp);
                }
                Console.WriteLine(Subjects[1].getSubjectName());
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine("Not Connected");
            }
        }
        public List<TimeSlots> TimeSlots= new List<TimeSlots>();
        
        public void LoadTimeSlots()
        {
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                Console.WriteLine("connected");
                MySql.Data.MySqlClient.MySqlCommand command = new
                    MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM timeslot", conn);
                MySql.Data.MySqlClient.MySqlDataReader reader = command.ExecuteReader();


                string time;
                string day;
                string subjectId;
                while (reader.Read())
                {
                    day= reader["day"].ToString();
                    time = reader["time"].ToString();
                    subjectId = reader["subject_subjectID"].ToString();

                    foreach (subject sub in Subjects)
                    {
                        if (sub.getSubjectID() == subjectId)
                        {
                            TimeSlots timeSlotsTemp = new TimeSlots(day, time, sub);
                            TimeSlots.Add(timeSlotsTemp);
                        }
                    }

                    
                }
                Console.WriteLine(TimeSlots[0].getSubject().getSubjectName());
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine("Not Connected");
            }
        }
        public List<subject_lecturer> subjectHasLecturer = new List<subject_lecturer>();
        public void LoadSubject_Lecturer()
        {
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                Console.WriteLine("connected");
                MySql.Data.MySqlClient.MySqlCommand command = new
                    MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM subject_has_lecturer", conn);
                MySql.Data.MySqlClient.MySqlDataReader reader = command.ExecuteReader();


                string lecturerID;
                string subjectId;
                while (reader.Read())
                {
                    subjectId = reader["subject_subjectID"].ToString();
                    lecturerID = reader["lecturer_lecturerID"].ToString();

                    foreach (subject sub in Subjects)
                    {
                        if (sub.getSubjectID() == subjectId)
                        {
                            foreach (Lecturer lecturer in lecturers)
                            {
                                if (lecturer.getLecturerID() == lecturerID)
                                {
                                    subject_lecturer sub_lecTemp = new subject_lecturer(sub, lecturer);
                                    subjectHasLecturer.Add(sub_lecTemp);
                                }
                            }

                        }
                    }


                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine("Not Connected");
            }
        }
        public List<Lecturer> GetLecturers()
        {
            return lecturers;
        }
        public List<TimeSlots> GetTimeSlots()
        {
            return TimeSlots;
        }
        public List<subject> GetSubjects() 
        {
            return Subjects; 
        }
        public List<subject_lecturer> GetSubject_Lecturers()
        {
            return subjectHasLecturer;
        }

    }
}
