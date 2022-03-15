using LeDrink.DAL.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;

namespace LeDrink.DAL.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Bottle Seeding
            Bottle CocaCola = new Bottle
            {
                Id = 1,
                BottleName = "Coca Cola",
                ImgPath = "/images/bottles/cocacola-1500ml.jpg",
                BottleSlotId = 1,
                MaxMl = 1500,
                CurrentMl = 1500
            };

            Bottle Fanta = new Bottle
            {
                Id = 2,
                BottleName = "Fanta",
                ImgPath = "/images/bottles/fanta-1500ml.jpg",
                BottleSlotId = 2,
                MaxMl = 1500,
                CurrentMl = 1500
            };

            Bottle RedBull = new Bottle
            {
                Id = 3,
                BottleName = "RedBull",
                ImgPath= "/images/bottles/redbull-250ml.jpg",
                BottleSlotId = 3,
                MaxMl = 250,
                CurrentMl = 250
            };

            Bottle Vodka = new Bottle
            {
                Id = 4,
                BottleName = "Vodka",
                ImgPath = "/images/bottles/vodka-700ml.jpg",
                BottleSlotId = 4,
                MaxMl = 700,
                CurrentMl = 700
            };

            Bottle Gin = new Bottle
            {
                Id = 5,
                BottleName = "Gin",
                ImgPath = "/images/bottles/gin-700ml.jpg",
                BottleSlotId = null,
                MaxMl = 700,
                CurrentMl = 700
            };

            Bottle OrangeJuice = new Bottle
            {
                Id = 6,
                BottleName = "Orange Juice",
                ImgPath = "/images/bottles/orangejuice-1000ml.jpg",
                BottleSlotId = null,
                MaxMl = 1000,
                CurrentMl = 1000
            };

            // Drink seeding
            Drink VodkaBull = new Drink
            {
                Id = 1,
                DrinkName = "VodkaBull",
                IsFavourite = true,
                ImgPath = "https://media.kaufland.com/images/PPIM/AP_Content_1010/std.lang.all/54/80/Asset_1895480.jpg",
                Price = 20
            };

            Drink Spezi = new Drink
            {
                Id = 2,
                DrinkName = "Spezi",
                IsFavourite = true,
                ImgPath = "https://www.spezi.com/wp-content/uploads/thumbnail-logo-spezi-original.jpg",
                Price = 10
            };

            Drink FantaBull = new Drink
            {
                Id = 3,
                DrinkName = "Fantabull",
                IsFavourite = false,
                ImgPath = "https://media.istockphoto.com/photos/fanta-red-bull-and-coca-cola-cans-picture-id458092615",
                Price = 15
            };

            Drink VodkaCoke = new Drink
            {
                Id = 4,
                DrinkName = "VodkaCoke",
                IsFavourite = true,
                ImgPath = "https://www.acouplecooks.com/wp-content/uploads/2020/12/Vodka-and-Coke-001.jpg",
                Price = 35
            };

            // Seed Mixes
            List<Mix> VodkaBullMix = new();
            List<Mix> SpeziMix = new();
            List<Mix> VodkaCokeMix = new();
            List<Mix> FantaBullMix = new();

            // Vodka Bull
            VodkaBullMix.Add(new Mix
            {
                Id = 1,
                bottleId = Vodka.Id,
                Milliliters = 250,
                drinkId = 1
            });

            VodkaBullMix.Add(new Mix
            {
                Id = 2,
                bottleId = CocaCola.Id,
                Milliliters = 250,
                drinkId = 1
            });

            // Spezi
            SpeziMix.Add(new Mix
            {
                Id = 3,
                bottleId = Fanta.Id,
                Milliliters = 250,
                drinkId = 2
            });

            SpeziMix.Add(new Mix
            {
                Id = 4,
                bottleId = CocaCola.Id,
                Milliliters = 250,
                drinkId = 2
            });

            // Fanta Bull
            FantaBullMix.Add(new Mix
            {
                Id = 5,
                bottleId = Fanta.Id,
                Milliliters = 300,
                drinkId = 3
            });

            FantaBullMix.Add(new Mix
            {
                Id = 6,
                bottleId = RedBull.Id,
                Milliliters = 200,
                drinkId = 3
            });

            // VodkaCoke
            VodkaCokeMix.Add(new Mix
            {
                Id = 7,
                bottleId = Vodka.Id,
                Milliliters = 250,
                drinkId = 4
            });

            VodkaCokeMix.Add(new Mix
            {
                Id = 8,
                bottleId = CocaCola.Id,
                Milliliters = 250,
                drinkId = 4
            });

            

            // Bottles
            modelBuilder.Entity<Bottle>().HasData(CocaCola);
            modelBuilder.Entity<Bottle>().HasData(Fanta);
            modelBuilder.Entity<Bottle>().HasData(RedBull);
            modelBuilder.Entity<Bottle>().HasData(Vodka);

            // Drinks
            modelBuilder.Entity<Drink>().HasData(VodkaBull);
            modelBuilder.Entity<Drink>().HasData(FantaBull);
            modelBuilder.Entity<Drink>().HasData(VodkaCoke);
            modelBuilder.Entity<Drink>().HasData(Spezi);

            // Mixes
            modelBuilder.Entity<Mix>().HasData(VodkaCokeMix);
            modelBuilder.Entity<Mix>().HasData(VodkaBullMix);
            modelBuilder.Entity<Mix>().HasData(SpeziMix);
            modelBuilder.Entity<Mix>().HasData(FantaBullMix);
        }

        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Mix> Mixes { get; set; }
        public DbSet<Bottle> Bottles { get; set; }
    }
}