using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace RecipeSite.Models
{
    public enum Measurement
    {
        None,
        Teaspoon,
        Tablespoon,
        Cup,
        FluidOunce,
        Ounce,
        Pint,
        Quart,
        Gallon,
        Pound,
        Milligram,
        Gram, 
        Kilogram,
        Milliliter,
        Liter
    }

    public class RecipeLine
    {
        [Key]
        public int RecipeLineID { get; set; }

        public int RecipeID { get; set; }

        public virtual Recipe Recipe { get; set; }

        public decimal Quantity { get; set; }

        public Measurement Measurement { get; set; }

        public string Ingredient { get; set; }
    }
}