using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_TheSpire
{
    public class GameSaveData
    {
        public int Seed { get; set; }
        public int RandomCallCount { get; set; } //난수 호출 횟수. 시드 재현용
        public int CurrentChapter { get; set; }
        public int CurrentCycle { get; set; }
        public int CurrentRound { get; set; } //빠져있어서 추가함. 라운드도 저장해야 함
        public int Coin { get; set; }
        public int CycleScore { get; set; }
        public int TargetScore { get; set; }
        public List<CardSaveData> Deck { get; set; }
        public List<int> InventoryItemIds { get; set; }

        public GameSaveData()
        {
            Deck = new List<CardSaveData>();
            InventoryItemIds = new List<int>();
        }
    }
}