using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Item
    {
        public int Strength { get; set; }
        public int Ability { get; set; }
        public int Intelligence { get; set; }


        public Item(int strength, int ability, int intelligence)
        {
            this.Strength = strength;
            this.Ability = ability;
            this.Intelligence = intelligence;
        }


        public override string ToString()
        {
            StringBuilder item = new StringBuilder();
            item.AppendLine("Item:");
            item.AppendLine($"  *  Strength: {this.Strength}");
            item.AppendLine($"  *  Ability: {this.Ability}");
            item.AppendLine($"  *  Intelligence: {this.Intelligence}");
            return item.ToString();
        }



    }
}
