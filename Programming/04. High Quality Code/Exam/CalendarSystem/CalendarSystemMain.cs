using System;
using System.Diagnostics;

namespace CalendarSystem
{
    class CalendarSystemMain
    {
        internal static void Main()
        {
            EventsManager eventsManager = new EventsManager();
            CalendarSystemProcessor processor = new CalendarSystemProcessor(eventsManager);

            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "End" || cmd == null)
                {
                    break;
                }

                try
                {
                    Console.WriteLine(processor.ProcessCommand(Command.Parse(cmd)));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}





