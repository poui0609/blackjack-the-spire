using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_TheSpire
{
    internal class Hand
    {
        private List<Card> cards; //패

        public Hand()
        {
            cards = new List<Card>();
        }

        public void AddCard(Card card) //카드 추가
        {
            cards.Add(card);
        }

        public void Clear() // 패 초기화
        {
            cards.Clear();
        }

        public List<Card> GetCards() // 패에 있는 카드 반환
        {
            return cards;
        }

        public int GetCardCount() // 패에 있는 카드 수 반환
        {
            return cards.Count;
        }

        public int CalculateValue() // 핵심임. 블랙잭 값 합산하고 A갯수 세고 21넘으면 1로 바꾸는거
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

        public bool IsBust() //버스트 여부
        {
            return CalculateValue() > 21;
        }

        public bool IsBlackjack() //블랙잭 여부
        {
            return cards.Count == 2 && CalculateValue() == 21;
        }

        public bool IsTwentyOne() // 21점 여부 블랙잭 아닐때 쓰셈
        {
            return CalculateValue() == 21;
        }
    }
}