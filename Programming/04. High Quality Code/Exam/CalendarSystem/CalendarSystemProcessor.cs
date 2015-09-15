using System;
using System.Linq;
using System.Text;
using System.Globalization;

namespace CalendarSystem
{
    public class CalendarSystemProcessor
    {
        private readonly IEventsManager eventsManager;

        public CalendarSystemProcessor(IEventsManager eventsManager)
        {
            this.eventsManager = eventsManager;
        }

        public IEventsManager EventsManager
        {
            get
            {
                return this.eventsManager;
            }
        }

        public string ProcessCommand(Command cmd)
        {
            // First command
            if ((cmd.CommandName == "AddEvent"))
            {
                return AddEvent(cmd);
            }

            // Second command
            if ((cmd.CommandName == "DeleteEvents") && (cmd.CommandParams.Length == 1))
            {
                return DeleteEvents(cmd);
            }

            // Third command
            if ((cmd.CommandName == "ListEvents") && (cmd.CommandParams.Length == 2))
            {
                return ListEvents(cmd);
            }
            throw new InvalidOperationException("This command: " + cmd.CommandName + " is not valid or supported!");
        }


        private string AddEvent(Command cmd)
        {
            DateTime date = DateTime.ParseExact(cmd.CommandParams[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            if (cmd.CommandParams.Length == 2)
            {
                Event currentEvent = new Event(date, cmd.CommandParams[1], null);
                this.eventsManager.AddEvent(currentEvent);
            }
            else
            {
                Event currentEvent = new Event(date, cmd.CommandParams[1], cmd.CommandParams[2]);
                this.eventsManager.AddEvent(currentEvent);
            }

            return "Event added";
        }
  
        private string DeleteEvents(Command cmd)
        {
            int deletedEventsCount = this.eventsManager.DeleteEventsByTitle(cmd.CommandParams[0]);

            if (deletedEventsCount == 0)
            {
                return "No events found";
            }

            return deletedEventsCount + " events deleted";
        }

        private string ListEvents(Command cmd)
        {
            DateTime date = DateTime.ParseExact(cmd.CommandParams[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            int eventsToListNumber = int.Parse(cmd.CommandParams[1]);
            var events = this.eventsManager.ListEvents(date, eventsToListNumber).ToList();

            StringBuilder sbOutput = new StringBuilder();

            if (!events.Any())
            {
                return "No events found";
            }

            foreach (var evt in events)
            {
                sbOutput.AppendLine(evt.ToString());
            }

            return sbOutput.ToString().Trim();
        }
    }
}
