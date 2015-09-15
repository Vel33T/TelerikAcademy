using System;
using System.Threading;

namespace DelegateTimer
{
    public delegate void Call(object obj);

    public class TimerCall
    {
        public static void TimeNow(Object obj)
        {
            Console.WriteLine(DateTime.Now);
        }
    
        static void Main()
        {
            Console.WriteLine("Pres Enter to stop!");
            Call call = new Call(TimeNow);
            Timer time = new Timer(call.Invoke, null, 0, 1000);

            Console.Read();
        }
    }
}
