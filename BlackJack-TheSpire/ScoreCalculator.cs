using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_TheSpire
{
    internal static class ScoreCalculator
    {
        public static double GetHandMultiplier(Hand hand)
        {
            if (hand.IsBust())
                return 0.0;

            if (hand.IsBlackjack())
                return 1.5;

            int value = hand.CalculateValue();

            if (value == 21)
                return 2.5;
            else if (value == 20)
                return 2.0;
            else if (value == 19)
                return 1.7;
            else if (value == 18)
                return 1.5;
            else if (value == 17)
                return 1.2;
            else if (value == 16)
                return 1.0;
            else if (value >= 14)
                return 0.9;
            else if (value >= 11)
                return 0.7;
            else
                return 0.5;
        }

        public static int CalculateScore(int bettingChips, double handMultiplier, double missionMultiplier, double itemMultiplier)
        {
            double total = bettingChips * handMultiplier * missionMultiplier * itemMultiplier;
            return (int)total;
        }

        public static int CalculateFinalScore(int bettingChips, Hand hand, double missionMultiplier, double itemMultiplier)
        {
            double handMultiplier = GetHandMultiplier(hand);
            return CalculateScore(bettingChips, handMultiplier, missionMultiplier, itemMultiplier);
        }
    }
}