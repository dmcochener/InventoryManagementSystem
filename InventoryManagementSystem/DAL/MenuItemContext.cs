using InventoryManagementSystem.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace InventoryManagementSystem.DAL
{
    public class MenuItemContext : DbContext
    {
        public MenuItemContext() : base("MenuItemContext")
        {
        }

        public DbSet<Ingredient> Ingredients { get; set; }
   

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}