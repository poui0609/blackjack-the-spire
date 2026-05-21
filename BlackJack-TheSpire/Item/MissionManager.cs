using BlackJack_TheSpire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
            new Mission(3, "스트레이트", "같은 숫자 카드 3장", 2.5, (hand) => { List<int> values = hand.GetCards().Select(card => card.GetMissionValue()).Distinct().OrderBy(v => v).ToList();
                for (int i = 0; i < values.Count - 2; i++) {if (values[i + 1] == values[i] + 1 && values[i + 2] == values[i] + 2) {return true;}} return false;}),
        };

        public static Mission GetRandomMission()
        {
            int index = GameRandom.Next(allMissions.Count);
            return allMissions[index];
        }

        public static List<Mission> GetRandomMissions(int count)
        {
            List<Mission> result = new List<Mission>();

            while (result.Count < count)
            {
                Mission randomMission = GetRandomMission();

                if (!result.Any(m =>
                    m.Id == randomMission.Id))
                {
                    result.Add(randomMission);
                }
            }

            return result;
        }
    }
}
