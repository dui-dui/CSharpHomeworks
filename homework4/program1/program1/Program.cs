using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public class ClockEventArgs : EventArgs
    {

    }
    public delegate void ClockEventHandler(object sender, ClockEventArgs e);
    public class Clock
    {
        public event ClockEventHandler AlarmClock;
        public void DoClock(int nHour, int nMinute)
        {
            while (DateTime.Now.Hour != nHour || DateTime.Now.Minute != nMinute)
            {

            }
            ClockEventArgs args = new ClockEventArgs();
            AlarmClock(this, args);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("设置时:");
            string s = Console.ReadLine();
            int nHour = int.Parse(s);
            Console.Write("设置分:");
            s = Console.ReadLine();
            int nMinute = int.Parse(s);
            var clock = new Clock();
            clock.AlarmClock += ShowProgress;
            clock.DoClock(nHour, nMinute);
        }
        static void ShowProgress(object sender, ClockEventArgs e)
        {
            Console.WriteLine("时间到了");
        }
    }
}