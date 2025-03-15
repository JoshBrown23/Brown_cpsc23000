using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Monster_Hunter.Models
{
    public class MonsterHunterWeapon
    {
        private int damageValue;
        private double damageMultiplier;
        private double motionValue;
        private string sharpnessColor;
        private double sharpnessMultiplier;

        public string Name { get; set; }

        public string WeaponClass { get; set; }

        public int DamageValue
        {
            get
            {
                return damageValue;
            }
            set
            {
                if (value < 0)
                {
                    damageValue = 1;
                }
                else
                {
                    damageValue = value;
                }
            }
        }

        public double DamageMultiplier
        {
            get
            {
                return damageMultiplier;
            }
            set
            {
                switch (WeaponClass)
                {
                    case "Hammer":
                        {
                            damageMultiplier = .52;
                            break;
                        }
                    case "Great Sword":
                        {
                            damageMultiplier = .48;
                            break;
                        }
                    case "Hunting Horn":
                        {
                            damageMultiplier = .42;
                            break;
                        }
                    case "Charge Blade":
                        {
                            damageMultiplier = .36;
                            break;
                        }
                    case "Switch Axe":
                        {
                            damageMultiplier = .35;
                            break;
                        }
                    case "Long Sword":
                        {
                            damageMultiplier = .33;
                            break;
                        }
                    case "Insect Glaive":
                        {
                            damageMultiplier = .31;
                            break;
                        }
                    case "Lance":
                        {
                            damageMultiplier = .23;
                            break;
                        }
                    case "Gunlance":
                        {
                            damageMultiplier = .23;
                            break;
                        }
                    case "Heavy Bowgun":
                        {
                            damageMultiplier = .15;
                            break;
                        }
                    case "Sword and Shield":
                        {
                            damageMultiplier = .14;
                            break;
                        }
                    case "Dual Blades":
                        {
                            damageMultiplier = .14;
                            break;
                        }
                    case "Light Bowgun":
                        {
                            damageMultiplier = .13;
                            break;
                        }
                    case "Bow":
                        {
                            damageMultiplier = .12;
                            break;
                        }
                    default:
                        {
                            damageMultiplier = 1;
                            break;
                        }
                }
            }
        }

        public double MotionValue
        {
            get
            {
                return motionValue;
            }
            set
            {
                motionValue = value;
            }
        }

        public string SharpnessColor
        {
            get
            {
                return sharpnessColor;
            }
            set
            {
                sharpnessColor = value;
            }
        }

        public double SharpnessMultiplier
        {
            get
            {
                return sharpnessMultiplier;
            }
            set
            {
                switch (SharpnessColor)
                {
                    case "red":
                        {
                            sharpnessMultiplier = 0.5;
                            break;
                        }
                    case "orange":
                        {
                            sharpnessMultiplier = 0.75;
                            break;
                        }
                    case "yellow":
                        {
                            sharpnessMultiplier = 1;
                            break;
                        }
                    case "green":
                        {
                            sharpnessMultiplier = 1.05;
                            break;
                        }
                    case "blue":
                        {
                            sharpnessMultiplier = 1.2;
                            break;
                        }
                    case "white":
                        {
                            sharpnessMultiplier = 1.32;
                            break;
                        }
                    default:
                        {
                            SharpnessColor = "yellow";
                            sharpnessMultiplier = 1;
                            break;
                        }
                }
            }
        }

        public MonsterHunterWeapon()
        {
            Name = "";
            WeaponClass = "";
            DamageValue = 500;
            DamageMultiplier = damageMultiplier;
            MotionValue = 0.5;
            SharpnessColor = "yellow";
            SharpnessMultiplier = sharpnessMultiplier;
        }

        public MonsterHunterWeapon(string name, string weaponClass, int damageValue, double motionValue, string sharpnessColor)
        {
            Name = name;
            WeaponClass = weaponClass;
            DamageValue = damageValue;
            DamageMultiplier = damageMultiplier;
            MotionValue = motionValue;
            SharpnessColor = sharpnessColor;
            SharpnessMultiplier = sharpnessMultiplier;
        }

        //This function calculates how much damage a single strike from your weapon will deal
        public double CalculateDamage()
        {
            return (DamageValue * DamageMultiplier * MotionValue * SharpnessMultiplier) / 0.45;
        }

        public override string ToString()
        {
            return $"Name:{Name}\nClass:{WeaponClass,18}\nDV:{DamageValue,20}\nDM:{DamageMultiplier,20}\nMV:{MotionValue,20}\nColor:{SharpnessColor,17}\nSM:{SharpnessMultiplier,20}";
        }

        //If the sharpness color is updated, the multiplier needs to be updated as well.
        //This function takes in the new sharpness color and recalculates and updates the multiplier
        public void UpdateSharpness(string sharpnessColor)
        {
            SharpnessColor = sharpnessColor;
            SharpnessMultiplier = sharpnessMultiplier;
        }
    }
}
