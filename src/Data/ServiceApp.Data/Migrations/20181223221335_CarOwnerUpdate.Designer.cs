﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServiceApp.Web.Models;

namespace ServiceApp.Data.Migrations
{
    [DbContext(typeof(ServiceAppContext))]
    [Migration("20181223221335_CarOwnerUpdate")]
    partial class CarOwnerUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ServiceApp.Data.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarOwnerId");

                    b.Property<string>("Make");

                    b.Property<string>("Model");

                    b.Property<string>("RegistrationNum");

                    b.Property<string>("VinNumber");

                    b.HasKey("Id");

                    b.HasIndex("CarOwnerId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("ServiceApp.Data.Models.CarOwner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Bulstat");

                    b.Property<string>("City");

                    b.Property<string>("Email");

                    b.Property<string>("MRP");

                    b.Property<string>("Name");

                    b.Property<decimal>("Obligation");

                    b.Property<string>("ServiceId");

                    b.Property<string>("Telephone");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.ToTable("CarOwners");
                });

            modelBuilder.Entity("ServiceApp.Data.Models.Obligation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<string>("ServiceId");

                    b.Property<int>("SupplierId");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Obligations");
                });

            modelBuilder.Entity("ServiceApp.Data.Models.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarId");

                    b.Property<DateTime>("DateOfCreation");

                    b.Property<string>("ServiceId");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("ServiceApp.Data.Models.OfferRaw", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count");

                    b.Property<int>("OfferId");

                    b.Property<int>("PartId");

                    b.Property<decimal>("PriceOfWork");

                    b.HasKey("Id");

                    b.HasIndex("OfferId");

                    b.HasIndex("PartId");

                    b.ToTable("OfferRaws");
                });

            modelBuilder.Entity("ServiceApp.Data.Models.OffersPart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OfferId");

                    b.Property<int>("PartId");

                    b.HasKey("Id");

                    b.HasIndex("OfferId");

                    b.HasIndex("PartId");

                    b.ToTable("OffersParts");
                });

            modelBuilder.Entity("ServiceApp.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarId");

                    b.Property<DateTime>("DateOfCreation");

                    b.Property<bool>("IsActive");

                    b.Property<string>("ServiceId");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ServiceApp.Data.Models.OrderRaw", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count");

                    b.Property<int?>("OrderId");

                    b.Property<int>("OrderrId");

                    b.Property<int>("PartId");

                    b.Property<decimal>("PriceOfWork");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("PartId");

                    b.ToTable("OrderRaws");
                });

            modelBuilder.Entity("ServiceApp.Data.Models.OrdersPart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId");

                    b.Property<int>("PartId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("PartId");

                    b.ToTable("OrdersParts");
                });

            modelBuilder.Entity("ServiceApp.Data.Models.Part", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<decimal>("DeliveryPrice");

                    b.Property<string>("Description");

                    b.Property<decimal>("SellingPrice");

                    b.Property<int>("SupplierId");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("ServiceApp.Data.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Bulstat");

                    b.Property<string>("City");

                    b.Property<string>("MRP");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("ServiceApp.Data.Models.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("ServiceApp.Data.Models.WarehousesPart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PartId");

                    b.Property<int>("WarehouseId");

                    b.HasKey("Id");

                    b.HasIndex("PartId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("WarehousesPart");
                });

            modelBuilder.Entity("ServiceApp.Web.Areas.Identity.Data.ServiceAppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address");

                    b.Property<string>("Bulstat");

                    b.Property<string>("City");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("MRP");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<int>("WarehouseId");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("WarehouseId")
                        .IsUnique();

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ServiceApp.Web.Areas.Identity.Data.ServiceAppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ServiceApp.Web.Areas.Identity.Data.ServiceAppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ServiceApp.Web.Areas.Identity.Data.ServiceAppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ServiceApp.Web.Areas.Identity.Data.ServiceAppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ServiceApp.Data.Models.Car", b =>
                {
                    b.HasOne("ServiceApp.Data.Models.CarOwner", "CarOwner")
                        .WithMany("Cars")
                        .HasForeignKey("CarOwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ServiceApp.Data.Models.CarOwner", b =>
                {
                    b.HasOne("ServiceApp.Web.Areas.Identity.Data.ServiceAppUser", "Service")
                        .WithMany("Clinets")
                        .HasForeignKey("ServiceId");
                });

            modelBuilder.Entity("ServiceApp.Data.Models.Obligation", b =>
                {
                    b.HasOne("ServiceApp.Web.Areas.Identity.Data.ServiceAppUser", "Service")
                        .WithMany("Obligations")
                        .HasForeignKey("ServiceId");

                    b.HasOne("ServiceApp.Data.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ServiceApp.Data.Models.Offer", b =>
                {
                    b.HasOne("ServiceApp.Data.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ServiceApp.Web.Areas.Identity.Data.ServiceAppUser", "Service")
                        .WithMany("Offers")
                        .HasForeignKey("ServiceId");
                });

            modelBuilder.Entity("ServiceApp.Data.Models.OfferRaw", b =>
                {
                    b.HasOne("ServiceApp.Data.Models.Offer", "Offer")
                        .WithMany("Raws")
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ServiceApp.Data.Models.Part", "Part")
                        .WithMany()
                        .HasForeignKey("PartId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ServiceApp.Data.Models.OffersPart", b =>
                {
                    b.HasOne("ServiceApp.Data.Models.Offer", "Offer")
                        .WithMany()
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ServiceApp.Data.Models.Part", "Part")
                        .WithMany("Offers")
                        .HasForeignKey("PartId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ServiceApp.Data.Models.Order", b =>
                {
                    b.HasOne("ServiceApp.Data.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ServiceApp.Web.Areas.Identity.Data.ServiceAppUser", "Service")
                        .WithMany("Orders")
                        .HasForeignKey("ServiceId");
                });

            modelBuilder.Entity("ServiceApp.Data.Models.OrderRaw", b =>
                {
                    b.HasOne("ServiceApp.Data.Models.Order", "Order")
                        .WithMany("Raws")
                        .HasForeignKey("OrderId");

                    b.HasOne("ServiceApp.Data.Models.Part", "Part")
                        .WithMany()
                        .HasForeignKey("PartId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ServiceApp.Data.Models.OrdersPart", b =>
                {
                    b.HasOne("ServiceApp.Data.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ServiceApp.Data.Models.Part", "Part")
                        .WithMany("Orders")
                        .HasForeignKey("PartId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ServiceApp.Data.Models.Part", b =>
                {
                    b.HasOne("ServiceApp.Data.Models.Supplier", "Supplier")
                        .WithMany("Parts")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ServiceApp.Data.Models.WarehousesPart", b =>
                {
                    b.HasOne("ServiceApp.Data.Models.Part", "Part")
                        .WithMany("Warehouses")
                        .HasForeignKey("PartId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ServiceApp.Data.Models.Warehouse", "Warehouse")
                        .WithMany("Parts")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ServiceApp.Web.Areas.Identity.Data.ServiceAppUser", b =>
                {
                    b.HasOne("ServiceApp.Data.Models.Warehouse", "Warehouse")
                        .WithOne("Service")
                        .HasForeignKey("ServiceApp.Web.Areas.Identity.Data.ServiceAppUser", "WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
