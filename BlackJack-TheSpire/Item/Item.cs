using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_TheSpire
{
    internal class Item
    {
        public int Id;
        public string Name;
        public string Description;
        public int Price;

        public Action<GameState> Effect;

        public Item(int id, string name, string description, int price, Action<GameState> effect)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Effect = effect;
        }
    }
}
