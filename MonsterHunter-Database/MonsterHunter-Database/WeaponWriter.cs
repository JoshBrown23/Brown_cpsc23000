using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunter_Database
{
    internal class WeaponWriter
    {
        public static void WriteWeaponsToScreen(List<MonsterHunterWeapon> weapons)
        {
            foreach (MonsterHunterWeapon weapon in weapons)
            {
                Console.WriteLine(weapon);
                Console.WriteLine();
            }
        }
    }
}
