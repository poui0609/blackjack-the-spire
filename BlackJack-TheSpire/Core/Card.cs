using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_TheSpire
{
    enum CardType
    {
        Spade, Club, Diamond, Heart
    }
    enum CardValue
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
            this.customBlackjackValue = 0;
            this.hasCustomValue = false;
        }

        public CardType GetCardType()
        {
            return type;
        }

        public CardValue GetCardValue()
        {
            return value;
        }

        public int GetBlackjackValue()
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

        public int GetCustomBlackjackValue()
        {
            return customBlackjackValue;
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