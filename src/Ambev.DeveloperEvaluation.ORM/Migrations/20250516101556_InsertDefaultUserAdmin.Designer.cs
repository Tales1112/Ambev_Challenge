﻿// <auto-generated />
using System;
using Ambev.DeveloperEvaluation.ORM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Ambev.DeveloperEvaluation.ORM.Migrations
{
    [DbContext(typeof(DefaultContext))]
    [Migration("20250516101556_InsertDefaultUserAdmin")]
    partial class InsertDefaultUserAdmin
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<Guid>("BoughtById")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CancelledAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CancelledById")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("DeletedById")
                        .HasColumnType("uuid");

                    b.Property<string>("PurchaseStatus")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<long>("SaleNumber")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("SoldAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("SaleAt");

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<decimal>("TotalSaleAmount")
                        .HasColumnType("numeric");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("BoughtById");

                    b.HasIndex("CancelledById");

                    b.HasIndex("CreatedById");

                    b.HasIndex("DeletedById");

                    b.HasIndex("SaleNumber")
                        .IsUnique();

                    b.ToTable("Carts", (string)null);
                });

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.CartItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<DateTime?>("CancelledAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CancelledById")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CartId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("DeletedById")
                        .HasColumnType("uuid");

                    b.Property<decimal>("DiscountAmount")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("DiscountPercentage")
                        .HasPrecision(5, 2)
                        .HasColumnType("numeric(5,2)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<string>("PurchaseStatus")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<decimal>("TotalAmount")
                        .HasPrecision(14, 2)
                        .HasColumnType("numeric(14,2)");

                    b.Property<decimal>("TotalPreDiscounts")
                        .HasPrecision(14, 2)
                        .HasColumnType("numeric(14,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CancelledById");

                    b.HasIndex("CartId");

                    b.HasIndex("CreatedById");

                    b.HasIndex("DeletedById");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems", (string)null);
                });

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("90b65dcd-3e65-4ffc-ab6f-5b88578dd818"),
                            CreatedAt = new DateTime(2025, 5, 16, 10, 15, 54, 457, DateTimeKind.Utc).AddTicks(2735),
                            Email = "admin@gmail.com",
                            Password = "$2a$11$uXrL7R90QQ4G1bILyQjFNeoFZZPXG2hDtW37kp2fN.5Gpc5Zg1Qv2",
                            Phone = "51981344567",
                            Role = "Admin",
                            Status = "Active",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.Cart", b =>
                {
                    b.HasOne("Ambev.DeveloperEvaluation.Domain.Entities.User", "BoughtBy")
                        .WithMany()
                        .HasForeignKey("BoughtById")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Ambev.DeveloperEvaluation.Domain.Entities.User", "CancelledBy")
                        .WithMany()
                        .HasForeignKey("CancelledById")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Ambev.DeveloperEvaluation.Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Ambev.DeveloperEvaluation.Domain.Entities.User", "DeletedBy")
                        .WithMany()
                        .HasForeignKey("DeletedById")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("BoughtBy");

                    b.Navigation("CancelledBy");

                    b.Navigation("CreatedBy");

                    b.Navigation("DeletedBy");
                });

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.CartItem", b =>
                {
                    b.HasOne("Ambev.DeveloperEvaluation.Domain.Entities.User", "CancelledBy")
                        .WithMany()
                        .HasForeignKey("CancelledById")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Ambev.DeveloperEvaluation.Domain.Entities.Cart", null)
                        .WithMany("Items")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ambev.DeveloperEvaluation.Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Ambev.DeveloperEvaluation.Domain.Entities.User", "DeletedBy")
                        .WithMany()
                        .HasForeignKey("DeletedById")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Ambev.DeveloperEvaluation.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("CancelledBy");

                    b.Navigation("CreatedBy");

                    b.Navigation("DeletedBy");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.Product", b =>
                {
                    b.HasOne("Ambev.DeveloperEvaluation.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.OwnsOne("Ambev.DeveloperEvaluation.Domain.ValueObjects.Rating", "Rating", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uuid");

                            b1.Property<int>("Count")
                                .HasColumnType("integer")
                                .HasColumnName("RateCount");

                            b1.Property<decimal>("Rate")
                                .HasPrecision(10, 2)
                                .HasColumnType("numeric(10,2)")
                                .HasColumnName("Rate");

                            b1.HasKey("ProductId");

                            b1.ToTable("Products");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.Navigation("Category");

                    b.Navigation("Rating")
                        .IsRequired();
                });

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.Cart", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
