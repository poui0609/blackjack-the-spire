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
        private int currentChapter;
        private int currentCycle;
        private int currentRound;
        private int coin;
        private int cycleScore;
        private int targetScore;
        private Deck deck;
        private List<Item> inventory;

        public GameState()
        {
            seed = 0;
            currentChapter = 1;
            currentCycle = 1;
            currentRound = 1;
            coin = 0;
            cycleScore = 0;
            targetScore = 0;
            deck = new Deck();
            inventory = new List<Item>();
        }

        public int GetSeed() { return seed; }
        public void SetSeed(int value) { seed = value; }

        public int GetCurrentChapter() { return currentChapter; }
        public void SetCurrentChapter(int value) { currentChapter = value; }

        public int GetCurrentCycle() { return currentCycle; }
        public void SetCurrentCycle(int value) { currentCycle = value; }

        public int GetCurrentRound() { return currentRound; }
        public void SetCurrentRound(int value) { currentRound = value; }

        public int GetCoin() { return coin; }
        public void SetCoin(int value) { coin = value; }

        public void AddCoin(int amount)
        {
            coin += amount;
        }

        public void SubtractCoin(int amount)
        {
            coin -= amount;
            if (coin < 0) coin = 0;
        }

        public int GetCycleScore() { return cycleScore; }
        public void SetCycleScore(int value) { cycleScore = value; }

        public void AddCycleScore(int amount)
        {
            cycleScore += amount;
        }

        public int GetTargetScore() { return targetScore; }
        public void SetTargetScore(int value) { targetScore = value; }

        public Deck GetDeck() { return deck; }

        public bool AddItem(Item item)
        {
            if (inventory.Count >= 5) return false;
            inventory.Add(item);
            return true;
        }

        public void RemoveItem(Item item)
        {
            inventory.Remove(item);
        }

        public List<Item> GetInventory()
        {
            return inventory;
        }

        public int GetInventoryCount()
        {
            return inventory.Count;
        }

        public void ResetCycleScore()
        {
            cycleScore = 0;
        }

        public void NextRound()
        {
            currentRound++;
        }

        public void NextCycle()
        {
            currentCycle++;
            currentRound = 1;
            cycleScore = 0;

            if (currentCycle > 4)
            {
                currentCycle = 1;
                currentChapter++;
            }
        }

        public bool IsTargetReached()
        {
            return cycleScore >= targetScore;
        }

        public int GetRemainingRounds()
        {
            return 4 - currentRound + 1;
        }

        public int CalculateCycleReward()
        {
            return GetRemainingRounds() * 2;
        }

        public bool IsGameClear()
        {
            return currentChapter > 6;
        }
    }
}