using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Tests
{
    [TestClass]
    public class CardToStringTests
    {
        [TestMethod]
        public void ToStringOfSevenDiamonds()
        {
            Card card = new Card(CardFace.Seven, CardSuit.Diamonds);
            string result = card.ToString();
            Assert.AreEqual("7♦", result);
        }

        [TestMethod]
        public void ToStringOfAceHearts()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Hearts);
            string result = card.ToString();
            Assert.AreEqual("A♥", result);
        }

        [TestMethod]
        public void ToStringOfTwoClubs()
        {
            Card card = new Card(CardFace.Two, CardSuit.Clubs);
            string result = card.ToString();
            Assert.AreEqual("2♣", result);
        }

        [TestMethod]
        public void ToStringOfTenSpades()
        {
            Card card = new Card(CardFace.Ten, CardSuit.Spades);
            string result = card.ToString();
            Assert.AreEqual("10♠", result);
        } 
    }
}
