using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class Time
    {
        public int Hours {  get; set; }
        public int Minutes {  get; set; }
        public int Seconds {  get; set; }
        public void SetValue(int hr, int min, int sec)
        {
            this.Minutes = sec/60 + min;
            this.Seconds = sec%60;
            this.Hours = Minutes / 60 + hr;
            this.Minutes = Minutes% 60 ;
        }
        public void DisplayData()
        {
            Console.WriteLine("Hours = " + Hours);
            Console.WriteLine("Minutes = " + Minutes);
            Console.WriteLine("Second = " + Seconds);
        }
    }
}
