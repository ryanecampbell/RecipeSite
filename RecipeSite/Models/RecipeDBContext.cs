using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RecipeSite.Models
{
    public class RecipeDBContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<RecipeLine> RecipeLines { get; set; }

        public DbSet<Instruction> Instructions { get; set; }
    }
}