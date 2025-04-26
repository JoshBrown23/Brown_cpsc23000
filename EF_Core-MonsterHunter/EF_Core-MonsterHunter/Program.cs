using System.Collections.Immutable;
using System.Diagnostics.Metrics;
using Microsoft.EntityFrameworkCore;
using static System.Console;

namespace EF_Core_MonsterHunter
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (WeaponDbContext db = new WeaponDbContext())
            {
                //Create hunters
                Hunter Josh, Adam, Ray;

                //Check if there are any currently in the database
                if (!db.Hunters.Any())
                {
                    Josh = new Hunter { HunterName = "Josh", HunterRank = 150 };
                    Adam = new Hunter { HunterName = "Adam", HunterRank = 14 };
                    Ray = new Hunter { HunterName = "Ray", HunterRank = 75 };
                    db.Hunters.AddRange(Josh, Adam, Ray);
                    await db.SaveChangesAsync();

                    // Seed weapon data
                    // I generated this weapon data using ChatGPT.
                    List<Weapon> weapons = new List<Weapon>
                    {
                        new Weapon{Name = "Wyvern Jawblade", WeaponClass = "Great Sword", DamageValue = 1200, DamageMultiplier = .48,  MotionValue = 0.9, SharpnessColor = "blue", SharpnessMultiplier = 1.2, Rank = "high rank", HunterId = Ray.Id },
                        new Weapon{Name = "Azure Serpentblade", WeaponClass =  "Long Sword", DamageValue = 950, DamageMultiplier = .33, MotionValue = 0.65, SharpnessColor = "white", SharpnessMultiplier = 1.32, Rank = "master rank", HunterId = Adam.Id },
                        new Weapon{Name = "Thunder Blitz", WeaponClass = "Light Bowgun", DamageValue = 240, DamageMultiplier = .13, MotionValue = 0.4, SharpnessColor = "yellow", SharpnessMultiplier = 1, Rank = "high rank", HunterId = Ray.Id },
                        new Weapon{Name = "Tusk Lance", WeaponClass = "Lance", DamageValue = 700, DamageMultiplier = .23, MotionValue = .55, SharpnessColor = "green", SharpnessMultiplier = 1.05, Rank = "low rank", HunterId = Ray.Id },
                        new Weapon{Name = "Venomedge Claws", WeaponClass = "Dual Blades", DamageValue = 560, DamageMultiplier = .14, MotionValue = .35, SharpnessColor = "blue", SharpnessMultiplier = 1.2, Rank = "master rank", HunterId = Josh.Id },
                        new Weapon{Name = "Infernal Executioner", WeaponClass = "Switch Axe", DamageValue = 1280, DamageMultiplier = .35, MotionValue = .78, SharpnessColor = "white", SharpnessMultiplier = 1.32, Rank = "master rank", HunterId = Adam.Id },
                        new Weapon{Name = "Iron Tempest", WeaponClass = "Hammer", DamageValue = 1100, DamageMultiplier = .52, MotionValue = .88, SharpnessColor = "blue", SharpnessMultiplier = 1.2, Rank = "high rank", HunterId = Josh.Id },
                        new Weapon{Name = "Abyss Piercer", WeaponClass = "Insect Glaive", DamageValue = 870, DamageMultiplier = .31, MotionValue = .6, SharpnessColor = "white", SharpnessMultiplier = 1.32, Rank = "master rank", HunterId = Josh.Id },
                        new Weapon{Name = "Crimson Howl", WeaponClass = "Hunting Horn", DamageValue = 990, DamageMultiplier = .42, MotionValue = .7, SharpnessColor = "blue", SharpnessMultiplier = 1.2, Rank = "high rank", HunterId = Josh.Id },
                        new Weapon{Name = "Frostbite Fang", WeaponClass = "Sword and Shield", DamageValue = 620, DamageMultiplier = .14, MotionValue = .5, SharpnessColor = "white", SharpnessMultiplier = 1.32, Rank = "high rank", HunterId = Adam.Id }
                    };

                    db.Weapons.AddRange(weapons);
                    await db.SaveChangesAsync();
                }
                else
                {
                    Josh = await db.Hunters.FirstOrDefaultAsync(h => h.HunterName == "Josh");
                    Adam = await db.Hunters.FirstOrDefaultAsync(h => h.HunterName == "Adam");
                    Ray = await db.Hunters.FirstOrDefaultAsync(h => h.HunterName == "Ray");
                }
                //Run queries

                // 1. Fetch all rows and columns from each table
                WriteLine("Here are all of the registered weapons and hunters!");
                List<Weapon> allWeapons = await db.Weapons.ToListAsync();
                foreach (Weapon weapon in allWeapons)
                {
                    WriteLine(weapon);
                    WriteLine();
                }
                WriteLine();
                List<Hunter> allHunters = await db.Hunters.ToListAsync();
                foreach (Hunter hunter in allHunters) 
                { 
                    WriteLine(hunter); 
                }
                WriteLine();
                Write("Press enter to continue...");
                ReadLine();

                // 2. Fetch a specific number of rows based on user input
                WriteLine("Next, let's retrieve a set number of weapons!");
                Write("Enter the number of weapons you would like to retrieve: ");
                int numWeapons = int.Parse(ReadLine());
                List<Weapon> nAmountOfWeapons = await db.Weapons
                    .Take(numWeapons)
                    .ToListAsync();
                foreach (Weapon weapon in nAmountOfWeapons)
                {
                    WriteLine(weapon);
                    WriteLine();
                }
                WriteLine();
                Write("Press enter to continue...");
                ReadLine();

                // 3. Fetch the first weapon from the DB if its damage value is greater than 1000
                //    If the condition is true, show the retrieved value
                //    Otherwise, state that the value is null
                WriteLine("Now let's see if the first weapon in the database has a damage value over 1000!");
                Weapon firstWeaponOverOneThousand = await db.Weapons
                    .FirstOrDefaultAsync(w => w.Id == 1 && w.DamageValue > 1000);

                if (firstWeaponOverOneThousand != null)
                {
                    WriteLine($"The first weapon's damage value is {firstWeaponOverOneThousand.DamageValue}");
                }
                else
                {
                    WriteLine("The first weapon's damage value is not over 1000...");
                }
                WriteLine();
                Write("Press enter to continue...");
                ReadLine();

                // 4. Sort and list the data from the weapons table by
                // name (ascending) and damage value (descending)
                WriteLine("Now let's sort the data by name (ascending) and damage value (descending)!");
                List<Weapon> sortByNameAndDamageValue = await db.Weapons
                    .OrderBy(w => w.Name)
                    .ThenByDescending(w => w.DamageValue)
                    .ToListAsync();
                foreach(Weapon weapon in sortByNameAndDamageValue)
                {
                    WriteLine(weapon);
                    WriteLine();
                }
                WriteLine();
                Write("Press enter to continue...");
                ReadLine();

                // 5. Fetch a subset of the weapon data (both rows and cols)
                WriteLine("New let's retrieve a subset of the weapon data (Id, Name, Damage Value > 900)");
                var subsetWeapons = await db.Weapons
                    .Select(x => new {x.Id, x.Name, x.DamageValue})
                    .Where(w => w.DamageValue > 900)
                    .ToListAsync();
                foreach(var w in subsetWeapons)
                {
                    WriteLine($"{w.Id}\t{w.Name}\t{w.DamageValue}");
                }
                WriteLine();
                Write("Press enter to continue...");
                ReadLine();

                // 6. Fetch a subset of data while joining both tables
                //    Filtered by SharpnessColor and HunterName
                //    Sorted by Name
                WriteLine("Now let's retrieve a subset of data from both the weapon and hunter tables!");
                WriteLine("Only weapons with a Sharpness Color of blue or with a HunterId of 1 will be retrieved.");
                var blueOrJosh = await db.Weapons
                    .Select(x => new {x.Id, x.Name, x.SharpnessColor, x.Hunter.HunterName})
                    .Where(w => w.SharpnessColor == "blue" || w.HunterName == Josh.HunterName)
                    .OrderBy(w => w.Name)
                    .ToListAsync();
                foreach (var boj in blueOrJosh)
                {
                    WriteLine($"{boj.Id}\t{boj.Name}\t{boj.SharpnessColor}\t{boj.HunterName}");
                }
                WriteLine();
                Write("Press enter to continue...");
                ReadLine();

                // 7. Perform a count query that finds the total number of weapons each hunter owns
                WriteLine("Now let's count how many weapons each Hunter owns!");
                var numWeaponsPerHunter = await db.Weapons
                    .GroupBy(w => w.Hunter)
                    .Select(x => new {Hunter = x.Key, Count = x.Count()})
                    .ToListAsync();
                foreach (var w in  numWeaponsPerHunter)
                {
                    WriteLine($"{w.Hunter}\t# of Weapons: {w.Count}");
                }
                WriteLine();
                Write("Press enter to continue...");
                ReadLine();

                // 8. Additional Query:
                //    This query returns the number of weapons with
                //    white sharpness owned by each Hunter
                //    Ordered by the count descending
                WriteLine("Lastly, let's retrieve and sort (descending) the number of weapons each Hunter owns that has white sharpness!");
                var numWhiteWeaponsPerHunter = await db.Weapons
                    .GroupBy(w => w.Hunter)
                    .Select(x => new {Hunter = x.Key , WhiteCount = x.Count(w => w.SharpnessColor == "white") })
                    .OrderByDescending(x => x.WhiteCount)
                    .ToListAsync();
                foreach (var w in numWhiteWeaponsPerHunter)
                {
                    WriteLine($"{w.Hunter}\t# of Weapons w/ White Sharpness: {w.WhiteCount}");
                }
            }

            /** 
             * The reason we should use asynchronous functions when working with a database is
             * because the speed of these queries can and will be affected by network traffic.
             * To limit the affects of this lag, we can use async functions to run the queries 
             * on a separate thread. Running them on a separate thread allows the user to 
             * continue using the application while waiting for the queries to finish executing.
            **/
        }
    }
}
