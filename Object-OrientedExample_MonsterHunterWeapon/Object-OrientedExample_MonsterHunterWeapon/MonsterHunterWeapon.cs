using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_OrientedExample_MonsterHunterWeapon
{
    internal class MonsterHunterWeapon
    {
        private string name;
        private int damageValue;
        private double damageMultiplier;
        private double motionValue;
        private string sharpnessColor;
        private double sharpnessMultiplier;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                switch(value)
                {
                    case "1": 
                        {
                            name = "Great Sword";
                            break;
                        }
                    case "2":
                        {
                            name = "Hammer";
                            break;
                        }
                    case "3":
                        {
                            name = "Hunting Horn";
                            break;
                        }
                    case "4":
                        {
                            name = "Charge Blade";
                            break;
                        }
                    case "5":
                        {
                            name = "Switch Axe";
                            break;
                        }
                    case "6":
                        {
                            name = "Long Sword";
                            break;
                        }
                    case "7":
                        {
                            name = "Insect Glaive";
                            break;
                        }
                    case "8":
                        {
                            name = "Lance";
                            break;
                        }
                    case "9":
                        {
                            name = "Gunlance";
                            break;
                        }
                    case "10":
                        {
                            name = "Heavy Bowgun";
                            break;
                        }
                    case "11":
                        {
                            name = "Sword and Shield";
                            break;
                        }
                    case "12":
                        {
                            name = "Dual Blades";
                            break;
                        }
                    case "13":
                        {
                            name = "Light Bowgun";
                            break;
                        }
                    case "14":
                        {
                            name = "Bow";
                            break;
                        }
                    default: 
                        {
                            name = "Weapon";
                            break;
                        }
                }
            }
        }

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
                switch (Name)
                {
                    case "Hammer":
                        {
                            damageMultiplier = 5.2;
                            break;
                        }
                    case "Great Sword":
                        {
                            damageMultiplier = 4.8;
                            break;
                        }
                    case "Hunting Horn":
                        {
                            damageMultiplier = 4.2;
                            break;
                        }
                    case "Charge Blade":
                        {
                            damageMultiplier = 3.6;
                            break;
                        }
                    case "Switch Axe":
                        {
                            damageMultiplier = 3.5;
                            break;
                        }
                    case "Long Sword": 
                        {
                            damageMultiplier = 3.3;
                            break;
                        }
                    case "Insect Glaive":
                        {
                            damageMultiplier = 3.1;
                            break;
                        }
                    case "Lance":
                        {
                            damageMultiplier = 2.3;
                            break;
                        }
                    case "Gunlance":
                        {
                            damageMultiplier = 2.3;
                            break;
                        }
                    case "Heavy Bowgun":
                        {
                            damageMultiplier = 1.5;
                            break;
                        }
                    case "Sword and Shield":
                        {
                            damageMultiplier = 1.4;
                            break;
                        }
                    case "Dual Blades":
                        {
                            damageMultiplier = 1.4;
                            break;
                        }
                    case "Light Bowgun": 
                        {
                            damageMultiplier = 1.3;
                            break;
                        }
                    case "Bow":
                        {
                            damageMultiplier = 1.2;
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
            Name = "1";
            DamageValue = 500;
            DamageMultiplier = damageMultiplier;
            MotionValue = 0.5;
            SharpnessColor = "yellow";
            SharpnessMultiplier = sharpnessMultiplier;
        }

        public MonsterHunterWeapon(string weaponNum, int damageValue, double motionValue, string sharpnessColor )
        {
            Name = weaponNum;
            DamageValue = damageValue;
            DamageMultiplier = damageMultiplier;
            MotionValue = motionValue;
            SharpnessColor= sharpnessColor;
            SharpnessMultiplier = sharpnessMultiplier;
        }

        public double CalculateDamage()
        {
            return ((DamageValue / DamageMultiplier) * MotionValue * SharpnessMultiplier) / 0.45;
        }

        public override string ToString()
        {
            return $"Name:{Name, 18}\nDV:{DamageValue, 20}\nDM:{DamageMultiplier ,20}\nMV:{MotionValue, 20}\nColor:{SharpnessColor, 17}\nSM:{SharpnessMultiplier, 20}";
        }
    } 
}