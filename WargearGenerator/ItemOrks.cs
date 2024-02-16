using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WargearGenerator
{
    internal class ItemOrks : Wargear
    {
        private string description;

        public ItemOrks()
        {
            type = ItemType.Item;
        }

        public string Description { get => description; set => description = value; }

        public override void Generate(Rarity r)
        {
            throw new NotImplementedException();
        }
    }
}
