using Microsoft.EntityFrameworkCore;
using Menu.Models;

namespace Menu.Data
{
    public class MenuContext : DbContext
    {
        public MenuContext( DbContextOptions<MenuContext> options ) : base( options ) 
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlavorIngredients>().HasKey(fi => new
            {
                fi.FlavorId,
                fi.IngredientId
            });
            modelBuilder.Entity<FlavorIngredients>().HasOne(f => f.Flavor).WithMany(fi => fi.FlavorIngredients).HasForeignKey(f => f.FlavorId);
            modelBuilder.Entity<FlavorIngredients>().HasOne(i => i.Ingredients).WithMany(fi => fi.FlavorIngredients).HasForeignKey(i => i.IngredientId);

            modelBuilder.Entity<Flavors>().HasData(
                new Flavors { Id=1, Name= "Strawberry Sundae", Price= 5.75, ImageUrl= "https://mcdonalds.bg/wp-content/uploads/2023/08/ice-cream_strawberry-strawberry_sok.png" }
                );

            modelBuilder.Entity<Ingredients>().HasData(
                new Ingredients { Id=1, Name=" Vanilla Ice Cream"},
                new Ingredients { Id = 2, Name = " Strawberry Sauce" },
                new Ingredients { Id = 3, Name = " Fresh Strawberries" }
                );

            modelBuilder.Entity<FlavorIngredients>().HasData(
                new FlavorIngredients { FlavorId=1, IngredientId=1},
                new FlavorIngredients { FlavorId=1, IngredientId=2},
                new FlavorIngredients { FlavorId=1, IngredientId=3}
                );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Flavors> Flavor { get; set; }
        public DbSet<Ingredients> Ingredient { get; set; }
        public DbSet<FlavorIngredients> FlavorIngredient { get; set; }
    }
}