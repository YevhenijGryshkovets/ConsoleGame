using System;
using System.Data.Entity;
using System.Linq;

namespace EntitiesCodeFirstMethod.DataModel
{
    public class GameDataBaseContext : DbContext
    {
        public GameDataBaseContext()
            : base("name=GameDbConnectionString")
        {
        }
        public DbSet<Player> Players { get; set; }
        public DbSet<WeaponType> WeaponTypes { get; set; }
        public DbSet<ArmorType> ArmorTypes { get; set;}
        public DbSet<Armor> Armors { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
    }
}