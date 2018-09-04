using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace RecipeSite.Models
{
    public enum MealType
    {
        None,
        Breakfast,
        Lunch,
        Dinner,
        Dessert
    }

    public class Recipe
    {
        [Key]
        public int RecipeID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [StringLength(5)]
        public string Rating { get; set; }

        public decimal PrepTime { get; set; }

        public decimal CookTime { get; set; }

        public MealType MealType { get; set; }

        public virtual IQueryable<RecipeLine> RecipeLines { get; set; }

        public virtual IQueryable<Instruction> Instructions { get; set; }
    }
}