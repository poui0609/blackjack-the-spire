using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_TheSpire
{
    internal static class ScoreCalculator
    {
        public static double GetHandMultiplier(Hand hand) // 배율 결정
        {
            if (hand.IsBust())
                return 0.0;

            if (hand.IsBlackjack())
                return 1.5;

            int value = hand.CalculateValue();

            if (value == 21)
                return 2.5;

            return value * 0.1;
        }

        public static int CalculateScore(Hand hand, GameState gameState) //이게 진짜 점수 계산 
        {
            if (hand.IsBust())
                return 0;

            int value = hand.CalculateValue();
            double multiplier = GetHandMultiplier(hand);
            double total = value * multiplier;

            foreach (Item item in gameState.GetInventory().GetItems())
            {
                total *= item.ScoreMultiplier;
            }

            return (int)total;
        }
    }
}