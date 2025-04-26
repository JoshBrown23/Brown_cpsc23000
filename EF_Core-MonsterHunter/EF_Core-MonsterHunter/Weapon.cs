using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_MonsterHunter
{
    internal class Weapon
    {
        private int damageValue;
        private double damageMultiplier;
        private double motionValue;
        private string sharpnessColor;
        private double sharpnessMultiplier;
        private Dictionary<string, double> damageMultipliers = new Dictionary<string, double>
        {
            {"Hammer", 0.52},
            {"Great Sword", 0.48},
            {"Hunting Horn", 0.42},
            {"Charge Blade", 0.36},
            {"Switch Axe", 0.35},
            {"Long Sword", 0.33},
            {"Insect Glaive", 0.31},
            {"Lance", 0.23},
            {"Gunlance", 0.23},
            {"Heavy Bowgun", 0.15},
            {"Sword and Shield", 0.14},
            {"Dual Blades", 0.14},
            {"Light Bowgun", 0.13},
            {"Bow", 0.12}
        };
        private Dictionary<string, double> sharpnessMultipliers = new Dictionary<string, double>
        {
            {"red", 0.5},
            {"orange", 0.75},
            {"yellow" ,1},
            {"green" ,1.05},
            {"blue" ,1.2},
            {"white" ,1.32}
        };

        public int Id { get; set; }
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
                if (damageMultipliers.ContainsKey(WeaponClass))
                {
                    damageMultiplier = damageMultipliers[WeaponClass];
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
                if (sharpnessMultipliers.ContainsKey(SharpnessColor))
                {
                    sharpnessMultiplier = sharpnessMultipliers[sharpnessColor];

                }
            }
        }

        public string Rank { get; set; }
        public int HunterId { get; set; } // foreign key
        public Hunter Hunter { get; set; }


        public Weapon()
        {
            Id = 0;
            Name = "";
            WeaponClass = "";
            DamageValue = 500;
            DamageMultiplier = damageMultiplier;
            MotionValue = 0.5;
            SharpnessColor = "yellow";
            SharpnessMultiplier = sharpnessMultiplier;
            Rank = "LR";
        }

        public Weapon(string name, string weaponClass, int damageValue, double motionValue, string sharpnessColor, string rank, int hunterId)
        {
            Name = name;
            WeaponClass = weaponClass;
            DamageValue = damageValue;
            DamageMultiplier = damageMultiplier;
            MotionValue = motionValue;
            SharpnessColor = sharpnessColor;
            SharpnessMultiplier = sharpnessMultiplier;
            Rank = rank;
            HunterId = hunterId;
        }

        public override string ToString()
        {
            return $"ID:{Id,22}\nName:{Name,20}\nClass:{WeaponClass,19}\nDamage Value:{DamageValue,12}\nDamage Mult:{DamageMultiplier,13:F2}\nMotion Value:{MotionValue,12:F2}\nSharpness Color:{SharpnessColor,9}\nSharpness Mult:{SharpnessMultiplier,10:F2}\nRank:{Rank,20}\nHunter ID: {HunterId, 14}";
        }

        public string ToTabDelimitedString()
        {
            return $"{Id}\t{Name}\t{WeaponClass}\t{DamageValue}\t{DamageMultiplier}\t{MotionValue}\t{SharpnessColor}\t{SharpnessMultiplier}\t{Rank}\t{HunterId}";
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
