using BlackJack_TheSpire;
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
        private Boss currentBoss;
        private Deck deck;
        private Inventory inventory;
        private List<Mission> currentMissions;
        private List<int> usedShopItem = new List<int>();
 
        public GameState() //초기값
        {
            seed = 0;
            currentChapter = 1;
            currentCycle = 1;
            currentRound = 1;
            coin = 0;
            cycleScore = 0;
            targetScore = 0;
            deck = new Deck();
            inventory = new Inventory();
            currentMissions = new List<Mission>();
            usedShopItem = new List<int>();
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

        public Inventory GetInventory() { return inventory; }

        public bool AddItem(Item item)
        {
            return inventory.AddItem(item);
        }

        public void RemoveItem(Item item)
        {
            inventory.RemoveItem(item);
        }

        public void ResetCycleScore()
        {
            cycleScore = 0;
        }

        public void NextRound()
        {
            currentRound += 1;
        }

        public void NextCycle() // 사이클 넘기는거 라운드 초기화 같은 기능있음
        {
            currentCycle += 1;
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

        public int GetRemainingRounds() // 남은 라운드 계산. 현재 라운드도 남은 라운드에 포함됨
        {
            return 5 - currentRound ;
        }

        public int CalculateCycleReward()
        {
            return coin/5 + GetRemainingRounds() * 2 ;
        }

        public bool IsGameClear()
        {
            return currentChapter > 6;
        }

        public List<Mission> GetCurrentMissions()
        {
            return currentMissions;
        }

        public void SetCurrentMissions(List<Mission> missions)
        {
            currentMissions = missions;
        }
        public Boss GetCurrentBoss()
        {
            return currentBoss;
        }

        public void SetCurrentBoss(Boss boss)
        {
            currentBoss = boss;
        }

        public List<int> GetUsedShopItem()
        {
            return usedShopItem;
        }
    }
}