using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalendarSystem.Tests
{
    [TestClass]
    public class CommandTests
    {
        [TestMethod]
        public void TestValidAddEventCommandParse3Params()
        {
            string cmdToParse = "AddEvent 2012-01-21T20:00:00 | party Viki | home";
            Command cmd = Command.Parse(cmdToParse);
            string expectedCommandName = "AddEvent";
            string[] expectedCommandParams = { "2012-01-21T20:00:00", "party Viki", "home" };
            int expectedLength = 3;
            Assert.AreEqual(expectedCommandName, cmd.CommandName);
            Assert.AreEqual(expectedLength, cmd.CommandParams.Length);
            Assert.AreEqual(expectedCommandParams[0], cmd.CommandParams[0]);
            Assert.AreEqual(expectedCommandParams[1], cmd.CommandParams[1]);
            Assert.AreEqual(expectedCommandParams[2], cmd.CommandParams[2]);
        }

        [TestMethod]
        public void TestValidAddEventCommandParse2Params()
        {
            string cmdToParse = "AddEvent 2012-01-21T20:00:00 | party Viki";
            Command cmd = Command.Parse(cmdToParse);
            string expectedCommandName = "AddEvent";
            string[] expectedCommandParams = { "2012-01-21T20:00:00", "party Viki" };
            int expectedLength = 2;
            Assert.AreEqual(expectedCommandName, cmd.CommandName);
            Assert.AreEqual(expectedLength, cmd.CommandParams.Length);
            Assert.AreEqual(expectedCommandParams[0], cmd.CommandParams[0]);
            Assert.AreEqual(expectedCommandParams[1], cmd.CommandParams[1]);
        }

        [TestMethod]
        public void TestValidDeleteEventsCommandParse()
        {
            string cmdToParse = "DeleteEvents c# exam";
            Command cmd = Command.Parse(cmdToParse);
            string expectedCommandName = "DeleteEvents";
            string[] expectedCommandParams = { "c# exam" };
            int expectedLength = 1;
            Assert.AreEqual(expectedCommandName, cmd.CommandName);
            Assert.AreEqual(expectedLength, cmd.CommandParams.Length);
            Assert.AreEqual(expectedCommandParams[0], cmd.CommandParams[0]);
        }

        [TestMethod]
        public void TestValidListEventsCommandParse()
        {
            string cmdToParse = "ListEvents 2013-11-27T08:30:25 | 25";
            Command cmd = Command.Parse(cmdToParse);
            string expectedCommandName = "ListEvents";
            string[] expectedCommandParams = { "2013-11-27T08:30:25", "25" };
            int expectedLength = 2;
            Assert.AreEqual(expectedCommandName, cmd.CommandName);
            Assert.AreEqual(expectedLength, cmd.CommandParams.Length);
            Assert.AreEqual(expectedCommandParams[0], cmd.CommandParams[0]);
            Assert.AreEqual(expectedCommandParams[1], cmd.CommandParams[1]);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Invalid command: AddBabaMeca")]
        public void TestInvalidCommandParse()
        {
            string cmdToParse = "AddBabaMeca";
            Command cmd = Command.Parse(cmdToParse);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Invalid command:  ")]
        public void TestInvalidCommandWhiteSpaceParse()
        {
            string cmdToParse = " ";
            Command cmd = Command.Parse(cmdToParse);
        }
    }
}
