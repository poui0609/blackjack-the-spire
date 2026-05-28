using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_TheSpire
{
    internal static class ItemManager            //아이템 리스트 클래스
    {
        public static List<Item> allItems = new List<Item>()
        {  // 아이템 번호, 아이템 이름, 설명, 가격, 배율 건드리기, 효과 적용
            new Item(1, "황금 주사위", "점수 배율 추가 x1.2", 5, (gameState, hand, multiplier)=> {return multiplier * 1.2; }),
            new Item(2, "VIP 카드", "점수 배율 추가 x1.5", 10, (gameState, hand, multiplier) => {return multiplier * 1.5; }),
            new Item(3, "블랙잭 마스터", "블랙잭시 추가 x2", 8, (gameState, hand, multiplier)=> {bool completed = gameState.GetCurrentMissions().Any(m => m.IsCompleted); if (completed) return multiplier * 1.3; return multiplier; }),
            new Item(4, "Ace 팬던트", "Ace 카드 포함시 x1.5", 8, (gameState, hand, multiplier) => {bool hasAce = hand.GetCards().Any(card => card.GetCardValue() == CardValue.Ace); if (hasAce) return multiplier * 1.5; return multiplier; }),
            new Item(5, "하이리스크 토큰", "카드 합 20 이상시 x2", 10, (gameState, hand, multiplier) => {if (hand.CalculateValue() >= 20) return multiplier * 2.0; return multiplier;}),
            new Item(6, "욕심쟁이 주사위", "카드 5장 이상시 x1.5", 5, (gameState, hand, multiplier) => {if (hand.GetCardCount() >= 5) return multiplier * 1.8; return multiplier;}),
            new Item(7, "도박 중독자", "카드를 뽑을수록 배율 0.1 증가", 8, (gameState, hand, multiplier) => {double bonus = 1.0 + (hand.GetCardCount() * 0.1); return multiplier * bonus; }),
            new Item(8, "코인 지원금", "보유 코인 30 이하일 때 x1.5", 5, (gameState, hand, multiplier) => {if (gameState.GetCoin() <= 30) return multiplier * 1.5; return multiplier; }),
            new Item(9, "마지막 승부", "4라운드에서 카드 2장이면 x2", 10, (gameState, hand, multiplier) => {if (gameState.GetCurrentRound() == 4 && hand.GetCardCount() <= 2) {return multiplier * 2.0;} return multiplier;}),
            new Item(10, "초심자의 행운", "첫 사이클은 배율 x2", 10, (gameState, hand, multiplier) => {if (gameState.GetCurrentCycle() == 1) return multiplier * 2.0; return multiplier;})
            //new Item(10, "이름10", "설명10", 10, (gameState, hand, multiplier)=> {})
        };

        public static Item GetRandomItem()                 //아이템 랜덤으로 뽑는 메소드
        {
            int index = GameRandom.Next(allItems.Count);
            return allItems[index];
        }

        public static Item GetRandomUniqueItem(GameState gameState)
        {
            List<int> usedIds = gameState.GetUsedShopItem();

            List<Item> availableItems =
                allItems.Where(item => !usedIds.Contains(item.Id)).ToList();

            if (availableItems.Count == 0)
            {
                usedIds.Clear();

                availableItems = allItems.ToList();
            }

            int index = GameRandom.Next(availableItems.Count);

            Item selected = availableItems[index];

            usedIds.Add(selected.Id);

            return selected;
        }
    }
}
