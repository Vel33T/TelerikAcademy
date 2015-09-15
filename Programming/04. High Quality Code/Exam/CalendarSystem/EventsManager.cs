using System;
using System.Linq;
using System.Collections.Generic;

namespace CalendarSystem
{
    public class EventsManager : IEventsManager
    {
        /// <summary>
        /// Keeps all added events
        /// </summary>
        private readonly List<Event> listOfEvents = new List<Event>();

        /// <summary>
        /// Adds Event to list
        /// </summary>
        /// <param name="eventToAdd">Event to be added</param>
        public void AddEvent(Event eventToAdd)
        {
            this.listOfEvents.Add(eventToAdd);
        }

        /// <summary>
        /// Deletes all events which have titles same as <paramref name="title"/>
        /// using lambdha function.
        /// </summary>
        /// <param name="title">Title key.</param>
        /// <returns>The number of deleted items.</returns>
        public int DeleteEventsByTitle(string title)
        {
            return this.listOfEvents.RemoveAll(e => e.Title.ToLowerInvariant() == title.ToLowerInvariant());
        }

        // The bottleneck is here, because of the sorting
        /// <summary>
        /// List all events starting from given <paramref name="date"/>. The number of 
        /// listed events is equal or less then <paramref name="count"/>.
        /// </summary>
        /// <param name="date">Starting date.</param>
        /// <param name="count">Number of listed items.</param>
        /// <returns>The events corresponding to the given conditions.</returns>
        public IEnumerable<Event> ListEvents(DateTime date, int count)
        {
            return (from evt in this.listOfEvents
                    where evt.Date >= date
                    orderby evt.Date, evt.Title, evt.Location
                    select evt).Take(count);
        }
    }
}