using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_TheSpire
{
    internal class Deck
    {
        private List<Card> cards;
        private List<Card> usedCards;

        public Deck()
        {
            cards = new List<Card>();
            usedCards = new List<Card>();
            InitializeStandardDeck();
        }

        public int GetCount()
        {
            return cards.Count;
        }

        public int GetUsedCount()
        {
            return usedCards.Count;
        }

        public int GetTotalCount()
        {
            return cards.Count + usedCards.Count;
        }

        public List<Card> GetAllCards()
        {
            return cards;
        }

        public void ClearAllCards()
        {
            cards.Clear();
            usedCards.Clear();
        }

        private void InitializeStandardDeck()
        {
            foreach (CardType type in Enum.GetValues(typeof(CardType)))
            {
                foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
                {
                    cards.Add(new Card(type, value));
                }
            }
        }

        public void Shuffle()
        {
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = GameRandom.Next(i + 1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        public Card Draw()
        {
            if (cards.Count == 0)
                throw new InvalidOperationException("덱에 카드가 없습니다.");

            Card drawn = cards[0];
            cards.RemoveAt(0);
            usedCards.Add(drawn);
            return drawn;
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public void ReturnUsedCards()
        {
            cards.AddRange(usedCards);
            usedCards.Clear();
        }

        public List<Card> GenerateRandomCardChoices(int count = 3)
        {
            List<Card> choices = new List<Card>();
            CardType[] allTypes = (CardType[])Enum.GetValues(typeof(CardType));
            CardValue[] allValues = (CardValue[])Enum.GetValues(typeof(CardValue));

            for (int i = 0; i < count; i++)
            {
                CardType randomType = allTypes[GameRandom.Next(allTypes.Length)];
                CardValue randomValue = allValues[GameRandom.Next(allValues.Length)];
                choices.Add(new Card(randomType, randomValue));
            }

            return choices;
        }
    }
}