using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace chefs_and_dishes.Models
{
    public class Chef
    {

        [Key]
        public int ChefId {get;set;}

        [Required]
        public string FirstName {get;set;}
        [Required]
        public string LastName {get;set;}
        [Required(ErrorMessage = "Please enter a valid date of birth.")]
        public DateTime DOB {get;set;}

        // Navigation Property
        public List<Dish> Menu {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}