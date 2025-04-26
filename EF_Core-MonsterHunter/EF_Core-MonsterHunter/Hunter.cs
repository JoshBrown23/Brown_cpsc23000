using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_MonsterHunter
{
    internal class Hunter
    {
        public int Id { get; set; }

        public string HunterName { get; set; }

        public int HunterRank { get; set; }

        // navigation property
        public List<Weapon> Weapons;

        public override string ToString()
        {
            return $"ID: {Id}\tName: {HunterName}\tRank: {HunterRank}";
        }
    }
}
