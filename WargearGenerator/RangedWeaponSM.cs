using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WargearGenerator
{
    internal class RangedWeaponSM : Weapon
    {
        private RangeType _rangeType;
        private bool _isGun;
        private bool _isHeavy;
        private bool _isPistol;
        private bool _isStorm;
        private string _prefix;
        private string _suffix;
        private int bonuses;

        public RangedWeaponSM()
        {
            type = ItemType.Ranged;
        }

        public override void Generate(Rarity rarity)
        {
            this.rarity = rarity;
            GenerateType();
            GenerateForm();
            GenerateBonus(rarity);
            GenerateKeywords(rarity);
            AppendName();
        }
        /// <summary>
        /// Generate the type of weapon (Bolt, Grav, Plasma, Melta, Flamer)
        /// </summary>
        private void GenerateType()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());

            int roll = random.Next(1, 101);

            if (roll <= 40) //40%
            {
                _rangeType = RangeType.Bolt;
                name = "Bolt";

                Range = 24;
                Attacks = "1";
                Skill = 3;
                Strength = 4;
                AP = 0;
                Damage = "1";
            }
            else if (roll > 40 && roll <= 55) //15%
            {
                _rangeType = RangeType.Flamer;
                name = "Flamer";
                
                Range = 12;
                Attacks = "D6";
                Skill = 0;
                Strength = 4;
                AP = 0;
                Damage = "1";
            }
            else if (roll > 50 && roll <= 70)//15%
            {
                _rangeType = RangeType.Grav;
                name = "Grav-";

                Range = 18;
                Attacks = "2";
                Skill = 3;
                Strength = 5;
                AP = 1;
                Damage = "2";
            }
            else if (roll > 70 && roll <= 85)
            {
                _rangeType = RangeType.Plasma;
                name = "Plasma";
                
                Range = 24;
                Attacks = "1";
                Skill = 3;
                Strength = 7;
                AP = 2;
                Damage = "1";
            }
            else
            {
                _rangeType = RangeType.Melta;
                name = "Melta";

                Range = 12;
                Attacks = "1";
                Skill = 3;
                Strength = 9;
                AP = 4;
                Damage = "D6";
            }
        }
        /// <summary>
        /// Generate the form of the weapon (Pistol, Gun, Heavy)
        /// </summary>
        private void GenerateForm()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            int form = random.Next(1, 101);

            if (form < 51)//gun
            {
                _isGun = true;
                if (_rangeType == RangeType.Grav || _rangeType == RangeType.Bolt)
                {
                    _suffix = "gun";
                }
                else if (_rangeType != RangeType.Flamer)
                {
                    _suffix = " gun";
                }

                //detour to make a Storm Bolter
                int roll = random.Next(1, 11);
                if (roll > 9 && _rangeType == RangeType.Bolt)
                {
                    _isStorm = true;
                    _suffix = string.Empty;
                    name = "Storm bolter";
                    Attacks = "2";
                }
            }
            else if (form > 50 && form <= 75)//pistol
            {
                _isPistol = true;
                if (_rangeType == RangeType.Grav)
                {
                    _suffix = "pistol";
                    Range = 12;
                    Attacks = "1";
                    Strength = 4;
                    AP = 1;
                    Damage = "2";
                }
                else if (_rangeType == RangeType.Melta)
                {
                    name = "Inferno";
                    _suffix = " pistol";
                    Range = 6;
                    Attacks = "1";
                    Strength = 8;
                    AP = 4;
                    Damage = "D6";
                }
                else if (_rangeType == RangeType.Flamer)
                {
                    name = "Hand Flamer";
                    Range = 12;
                    Attacks = "D6";
                    Strength = 3;
                    AP = 0;
                    Damage = "1";
                }
                else
                {
                    _suffix = " pistol";
                    Range = 12;
                }
            }
            else//Heavy
            {
                _isHeavy = true;
                if (_rangeType == RangeType.Bolt)
                {
                    name = "Heavy bolter";
                    Range = 36;
                    Attacks = "3";
                    Skill = 4;
                    Strength = 5;
                    AP = 1;
                    Damage = "2";
                }
                else if (_rangeType == RangeType.Melta)
                {
                    name = "Multi-melta";
                    Range = 18;
                    Attacks = "2";
                }
                else if (_rangeType == RangeType.Grav)
                {
                    _suffix = "cannon";
                    Range = 24;
                    Attacks = "3";
                    Skill = 4;
                    Strength = 6;
                    AP = 1;
                    Damage = "3";
                }
                else if (_rangeType == RangeType.Flamer)
                {
                    name = "Heavy flamer";
                    Range = 12;
                    Attacks = "D6";
                    Skill = 0;
                    Strength = 5;
                    AP = 1;
                    Damage = "1";
                }
                else
                {
                    _suffix = " cannon";
                    Range = 36;
                    Attacks = "D3";
                    Skill = 4;
                }
            }
        }
        /// <summary>
        /// Generate the rarity bonuses the weapon will recieve
        /// </summary>
        /// <param name="rarity"></param>
        private void GenerateBonus(Rarity rarity)
        {
            var random = new Random(Guid.NewGuid().GetHashCode());

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

            //Generate prefix bonuses
            bool gen = true;
            bool doItAgain = false;
            bool isMC = false;
            bool isRelic = false;
            bool isAuto = false;

            while (gen)
            {
                int check = random.Next(1,101);
                if (check > 61 && check <= 70 && !isMC)
                {
                    isMC = true;
                    _prefix += "Master-crafted ";
                    AddDamage(1);
                    bonuses--;
                }
                else if (check > 71 && check <=90 && !isRelic)
                {
                    isRelic = true;
                    _prefix += "Relic ";
                    AP++;
                    bonuses--;
                }
                else if (check > 91 && !isAuto)
                {
                    isAuto = true;
                    _prefix += "Auto ";
                    bonuses--;
                    if (rarity == Rarity.Legendary)
                    {
                        AddAttacks(2);
                    }
                    else
                    {
                        AddAttacks(1);
                    }
                    
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
        /// <summary>
        /// Generate Keywords for the weapon, both required keywords for the weapon type and bonus keywords for rarity
        /// </summary>
        /// <param name="rarity"></param>
        private void GenerateKeywords(Rarity rarity)
        {
            bool hasSustained = false;
            bool hasRapid = false;
            bool hasIgnoreCover = false;
            bool hasAnti = false;
            bool hasCombi = false;
            bool hasLethal = false;
            bool hasDevastating = false;
            bool hasAssault = false;
            bool hasPrecision = false;

            if (_rangeType == RangeType.Grav)
            {
                Keywords.Add("ANTI-VEHICLE 2+");
                hasAnti = true;
            }
            else if (_rangeType == RangeType.Melta)
            {
                Keywords.Add("MELTA 2");
            }
            else if (_rangeType == RangeType.Plasma)
            {
                Keywords.Add("PLASMA");
                if (!_isPistol && !_isHeavy)
                {
                    Keywords.Add("RAPID FIRE 1");
                    hasRapid = true;
                }
            }
            else if (_rangeType == RangeType.Flamer)
            {
                Keywords.Add("IGNORES COVER");
                Keywords.Add("TORRENT");
                hasIgnoreCover = true;
            }

            if (_isPistol)
            {
                Keywords.Add("PISTOL");
            }

            if (_isHeavy)
            {
                if (_rangeType != RangeType.Flamer)
                {
                    Keywords.Add("HEAVY");
                }
                if (_rangeType == RangeType.Bolt)
                {
                    if (rarity == Rarity.Legendary)
                    {
                        Keywords.Add("SUSTAINED HITS 2");
                    }
                    else
                    {
                        Keywords.Add("SUSTAINED HITS 1");
                    }
                    hasSustained = true;
                }
                else if (_rangeType == RangeType.Plasma)
                {
                    Keywords.Add("BLAST");
                }
            }

            if (_isStorm)
            {
                if (rarity == Rarity.Legendary)
                {
                    Keywords.Add("RAPID FIRE 3");
                }
                else
                {
                    Keywords.Add("RAPID FIRE 2");
                }
                hasRapid = true;
            }

            //-----Random bonus keywords-----

            var rand = new Random(Guid.NewGuid().GetHashCode());
            while (bonuses > 0)
            {
                int roll = rand.Next(1, 101);
                if (roll < 11 && !hasRapid)
                {
                    if (rarity == Rarity.Legendary)
                    {
                        int shots = rand.Next(1, 4);
                        Keywords.Add("RAPID FIRE " + shots.ToString());
                    }
                    else
                    {
                        Keywords.Add("RAPID FIRE 1");
                    }
                    hasRapid = true;
                    bonuses--;
                }
                else if (roll >= 11 && roll < 21 && !hasIgnoreCover)
                {
                    Keywords.Add("IGNORES COVER");
                    hasIgnoreCover = true;
                    bonuses--;
                }
                else if (roll >= 21 && roll < 31 && !hasSustained && _rangeType != RangeType.Flamer)
                {
                    if (rarity == Rarity.Legendary)
                    {
                        int shots = rand.Next(1, 3);
                        Keywords.Add("SUSTAINED HITS " + shots.ToString());
                    }
                    else
                    {
                        Keywords.Add("SUSTAINED HITS 1");
                    }
                    hasSustained = true;
                    bonuses--;
                }
                else if (roll >= 31 && roll < 41 && !hasAnti)
                {
                    int antiType = rand.Next(1, 3);
                    string key;
                    if (antiType == 1)
                    {
                        key = "INFANTRY";
                    }
                    else if (antiType == 2)
                    {
                        key = "MONSTER";
                    }
                    else
                    {
                        key = "VEHICLE";
                    }
                    Keywords.Add("ANTI-" + key + " 4+");
                    hasAnti = true;
                    bonuses--;
                }
                else if (roll >= 41 && roll < 51 && !hasLethal && _rangeType != RangeType.Flamer)
                {
                    Keywords.Add("LETHAL HITS");
                    hasLethal = true;
                    bonuses--;
                }
                else if (roll >= 51 && roll < 61 && !hasDevastating)
                {
                    Keywords.Add("DEVASTATING WOUNDS");
                    hasDevastating = true;
                    bonuses--;
                }
                else if (roll >= 61 && roll < 71 && !hasPrecision)
                {
                    Keywords.Add("PRECISION");
                    hasPrecision = true;
                    bonuses--;
                }
                else if (roll >= 71 && roll < 81 && !hasAssault)
                {
                    Keywords.Add("ASSAULT");
                    hasAssault = true;
                    bonuses--;
                }
                else if (roll >= 81 && roll < 91 && !hasCombi && _isGun && _rangeType != RangeType.Bolt)
                {
                    Keywords.Add("COMBI");
                    hasCombi = true;
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

    enum RangeType
    {
        Bolt,
        Grav,
        Plasma,
        Melta,
        Flamer
    }
}
