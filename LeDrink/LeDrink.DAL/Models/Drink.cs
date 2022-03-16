using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeDrink.DAL.Models
{
    public class Drink
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(2), MaxLength(100)]
        public string DrinkName { get; set; }
        public string? ImgPath { get; set; }
        public ICollection<Mix> Mixes { get; set; }
        public int TotalMl { get { 
                int totalMl = 0;
                foreach(var mix in Mixes)
                {
                    totalMl += mix.Milliliters;
                }
                return totalMl;
            } } 
        public bool? IsFavourite { get; set; }
    }
}
