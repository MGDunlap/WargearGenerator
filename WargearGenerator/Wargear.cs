using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WargearGenerator
{
    internal abstract class Wargear
    {
        protected string name;
        protected Rarity rarity;
        protected ItemType type;

        public abstract void Generate(Rarity rarity);

        public string Name { get { return name; } }
        public Rarity Rarity { get { return rarity; } }
        public ItemType Type { get { return type; } }

    }

    enum ItemType
    {
        Melee,
        Ranged,
        Item
    }

    enum Rarity
    {
        Common,
        Uncommon,
        Rare,
        Legendary
    }
}
