using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WindowsForms_Monster_Hunter.Models;
using WindowsForms_Monster_Hunter.Views;



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
        public void AddWeapon(string name, string weaponClass, int damageValue, double motionValue, string sharpnessColor)
        {
            MonsterHunterWeapon? existing = weapons.Find(w => w.Name == name);
            MonsterHunterWeapon newWeapon;
            if (existing == null)
            {
                newWeapon = new MonsterHunterWeapon(name, weaponClass, damageValue, motionValue, sharpnessColor);
                weapons.Add(newWeapon);
            }
            else
            {
                existing.WeaponClass = weaponClass;
                existing.DamageValue = damageValue;
                existing.MotionValue = motionValue;
                existing.UpdateSharpness(sharpnessColor);
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
                result.Add("");
            }
            return result;
        }

        //This function ensures that all text fields have some kind of information to pass along
        //If a field is empty, an error message may be displayed
        public bool ValidateEntries(string name, string weaponClass, string damageValue, string motionValue, string sharpnessColor)
        {
            if(name == "" || weaponClass == "" || damageValue == "" || motionValue == "" || sharpnessColor == "") 
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
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
