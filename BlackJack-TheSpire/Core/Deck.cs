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

        public Deck() //덱 만드는거. 이어하기 안하면 이걸로 만듦
        {
            cards = new List<Card>();
            usedCards = new List<Card>();
            InitializeStandardDeck();
        }

        public int GetCount() //카드 몇장 남아있나 세주는거
        {
            return cards.Count;
        }

        public int GetUsedCount() //사용한 카드 수
        {
            return usedCards.Count;
        }

        public int GetTotalCount() // 전체
        {
            return cards.Count + usedCards.Count;
        }

        public List<Card> GetAllCards() //덱에 있는 카드 수말고 카드들 반환
        {
            return cards;
        }

        public void ClearAllCards() //덱 카드들 다 지우는거
        {
            cards.Clear();
            usedCards.Clear();
        }

        private void InitializeStandardDeck() // 덱 처음 만드는거
        {
            foreach (CardType type in Enum.GetValues(typeof(CardType)))
            {
                foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
                {
                    cards.Add(new Card(type, value));
                }
            }
        }

        public void Shuffle() //셔플
        {
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = GameRandom.Next(i + 1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        public Card Draw()//카드 뽑기
        {
            if (cards.Count == 0)
                throw new InvalidOperationException("덱에 카드가 없습니다.");

            Card drawn = cards[0];
            cards.RemoveAt(0);
            usedCards.Add(drawn);
            return drawn;
        }

        public void AddCard(Card card)// 덱에 카드 추가하기
        {
            cards.Add(card);
        }

        public void ReturnUsedCards() //사용한 카드 덱으로 보내기
        {
            cards.AddRange(usedCards);
            usedCards.Clear();
        }
        public List<Card> GetUsedCards() // 사용한 카드 반환
        {
            return usedCards;
        }
        public List<Card> GenerateRandomCardChoices(int count = 3) // 랜덤 카드 선택지 생성
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