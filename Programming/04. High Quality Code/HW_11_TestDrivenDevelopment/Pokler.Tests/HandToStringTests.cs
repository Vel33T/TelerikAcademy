using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace Poker.Tests
{
    [TestClass]
    public class HandToStringTests
    {
        [TestMethod]
        public void ToStringWithNoCards()
        {
            Hand hand = new Hand(new List<ICard>());
            string result = hand.ToString();
            Assert.AreEqual(String.Empty, result);
        }

        [TestMethod]
        public void ToStringWithOneCardTenSpades()
        {
            Card card = new Card(CardFace.Ten, CardSuit.Spades);
            Hand hand = new Hand(new List<ICard>() {card} );
            string result = hand.ToString();
            Assert.AreEqual("10♠", result);
        }

        [TestMethod]
        public void ToStringWithFiveCards()
        {
            List<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Spades)
            };
            Hand hand = new Hand(cards);
            string result = hand.ToString();
            Assert.AreEqual("10♠ 9♠ 8♠ 7♠ 6♠", result);
        }

        [TestMethod]
        public void ToStringWithSameCards()
        {
            List<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades),
            };
            Hand hand = new Hand(cards);
            string result = hand.ToString();
            Assert.AreEqual("10♠ 10♠", result);
        }
    }
}
