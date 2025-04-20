using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Configuration;
using static System.Console;
using System.Threading;

namespace MonsterHunter_Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeaponDb wdb = GetNewWeaponDb();
            List<MonsterHunterWeapon> weapons = wdb.GetWeapons();

            int option = 0, damageValue = 0, removeId = 0, updateId = 0;
            double damageMultiplier, motionValue = 0, sharpnessMultiplier, damageCalculation;
            string weaponName, weaponClass, sharpnessColor, rank, confirmation;

            PrintHeader();
            WriteLine();
            do
            {
                PrintMenu();
                Write("Enter the number of your choice: ");
                option = int.Parse(ReadLine());
                switch (option)
                {
                    case 1: // Add weapon
                        {
                            // Get user input for weapon details
                            Write("Enter the name of the weapon: ");
                            weaponName = ReadLine();

                            Write("Enter the class of the weapon: ");
                            weaponClass = ReadLine();

                            try
                            {
                                Write("Enter the damage value of the weapon: ");
                                damageValue = int.Parse(ReadLine());
                            }
                            catch (Exception ex)
                            {
                                WriteLine("You must enter an integer...");
                            }

                            try
                            {
                                Write("Enter the motion value of the weapon: ");
                                motionValue = double.Parse(ReadLine());
                            }
                            catch (Exception ex)
                            {
                                WriteLine("You must enter a number between 0 and 1...");
                            }

                            Write("Enter the sharpness color of the weapon: ");
                            sharpnessColor = ReadLine();

                            Write("Enter the rank of the weapon: ");
                            rank = ReadLine();

                            // Create the weapon
                            MonsterHunterWeapon weapon = new MonsterHunterWeapon(weaponName, weaponClass, damageValue, motionValue, sharpnessColor, rank);

                            if (wdb.AddWeapon(weapon))
                            {
                                WriteLine("The weapon was successfully added to the database!");
                            }
                            else
                            {
                                WriteLine("The weapon could not be added to the database...");
                            }
                            WriteLine();
                            break;
                        }
                    case 2: // List all weapons
                        {
                            weapons = wdb.GetWeapons();
                            WeaponWriter.WriteWeaponsToScreen(weapons);
                            WriteLine();
                            break;
                        }
                    case 3: // Update a weapon
                        {
                            try
                            {
                                Write("Enter the ID of the weapon you to update: ");
                                updateId = int.Parse(ReadLine());
                            }
                            catch (Exception ex)
                            {
                                WriteLine("You must enter an integer...");
                            }

                            // Get user input for weapon details
                            Write("Enter the name of the weapon: ");
                            weaponName = ReadLine();

                            Write("Enter the class of the weapon: ");
                            weaponClass = ReadLine();

                            try
                            {
                                Write("Enter the damage value of the weapon: ");
                                damageValue = int.Parse(ReadLine());
                            }
                            catch (Exception ex)
                            {
                                WriteLine("You must enter an integer...");
                            }

                            try
                            {
                                Write("Enter the motion value of the weapon: ");
                                motionValue = double.Parse(ReadLine());
                            }
                            catch (Exception ex)
                            {
                                WriteLine("You must enter a number between 0 and 1...");
                            }

                            Write("Enter the sharpness color of the weapon: ");
                            sharpnessColor = ReadLine();

                            Write("Enter the rank of the weapon: ");
                            rank = ReadLine();

                            MonsterHunterWeapon updateWeapon = new MonsterHunterWeapon(updateId, weaponName, weaponClass, damageValue, motionValue, sharpnessColor, rank);

                            try
                            {
                                wdb.UpdateWeapon(updateWeapon);
                                WriteLine("The weapon was successfully updated in the database!");
                            }
                            catch (Exception ex)
                            {
                                WriteLine("The weapon could not be updated in the database...");
                            }
                            WriteLine();
                            break;
                        }
                    case 4: // Remove a weapon
                        {
                            try
                            {
                                Write("Enter the ID of the weapon you want to remove: ");
                                removeId = int.Parse(ReadLine());
                            }catch (Exception ex)
                            {
                                WriteLine("You must enter an integer...");
                            }
                            
                            if (wdb.RemoveWeapon(removeId))
                            {
                                WriteLine("The weapon was successfully removed from the database!");
                            }
                            else
                            {
                                WriteLine("The weapon could not be removed from the database...");
                            }
                            WriteLine();
                            break;
                        }
                    case 5: // Remove all weapons
                        {
                            Write("Are you sure you want to delete all weapon data? (Y/n) ");
                            confirmation = ReadLine().ToLower();
                            if (confirmation == "y")
                            {
                                if (wdb.RemoveAllWeapons())
                                {
                                    WriteLine("All weapons were successfully deleted from the database!");
                                }
                                else
                                {
                                    WriteLine("Weapon data could not be deleted...");
                                }
                            }
                            WriteLine();
                            break;
                        }
                    case 6: // Exit
                        {
                            WriteLine("Thank you for using this program!");
                            break;
                        }
                    default:
                        {
                            WriteLine("That is not a valid choice. Please try again.");
                            break;
                        }
                }
            } while (option != 6);
        }

        static WeaponDb GetNewWeaponDb()
        {
            string provider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];
            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);
            DbConnection connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            WeaponDb wdb = new WeaponDb(connection);
            return wdb;
        }

        static void PrintHeader()
        {
            WriteLine(new string('*', 50));
            WriteLine($"{"Monster Hunter Weapon Database", 40}");
            WriteLine(new string('*', 50));
        }

        static void PrintMenu()
        {
            WriteLine("What would you like to do?");
            WriteLine("1. Add a weapon\n2. List weapons\n3. Update a weapon\n4. Remove a weapon\n5. Remove all weapons\n6. Exit\n");
        }
    }
}
