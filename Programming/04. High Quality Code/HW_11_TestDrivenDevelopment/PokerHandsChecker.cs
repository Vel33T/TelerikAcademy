using System;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            bool haveFiveCards = false;
            if (hand.Cards.Count == 5)
            {
                haveFiveCards = true;
            }

            bool noDuplicates = true;
            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (hand.Cards[i].Face == hand.Cards[i + 1].Face &&
                    hand.Cards[i].Suit == hand.Cards[i + 1].Suit)
                {
                    noDuplicates = false;
                }
            }

            return haveFiveCards && noDuplicates;
        }

        public bool IsFlush(IHand hand)
        {
            bool isFlush = true;

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (hand.Cards[i].Suit != hand.Cards[i + 1].Suit)
                {
                    isFlush = false;
                    break;
                }
            }

            return isFlush;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            for (int i = 0; i < 2; i++)
            {
                int sameCardsCount = 0;
                for (int j = 0; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        sameCardsCount++;
                    }

                    if (sameCardsCount == 4)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
