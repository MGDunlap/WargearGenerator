using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WargearGenerator
{
    internal abstract class Weapon : Wargear
    {
        private int range;
        private string attacks;
        private int skill;
        private int strength;
        private int aP;
        private string damage;
        private List<string> keywords;

        public int Range { get => range; set => range = value; }
        public string Attacks { get => attacks; set => attacks = value; }
        public int Skill { get => skill; set => skill = value; }
        public int Strength { get => strength; set => strength = value; }
        public int AP { get => aP; set => aP = value; }
        public string Damage { get => damage; set => damage = value; }
        public List<string> Keywords { get => keywords; set => keywords = value; }

        public Weapon()
        {
            Keywords = new List<string>();
        }
        /// <summary>
        /// Add additional damage to the damage string
        /// </summary>
        /// <param name="damage"></param>
        protected void AddDamage(int damage)
        {
            string dHold = Damage;

            if (Int32.TryParse(dHold, out int num))
            {
                damage += num;
                Damage = damage.ToString();
            }
            else
            {
                Damage = dHold + "+" + damage.ToString();
            }
        }
        /// <summary>
        /// Add additional attacks to attacks
        /// </summary>
        /// <param name="attack">The number to add</param>
        protected void AddAttacks(int attack)
        {
            string aHold = Attacks;

            if (Int32.TryParse(aHold, out int num))
            {
                attack += num;
                Attacks = attack.ToString();
            }
            else
            {
                Attacks = aHold + "+" + attack.ToString();
            }
        }
    }
}
