﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopsRUs.Infrastructure.DBContext;

namespace ShopsRUs.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211012125034_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("ShopsRUs.Domain.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 10, 12, 13, 50, 33, 597, DateTimeKind.Local).AddTicks(6036),
                            Email = "johndoe@gmail.com",
                            FirstName = "John",
                            LastName = "Doe",
                            PhoneNumber = "09045735473",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 2, 4, 14, 24, 59, 0, DateTimeKind.Local),
                            Email = "barnesolson@ronbert.com",
                            FirstName = "Barnes",
                            LastName = "Olson",
                            PhoneNumber = "080465374833",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(8796),
                            Email = "chuka@moses.com",
                            FirstName = "Chuka",
                            LastName = "Moses",
                            PhoneNumber = "07046537833",
                            RoleId = 3
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2018, 7, 4, 14, 24, 59, 0, DateTimeKind.Local),
                            Email = "clement@gmail.com",
                            FirstName = "Clement",
                            LastName = "Azabataram",
                            PhoneNumber = "08136374833",
                            RoleId = 3
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2019, 10, 2, 14, 24, 59, 0, DateTimeKind.Local),
                            Email = "olatobi@gmail.com",
                            FirstName = "Tobi",
                            LastName = "Ola",
                            PhoneNumber = "09086574839",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9011),
                            Email = "godwinjulieth@gmail.com",
                            FirstName = "Julieth",
                            LastName = "Godwin",
                            PhoneNumber = "0704674833",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9013),
                            Email = "gabriel@benard.com",
                            FirstName = "Bernard",
                            LastName = "Gabriel",
                            PhoneNumber = "080465374833",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9015),
                            Email = "godson@frank.com",
                            FirstName = "Frank",
                            LastName = "Godson",
                            PhoneNumber = "07035374833",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9016),
                            Email = "eunice@beauty.com",
                            FirstName = "Eunice",
                            LastName = "Beauty",
                            PhoneNumber = "09054836483",
                            RoleId = 3
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9018),
                            Email = "emmanuelpeter@gmail.com",
                            FirstName = "Emmanuel",
                            LastName = "Peter",
                            PhoneNumber = "09067374367",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9019),
                            Email = "somtoochukwuonuh@gmail.com",
                            FirstName = "Somtoochukwu",
                            LastName = "Onuh",
                            PhoneNumber = "08063737373",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9021),
                            Email = "theresa@gmail.com",
                            FirstName = "Theresa",
                            LastName = "Samson",
                            PhoneNumber = "07074838833",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 13,
                            CreatedAt = new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9023),
                            Email = "francisjoshua@gmail.com",
                            FirstName = "Francis",
                            LastName = "Joshua",
                            PhoneNumber = "0813473747374",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 14,
                            CreatedAt = new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9024),
                            Email = "okaforfaith@gmail.com",
                            FirstName = "Faith",
                            LastName = "Okafor",
                            PhoneNumber = "09037473736",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 15,
                            CreatedAt = new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9025),
                            Email = "godsonemeka@gmail.com",
                            FirstName = "Godson",
                            LastName = "Emeka",
                            PhoneNumber = "0703748483",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 16,
                            CreatedAt = new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9027),
                            Email = "queen@gmail.com",
                            FirstName = "Queen",
                            LastName = "Moses",
                            PhoneNumber = "09063637373",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 17,
                            CreatedAt = new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9028),
                            Email = "obygrace@gmail.com",
                            FirstName = "Grace",
                            LastName = "Oby",
                            PhoneNumber = "07036737373",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 18,
                            CreatedAt = new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9030),
                            Email = "kingsleyemenike@gmail.com",
                            FirstName = "Kingsley",
                            LastName = "Emenike",
                            PhoneNumber = "0813838383",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 19,
                            CreatedAt = new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9032),
                            Email = "joshclem@gmail.com",
                            FirstName = "Joshua",
                            LastName = "Clement",
                            PhoneNumber = "090474838393",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 20,
                            CreatedAt = new DateTime(2021, 10, 12, 13, 50, 33, 609, DateTimeKind.Local).AddTicks(9033),
                            Email = "obinnachibueze@gmail.com",
                            FirstName = "Obinna",
                            LastName = "Chibueze",
                            PhoneNumber = "09037473833",
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("ShopsRUs.Domain.Models.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Rate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Discounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 10, 12, 13, 50, 33, 595, DateTimeKind.Local).AddTicks(9391),
                            Name = "Employee",
                            Rate = 0.3m
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 10, 12, 13, 50, 33, 595, DateTimeKind.Local).AddTicks(9590),
                            Name = "Affiliate",
                            Rate = 0.1m
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2021, 10, 12, 13, 50, 33, 595, DateTimeKind.Local).AddTicks(9592),
                            Name = "Customer",
                            Rate = 0.05m
                        });
                });

            modelBuilder.Entity("ShopsRUs.Domain.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 300.0m,
                            Category = "Groceries",
                            Name = "Rice"
                        },
                        new
                        {
                            Id = 2,
                            Amount = 550.0m,
                            Category = "Stationaries",
                            Name = "Book"
                        },
                        new
                        {
                            Id = 3,
                            Amount = 175450.0m,
                            Category = "Electronics",
                            Name = "Plasma Televison"
                        },
                        new
                        {
                            Id = 4,
                            Amount = 500000.0m,
                            Category = "Hp Pavillion",
                            Name = "Hp Pavillion"
                        },
                        new
                        {
                            Id = 5,
                            Amount = 200000.0m,
                            Category = "Gaming",
                            Name = "PS 4"
                        },
                        new
                        {
                            Id = 6,
                            Amount = 550.0m,
                            Category = "Baby Product",
                            Name = "Diaper bag"
                        },
                        new
                        {
                            Id = 7,
                            Amount = 100000.0m,
                            Category = "Smart Phones",
                            Name = "Redmi Note 9"
                        },
                        new
                        {
                            Id = 8,
                            Amount = 150000.0m,
                            Category = "Building",
                            Name = "Rods"
                        },
                        new
                        {
                            Id = 9,
                            Amount = 80.0m,
                            Category = "Groceries",
                            Name = "Beans"
                        });
                });

            modelBuilder.Entity("ShopsRUs.Domain.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Employee"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Affiliate"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Customer"
                        });
                });

            modelBuilder.Entity("ShopsRUs.Domain.Models.AppUser", b =>
                {
                    b.HasOne("ShopsRUs.Domain.Models.Role", "Role")
                        .WithMany("AppUser")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ShopsRUs.Domain.Models.Role", b =>
                {
                    b.Navigation("AppUser");
                });
#pragma warning restore 612, 618
        }
    }
}
