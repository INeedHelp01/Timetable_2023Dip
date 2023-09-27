using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableApp
{
    public class subject
    {
        public string subjectID;
        public string subjectName;  
        public string roomID;

        public string SUBJECT = "NA";
        public string SUBJECTNAME = "NA";
        public string ROOMID = "NA";
        public subject(string subjectID, string subjectName, string roomID)
        {
            this.subjectID = subjectID;
            this.subjectName = subjectName;
            this.roomID = roomID;
        }
        public subject()
        {
            this.subjectID = SUBJECT;
            this.subjectName = SUBJECTNAME;
            this.roomID = ROOMID;
        }
        public string getSubjectID() { return this.subjectID; }
        public string getSubjectName() { return this.subjectName; }
        public string getroomID() { return roomID; }
    }
}
