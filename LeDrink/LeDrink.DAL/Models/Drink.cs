﻿using LeDrink.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace LeDrink.Web.Models
{
    public class Drink
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(2), MaxLength(100)]
        public string DrinkName { get; set; }
        public double? Price { get; set; }
        public ICollection<Mix> Mixes { get; set; }
    }
}
