using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization.Formatters.Binary;

namespace LeDrink.DAL.Models
{
    public class Mix
    {

        [Key]
        public int Id { get; set; }
        public Bottle Bottle { get; set; }
        public int? bottleId { get; set; }
        public Drink Drink { get; set; }
        public int drinkId { get; set; }
        public int? Milliliters { get; set; }
    }
}
