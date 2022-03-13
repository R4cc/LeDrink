using System.ComponentModel.DataAnnotations;

namespace LeDrink.DAL.Models
{
    public class Mix
    {
        [Key]
        public int Id { get; set; }
        public Bottle Bottle { get; set; }
        [Range(0.0, 450.00, ErrorMessage = "Invalid Ml size (0-450ml)")]
        public double Milliliters { get; set; }
        public Drink Drink { get; set; }

    }
}
