using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_TheSpire
{

    // 얘네가 카드 밸류랑 타입 정함
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
        private int customBlackjackValue; // 아이템 효과로 덮어쓰는거
        private bool hasCustomValue; // 아이템효과 있나 없나 보는거

        public Card(CardType type, CardValue value) // 기본값
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

        public int GetBlackjackValue() // 커스텀 값 있으면 그거 반환, 없으면 일반값 반환. 블랙잭 JQK는 10으로 계산됨
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

        public int GetMissionValue() //미션 판정용 값, 원본값 반환해주는거임
        {
            return (int)value;
        }

        public int GetCustomBlackjackValue() //커스텀 값 가져오는거.
        {
            return customBlackjackValue;
        }

        public void SetCustomBlackjackValue(int newValue) // 커스텀 값 설정하는거
        {
            customBlackjackValue = newValue;
            hasCustomValue = true;
        }

        public void ClearCustomBlackjackValue() // 커스텀 값 초기화하는거
        {
            customBlackjackValue = 0;
            hasCustomValue = false;
        }

        public bool HasCustomValue() 
        {
            return hasCustomValue;
        }

        public override string ToString() //디버깅용임
        {
            return type.ToString() + " " + value.ToString();
        }
    }
}