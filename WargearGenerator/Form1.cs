using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WargearGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            clearForm();
            
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            var random = new Random();
            Wargear gear;
            Rarity rarity;
            buttonGen.Enabled = false;
            buttonClear.Enabled = true;

            //type
            if (typeRandom.Checked)
            {
                int rand = random.Next(1, 4);
                if (rand == 1)
                {
                    if (radioButtonSM.Checked)
                    {
                        gear = new RangedWeaponSM();
                    }
                    else
                    {
                        gear = new RangedWeaponOrks();
                    }

                }
                else if (rand == 2)
                {
                    if (radioButtonSM.Checked)
                    {
                        gear = new MeleeWeaponSM();
                    }
                    else
                    {
                        gear = new MeleeWeaponOrks();
                    }
                }
                else
                {
                    if (radioButtonSM.Checked)
                    {
                        gear = new ItemSM();
                    }
                    else
                    {
                        gear = new ItemOrks();
                    }
                }
            }
            else if (typeWeapon.Checked)
            {
                int rand = random.Next(1, 3);
                if (rand == 1)
                {
                    if (radioButtonSM.Checked)
                    {
                        gear = new RangedWeaponSM();
                    }
                    else
                    {
                        gear = new RangedWeaponOrks();
                    }
                }
                else
                {
                    if (radioButtonSM.Checked)
                    {
                        gear = new MeleeWeaponSM();
                    }
                    else
                    {
                        gear = new MeleeWeaponOrks();
                    }
                }
            }
            else if (typeRanged.Checked)
            {
                if (radioButtonSM.Checked)
                {
                    gear = new RangedWeaponSM();
                }
                else
                {
                    gear = new RangedWeaponOrks();
                }
            }
            else if (typeMelee.Checked)
            {
                if (radioButtonSM.Checked)
                {
                    gear = new MeleeWeaponSM();
                }
                else
                {
                    gear = new MeleeWeaponOrks();
                }
            }
            else
            {
                if (radioButtonSM.Checked)
                {
                    gear = new ItemSM();
                }
                else
                {
                    gear = new ItemOrks();
                }
            }

            //rarity
            int randRarity = random.Next(1, 101);
            if (rarityRandom.Checked)
            {
                if (randRarity < 41)
                {
                    rarity = Rarity.Common;
                }
                else if (randRarity >= 41 && randRarity < 71)
                {
                    rarity = Rarity.Uncommon;
                }
                else if (randRarity >= 71 && randRarity < 91)
                {
                    rarity = Rarity.Rare;
                }
                else
                {
                    rarity = Rarity.Legendary;
                }
            }
            else if (rarityCommon.Checked)
            {
                rarity = Rarity.Common;
            }
            else if (rarityUncommon.Checked)
            {
                rarity = Rarity.Uncommon;
            }
            else if (rarityRare.Checked)
            {
                rarity = Rarity.Rare;
            }
            else
            {
                rarity = Rarity.Legendary;
            }
            

            gear.Generate(rarity);
            display(gear);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            buttonGen.Enabled = true;
            buttonClear.Enabled = false;
            clearForm();
        }

        private void clearForm()
        {
            labelWeapName.Text = string.Empty;
            labelRange.Text = string.Empty;
            labelAttacks.Text = string.Empty;
            labelSkill.Text = string.Empty;
            labelStrength.Text = string.Empty;
            labelAP.Text = string.Empty;
            labelDamage.Text = string.Empty;
            labelKeywords.Text = string.Empty;
            labelRarity.Text = string.Empty;
        }

        private void display(Wargear gear)
        {
            if (gear.Type == ItemType.Melee || gear.Type == ItemType.Ranged)
            {
                Weapon weap = (Weapon)gear;

                if (weap.Rarity == Rarity.Rare)
                {
                    labelRarity.Text = "Rare";
                }
                else if (weap.Rarity == Rarity.Common)
                {
                    labelRarity.Text = "Common";
                }
                else if (weap.Rarity == Rarity.Uncommon)
                {
                    labelRarity.Text = "Uncommon";
                }
                else if (weap.Rarity == Rarity.Legendary)
                {
                    labelRarity.Text = "Legendary";
                }
                labelWeapName.Text = weap.Name;

                if (weap.Range == 0)
                {
                    labelRange.Text = "Melee";
                }
                else
                {
                    labelRange.Text = weap.Range.ToString() + "\"";
                }
                labelAttacks.Text = weap.Attacks;
                if (weap.Skill == 0)
                {
                    labelSkill.Text = "N/A";
                }
                else
                {
                    labelSkill.Text = "+" + weap.Skill.ToString();
                }
                labelStrength.Text = weap.Strength.ToString();
                if(weap.AP == 0)
                {
                    labelAP.Text = weap.AP.ToString();
                }
                else
                {
                    labelAP.Text = "-" + weap.AP.ToString();
                }
                labelDamage.Text = weap.Damage;

                //write keywords
                if (weap.Keywords.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("[");
                    for (int i = 0; i < weap.Keywords.Count-1; i++)
                    {
                        sb.Append(weap.Keywords[i]);
                        sb.Append(", ");
                    }
                    sb.Append(weap.Keywords.Last());
                    sb.Append("]");
                    labelKeywords.Text = sb.ToString();
                }
            }
        }

    }
}
