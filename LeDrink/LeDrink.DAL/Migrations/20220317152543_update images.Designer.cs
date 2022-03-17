﻿// <auto-generated />
using System;
using LeDrink.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LeDrink.DAL.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20220317152543_update images")]
    partial class updateimages
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("LeDrink.DAL.Models.Bottle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BottleName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("BottleSlotId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CurrentMl")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImgPath")
                        .HasColumnType("TEXT");

                    b.Property<int>("MaxMl")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Bottles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BottleName = "Coca Cola",
                            BottleSlotId = 1,
                            CurrentMl = 1500,
                            ImgPath = "/images/bottles/CocaCola.png",
                            MaxMl = 1500
                        },
                        new
                        {
                            Id = 2,
                            BottleName = "Fanta",
                            BottleSlotId = 2,
                            CurrentMl = 1500,
                            ImgPath = "/images/bottles/fanta.png",
                            MaxMl = 1500
                        },
                        new
                        {
                            Id = 3,
                            BottleName = "RedBull",
                            BottleSlotId = 3,
                            CurrentMl = 250,
                            ImgPath = "/images/bottles/redbull.png",
                            MaxMl = 250
                        },
                        new
                        {
                            Id = 4,
                            BottleName = "Vodka",
                            BottleSlotId = 4,
                            CurrentMl = 700,
                            ImgPath = "/images/bottles/vodka_white.png",
                            MaxMl = 700
                        },
                        new
                        {
                            Id = 5,
                            BottleName = "Gin",
                            CurrentMl = 700,
                            ImgPath = "/images/bottles/Gin.png",
                            MaxMl = 700
                        },
                        new
                        {
                            Id = 6,
                            BottleName = "Orange Juice",
                            CurrentMl = 1000,
                            ImgPath = "/images/bottles/OrangeJuice.png",
                            MaxMl = 1000
                        },
                        new
                        {
                            Id = 7,
                            BottleName = "Bacardi",
                            CurrentMl = 1000,
                            ImgPath = "/images/bottles/Bacardi.png",
                            MaxMl = 1000
                        },
                        new
                        {
                            Id = 8,
                            BottleName = "Malibu",
                            CurrentMl = 1000,
                            ImgPath = "/images/bottles/Malibu.png",
                            MaxMl = 1000
                        },
                        new
                        {
                            Id = 9,
                            BottleName = "RedWine",
                            CurrentMl = 1000,
                            ImgPath = "/images/bottles/RedWine.png",
                            MaxMl = 1000
                        });
                });

            modelBuilder.Entity("LeDrink.DAL.Models.Drink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DrinkName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("ImgPath")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("IsFavourite")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Drinks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DrinkName = "VodkaBull",
                            ImgPath = "/images/drinks/template-cup-test.png",
                            IsFavourite = true
                        },
                        new
                        {
                            Id = 3,
                            DrinkName = "Fantabull",
                            ImgPath = "https://media.istockphoto.com/photos/fanta-red-bull-and-coca-cola-cans-picture-id458092615",
                            IsFavourite = false
                        },
                        new
                        {
                            Id = 4,
                            DrinkName = "VodkaCoke",
                            ImgPath = "https://www.acouplecooks.com/wp-content/uploads/2020/12/Vodka-and-Coke-001.jpg",
                            IsFavourite = true
                        },
                        new
                        {
                            Id = 2,
                            DrinkName = "Spezi",
                            ImgPath = "https://www.spezi.com/wp-content/uploads/thumbnail-logo-spezi-original.jpg",
                            IsFavourite = true
                        });
                });

            modelBuilder.Entity("LeDrink.DAL.Models.Mix", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Milliliters")
                        .HasColumnType("INTEGER");

                    b.Property<int>("bottleId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("drinkId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("bottleId");

                    b.HasIndex("drinkId");

                    b.ToTable("Mixes");

                    b.HasData(
                        new
                        {
                            Id = 7,
                            Milliliters = 250,
                            bottleId = 4,
                            drinkId = 4
                        },
                        new
                        {
                            Id = 8,
                            Milliliters = 250,
                            bottleId = 1,
                            drinkId = 4
                        },
                        new
                        {
                            Id = 1,
                            Milliliters = 250,
                            bottleId = 4,
                            drinkId = 1
                        },
                        new
                        {
                            Id = 2,
                            Milliliters = 250,
                            bottleId = 1,
                            drinkId = 1
                        },
                        new
                        {
                            Id = 3,
                            Milliliters = 250,
                            bottleId = 2,
                            drinkId = 2
                        },
                        new
                        {
                            Id = 4,
                            Milliliters = 250,
                            bottleId = 1,
                            drinkId = 2
                        },
                        new
                        {
                            Id = 5,
                            Milliliters = 300,
                            bottleId = 2,
                            drinkId = 3
                        },
                        new
                        {
                            Id = 6,
                            Milliliters = 200,
                            bottleId = 3,
                            drinkId = 3
                        });
                });

            modelBuilder.Entity("LeDrink.DAL.Models.Mix", b =>
                {
                    b.HasOne("LeDrink.DAL.Models.Bottle", "Bottle")
                        .WithMany()
                        .HasForeignKey("bottleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LeDrink.DAL.Models.Drink", "Drink")
                        .WithMany("Mixes")
                        .HasForeignKey("drinkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bottle");

                    b.Navigation("Drink");
                });

            modelBuilder.Entity("LeDrink.DAL.Models.Drink", b =>
                {
                    b.Navigation("Mixes");
                });
#pragma warning restore 612, 618
        }
    }
}
