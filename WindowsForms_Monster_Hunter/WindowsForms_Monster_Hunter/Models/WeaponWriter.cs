using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using WindowsForms_Monster_Hunter.Controllers;

namespace WindowsForms_Monster_Hunter.Models
{
    public class WeaponWriter
    {
        public bool WriteText(List<MonsterHunterWeapon> weapons, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (MonsterHunterWeapon weapon in weapons)
                    {
                        sw.WriteLine(weapon.ToTabDelimitedString());
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ReadJson(string path)
        {
            try
            {
                DataSerializer ds = new DataSerializer();
                ds.JsonDeserializer<List<MonsterHunterWeapon>>(path);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool WriteJson(List<MonsterHunterWeapon> weapons, string path)
        {
            try
            {
                DataSerializer ds = new DataSerializer();
                ds.JsonSerialize<List<MonsterHunterWeapon>>(weapons, path);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
