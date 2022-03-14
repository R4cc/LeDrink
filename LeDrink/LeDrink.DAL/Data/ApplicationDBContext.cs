using LeDrink.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace LeDrink.DAL.Data
{
    public  class ApplicationDBContext : DbContext
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
                BottleSlotId = 1
            };

            Bottle Fanta = new Bottle
            {
                Id = 2,
                BottleName = "Fanta",
                BottleSlotId = 2
            };

            Bottle RedBull = new Bottle
            {
                Id = 3,
                BottleName = "RedBull",
                BottleSlotId = 3
            };

            Bottle Vodka = new Bottle
            {
                Id = 4,
                BottleName = "Vodka",
                BottleSlotId = 4
            };

            modelBuilder.Entity<Bottle>().HasData(CocaCola);
            modelBuilder.Entity<Bottle>().HasData(Fanta);
            modelBuilder.Entity<Bottle>().HasData(RedBull);
            modelBuilder.Entity<Bottle>().HasData(Vodka);

            // Seed Mixes
            List<Mix> VodkaBull = new();
            List<Mix> Spezi = new();
            List<Mix> VodkaCoke = new();
            List<Mix> FantaBull = new();

            // Vodka Bull
            VodkaBull.Add(new Mix
            {
                Id = 1,
                Bottle = Vodka,
                Milliliters = 250,
                Drink = new Drink
                {
                    Id = 1
                }
            });

            VodkaBull.Add(new Mix
            {
                Id = 2,
                Bottle = CocaCola,
                Milliliters = 250,
                Drink = new Drink
                {
                    Id = 1
                }
            });

            modelBuilder.Entity<Drink>().HasData(new Drink
            {
                Id = 1,
                DrinkName = "VodkaBull",
                IsFavourite = true,
                Mixes = VodkaBull,
                ImgPath = "https://media.kaufland.com/images/PPIM/AP_Content_1010/std.lang.all/54/80/Asset_1895480.jpg",
                Price = 20
            });

            // Spezi
            Spezi.Add(new Mix
            {
                Id = 3,
                Bottle = Fanta,
                Milliliters = 250,
                Drink = new Drink
                {
                    Id = 2
                }
            });

            Spezi.Add(new Mix
            {
                Id = 4,
                Bottle = CocaCola,
                Milliliters = 250,
                Drink = new Drink
                {
                    Id = 2
                }
            });

            modelBuilder.Entity<Drink>().HasData(new Drink
            {
                Id = 2,
                DrinkName = "Spezi",
                IsFavourite = true,
                Mixes = Spezi,
                ImgPath = "https://www.spezi.com/wp-content/uploads/thumbnail-logo-spezi-original.jpg",
                Price = 10
            });

            // 
            FantaBull.Add(new Mix
            {
                Id = 5,
                Bottle = Fanta,
                Milliliters = 300,
                Drink = new Drink
                {
                    Id = 3
                }
            });

            FantaBull.Add(new Mix
            {
                Id = 6,
                Bottle = RedBull,
                Milliliters = 200,
                Drink = new Drink
                {
                    Id = 3
                }
            });

            modelBuilder.Entity<Drink>().HasData(new Drink
            {
                Id = 3,
                DrinkName = "Fantabull",
                IsFavourite = false,
                Mixes = FantaBull,
                ImgPath = "https://media.istockphoto.com/photos/fanta-red-bull-and-coca-cola-cans-picture-id458092615",
                Price = 15
            });

            // VodkaCoke
            VodkaCoke.Add(new Mix
            {
                Id = 7,
                Bottle = Vodka,
                Milliliters = 250,
                Drink = new Drink
                {
                    Id = 4
                }
            });

            FantaBull.Add(new Mix
            {
                Id = 8,
                Bottle = CocaCola,
                Milliliters = 250,
                Drink = new Drink
                {
                    Id = 4
                }
            });

            modelBuilder.Entity<Drink>().HasData(new Drink
            {
                Id = 4,
                DrinkName = "VodkaCoke",
                IsFavourite = true,
                Mixes = VodkaCoke,
                ImgPath = "https://www.acouplecooks.com/wp-content/uploads/2020/12/Vodka-and-Coke-001.jpg",
                Price = 35
            });

        }

        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Mix> Mixes { get; set; }
        public DbSet<Bottle> Bottles { get; set; }
    }
}
