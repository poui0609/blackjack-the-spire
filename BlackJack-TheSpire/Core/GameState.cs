using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_TheSpire
{
    internal class GameState
    {
        private int seed;
        private int currentRound;
        private int currentCycle;
        private int currentHand;
        private int coin;
        private int roundScore;
        private int targetScore;
        private Deck deck;

        private List<Item> inventory; //아이템 넣어 놓을 인벤토리 추가

        public GameState()
        {
            seed = 0;
            currentRound = 1;
            currentCycle = 1;
            currentHand = 1;
            coin = 0;
            roundScore = 0;
            targetScore = 0;
            deck = new Deck();

            inventory = new List<Item>(); //생성자 추가
        }

        public int GetSeed()
        {
            return seed;
        }

        public void SetSeed(int value)
        {
            seed = value;
        }

        public int GetCurrentRound()
        {
            return currentRound;
        }

        public void SetCurrentRound(int value)
        {
            currentRound = value;
        }

        public int GetCurrentCycle()
        {
            return currentCycle;
        }

        public void SetCurrentCycle(int value)
        {
            currentCycle = value;
        }

        public int GetCurrentHand()
        {
            return currentHand;
        }

        public void SetCurrentHand(int value)
        {
            currentHand = value;
        }

        public int GetCoin()
        {
            return coin;
        }

        public void SetCoin(int value)
        {
            coin = value;
        }

        public void AddCoin(int amount)
        {
            coin += amount;
        }

        public void SubtractCoin(int amount)
        {
            coin -= amount;
            if (coin < 0) coin = 0;
        }

        public int GetRoundScore()
        {
            return roundScore;
        }

        public void SetRoundScore(int value)
        {
            roundScore = value;
        }

        public void AddRoundScore(int amount)
        {
            roundScore += amount;
        }

        public int GetTargetScore()
        {
            return targetScore;
        }

        public void SetTargetScore(int value)
        {
            targetScore = value;
        }

        public Deck GetDeck()
        {
            return deck;
        }

        public void ResetRoundScore()
        {
            roundScore = 0;
        }

        public void NextHand()
        {
            currentHand++;
        }

        public void NextRound()
        {
            currentRound++;
            currentHand = 1;
            roundScore = 0;
        }

        public bool IsTargetReached()
        {
            return roundScore >= targetScore;
        }

        public int GetRemainingHands()
        {
            return 4 - currentHand + 1;
        }

        public List<Item> GetInventory()
        {
            return inventory;
        }

        public void AddItem(Item item)
        {
            inventory.Add(item);
        }
    }
}