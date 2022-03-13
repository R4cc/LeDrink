using System.ComponentModel.DataAnnotations;

namespace LeDrink.DAL.Models
{
    public class Drink
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(2), MaxLength(100)]
        public string DrinkName { get; set; }
        public int? Price { get; set; }
        public string ImgPath { get; set; }
        public ICollection<Mix> Mixes { get; set; }
        public bool IsFavourite { get; set; }
    }
}
