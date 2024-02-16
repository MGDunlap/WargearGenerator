using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WargearGenerator
{
    internal class ItemSM : Wargear
    {
        private string description;

        public ItemSM()
        {
            type = ItemType.Item;
        }

        public string Description { get => description; set => description = value; }

        public override void Generate(Rarity r)
        {
            this.rarity = r;
            GenerateType();
        }

        private void GenerateType()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());

            int roll = random.Next(1, 101);

            if (roll == 0)
            {

            }
        }
    }
}
