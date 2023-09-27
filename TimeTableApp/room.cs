using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableApp
{
    public class room
    {
        public string roomID;
        public string roomName;

        public room(string roomID, string roomName)
        {
            this.roomID = roomID;
            this.roomName = roomName;
        }
        public string getRoomID() { return this.roomID; }
        public string getRoomName() {  return this.roomName; }
    }
}
