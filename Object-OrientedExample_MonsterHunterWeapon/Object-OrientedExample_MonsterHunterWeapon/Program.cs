using System.Buffers.Text;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Threading;
using System;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Object_OrientedExample_MonsterHunterWeapon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintWelcome();
            WriteLine();
            PrintWeaponTypes();

            string weaponNum;
            int damageValue;
            double motionValue;
            string sharpnessColor;
            double motionValueFilter;
            List<MonsterHunterWeapon> weapons = new List<MonsterHunterWeapon>();
            do
            {
                WriteLine();
                //WEAPON TYPE
                Write("Enter a number between 1 and 14 to select your weapon (or type 'quit'): ");
                weaponNum = ReadLine();
                if (weaponNum == "quit")
                {
                    continue;
                }

                //DAMAGE VALUE
                try
                {
                    Write("Now enter the damage value of your selected weapon (Must be an integer): ");
                    damageValue = int.Parse(ReadLine());

                }
                catch (Exception ex) 
                {
                    WriteLine("You needed to enter an integer.");
                    continue;
                }

                //MOTION VALUE
                try
                {
                    Write("Next, enter a motion value between 0 and 1 (Must be a decimal): ");
                    motionValue = double.Parse(ReadLine());
                    if (motionValue < 0 || motionValue > 1)
                    {
                        WriteLine("You needed to enter a motion value between 0 and 1");
                        continue;
                    }

                } catch
                {
                    WriteLine("You need to enter a decimal.");
                    continue;
                }

                //SHARPNESS COLOR
                Write("Lastly, enter the sharpness color of your weapon (red, orange, yellow, green, blue, white): ");
                sharpnessColor = ReadLine().ToLower();
                
                weapons.Add(new MonsterHunterWeapon(weaponNum, damageValue, motionValue, sharpnessColor));
            } while (weaponNum != "quit");

            WriteLine();
            WriteLine(new string('*', 51));
            WriteLine("Here are the weapons you created!");
            PrintWeaponObjs(weapons);

            //Sort the weapons based on highest damage value
            List<MonsterHunterWeapon> sortedDamageValueWeapons = weapons.OrderBy(x => x.DamageValue).ToList();
            WriteLine();
            WriteLine(new string('*', 51));
            WriteLine("Here are your weapons sorted by damage value (DV):");
            PrintWeaponObjs(sortedDamageValueWeapons);

            //Filter the weapons based on motion value greater than input value
            WriteLine(new string('*', 51));
            Write("Enter a value to filter your weapons by motion value (MV):");
            motionValueFilter = double.Parse(ReadLine());
            List<MonsterHunterWeapon> filterMotionValueWeapons = weapons.Where(x => x.MotionValue >= motionValueFilter).ToList();
            List<MonsterHunterWeapon> sortFilteredMotionValueWeapons = filterMotionValueWeapons.OrderBy(x => x.MotionValue).ToList();
            WriteLine();
            WriteLine();
            WriteLine("Here are your weapons filtered by the motion value (MV) you provided:");
            PrintWeaponObjs(sortFilteredMotionValueWeapons);
        }

        static void PrintWelcome()
        {
            WriteLine(new string('*', 51));
            WriteLine($"{"Monster Hunter Weapons V1", 38}");
            WriteLine(new string('*', 51));

            WriteLine();
            WriteLine("This program allows you to create a weapon based on " +
                "\none of 14 weapon classes from the Monster Hunter video game.");
            WriteLine("You will be asked to enter several values:\n");
            WriteLine("1. Enter a number that corresponds to a weapon type.");
            WriteLine("2. Enter your weapon's damage value stat.");
            WriteLine("3. Enter your weapon's motion value" +
                "\n\t- The motion value is a multiplier that determines" +
                "\n\thow much damage your weapon's attack will deal." +
                "\n\tHigher values mean higher damage");
            WriteLine("4. Enter your weapon's sharpness color" +
                "\n\t- Each color has a corresponding multiplier that increases" +
                "\n\tor decreases your weapon's damage. Warmer colors mean" +
                "\n\tyour weapon is getting dull. Cooler colors mean your" +
                "\n\tweapon is sharper.");
        }
 

        static void PrintWeaponTypes()
        {
            WriteLine("These are the 14 Monster Hunter weapon classes:");
            WriteLine($"1.  Great Sword\n2.  Hammer\n3.  Hunting Horn\n4.  Charge Blade\n5.  Switch Axe\n6.  Long Sword\n7.  Insect Glaive\n8.  Lance\n9.  Gunlance\n10. Heavy Bowgun\n11. Sword and Sheild\n12. Dual Blades\n13. Light Bowgun\n14. Bow");
        }

        static void PrintWeaponObjs(List<MonsterHunterWeapon> weapons)
        {
            foreach (MonsterHunterWeapon weapon in weapons)
            {
                WriteLine(weapon);
                WriteLine($"With this weapon, you will deal {weapon.CalculateDamage(),0:F1} damage!");
                WriteLine();
            }
        }
    }
}
