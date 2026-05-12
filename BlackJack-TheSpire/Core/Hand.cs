using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_TheSpire
{
    internal class Hand
    {
        private List<Card> cards;

        public Hand()
        {
            cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public void Clear()
        {
            cards.Clear();
        }

        public List<Card> GetCards()
        {
            return cards;
        }

        public int GetCardCount()
        {
            return cards.Count;
        }

        public int CalculateValue()
        {
            int total = 0;
            int aceCount = 0;

            foreach (Card card in cards)
            {
                total += card.GetBlackjackValue();

                if (card.GetCardValue() == CardValue.Ace && !card.HasCustomValue())
                    aceCount++;
            }

            while (total > 21 && aceCount > 0)
            {
                total -= 10;
                aceCount--;
            }

            return total;
        }

        public bool IsBust()
        {
            return CalculateValue() > 21;
        }

        public bool IsBlackjack()
        {
            return cards.Count == 2 && CalculateValue() == 21;
        }

        public bool IsTwentyOne()
        {
            return CalculateValue() == 21;
        }
    }
}