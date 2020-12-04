﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineShop.Domain;

namespace OnlineShop.Domain.Migrations
{
    [DbContext(typeof(OnlineShopDbContext))]
    partial class OnlineShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("OnlineShop.Domain.Models.Adress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Apartment")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Country")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Street")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Adresses");
                });

            modelBuilder.Entity("OnlineShop.Domain.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("OnlineShop.Domain.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AdressId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("LastNamee")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("AdressId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("OnlineShop.Domain.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OnlineShop.Domain.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("OnlineShop.Domain.Models.Customer", b =>
                {
                    b.HasOne("OnlineShop.Domain.Models.Adress", "Adress")
                        .WithMany()
                        .HasForeignKey("AdressId");
                });

            modelBuilder.Entity("OnlineShop.Domain.Models.Order", b =>
                {
                    b.HasOne("OnlineShop.Domain.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("OnlineShop.Domain.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("OnlineShop.Domain.Models.Product", b =>
                {
                    b.HasOne("OnlineShop.Domain.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");
                });
#pragma warning restore 612, 618
        }
    }
}
