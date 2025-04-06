using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WindowsForms_Monster_Hunter.Models;
using WindowsForms_Monster_Hunter.Views;
using Utilities;



namespace WindowsForms_Monster_Hunter.Controllers
{
    public class WeaponController
    {
        private List<MonsterHunterWeapon> weapons;
        public WeaponController()
        {
            weapons = new List<MonsterHunterWeapon>();
        }

        //This function helps create new weapons or edit existing ones
        //First, the function will check if the provided name already exists
        //If so, then the other information is used to update the weapon with said name
        //If that name cannot be found, then a new weapon is created instead.
        public void AddWeapon(string name, string weaponClass, int damageValue, double motionValue, string sharpnessColor, string rank)
        {
            MonsterHunterWeapon? existing = weapons.Find(w => w.Name == name);
            MonsterHunterWeapon newWeapon;
            if (existing == null)
            {
                newWeapon = new MonsterHunterWeapon(name, weaponClass, damageValue, motionValue, sharpnessColor, rank);
                weapons.Add(newWeapon);
            }
            else
            {
                existing.WeaponClass = weaponClass;
                existing.DamageValue = damageValue;
                existing.MotionValue = motionValue;
                existing.UpdateSharpness(sharpnessColor);
                existing.Rank = rank;
            }
        }

        //This function generates and returns a list that contains the names of all created weapons
        //This function assists in the filling of the weapon names combo box
        public List<String> GetWeaponNames()
        {
            List<string> names = new List<string>();
            foreach (MonsterHunterWeapon weapon in weapons)
            {
                names.Add(weapon.Name);
            }
            return names;
        }

        //This function generates and returns a list that contains all of a weapon's information
        //This function is called when a weapon(s) is displayed in the rich text box
        public List<string> GetTextOfAllWeapons()
        {
            List<string> result = new List<string>();
            foreach (MonsterHunterWeapon w in weapons)
            {
                result.Add($"Name: {w.Name}");
                result.Add($"Class: {w.WeaponClass}");
                result.Add($"Damage Value: {w.DamageValue}");
                result.Add($"Damage Multiplier: {w.DamageMultiplier}");
                result.Add($"Motion Value: {w.MotionValue}");
                result.Add($"Sharpness Color: {w.SharpnessColor}");
                result.Add($"Shaprness Multiplier: {w.SharpnessMultiplier}");
                result.Add($"Damage Calculation: {w.CalculateDamage(), 0:F2}");
                result.Add($"Rank: {w.Rank}");
                result.Add("");
            }
            return result;
        }

        //This function ensures that all text fields have some kind of information to pass along
        //If a field is empty, an error message may be displayed
        public bool ValidateEntries(string name, string weaponClass, string damageValue, string motionValue, string sharpnessColor, string rank)
        {
            if(name == "" || weaponClass == "" || damageValue == "" || motionValue == "" || sharpnessColor == "" || rank == "") 
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //This function generates and returns a dictionary that contains the information of a specific weapon.
        //The selected weapon is determined by the name passed into the function
        //Only returns information if that weapon is found
        public Dictionary<string, string> GetWeaponDetails(string name)
        {
            MonsterHunterWeapon? existing = weapons.Find(w => w.Name == name);
            Dictionary<string, string> result = new Dictionary<string, string>();
            if (existing != null)
            {
                result.Add("name", existing.Name);
                result.Add("weapon class", existing.WeaponClass);
                result.Add("damage value", existing.DamageValue.ToString());
                result.Add("motion value", existing.MotionValue.ToString());
                result.Add("sharpness color", existing.SharpnessColor);
                result.Add("rank", existing.Rank);
                return result;
            }
            else
            {
                return null;
            }
        }

        public bool ReadWeapon(string path)
        {
            string extension = Path.GetExtension(path);
            if (extension == ".txt")
            {
                string text;
                string[] parts;
                try
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        do
                        {
                            text = sr.ReadLine();
                            parts = text.Split('\t');
                            AddWeapon(parts[0], parts[1], int.Parse(parts[2]), double.Parse(parts[4]), parts[5], parts[7]);
                            Array.Clear(parts);
                        } while (!sr.EndOfStream);
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            else if (extension == ".json")
            {
                try
                {
                    DataSerializer ds = new DataSerializer();
                    List<MonsterHunterWeapon> jsonList = ds.JsonDeserializer<List<MonsterHunterWeapon>>(path);
                    weapons.AddRange(jsonList);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
            
        }

        public bool SaveWeapon(string path)
        {
            string extension = Path.GetExtension(path);
            WeaponWriter ww = new WeaponWriter();
            if (extension == ".txt")
            {
                return ww.WriteText(weapons, path);
            }
            else if (extension == ".json")
            {
                return ww.WriteJson(weapons, path);
            }
            else
            {
                return false;
            }
        }

        public string[] SplitWeaponDataString(string text)
        {
            string[] parts;
            parts = text.Split('\t');
            return parts;
        }

        public List<MonsterHunterWeapon> GetWeapons(string sortBy = "Name")
        {
            if (sortBy == "Name")
            {
                return weapons.OrderBy(w => w.Name).ToList();
            }
            else if (sortBy == "DamageValue")
            {
                return weapons.OrderByDescending(w => w.DamageValue).ToList();
            }
            else
            {
                return weapons;
            }

        }

        public List<MonsterHunterWeapon> UpdateRTBWeapons(List<MonsterHunterWeapon> updatedWeapons)
        {
            weapons = updatedWeapons;
            UpdateWeaponSharpness(weapons);
            UpdateWeaponDamage(weapons);
            return weapons;
        }

        public List<MonsterHunterWeapon> UpdateWeaponSharpness(List<MonsterHunterWeapon> list)
        {
            foreach (MonsterHunterWeapon weapon in list)
            {
                weapon.UpdateSharpness(weapon.SharpnessColor);
            }
            return list;
        }

        public List<MonsterHunterWeapon> UpdateWeaponDamage(List<MonsterHunterWeapon> list)
        {
            foreach (MonsterHunterWeapon weapon in list)
            {
                weapon.DamageCalc = weapon.CalculateDamage();
            }
            return list;
        }
    }
}
