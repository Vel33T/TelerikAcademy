using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

namespace CalendarSystem
{
    public class EventsManagerFast : IEventsManager
    {
        private readonly MultiDictionary<string, CalendarSystem.Event> titles = new MultiDictionary<string, CalendarSystem.Event>(true);

        private readonly OrderedMultiDictionary<DateTime, Event> dates = new OrderedMultiDictionary<DateTime, Event>(true);

        /// <summary>
        /// Adds event properties to the corresponding data structures.
        /// </summary>
        public void AddEvent(Event eventToAdd)
        {
            string eventTitleLowerCase = eventToAdd.Title.ToLowerInvariant();
            this.titles.Add(eventTitleLowerCase, eventToAdd);
            this.dates.Add(eventToAdd.Date, eventToAdd);
        }

        /// <summary>
        /// Deletes all events which have titles same as <paramref name="title"/>
        /// </summary>
        /// <param name="title">Title key</param>
        /// <returns>The number of deleted items</returns>
        public int DeleteEventsByTitle(string title)
        {
            string titleToLower = title.ToLowerInvariant();
            var delete = this.titles[titleToLower];
            int count = delete.Count;

            foreach (var evt in delete)
            {
                this.dates.Remove(evt.Date, evt);
            }

            this.titles.Remove(titleToLower);

            return count;
        }


        // This method have problems with the sorting
        // For more info see the documentation
        /// <summary>
        /// List all events starting from given <paramref name="date"/>. The number of 
        /// listed events is equal or less then <paramref name="count"/>.
        /// </summary>
        /// <param name="date">Starting date.</param>
        /// <param name="count">Number of listed items.</param>
        /// <returns>The events corresponding to the given conditions.</returns>
        public IEnumerable<Event> ListEvents(DateTime date, int count)
        {
            var eventsInRange =
                from evt in this.dates.RangeFrom(date, true).Values
                select evt;

            var events = eventsInRange.Take(count);
            return events;
        }
    }
}
