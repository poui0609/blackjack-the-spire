using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_TheSpire
{
    internal class Mission
    {
        public int Id;
        public string Name;
        public string Description;
        public double BonusMultiplier;
        public bool IsCompleted;

        public Func<Hand, bool> Condition;

        public Mission(int id, string name, string description, double bonusMultiplier, Func<Hand, bool> condition)
        {
            Id = id;
            Name = name;
            Description = description;
            BonusMultiplier = bonusMultiplier;
            IsCompleted = false;
            Condition = condition;
        }

        public bool Check(Hand hand)
        {
            return Condition(hand);
        }
    }
}
