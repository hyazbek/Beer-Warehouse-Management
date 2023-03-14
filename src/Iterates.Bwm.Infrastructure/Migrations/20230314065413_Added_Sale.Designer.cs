﻿// <auto-generated />
using System;
using Iterates.Bwm.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Iterates.Bwm.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230314065413_Added_Sale")]
    partial class Added_Sale
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Iterates.Bwm.Domain.Entities.Beer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AlcoholContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BatchNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("BrewerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BrewerId");

                    b.ToTable("Beers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e3fa75d9-82bb-44c8-8ff5-7e3e0ff7f767"),
                            AlcoholContent = "6,6%",
                            BatchNumber = "Batch #231",
                            BrewerId = new Guid("bab4cfe6-e3e9-48c6-9230-8f232a25eda0"),
                            Created = new DateTime(2023, 3, 14, 9, 54, 13, 474, DateTimeKind.Local).AddTicks(4766),
                            Name = " Leffe Blonde",
                            Updated = new DateTime(2023, 3, 14, 9, 54, 13, 474, DateTimeKind.Local).AddTicks(4766)
                        });
                });

            modelBuilder.Entity("Iterates.Bwm.Domain.Entities.Brewer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Brewers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bab4cfe6-e3e9-48c6-9230-8f232a25eda0"),
                            Created = new DateTime(2023, 3, 14, 9, 54, 13, 474, DateTimeKind.Local).AddTicks(4611),
                            Name = "Abbaye de Leffe",
                            Updated = new DateTime(2023, 3, 14, 9, 54, 13, 474, DateTimeKind.Local).AddTicks(4621)
                        },
                        new
                        {
                            Id = new Guid("8c641b60-6d70-4fb3-94f0-e8f6c23e8535"),
                            Created = new DateTime(2023, 3, 14, 9, 54, 13, 474, DateTimeKind.Local).AddTicks(4641),
                            Name = "Brasserie de la Senne",
                            Updated = new DateTime(2023, 3, 14, 9, 54, 13, 474, DateTimeKind.Local).AddTicks(4642)
                        });
                });

            modelBuilder.Entity("Iterates.Bwm.Domain.Entities.Sale", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BeerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BrewerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Delivery")
                        .HasColumnType("bit");

                    b.Property<string>("OrderNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("WholesalerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BeerId");

                    b.HasIndex("WholesalerId");

                    b.ToTable("Sales");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5633ec69-7546-42a3-95cd-a949c2f69601"),
                            BeerId = new Guid("e3fa75d9-82bb-44c8-8ff5-7e3e0ff7f767"),
                            BrewerId = new Guid("bab4cfe6-e3e9-48c6-9230-8f232a25eda0"),
                            Created = new DateTime(2023, 3, 14, 9, 54, 13, 474, DateTimeKind.Local).AddTicks(4792),
                            Delivery = true,
                            OrderNumber = "#BRU241",
                            Price = 2.20m,
                            Stock = 1000,
                            Updated = new DateTime(2023, 3, 14, 9, 54, 13, 474, DateTimeKind.Local).AddTicks(4793),
                            WholesalerId = new Guid("1847dd70-7b84-4fd7-a611-0e46dbfe0f67")
                        });
                });

            modelBuilder.Entity("Iterates.Bwm.Domain.Entities.Wholesaler", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Wholesalers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1847dd70-7b84-4fd7-a611-0e46dbfe0f67"),
                            Created = new DateTime(2023, 3, 14, 9, 54, 13, 474, DateTimeKind.Local).AddTicks(4818),
                            Name = "GeneDrinks",
                            Updated = new DateTime(2023, 3, 14, 9, 54, 13, 474, DateTimeKind.Local).AddTicks(4818)
                        },
                        new
                        {
                            Id = new Guid("4a413b7b-3b8e-457f-b7af-4944b7dd8cda"),
                            Created = new DateTime(2023, 3, 14, 9, 54, 13, 474, DateTimeKind.Local).AddTicks(4821),
                            Name = "OneShot",
                            Updated = new DateTime(2023, 3, 14, 9, 54, 13, 474, DateTimeKind.Local).AddTicks(4821)
                        });
                });

            modelBuilder.Entity("Iterates.Bwm.Domain.Entities.WholesalerStock", b =>
                {
                    b.Property<Guid>("WholesalerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BeerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("WholesalerId", "BeerId");

                    b.HasIndex("BeerId");

                    b.ToTable("WholesalerStocks");

                    b.HasData(
                        new
                        {
                            WholesalerId = new Guid("1847dd70-7b84-4fd7-a611-0e46dbfe0f67"),
                            BeerId = new Guid("e3fa75d9-82bb-44c8-8ff5-7e3e0ff7f767"),
                            Created = new DateTime(2023, 3, 14, 9, 54, 13, 474, DateTimeKind.Local).AddTicks(4840),
                            Id = new Guid("24f3e073-c3e9-437d-b8a3-fc2a7e7642af"),
                            Stock = 100,
                            Updated = new DateTime(2023, 3, 14, 9, 54, 13, 474, DateTimeKind.Local).AddTicks(4840)
                        },
                        new
                        {
                            WholesalerId = new Guid("4a413b7b-3b8e-457f-b7af-4944b7dd8cda"),
                            BeerId = new Guid("e3fa75d9-82bb-44c8-8ff5-7e3e0ff7f767"),
                            Created = new DateTime(2023, 3, 14, 9, 54, 13, 474, DateTimeKind.Local).AddTicks(4844),
                            Id = new Guid("249474e0-e61f-4d2f-b768-205c570de3e5"),
                            Stock = 500,
                            Updated = new DateTime(2023, 3, 14, 9, 54, 13, 474, DateTimeKind.Local).AddTicks(4844)
                        });
                });

            modelBuilder.Entity("Iterates.Bwm.Domain.Entities.Beer", b =>
                {
                    b.HasOne("Iterates.Bwm.Domain.Entities.Brewer", null)
                        .WithMany("Beers")
                        .HasForeignKey("BrewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Iterates.Bwm.Domain.Entities.Sale", b =>
                {
                    b.HasOne("Iterates.Bwm.Domain.Entities.Beer", "Beer")
                        .WithMany()
                        .HasForeignKey("BeerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Iterates.Bwm.Domain.Entities.Wholesaler", "Wholesaler")
                        .WithMany()
                        .HasForeignKey("WholesalerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Beer");

                    b.Navigation("Wholesaler");
                });

            modelBuilder.Entity("Iterates.Bwm.Domain.Entities.WholesalerStock", b =>
                {
                    b.HasOne("Iterates.Bwm.Domain.Entities.Beer", "Beer")
                        .WithMany()
                        .HasForeignKey("BeerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Iterates.Bwm.Domain.Entities.Wholesaler", "Wholesaler")
                        .WithMany()
                        .HasForeignKey("WholesalerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Beer");

                    b.Navigation("Wholesaler");
                });

            modelBuilder.Entity("Iterates.Bwm.Domain.Entities.Brewer", b =>
                {
                    b.Navigation("Beers");
                });
#pragma warning restore 612, 618
        }
    }
}