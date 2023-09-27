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
        

        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Program program = new Program();
            program.loadLecturer();
            program.loadSubject();
            program.LoadTimeSlots();
            program.LoadSubject_Lecturer();
            List<subject_lecturer> subject_Lecturers = program.GetSubject_Lecturers();
            List<TimeSlots> slots = program.GetTimeSlots();

            foreach (var slot in slots)
            {
                Console.WriteLine(slot.getSubject().getSubjectID());
                if (slot.getTime() == "09:00")
                {
                    if (slot.getDay() == "Monday")
                    {
                        
                        foreach(subject_lecturer sub in subject_Lecturers)
                        {
                            if (sub.getSubject().getSubjectID() == slot.getSubject().getSubjectID())
                            {
                                string temp1 = sub.getSubject().getSubjectID();
                                string temp2 = sub.getlecturer().getLecturerID();
                                TestLabel.Text = slot.getSubject().getSubjectID() + "\n" + 
                                    sub.getSubject().getSubjectID() + "\n"+ sub.getlecturer().getLecturerID();
                            }
                        }
                        Slot11.Text = slot.getSubject().getSubjectID();
                    }
                    else if (slot.getDay() == "Tuesday")
                    {
                        Slot12.Text = slot.getSubject().getSubjectID();
                    }
                    else if (slot.getDay() == "Wednesday")
                    {
                        Slot13.Text = slot.getSubject().getSubjectID();
                    }
                    else if (slot.getDay() == "Thursday")
                    {
                        Slot14.Text = slot.getSubject().getSubjectID();
                    }

                }else if (slot.getTime() == "12:00")
                {

                    if (slot.getDay() == "Monday")
                    {
                        Slot21.Text = slot.getSubject().getSubjectID();
                    }
                    else if (slot.getDay() == "Tuesday")
                    {
                        Slot22.Text = slot.getSubject().getSubjectID();
                    }
                    else if (slot.getDay() == "Wednesday")
                    {
                        Slot23.Text = slot.getSubject().getSubjectID();
                    }
                    else if (slot.getDay() == "Thursday")
                    {
                        Slot24.Text = slot.getSubject().getSubjectID();
                    }

                }else if (slot.getTime() == "15:00")
                {

                    if (slot.getDay() == "Monday")
                    {
                        Slot31.Text = slot.getSubject().getSubjectID();
                    }
                    else if (slot.getDay() == "Tuesday")
                    {
                        Slot32.Text = slot.getSubject().getSubjectID();
                    }
                    else if (slot.getDay() == "Wednesday")
                    {
                        Slot33.Text = slot.getSubject().getSubjectID();
                    }
                    else if (slot.getDay() == "Thursday")
                    {
                        Slot34.Text = slot.getSubject().getSubjectID();
                    }

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
