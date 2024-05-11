using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WargearGenerator
{
    internal class ItemSM : Wargear
    {
        
        public ItemForm _itemForm;
        private string _limitingKeywords;
        private bool _isVehicle;
        private bool _isMounted;
        private bool _isLeader;
        private bool _isInfantry;
        private bool _isWalker;

        public ItemSM()
        {
            type = ItemType.Item;
        }

        public override void Generate(Rarity r)
        {
            this.rarity = r;
            GenerateType();
            GenerateText();
        }

        /// <summary>
        /// Generate form of item
        /// </summary>
        private void GenerateType()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());

            int roll = random.Next(1, 101);

            if (roll <= 40)
            {
                _itemForm = ItemForm.Armor;
            }
            else if (roll <= 70 && roll > 40)
            {
                _itemForm = ItemForm.Grenade;
                
            }
            else if (roll > 70)
            {
                _itemForm = ItemForm.Wonderous;
            }
        }

        private void GenerateText()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());

            int roll = random.Next(1, 101);

            if (_itemForm == ItemForm.Armor)
            {
                //set limiting keywords and type of armor
                int armorRoll = random.Next(1, 101);
                if (armorRoll <= 40)
                {
                    _limitingKeywords += "INFANTRY ";
                    _isInfantry = true;
                }
                else if (armorRoll <= 70 && armorRoll > 40)
                {
                    _limitingKeywords += "MOUNTED ";
                    _isMounted = true;
                }
                else if (armorRoll > 70)
                {
                    _limitingKeywords += "VEHICLE ";
                    _isVehicle = true;

                    int vehicleRoll = random.Next(1, 101);
                    if (vehicleRoll >= 50)
                    {
                        _limitingKeywords += "WALKER ";
                        _isWalker = true;
                    }
                }
                GenerateArmorText();

            }//gredanes
            else if (_itemForm == ItemForm.Grenade)
            {
                _limitingKeywords += "GRENADES ";
                GenerateGrenadeText();

            }
            //Generate wonderous limiting keywords
            else if (_itemForm == ItemForm.Wonderous)
            {
                int armorRoll = random.Next(1, 101);
                if (armorRoll <= 40)
                {
                    _limitingKeywords += "INFANTRY ";
                    _isInfantry = true;
                }
                else if (armorRoll <= 70 && armorRoll > 40)
                {
                    _limitingKeywords += "MOUNTED ";
                    _isMounted = true;
                }
                else if (armorRoll > 70)
                {
                    _limitingKeywords += "VEHICLE ";
                    _isVehicle = true;
                }
                GenerateWonderousText();
            }
        }

        private void GenerateArmorText()
        {

            var random = new Random(Guid.NewGuid().GetHashCode());

            string[] _name;
            string[] _prefix;
            string[] _descrip;

            var value = (low: 4, high: 6, gen: 1);

            if (rarity == Rarity.Uncommon)
            {
                value = (low: 3, high: 5, gen: 1);
            }
            else if (rarity == Rarity.Rare)
            {
                value = (low: 3, high: 4, gen: 2);
            }
            else if (rarity == Rarity.Legendary)
            {
                value = (low: 2, high: 3, gen: 2);
            }

            if (_isInfantry)
            {
                _name = new string[] { "Glory", "Plate", "Armor", "Mantle", "Defender", "Shield", "Aegis", "Barding" };
                _prefix = new string[] {"Artificer's ", "Holy ", "Blessed ", "Hardened ", "Vindicted ", "Stoic ", "Roboute's ",
                    "Ultramar's ", "Veteran's " };
                
                if (rarity == Rarity.Legendary)
                {
                    _descrip = new string[] { $"Increase the bearer's Wounds characteristic by {value.gen}",
                        $"The bearer has a Save characteristic of 2+ and a {value.high}+ invulnerable save",
                        $"The bearer has the Feel No Pain {value.high}+ ability",
                        $"Models in the bearer's unit have the Feel No Pain {value.high}+ ability",
                        $"The bearer has a {value.high}+ invulnerable save, each time a ranged attack targets the bearer's unit, worsen the Armour Penetration characteristic of that attack by 1",};
                }
                else
                {
                    _descrip = new string[] { $"Increase the bearer's Wounds characteristic by {value.gen}",
                        $"The bearer has a Save characteristic of 2+ and a {value.high}+ invulnerable save",
                        $"The bearer has the Feel No Pain {value.high}+ ability",};
                }
            }
            else if (_isMounted)
            {
                _name = new string[] { "Saddle", "Mantle", "Hull", "Frame", "Case", "Aegis", "Barding" };
                _prefix = new string[] {"Armored ", "Blessed ", "Hardened ", "Artificer's ", "Veteran's " };

                _descrip = new string[] { $"Increase the bearer's Wounds characteristic by {value.gen}",
                        $"The bearer has a Save characteristic of 2+ and a {value.high}+ invulnerable save",
                        $"The bearer has the Feel No Pain {value.high}+ ability",
                        $"Increase the bearer's unit's Move characteristic by {value.gen}, you can reroll advance rolls for this unit",
                        $"Add {value.gen} to advance and charge rolls for the bearer's unit",
                        $"The bearer's unit is eligible to shoot or declare a charge (but not both) in a turn in which it advanced or fell back"};
            }
            else if (_isVehicle)
            {
                _name = new string[] { "Mantle", "Hull", "Frame", "Case", "Chassis" ,"Plating"};
                _prefix = new string[] { "Armored ", "Blessed ", "Hardened ", "Artificer's ", "Holy ", "Adamintine ", "Veteran's " };

                _descrip = new string[] { $"Increase the bearer's Wounds characteristic by {value.gen}",
                        $"The bearer has a Save characteristic of 2+ and a {value.high}+ invulnerable save",
                        $"The bearer has the Feel No Pain {value.high}+ ability",
                        $"Increase the bearer's Move characteristic by {value.gen}",
                        $"Add {value.gen} to advance and charge rolls for the bearer",
                        $"This model is eligible to shoot and declare a charge in a turn in which it advanced or fell back",
                        $"At the end of your Command phase, this model regains {value.gen} lost wound(s)"};

                if (_isWalker)
                {
                    _name = new string[] { "Mantle", "Hull", "Frame", "Case", "Chassis", "Sarcophagus", "Plating", "Tomb", "Vault" };
                }
            }
            else
            {
                _name = new string[] { "Default" };
                _prefix = new string[] { "Defualt " };
                _descrip = new string[] { "Defualt " };
            }

            int nameRand = random.Next(_name.Length);
            int prefRand = random.Next(_prefix.Length);
            int descRand = random.Next(_descrip.Length);


            name = _prefix[prefRand] + _name[nameRand];

            description = _limitingKeywords + " model only. " + _descrip[descRand];
        }

        private void GenerateGrenadeText()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());

            string[] _name;
            string[] _prefix;
            string[] _descrip;

            var value = (low: 1, high: 2, gen: 1);

            if (rarity == Rarity.Uncommon)
            {
                value = (low: 2, high: 3, gen: 1);
            }
            else if (rarity == Rarity.Rare)
            {
                value = (low: 3, high: 4, gen: 2);
            }
            else if (rarity == Rarity.Legendary)
            {
                value = (low: 4, high: 5, gen: 2);
            }

            _name = new string[] { "Grenade", "Bomb", "Charge"};
            _prefix = new string[] {"Vortex ", "Cobalt-60 ", "Blind ", "Stunner ", "Exterminatus "};

            _descrip = new string[] { $"Add 1 to the dice roll when using the GRENADE stratagem on this unit",
                        $"Roll an additional {value.low} dice when using the GRENADE stratagem on this unit",
                        $"If an enemy unit suffers mortal wounds as the result of using the GRENADE stratagem on this unit, that unit is unable to use the Overwatch stratagem until the start of your next shooting phase",
                        $"If an enemy unit suffers mortal wounds as the result of using the GRENADE stratagem on this unit, until the end of the phase, add 1 to the hit roll when targeting that unit",
                        $"Roll {value.low} fewer dice when using the GRENADE stratagem on this unit, the target enemy unit suffers {value.high} mortal wounds on a 4+ instead of 1"};

            int nameRand = random.Next(_name.Length);
            int prefRand = random.Next(_prefix.Length);


            name =  _prefix[prefRand] + _name[nameRand];

            description = "SINGLE USE. " + _limitingKeywords + " unit only. " + _descrip[prefRand];

        }

        private void GenerateWonderousText()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());

            string[] _name;
            string[] _prefix;
            string[] _descrip;

            int lead = random.Next(1, 101);

            if (lead > 70)
            {
                _isLeader = true;
            }

            var value = (low: 4, high: 6, gen: 1);

            if (rarity == Rarity.Uncommon)
            {
                value = (low: 3, high: 5, gen: 1);
            }
            else if (rarity == Rarity.Rare)
            {
                value = (low: 2, high: 4, gen: 2);
            }
            else if (rarity == Rarity.Legendary)
            {
                value = (low: 2, high: 3, gen: 3);
            }

            if (_isInfantry)
            {
                _name = new string[] { "The Emperor", "Might", "Justice", "Ultramar", "Hate", "Holy Fire", "the Crusader", "Victory", "Light", "The Omnissiah", "Holy Terra", "Destruction", "Steel" };
                _prefix = new string[] { "Banner of ", "Retribution of ", "Beacon of ", "Insight of ", "Oath of ", "Prayer of ", "Rite of ", "Psalm of ", "Benediction of ", "Hymn of ", "Standard of ", "Iron Halo of " };

                _descrip = new string[] { $"Add {value.gen} to the Attacks and Strength characteristic of the bearer's melee weapons",
                                $"When the bearer makes a melee attack, add 1 to the hit roll",
                                $"When the bearer makes a ranged attack, add 1 to the hit roll",
                                $"The bearer gains the Lone Operative ability",
                                $"Add {value.gen} to the Attacks and Damage characteristic of the bearer's melee weapons",
                                $"Add {value.gen} to the Strength characteristic of the bearer's melee weapons and improve that weapons AP by 1"};
                if (_isLeader)
                {
                    _descrip = new string[] { $"While this model is leading a unit, add {value.gen} to the move characteristic of that unit",
                                $"While this model is leading a unit, that unit gains the Infiltrators ability",
                                $"While this model is leading a unit, that unit gains the Stealth ability",
                                $"While this model is leading a unit, models in that unit have the Feel No Pain {value.high}+ ability",
                                $"While this model is leading a unit, that unit gains the Deep Strike ability and can be set up within D6 + {value.low}\" horizontally away from all enemy models",
                                $"While this model is leading a unit, that unit cannot be targeted by Psychic Attacks",
                                $"While this model is leading a unit, ranged weapons equipped by that unit have the [Anti-Infantry {value.low}+] ability",
                                $"Once per battle, while this model is leading a unit, return D6 - {value.low} destroyed bodyguard models to that unit"};
                }
            }
            else if (_isMounted)
            {
                _name = new string[] { "Default" };
                _prefix = new string[] { "Defualt " };
                _descrip = new string[] { "Defualt " };

            }
            else if (_isVehicle)
            {
                _name = new string[] { "Default" };
                _prefix = new string[] { "Defualt " };
                _descrip = new string[] { "Defualt " };
                if (_isWalker)
                {

                }
            }
            else
            {
                _name = new string[] { "Default" };
                _prefix = new string[] { "Defualt " };
                _descrip = new string[] { "Defualt " };
            }

            int nameRand = random.Next(_name.Length);
            int prefRand = random.Next(_prefix.Length);
            int descRand = random.Next(_descrip.Length);


            name = _prefix[prefRand] + _name[nameRand];

            if (_isLeader)
            {
                description = _limitingKeywords + " Leader unit only. " + _descrip[descRand];
            }
            else
            {
                description = _limitingKeywords + " unit only. " + _descrip[descRand];
            }

            
        }
    }

    enum ItemForm
    {
        Armor,
        Grenade,
        Wonderous
    }
}
