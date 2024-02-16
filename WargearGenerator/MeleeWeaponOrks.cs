using System;

namespace WargearGenerator
{
    internal class MeleeWeaponOrks : Weapon
    {
        private MeleeTypeOrk _meleeType;
        private int bonuses;
        private string _prefix;
        private string _suffix;
        public MeleeWeaponOrks() 
        {
            type = ItemType.Melee;
            Range = 0;
        }

        public override void Generate(Rarity rarity)
        {
            this.rarity = rarity;
            GenerateType();
            GenerateForm();
            GenerateBonuses();
            GenerateKeywords();
            AppendName();
        }
        /// <summary>
        /// Generate type of melee weapon (weapon, chainsword, fist, hammer, claws)
        /// </summary>
        private void GenerateType()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            int roll = random.Next(1, 101);
            
            if (roll < 51) //50%
            {
                _meleeType = MeleeTypeOrk.Choppa;

                name = "Choppa";
                Attacks = "4";
                Skill = 3;
                Strength = 5;
                AP = 1;
                Damage = "1";
            }
            else if (roll >= 51 && roll <= 85)//35%
            {
                _meleeType = MeleeTypeOrk.Klaw;

                name = "Power klaw";
                Attacks = "3";
                Skill = 4;
                Strength = 9;
                AP = 2;
                Damage = "2";
            }
            else//15%
            {
                _meleeType = MeleeTypeOrk.Killsaw;

                name = "Killsaw";
                Attacks = "2";
                Skill = 4;
                Strength = 12;
                AP = 3;
                Damage = "2";
            }
            


        }
        /// <summary>
        /// Generate form of Choppas and killsaws
        /// </summary>
        private void GenerateForm()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            int form = random.Next(1, 101);

            if (_meleeType == MeleeTypeOrk.Choppa)
            {
                if (form <= 20)
                {
                    name = "Big choppa";
                    Attacks = "3";
                    Skill = 3;
                    Strength = 7;
                    AP = 1;
                    Damage = "2";
                }
                else if (form > 20 && form <= 40)
                {
                    name = "'Uge choppa";
                    Attacks = "4";
                    Skill = 2;
                    Strength = 12;
                    AP = 2;
                    Damage = "2";
                }else if (form > 92)
                {
                    name = "Twin choppa";
                    Keywords.Add("TWIN-LINKED");

                }
            }
            else if (_meleeType == MeleeTypeOrk.Killsaw)
            {
                if (form > 75)
                {
                    name = "Twin killsaw";
                    Keywords.Add("TWIN-LINKED");
                }

            }
        }
        /// <summary>
        /// Generate number of bonuses and bonus prefix per rarity
        /// </summary>
        private void GenerateBonuses()
        {

            switch (rarity)
            {
                case Rarity.Common:
                    bonuses = 1;
                    break;
                case Rarity.Uncommon:
                    bonuses = 2;
                    break;
                case Rarity.Rare:
                    bonuses = 3;
                    break;
                case Rarity.Legendary:
                    bonuses = 4;
                    break;
            }

            var random = new Random(Guid.NewGuid().GetHashCode());
            bool gen = true;
            bool doItAgain = false;
            bool isMC = false;
            bool isRelic = false;
            bool isFury = false;
            

            while (gen)
            {
                int check = random.Next(1, 101);
                if (check > 61 && check <= 70 && !isMC)
                {
                    isMC = true;
                    _prefix += "Speshul ";
                    AddDamage(1);
                    bonuses--;
                }
                else if (check > 71 && check <= 90 && !isRelic)
                {
                    isRelic = true;
                    _prefix += "Snazzy ";
                    AP++;
                    bonuses--;
                }
                else if (check > 91 && !isFury)
                {
                    isFury = true;
                    _prefix += "Killy ";
                    bonuses--;
                    Strength++;
                }

                if (bonuses > 1 && !doItAgain)
                {
                    doItAgain = true;
                }
                if (bonuses < 3)
                {
                    gen = false;
                }
            }
        }

        private void GenerateKeywords()
        {
            bool hasSustained = false;
            bool hasAntiInf = false;
            bool hasAntiVeh = false;
            bool hasAntiMon = false;
            bool hasLethal = false;
            bool hasDevastating = false;
            bool hasPrecision = false;
            bool hasExtra = false;
            bool hasLance = false;



            //Random Bonus Keywords
            var rand = new Random(Guid.NewGuid().GetHashCode());


            while (bonuses > 0)
            {
                int roll = rand.Next(1, 101);
                if (roll <= 15 && !hasSustained)
                {
                    Keywords.Add("SUSTAINED HITS 1");
                    hasSustained = true;
                    bonuses--;
                }
                else if (roll >= 16 && roll <= 30 && !hasLethal)
                {
                    Keywords.Add("LETHAL HITS");
                    hasLethal = true;
                    bonuses--;
                }
                else if (roll >= 31 && roll <= 45 && !hasDevastating)
                {
                    Keywords.Add("DEVASTATING WOUNDS");
                    hasDevastating = true;
                    bonuses--;
                }
                else if (roll >= 46 && roll <= 60 && !hasPrecision)
                {
                    Keywords.Add("PRECISION");
                    hasPrecision = true;
                    bonuses--;
                }
                else if (roll >= 61 && roll <= 75 && !hasExtra)
                {
                    Keywords.Add("EXTRA ATTACKS");
                    hasExtra = true;
                    bonuses--;
                }
                else if (roll >= 76 && roll <= 90 && !hasLance)
                {
                    Keywords.Add("LANCE");
                    hasLance = true;
                    bonuses--;
                }
                else
                {
                    int anti = rand.Next(1, 101);
                    int value = 4;

                    if (rarity == Rarity.Legendary)
                    {
                        value = 3;
                    }
                    
                    if (anti <= 33 && !hasAntiInf)
                    {
                        Keywords.Add("ANTI-INFANTRY " + value + "+");
                        hasAntiInf = true;
                    }
                    else if (anti >= 34 && anti <= 66 && !hasAntiMon)
                    {
                        Keywords.Add("ANTI-MONSTER " + value + "+");
                        hasAntiMon = true;
                    }
                    else if (!hasAntiVeh)
                    {
                        Keywords.Add("ANTI-VEHICLE " + value + "+");
                        hasAntiVeh = true;
                    }
                    bonuses--;
                }
            }
        }
        /// <summary>
        /// Append the final name of the weapon
        /// </summary>
        private void AppendName()
        {
            name = _prefix + Name + _suffix;
        }
    }

    enum MeleeTypeOrk
    {
        Klaw,
        Choppa,
        Killsaw
    }
}
