namespace LeDrink.DAL.Models
{
    [Serializable]
    public class Bottle
    {
        public int Id { get; set; }
        public int? BottleSlotId { get; set; }
        public string BottleName { get; set; }
        public string? ImgPath { get; set; } = "/images/bottles/default.png";
        public int MaxMl { get; set; }
        public int CurrentMl { get; set; }
    }
}
