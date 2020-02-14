using UserControlPanel.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace UserControlPanel.DAL
{
    public class CPContext : DbContext
    {

        public CPContext() : base("CPContext")
        {
        }

        public DbSet<Login> Login { get; set; }
        public DbSet<Character> Character { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Inventory> Inventory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Inventory>().HasKey(c => new { c.CharacterID, c.ItemID });
        }
    }
}