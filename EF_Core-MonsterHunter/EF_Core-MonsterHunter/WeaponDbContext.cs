using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_MonsterHunter
{
    internal class WeaponDbContext:DbContext
    {
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Hunter> Hunters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MSI;Initial Catalog=EF_Core-MonsterHunter;Integrated Security=True;Pooling=False;Encrypt=False;Trust Server Certificate=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hunter>()
                .HasMany(h => h.Weapons)
                .WithOne(w => w.Hunter)
                .HasForeignKey(w => w.HunterId);
        }
    }
}
