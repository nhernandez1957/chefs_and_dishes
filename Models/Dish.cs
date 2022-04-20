using System;
using System.ComponentModel.DataAnnotations;

namespace chefs_and_dishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}

        [Required]
        public string Name {get;set;}
        [Required]
        [Range(1, int.MaxValue)]
        public int Calories {get;set;}
        [Required]
        [Range(1,5)]
        public int Tastiness {get;set;}
        [Required]
        public string Description {get;set;}

        public int ChefId {get;set;}

        // Navigation Property
        public Chef Chef {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}