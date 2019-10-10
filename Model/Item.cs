using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int BaseGold { get; set; } // Cost to buy with ingredient items ready
        public int TotalGold { get; set; } // Cost to buy without ingredient items
        public int SellGold { get; set; }
        }
}
