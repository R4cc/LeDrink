using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization.Formatters.Binary;

namespace LeDrink.DAL.Models
{
    [Serializable]
    public class Drink
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(2), MaxLength(100)]
        public string DrinkName { get; set; }
        public string? ImgPath { get; set; }
        public IList<Mix> Mixes { get; set; }
        public int? TotalMl { get { 
                int? totalMl = 0;
                foreach(var mix in Mixes)
                {
                    totalMl += mix.Milliliters;
                }
                return totalMl;
            } }
        public bool IsFavourite { get; set; } = false;
        public object Clone()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                if (this.GetType().IsSerializable)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, this);
                    stream.Position = 0;
                    return formatter.Deserialize(stream);
                }
                return null;
            }
        }
    }
}
