using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_TheSpire
{
    public class CardSaveData
    {
        public int Type { get; set; }
        public int Value { get; set; }
        public int CustomBlackjackValue { get; set; }
        public bool HasCustomValue { get; set; }
    }
}