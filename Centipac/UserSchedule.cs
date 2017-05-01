using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centipac
{
    /// <summary>
    /// Class used for serializing and storing schedule information in TimePickers and on server.
    /// Associates days of week with time values.
    /// </summary>
    public class UserSchedule
    {
        public string name { get; set; }
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; }

        public UserSchedule(string name, string monday, string tuesday, string wednesday, string thursday, string friday, string saturday, string sunday)
        {
            this.name = name;
            this.Monday = monday;
            this.Tuesday = tuesday;
            this.Wednesday = wednesday;
            this.Thursday = thursday;
            this.Friday = friday;
            this.Saturday = saturday;
            this.Sunday = sunday;
        }

        public UserSchedule(string name)
        {
            this.name = name;
        }

        public bool setValueSuccess(string day, string timeString)
        {
            switch (day)
            {
                case "Monday": this.Monday = timeString; return true;
                case "Tuesday": this.Tuesday = timeString; return true;
                case "Wednesday": this.Wednesday = timeString; return true;
                case "Thursday": this.Thursday = timeString; return true;
                case "Friday": this.Friday = timeString; return true;
                case "Saturday": this.Saturday = timeString; return true;
                case "Sunday": this.Sunday = timeString; return true;
            }

            return false;
        }
    }
}
