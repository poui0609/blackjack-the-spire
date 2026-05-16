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
        {
            new BlackJack_TheSpire.Item(1, "이름1", "효과1", 100), new BlackJack_TheSpire.Item(1, "이름2", "효과2", 150), new BlackJack_TheSpire.Item(1, "이름3", "효과3", 200)
        };

        public static Item GetRandomItem()
        {
            int index = GameRandom.Next(allItems.Count);
            return allItems[index];
        }
    }
}
