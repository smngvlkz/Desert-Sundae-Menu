﻿// <auto-generated />
using Menu.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Menu.Migrations
{
    [DbContext(typeof(MenuContext))]
    [Migration("20240401195446_Initia migration")]
    partial class Initiamigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Menu.Models.FlavorIngredients", b =>
                {
                    b.Property<int>("FlavorId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.HasKey("FlavorId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("FlavorIngredient");

                    b.HasData(
                        new
                        {
                            FlavorId = 1,
                            IngredientId = 1
                        },
                        new
                        {
                            FlavorId = 1,
                            IngredientId = 2
                        },
                        new
                        {
                            FlavorId = 1,
                            IngredientId = 3
                        });
                });

            modelBuilder.Entity("Menu.Models.Flavors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Flavor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "https://mcdonalds.bg/wp-content/uploads/2023/08/ice-cream_strawberry-strawberry_sok.png",
                            Name = "Strawberry Sundae",
                            Price = 5.75
                        });
                });

            modelBuilder.Entity("Menu.Models.Ingredients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ingredient");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = " Vanilla Ice Cream"
                        },
                        new
                        {
                            Id = 2,
                            Name = " Strawberry Sauce"
                        },
                        new
                        {
                            Id = 3,
                            Name = " Fresh Strawberries"
                        });
                });

            modelBuilder.Entity("Menu.Models.FlavorIngredients", b =>
                {
                    b.HasOne("Menu.Models.Flavors", "Flavor")
                        .WithMany("FlavorIngredients")
                        .HasForeignKey("FlavorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Menu.Models.Ingredients", "Ingredients")
                        .WithMany("FlavorIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flavor");

                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("Menu.Models.Flavors", b =>
                {
                    b.Navigation("FlavorIngredients");
                });

            modelBuilder.Entity("Menu.Models.Ingredients", b =>
                {
                    b.Navigation("FlavorIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
