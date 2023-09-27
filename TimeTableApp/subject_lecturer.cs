using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableApp
{
    public class subject_lecturer
    {
        public subject subject;
        public Lecturer lecturer;

        public subject_lecturer(subject subject, Lecturer lecturer)
        {
            this.subject = subject;
            this.lecturer = lecturer;
        }
        public subject getSubject() { return subject; }
        public Lecturer getlecturer() {  return lecturer; }
    }
}
