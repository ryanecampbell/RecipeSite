using System;
using System.Data.Entity;

namespace RecipeSite.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class RecipeDBContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }
    }
}