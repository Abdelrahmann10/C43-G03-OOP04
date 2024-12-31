using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_Assignment
{
    internal class Duration
    {

        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration(int Sec)
        {
            Hours = Sec / 3600;
            Minutes = (Sec % 3600) / 60;
            Seconds = Sec % 60;
        }

        public override string ToString()
        {
            return $" Hours : {Hours} , Minutes : {Minutes} , Seconds : {Seconds} ";
        }




        #region 4- Forth Project

        public int TotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }

        public static Duration operator +(Duration D1, Duration D2)
        {
            return new Duration(D1.TotalSeconds() + D2.TotalSeconds());
        }

        public static Duration operator +(Duration D1, int seconds)
        {
            return new Duration(D1.TotalSeconds() + seconds);
        }

        public static Duration operator +(int seconds, Duration D2)
        {
            return new Duration(seconds + D2.TotalSeconds());
        }

        public static Duration operator ++(Duration D)
        {
            return new Duration(D.TotalSeconds() + 60);
        }

        public static Duration operator --(Duration D)
        {
            return new Duration(D.TotalSeconds() - 60);
        }


        public static Duration operator -(Duration D1, Duration D2)
        {
            return new Duration(D1.TotalSeconds() - D2.TotalSeconds());
        }


        public static bool operator >(Duration D1, Duration D2)
        {
            return D1.TotalSeconds() > D2.TotalSeconds();
        }


        public static bool operator <(Duration D1, Duration D2)
        {
            return D1.TotalSeconds() < D2.TotalSeconds();
        }


        public static bool operator >=(Duration D1, Duration D2)
        {
            return D1.TotalSeconds() >= D2.TotalSeconds();
        }


        public static bool operator <=(Duration D1, Duration D2)
        {
            return D1.TotalSeconds() <= D2.TotalSeconds();
        }


        public static explicit operator DateTime(Duration D)
        {
            return new DateTime().AddSeconds(D.TotalSeconds());
        }


        #endregion
    }
}
