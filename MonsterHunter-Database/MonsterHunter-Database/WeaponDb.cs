using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Net.Http.Headers;

namespace MonsterHunter_Database
{
    internal class WeaponDb
    {
        private DbConnection conn;
        private DbCommand cmd;
        public WeaponDb (DbConnection conn)
        {
            this.conn = conn;
            cmd = conn.CreateCommand();
        }

        // List all weapons
        public List<MonsterHunterWeapon> GetWeapons()
        {
            cmd.CommandText = "select * from Weapons";
            List<MonsterHunterWeapon> weapons = new List<MonsterHunterWeapon>();
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                int weaponId, damageValue;
                double damageMultiplier, motionValue, sharpnessMultiplier, damageCalculation;
                string weaponName, weaponClass, sharpnessColor, rank;
                while (reader.Read())
                {
                    weaponId = Convert.ToInt32(reader["WeaponId"]);
                    weaponName = Convert.ToString(reader["WeaponName"]);
                    weaponClass = Convert.ToString(reader["WeaponClass"]);
                    damageValue = Convert.ToInt32(reader["DamageValue"]);
                    damageMultiplier = Convert.ToSingle(reader["damageMultiplier"]);
                    motionValue = Convert.ToSingle(reader["MotionValue"]);
                    sharpnessColor = Convert.ToString(reader["SharpnessColor"]);
                    sharpnessMultiplier = Convert.ToSingle(reader["SharpnessMultiplier"]);
                    damageCalculation = Convert.ToSingle(reader["DamageCalculation"]);
                    rank = Convert.ToString(reader["Rank"]);

                    MonsterHunterWeapon newWeapon = new MonsterHunterWeapon(weaponId, weaponName, weaponClass, damageValue, motionValue, sharpnessColor, rank);
                    weapons.Add(newWeapon);
                }
            }
            return weapons;
        }

        // Add a new weapon
        public bool AddWeapon(string weaponName, string weaponClass, string damageValue, string damageMultiplier, string motionValue, string sharpnessColor, string sharpnessMultiplier, string damageCalculation, string rank)
        {
            cmd.CommandText = $"insert into Weapons (WeaponName, WeaponClass, DamageValue, DamageMultiplier, MotionValue, SharpnessColor, SharpnessMultiplier, DamageCalculation, Rank) values ('{weaponName}','{weaponClass}','{damageValue}','{damageMultiplier}','{motionValue}','{sharpnessColor}','{sharpnessMultiplier}','{damageCalculation}','{rank}')";
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddWeapon(MonsterHunterWeapon weapon)
        {
            return AddWeapon(weapon.Name, weapon.WeaponClass, Convert.ToString(weapon.DamageValue), Convert.ToString(weapon.DamageMultiplier), Convert.ToString(weapon.MotionValue), weapon.SharpnessColor, Convert.ToString(weapon.SharpnessMultiplier), Convert.ToString(weapon.DamageCalc), weapon.Rank);
        }

        // Delete a weapon
        public bool RemoveWeapon(int weaponId)
        {
            cmd.CommandText = $"delete from Weapons where WeaponId='{weaponId}'";
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveAllWeapons()
        {
            cmd.CommandText = $"delete from Weapons DBCC CHECKIDENT ('Weapons', RESEED, 0);";
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Update a weapon
        public bool UpdateWeapon(int weaponId, string weaponName, string weaponClass, int damageValue, double damageMultiplier, double motionValue, string sharpnessColor, double sharpnessMultiplier, double damageCalculation, string rank)
        {
            cmd.CommandText = $"update Weapons set WeaponName='{weaponName}', WeaponClass='{weaponClass}', DamageValue='{damageValue}', DamageMultiplier='{damageMultiplier}', MotionValue='{motionValue}', SharpnessColor='{sharpnessColor}', SharpnessMultiplier='{sharpnessMultiplier}', DamageCalculation='{damageCalculation}', Rank='{rank}' where WeaponId='{weaponId}'";
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;    
            }
        }

        public bool UpdateWeapon(MonsterHunterWeapon weapon)
        {
            return UpdateWeapon(weapon.Id, weapon.Name, weapon.WeaponClass, weapon.DamageValue, weapon.DamageMultiplier, weapon.MotionValue, weapon.SharpnessColor, weapon.SharpnessMultiplier, weapon.CalculateDamage(), weapon.Rank);
        }
    }
}
