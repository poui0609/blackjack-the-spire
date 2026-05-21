using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_TheSpire
{
    internal static class ItemManager
    {
        public static List<Item> allItems = new List<Item>()
        {  // 아이템 번호, 아이템 이름, 설명, 가격, 효과 적용
            new BlackJack_TheSpire.Item(1, "이름1", "설명1", 10, (gameState)=> {}),
            new BlackJack_TheSpire.Item(2, "이름2", "설명2", 15, (gameState)=> {}),
            new BlackJack_TheSpire.Item(3, "이름3", "설명3", 20, (gameState)=> {}),
            new BlackJack_TheSpire.Item(4, "이름4", "설명4", 10, (gameState)=> {}),
            new BlackJack_TheSpire.Item(5, "이름5", "설명5", 15, (gameState)=> {}),
            new BlackJack_TheSpire.Item(6, "이름6", "설명6", 20, (gameState)=> {}),
            new BlackJack_TheSpire.Item(7, "이름7", "설명7", 10, (gameState)=> {}),
            new BlackJack_TheSpire.Item(8, "이름8", "설명8", 15, (gameState)=> {}),
            new BlackJack_TheSpire.Item(9, "이름9", "설명9", 20, (gameState)=> {}),
            new BlackJack_TheSpire.Item(10, "이름10", "설명10", 10, (gameState)=> {}),
            new BlackJack_TheSpire.Item(11, "이름11", "설명11", 15, (gameState)=> {}),
            new BlackJack_TheSpire.Item(12, "이름12", "설명12", 20, (gameState)=> {}),
            new BlackJack_TheSpire.Item(13, "이름13", "설명13", 10, (gameState)=> {}),
            new BlackJack_TheSpire.Item(14, "이름14", "설명14", 15, (gameState)=> {}),
            new BlackJack_TheSpire.Item(15, "이름15", "설명15", 20, (gameState)=> {}),
        };

        public static Item GetRandomItem()
        {
            int index = GameRandom.Next(allItems.Count);
            return allItems[index];
        }
    }
}
