using System;

namespace CalendarSystem
{
    public class Event : IComparable<Event>
    {
        public Event(DateTime date, string title, string location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        public DateTime Date { get; private set; }
        public string Title { get; private set; }
        public string Location { get; private set; }

        public override string ToString()
        {
            string format = "{0:yyyy-MM-ddTHH:mm:ss} | {1}";

            if (this.Location != null)
            {
                format = "{0:yyyy-MM-ddTHH:mm:ss} | {1} | {2}";
            }

            string eventAsString = String.Format(format, this.Date, this.Title, this.Location);

            return eventAsString;
        }

        public int CompareTo(Event other)
        {
            int result = DateTime.Compare(this.Date, other.Date);

            if (result == 0)
            {
                result = string.Compare(this.Title, other.Title, StringComparison.InvariantCulture);
            }

            if (result == 0)
            {
                result = string.Compare(this.Location, other.Location, StringComparison.InvariantCulture);
            }

            return result;
        }
    }
}
