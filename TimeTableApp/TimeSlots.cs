using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableApp
{
    public class TimeSlots
    {
        public string day;
        public string time;
        public subject subjectOBJ;

        public TimeSlots(string day, string time, subject subjectOBJ)
        {
            this.day = day;
            this.time = time;
            this.subjectOBJ = subjectOBJ;
        }

        public string getDay() { return day; }
        public string getTime() { return time; }
        public subject getSubject(){ return subjectOBJ; }


    }
}
