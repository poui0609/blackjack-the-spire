using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_TheSpire
{
    enum CardType // 문양
    {
        Spade, Club, Diamond, Heart
    }
    enum CardValue // 숫자
    {
        Ace = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
    }

    internal class Card
    {
        private CardType type;
        private CardValue value;
        private int customBlackjackValue;
        private bool hasCustomValue;

        public Card(CardType type, CardValue value)
        {
            this.type = type;
            this.value = value;
        }

        public CardType GetCardType() //카드 문양 가져오는거
        {
            return type;
        }

        public CardValue GetCardValue() //카드 숫자 가져오는거
        {
            return value;
        }

        public int GetBlackjackValue() //잭 킹 퀸은 10으로 간주하는거. 에이스도 11로 간주함.
        {
            if (hasCustomValue)
                return customBlackjackValue;

            if (value == CardValue.Jack || value == CardValue.Queen || value == CardValue.King)
                return 10;
            else if (value == CardValue.Ace)
                return 11;
            else
                return (int)value;
        }

        public int GetMissionValue()
        {
            return (int)value;
        }

        public void SetCustomBlackjackValue(int newValue)
        {
            customBlackjackValue = newValue;
            hasCustomValue = true;
        }

        public void ClearCustomBlackjackValue()
        {
            customBlackjackValue = 0;
            hasCustomValue = false;
        }

        public bool HasCustomValue()
        {
            return hasCustomValue;
        }

        public override string ToString()
        {
            return type.ToString() + " " + value.ToString();
        }
    }
}