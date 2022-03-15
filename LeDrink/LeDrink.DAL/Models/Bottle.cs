﻿namespace LeDrink.DAL.Models
{
    public  class Bottle
    {
        public int Id { get; set; }
        public int? BottleSlotId { get; set; }
        public string BottleName { get; set; }
        public string? ImgPath { get; set; }
        public int MaxMl { get; set; }
        public int CurrentMl { get; set; }
    }
}
