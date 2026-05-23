using BlackJack_TheSpire;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BlackJack_TheSpire
{
    internal static class MissionManager              
    {
        public static List<Mission> allMissions = new List<Mission>()
        {
            new Mission(1, "트리플", "같은 숫자 카드 3장", 1.5, (hand) => {return hand.GetCards().GroupBy(card => card.GetMissionValue()).Any(group => group.Count() >= 3);}),
            new Mission(2, "플러시", "같은 문양 카드 3장", 2.0, (hand) => {return hand.GetCards().GroupBy(card => card.GetCardType()).Any(group => group.Count() >= 3);}),
            new Mission(3, "스트레이트", "연속된 숫자 카드 3장", 2.5, (hand) => { List<int> values = hand.GetCards().Select(card => card.GetMissionValue()).Distinct().OrderBy(v => v).ToList();
                for (int i = 0; i < values.Count - 2; i++) {if (values[i + 1] == values[i] + 1 && values[i + 2] == values[i] + 2) {return true;}} return false;}),
            new Mission(4, "미들 카드", "숫자 합 15 이상", 1.2, (hand) => {return hand.CalculateValue() >= 15;}),
            new Mission(5, "하이 카드", "숫자 합 18 이상", 1.5, (hand) => {return hand.CalculateValue() >= 18;}),
            new Mission(6, "초고점", "숫자 합 20 이상", 1.8, (hand) => {return hand.CalculateValue() >= 20;}),
            new Mission(7, "블랙잭", "숫자 합 21", 2.0, (hand) => {return hand.IsBlackjack(); }),
            new Mission(8, "욕심쟁이", "카드 5장 이상", 1.5, (hand) => {return hand.GetCardCount() >= 5; }),
            new Mission(9, "슈퍼 플러시", "같은 문양 카드 4장", 2.5, (hand) => {return hand.GetCards().GroupBy(card => card.GetCardType()).Any(group => group.Count() >= 4);}),
            new Mission(10, "롱 스트레이트", "연속된 숫자 카드 4장", 3.0, (hand) => {List<int> values = hand.GetCards().Select(card => card.GetMissionValue()).Distinct().OrderBy(v => v).ToList();
                for (int i = 0; i < values.Count - 3; i++) {if (values[i + 1] == values[i] + 1 && values[i + 2] == values[i] + 2 && values[i + 3] == values[i] + 3){return true;}} return false;}),
            new Mission(11, "짝수광", "짝수 숫자 카드 3장", 1.5, (hand) =>{return hand.GetCards().Count(card => {int value = card.GetMissionValue(); return value >= 2 && value <= 10 && value % 2 == 0;}) >= 3;}),
            new Mission(12, "홀수광", "홀수 숫자 카드 3장", 1.5, (hand) =>{return hand.GetCards().Count(card => {int value = card.GetMissionValue(); return value >= 1 && value <= 9 && value % 2 == 1;}) >= 3;}),
            new Mission(13, "에이스 마스터", "Ace 카드 2장", 2.0, (hand) => {return hand.GetCards().Count(card => card.GetCardValue() == CardValue.Ace) >= 2; }),
            new Mission(14, "럭키 세븐", "7 카드 포함", 1.7, (hand) => {return hand.GetCards().Any(card => card.GetMissionValue() == 7); }),
            new Mission(15, "유리 심장", "Ace 없이 21 만들기", 3.0, (hand) => {bool hasAce = hand.GetCards().Any(card => card.GetCardValue() == CardValue.Ace); return !hasAce && hand.CalculateValue() == 21;})
        };

        public static Mission GetRandomMission()               //미션 1개 랜덤으로 뽑기
        {
            int index = GameRandom.Next(allMissions.Count);

            Mission original = allMissions[index];

            return new Mission(original.Id, original.Name, original.Description, original.BonusMultiplier, original.Condition);
        }

        public static List<Mission> GetRandomMissions(int count)           //미션 원하는 수만큼 뽑기 
        {
            List<Mission> result = new List<Mission>();

            while (result.Count < count)
            {
                Mission randomMission = GetRandomMission();            //여기서 위의 메소드 호출

                if (!result.Any(m =>
                    m.Id == randomMission.Id))                     //미션 중복 관리
                {
                    result.Add(randomMission);
                }
            }

            return result;
        }
    }
}
