﻿using LeDrink.Web.Models;

namespace LeDrink.DAL.Models
{
    public  class Bottle
    {
        public int Id { get; set; }
        public int BottleSlotId { get; set; }
        public string BottleName { get; set; }
        public ICollection<Mix> Mixes { get; set; }
        
    }
}