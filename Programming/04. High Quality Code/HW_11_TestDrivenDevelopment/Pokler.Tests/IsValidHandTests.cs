using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Poker.Tests
{
    [TestClass]
    public class IsValidHandTests
    {
        [TestMethod]
        public void FourCardsTest()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            List<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Spades),
            };
            Hand hand = new Hand(cards);
            Assert.IsFalse(checker.IsValidHand(hand));
        }

        [TestMethod]
        public void SixCardsTest()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            List<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Spades),
            };
            Hand hand = new Hand(cards);
            Assert.IsFalse(checker.IsValidHand(hand));
        }

        [TestMethod]
        public void FiveCardsButTwoEqualTest()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            List<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Spades),
            };
            Hand hand = new Hand(cards);
            Assert.IsFalse(checker.IsValidHand(hand));
        }

        [TestMethod]
        public void FiveCardsTest()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            List<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Spades),
            };
            Hand hand = new Hand(cards);
            Assert.IsTrue(checker.IsValidHand(hand));
        }
    }
}
