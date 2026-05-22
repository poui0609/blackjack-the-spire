using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_TheSpire
{
    internal class Inventory                   //아이템 구현 클래스
    {
        private List<Item> items;

        public Inventory()
        {
            items = new List<Item>();
        }

        public List<Item> GetItems()
        {
            return items;
        }

        public int GetCount()
        {
            return items.Count;
        }

        public bool AddItem(Item item)
        {
            if (items.Count >= 5)
                return false;

            items.Add(item);

            return true;
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
        }

        public Item GetItem(int index)
        {
            return items[index];
        }

        public bool IsFull()
        {
            return items.Count >= 5;
        }

        public void Clear()
        {
            items.Clear();
        }
    }
}
