using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Poker.Tests
{
    [TestClass]
    public class IsFourOfAKindTests
    {
        [TestMethod]
        public void FourTensTest()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            List<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Clubs),
            };
            Hand hand = new Hand(cards);
            Assert.IsTrue(checker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void FourQueensTest()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            List<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Clubs),
            };
            Hand hand = new Hand(cards);
            Assert.IsTrue(checker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void ThreeQueensTwoKindsTest()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            List<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Clubs),
            };
            Hand hand = new Hand(cards);
            Assert.IsFalse(checker.IsFourOfAKind(hand));
        }
    }
}
