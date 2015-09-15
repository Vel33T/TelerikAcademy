using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Poker.Tests
{
    [TestClass]
    public class IsFlushTests
    {
        [TestMethod]
        public void FiveCardsOfSpadesTest()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            List<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Spades),
            };
            Hand hand = new Hand(cards);
            Assert.IsTrue(checker.IsFlush(hand));
        }

        [TestMethod]
        public void FiveCardsOfHeartsTest()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            List<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
            };
            Hand hand = new Hand(cards);
            Assert.IsTrue(checker.IsFlush(hand));
        }

        [TestMethod]
        public void FourCardsOfSpadesTest()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            List<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Diamonds),
            };
            Hand hand = new Hand(cards);
            Assert.IsFalse(checker.IsFlush(hand));
        }
    }
}
