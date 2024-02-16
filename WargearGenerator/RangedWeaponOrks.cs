using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WargearGenerator
{
    internal class RangedWeaponOrks : Weapon
    {
        private RangeTypeOrk _rangeType;
        private bool _isGun;
        private bool _isHeavy;
        private bool _isPistol;
        private bool _isKombi;
        private string _prefix;
        private string _suffix;
        private int bonuses;

        public RangedWeaponOrks()
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
        /// Generate the type of weapon (Shoota,Slugga,KMB,Rokkit,Skorcha)
        /// </summary>
        private void GenerateType()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());

            int roll = random.Next(1, 101);

            if (roll <= 45)
            {
                _rangeType = RangeTypeOrk.Shoota;
                name = "Shoota";

                Range = 18;
                Attacks = "2";
                Skill = 5;
                Strength = 4;
                AP = 0;
                Damage = "1";
            }
            else if (roll > 45 && roll <= 60)
            {
                _rangeType = RangeTypeOrk.KMB;
                name = "Kustom mega-";

                Range = 24;
                Attacks = "3";
                Skill = 5;
                Strength = 9;
                AP = 2;
                Damage = "D6";
            }
            else if (roll > 60 && roll <= 80)
            {
                _rangeType = RangeTypeOrk.Skorcha;
                name = "Skorcha";
                
                Range = 12;
                Attacks = "D6";
                Skill = 0;
                Strength = 5;
                AP = 1;
                Damage = "1";
            }
            else
            {
                _rangeType = RangeTypeOrk.Rokkit;
                name = "Rokkit launcha";

                Range = 24;
                Attacks = "D3";
                Skill = 5;
                Strength = 9;
                AP = 2;
                Damage = "3";
            }
        }
        /// <summary>
        /// Generate the form of the weapon
        /// </summary>
        private void GenerateForm()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            int form = random.Next(1, 101);

            if (form < 56)//Regular, big shoota 55%
            {
                _isGun = true;
                if (_rangeType == RangeTypeOrk.Shoota)
                {
                    int roll = random.Next(1, 101);
                    if (roll > 50 && roll <= 75) //Make Kustom 25%
                    {
                        _isKombi = true;
                        name = "Kustom shoota";
                        Attacks = "4";
                    }
                    if (roll > 75)//Make big shoota 25%
                    {
                        _isHeavy = true;
                        _suffix = string.Empty;
                        name = "Big shoota";
                        Range = 36;
                        Attacks = "3";
                        Strength = 5;
                    }
                }

                if (_rangeType == RangeTypeOrk.KMB)
                {
                    _suffix = "blasta";
                    _prefix = string.Empty;
                }

            }
            else//Pistol 
            {
                if (_rangeType != RangeTypeOrk.Skorcha)
                {
                    _isPistol = true;
                }
                if (_rangeType == RangeTypeOrk.Shoota)
                {
                    name = "Slugga";
                    Range = 12;
                    Attacks = "1";
                }
                else if (_rangeType == RangeTypeOrk.KMB)
                {
                    _suffix = "slugga";
                    _prefix = string.Empty;
                    Range = 12;
                    Attacks = "D3";
                    Skill = 5;
                    Strength = 8;
                    AP = 2;
                    Damage = "D6";
                }
                else if (_rangeType == RangeTypeOrk.Rokkit)
                {
                    name = "Pair of rokkit Pistols";
                    Range = 12;
                    Attacks = "1";
                    Skill = 5;
                    Strength = 7;
                    AP = 1;
                    Damage = "D3";
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
                    _prefix += "Speshul ";
                    AddDamage(1);
                    bonuses--;
                }
                else if (check > 71 && check <=90 && !isRelic)
                {
                    isRelic = true;
                    _prefix += "Snazzy ";
                    AP++;
                    bonuses--;
                }
                else if (check > 91 && !isAuto)
                {
                    isAuto = true;
                    _prefix += "Dakka ";
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

            if (_rangeType == RangeTypeOrk.Shoota && _isPistol == false)
            {
                if (_isHeavy)
                {
                    Keywords.Add("RAPID FIRE 2");
                }
                else if (_isKombi)
                {
                    Keywords.Add("RAPID FIRE 2");
                    hasCombi = true;
                }
                else
                {
                    Keywords.Add("RAPID FIRE 1");
                }
                hasRapid = true;
            }
            else if (_rangeType == RangeTypeOrk.Rokkit)
            {
                Keywords.Add("BLAST");
            }
            else if (_rangeType == RangeTypeOrk.KMB)
            {
                Keywords.Add("HAZARDOUS");
                if (_isPistol)
                {
                    Keywords.Add("BLAST");
                }
            }
            else if (_rangeType == RangeTypeOrk.Skorcha)
            {
                Keywords.Add("IGNORES COVER");
                Keywords.Add("TORRENT");
                hasIgnoreCover = true;
            }

            if (_isPistol)
            {
                Keywords.Add("PISTOL");
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
                else if (roll >= 21 && roll < 31 && !hasSustained && _rangeType != RangeTypeOrk.Skorcha)
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
                else if (roll >= 41 && roll < 51 && !hasLethal && _rangeType != RangeTypeOrk.Skorcha)
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
                else if (roll >= 81 && roll < 91 && !hasCombi && _isGun && _rangeType != RangeTypeOrk.KMB && _rangeType != RangeTypeOrk.Shoota)
                {
                    Keywords.Add("KOMBI");
                    hasCombi = true;
                    _isKombi = true;
                    if (_rangeType == RangeTypeOrk.Skorcha)
                    {
                        name = "Kombi-Skorcha";
                    }
                    else if (_rangeType == RangeTypeOrk.Rokkit)
                    {
                        name = "Kombi-Rokkit";
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

    enum RangeTypeOrk
    {
        Shoota,
        KMB,
        Rokkit,
        Skorcha
    }
}
