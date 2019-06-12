using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Theatre
{
    class Time
    {
       public int Hours { get; private set; }
       public int Minutes { get; private set; }
       public int Seconds { get; private set; }

       public Time(int hours, int minutes, int seconds = 0)
       {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
       }
        public override string ToString()
       {
            return $"{(Hours > 12 ? Hours - 12 : Hours)}:{Minutes:D2}{(Seconds == 0 ? "" : ":"+ Seconds)} {(Hours > 12 ? "pm" : "am")}";
       }

       public static bool operator !=(Time lhs, Time rhs)
       {
            //return !lhs.Equals(rhs);
            int l = (lhs.Hours * 60) + lhs.Minutes;
            int r = (rhs.Hours * 60) + rhs.Minutes;
            if ((l - r) < 15 || (r - l) < 15)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

       public static bool operator ==(Time lhs, Time rhs)
       {
            //return lhs.Equals(rhs);
            int l = (lhs.Hours * 60) + lhs.Minutes;
            int r = (rhs.Hours * 60) + rhs.Minutes;
            int min;
            if (l > r)
                min = l - r;
            else
                min = r - l;
            if (min < 15)
                return true;
            return false;
        }
    }
}   
