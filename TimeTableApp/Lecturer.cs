using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlConnector;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace TimeTableApp
{
    public class Lecturer
    {
        public string lecturer_ID;
        public string lecturer_firstname;
        public string lecturer_lastname;

        public Lecturer(string lecturer_ID, string lecturer_firstname, string lecturer_lastname) { 
            this.lecturer_ID = lecturer_ID;
            this.lecturer_firstname = lecturer_firstname;
            this.lecturer_lastname = lecturer_lastname;
        }
        public string getName()
        {
            return this.lecturer_firstname + " " + this.lecturer_lastname;
        }
        public string getLecturerID() { return  this.lecturer_ID; }



    }
}
