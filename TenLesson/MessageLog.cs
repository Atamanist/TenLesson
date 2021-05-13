using System;
using System.Collections.Generic;
using System.Text;

namespace TenLesson
{
    class MessageLog
    {
        public string Time { get; set; }

        public long Id { get; set; }

        public string Msg { get; set; }

        public string Type { get; set; }

        public string FirstName { get; set; }

        public MessageLog(string Time, string Msg, string FirstName, long Id,string type)
        {
            this.Time = Time;
            this.Msg = Msg;
            this.FirstName = FirstName;
            this.Id = Id;
            this.Type = type;
        }

    }
}
