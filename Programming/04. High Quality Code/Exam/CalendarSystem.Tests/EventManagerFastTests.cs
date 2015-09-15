using System;
using System.Globalization;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalendarSystem.Tests
{
    [TestClass]
    public class EventManagerFastTests
    {
        [TestMethod]
        public void AddOneEventThenListEvent()
        {
            DateTime date = DateTime.ParseExact("2012-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            Event event3Params = new Event(date, "party Viki", "home");

            EventsManagerFast eventManager = new EventsManagerFast();
            eventManager.AddEvent(event3Params);
            var actual = eventManager.ListEvents(date, 3).ToList();
            Assert.AreEqual(1, actual.Count);
        }

        [TestMethod]
        public void AddTwoEventsThenListEvent()
        {
            DateTime date = DateTime.ParseExact("2012-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            Event event3Params = new Event(date, "party Viki", "home");
            Event event2Params = new Event(date, "C# exam", null);

            EventsManagerFast eventManager = new EventsManagerFast();
            eventManager.AddEvent(event2Params);
            eventManager.AddEvent(event3Params);
            var actual = eventManager.ListEvents(date, 3).ToList();
            Assert.AreEqual(2, actual.Count);
        }

        [TestMethod]
        public void AddTwoEventsThenListMissingEvent()
        {
            DateTime dateOne = DateTime.ParseExact("2012-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            DateTime dateTwo = DateTime.ParseExact("2013-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            Event event3Params = new Event(dateOne, "party Viki", "home");
            Event event2Params = new Event(dateOne, "C# exam", null);

            EventsManagerFast eventManager = new EventsManagerFast();
            eventManager.AddEvent(event2Params);
            eventManager.AddEvent(event3Params);
            var events = eventManager.ListEvents(dateTwo, 3).ToList();

            //Both are valid assertions
            //only one may do the job
            Assert.IsFalse(events.Any());
            Assert.AreEqual(0, events.Count);
        }

        [TestMethod]
        public void AddTwoEventsThenDeleteOneAndList()
        {
            DateTime dateOne = DateTime.ParseExact("2012-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            Event event3Params = new Event(dateOne, "party Viki", "home");
            Event event2Params = new Event(dateOne, "C# exam", null);

            EventsManagerFast eventManager = new EventsManagerFast();
            eventManager.AddEvent(event2Params);
            eventManager.AddEvent(event3Params);

            int deletedCount = eventManager.DeleteEventsByTitle("C# exam");

            var events = eventManager.ListEvents(dateOne, 3).ToList();

            Assert.AreEqual(1, deletedCount);
            Assert.AreEqual(1, events.Count);
        }

        [TestMethod]
        public void AddTwoEventsThenDeleteInvalidEventAndList()
        {
            DateTime dateOne = DateTime.ParseExact("2012-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            Event event3Params = new Event(dateOne, "party Viki", "home");
            Event event2Params = new Event(dateOne, "C# exam", null);

            EventsManagerFast eventManager = new EventsManagerFast();
            eventManager.AddEvent(event2Params);
            eventManager.AddEvent(event3Params);

            int deletedCount = eventManager.DeleteEventsByTitle("Baba Meca");

            var events = eventManager.ListEvents(dateOne, 3).ToList();

            Assert.AreEqual(0, deletedCount);
            Assert.AreEqual(2, events.Count);
        }

        [TestMethod]
        public void AddEventsThenCheckListIfSortedByLocation()
        {
            DateTime dateOne = DateTime.ParseExact("2012-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            EventsManagerFast eventManager = new EventsManagerFast();
            eventManager.AddEvent(new Event(dateOne, "party Viki", "zoo"));
            eventManager.AddEvent(new Event(dateOne, "party Viki", "home"));
            eventManager.AddEvent(new Event(dateOne, "party Viki", "alone"));
            eventManager.AddEvent(new Event(dateOne, "party Viki", "home"));

            var events = eventManager.ListEvents(dateOne, 4).ToList();

            Assert.AreEqual(events[0].Location, "alone");
            Assert.AreEqual(events[1].Location, "home");
            Assert.AreEqual(events[2].Location, "home");
            Assert.AreEqual(events[3].Location, "zoo");
        }

        [TestMethod]
        public void AddEventsThenCheckListIfSortedByTitle()
        {
            DateTime dateOne = DateTime.ParseExact("2012-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            EventsManagerFast eventManager = new EventsManagerFast();
            eventManager.AddEvent(new Event(dateOne, "party Viki", "home"));
            eventManager.AddEvent(new Event(dateOne, "party Asen", "home"));
            eventManager.AddEvent(new Event(dateOne, "party Viki", "home"));
            eventManager.AddEvent(new Event(dateOne, "party Asen", "home"));

            var events = eventManager.ListEvents(dateOne, 4).ToList();

            Assert.AreEqual(events[0].Title, "party Asen");
            Assert.AreEqual(events[1].Title, "party Asen");
            Assert.AreEqual(events[2].Title, "party Viki");
            Assert.AreEqual(events[3].Title, "party Viki");
        }

        [TestMethod]
        public void AddEventsThenCheckListIfSortedByDate()
        {
            DateTime dateOne = DateTime.ParseExact("2012-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            DateTime dateTwo = DateTime.ParseExact("2013-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            EventsManagerFast eventManager = new EventsManagerFast();
            eventManager.AddEvent(new Event(dateOne, "party Viki", "home"));
            eventManager.AddEvent(new Event(dateTwo, "party Viki", "home"));
            eventManager.AddEvent(new Event(dateOne, "party Viki", "home"));
            eventManager.AddEvent(new Event(dateTwo, "party Viki", "home"));

            var events = eventManager.ListEvents(dateOne, 4).ToList();

            Assert.AreEqual(events[0].Date, dateOne);
            Assert.AreEqual(events[1].Date, dateOne);
            Assert.AreEqual(events[2].Date, dateTwo);
            Assert.AreEqual(events[3].Date, dateTwo);
        }

        //This test fail on purpose
        //Check documentation why
        [TestMethod]
        public void AddEventsThenCheckListIfSortedByManyCriterias()
        {
            DateTime dateOne = DateTime.ParseExact("2012-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            DateTime dateTwo = DateTime.ParseExact("2013-01-21T20:00:00", "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            EventsManagerFast eventManager = new EventsManagerFast();
            eventManager.AddEvent(new Event(dateOne, "party viki", "home1"));
            eventManager.AddEvent(new Event(dateOne, "party Asen", "home3"));
            eventManager.AddEvent(new Event(dateTwo, "party Viki", "home5"));
            eventManager.AddEvent(new Event(dateOne, "party Viki", "home2"));
            eventManager.AddEvent(new Event(dateTwo, "party Viki", "home4"));

            var events = eventManager.ListEvents(dateOne, 5).ToList();

            Assert.AreEqual(events[0].Location, "home3");
            Assert.AreEqual(events[1].Location, "home2");
            Assert.AreEqual(events[2].Location, "home1");
            Assert.AreEqual(events[3].Location, "home4");
            Assert.AreEqual(events[4].Location, "home5");
        }
    }
}
