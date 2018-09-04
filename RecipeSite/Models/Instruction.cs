using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace RecipeSite.Models
{
    public class Instruction
    {
        [Key]
        public int InstructionID { get; set; }

        public int RecipeID { get; set; }

        public virtual Recipe Recipe { get; set; }

        public int Sequence { get; set; }

        public string Text { get; set; }
    }
}