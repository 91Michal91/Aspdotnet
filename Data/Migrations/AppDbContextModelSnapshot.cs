﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("Data.Entities.ContactEntity", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Birth")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<int?>("OrganizationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.HasKey("ContactId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            Birth = new DateTime(1988, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "eva@techuniversity.com",
                            Name = "Eva",
                            OrganizationId = 101,
                            Phone = "555123456",
                            Priority = 1
                        },
                        new
                        {
                            ContactId = 2,
                            Birth = new DateTime(1975, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(2024, 1, 18, 20, 20, 56, 853, DateTimeKind.Utc).AddTicks(4522),
                            Email = "mark@innovatech.com",
                            Name = "Mark",
                            OrganizationId = 102,
                            Phone = "555654321",
                            Priority = 0
                        },
                        new
                        {
                            ContactId = 3,
                            Birth = new DateTime(1992, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(2024, 1, 18, 20, 20, 56, 853, DateTimeKind.Utc).AddTicks(4526),
                            Email = "julia@softserve.com",
                            Name = "Julia",
                            OrganizationId = 103,
                            Phone = "555789123",
                            Priority = 2
                        });
                });

            modelBuilder.Entity("Data.Entities.OrganizationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Organizations");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            Description = "Higher Education Institution",
                            Name = "Tech University"
                        },
                        new
                        {
                            Id = 102,
                            Description = "Technology Solutions Company",
                            Name = "Innovatech"
                        },
                        new
                        {
                            Id = 103,
                            Description = "Software Development Company",
                            Name = "SoftServe"
                        });
                });

            modelBuilder.Entity("Data.Entities.PokojDetailsEntity", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Numer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Pietro")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rozmiar")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("PokojDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nazwa = "Deluxe Suite",
                            Numer = "301",
                            Pietro = 3,
                            Rozmiar = 35
                        },
                        new
                        {
                            Id = 2,
                            Nazwa = "Standard Room",
                            Numer = "202",
                            Pietro = 2,
                            Rozmiar = 20
                        });
                });

            modelBuilder.Entity("Data.Entities.ReservationEntity", b =>
                {
                    b.Property<int>("ReservationEntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Cena")
                        .HasColumnType("TEXT");

                    b.Property<int>("ContactEntityContactId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.HasKey("ReservationEntityId");

                    b.HasIndex("ContactEntityContactId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            ReservationEntityId = 1,
                            Cena = 250.5m,
                            ContactEntityContactId = 1,
                            ContactName = "Eva",
                            Data = new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ReservationEntityId = 2,
                            Cena = 300.75m,
                            ContactEntityContactId = 2,
                            ContactName = "Mark",
                            Data = new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "e4a90d44-c685-4b2b-bcc3-5e55315f4147",
                            ConcurrencyStamp = "e4a90d44-c685-4b2b-bcc3-5e55315f4147",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "3881ea95-854e-42fc-a619-99c79281d890",
                            Name = "user",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "90852290-0253-4178-abff-fe437255e29c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cbb113ef-b404-494c-aa4d-0becd7a7661a",
                            Email = "adam@wsei.edu.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADAM@WSEI.EDU.PL",
                            NormalizedUserName = "ADAM",
                            PasswordHash = "AQAAAAIAAYagAAAAEC5vo/4quomCJJVXzLouefbMBxy1ldgvVraZfT0gOx7ot2FySVDIhn6SqbQ14wWdhg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "27bf25d0-8c43-4031-8065-4c8000592bef",
                            TwoFactorEnabled = false,
                            UserName = "adam"
                        },
                        new
                        {
                            Id = "c76afa90-4f58-4cff-8aba-ff5d58ed64ff",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "84e1e6c4-fb20-445c-86d2-dbe7a8d8179b",
                            Email = "ewa@wsei.edu.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "EWA@WSEI.EDU.PL",
                            NormalizedUserName = "EWA",
                            PasswordHash = "AQAAAAIAAYagAAAAEF3UZdjbCR9XiTxIlfWK5nKQboftQYqDJAHDAguxel4KulaRK2sHZqkFImcduoG3dw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "48a38d9c-15fc-45e3-ba93-20aacae21487",
                            TwoFactorEnabled = false,
                            UserName = "ewa"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "90852290-0253-4178-abff-fe437255e29c",
                            RoleId = "e4a90d44-c685-4b2b-bcc3-5e55315f4147"
                        },
                        new
                        {
                            UserId = "c76afa90-4f58-4cff-8aba-ff5d58ed64ff",
                            RoleId = "3881ea95-854e-42fc-a619-99c79281d890"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Data.Entities.ContactEntity", b =>
                {
                    b.HasOne("Data.Entities.OrganizationEntity", "Organization")
                        .WithMany("Contacts")
                        .HasForeignKey("OrganizationId");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Data.Entities.OrganizationEntity", b =>
                {
                    b.OwnsOne("Data.Models.Adress", "Adress", b1 =>
                        {
                            b1.Property<int>("OrganizationEntityId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("PostalCode")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.HasKey("OrganizationEntityId");

                            b1.ToTable("Organizations");

                            b1.WithOwner()
                                .HasForeignKey("OrganizationEntityId");

                            b1.HasData(
                                new
                                {
                                    OrganizationEntityId = 101,
                                    City = "Liberty City",
                                    PostalCode = "10001",
                                    Street = "Freedom St 47"
                                },
                                new
                                {
                                    OrganizationEntityId = 102,
                                    City = "Liberty City",
                                    PostalCode = "10002",
                                    Street = "Innovation Ave 3"
                                },
                                new
                                {
                                    OrganizationEntityId = 103,
                                    City = "Liberty City",
                                    PostalCode = "10003",
                                    Street = "Tech Park Rd 21"
                                });
                        });

                    b.Navigation("Adress");
                });

            modelBuilder.Entity("Data.Entities.PokojDetailsEntity", b =>
                {
                    b.HasOne("Data.Entities.ReservationEntity", "ReservationEntity")
                        .WithOne("PokojDetailsEntity")
                        .HasForeignKey("Data.Entities.PokojDetailsEntity", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReservationEntity");
                });

            modelBuilder.Entity("Data.Entities.ReservationEntity", b =>
                {
                    b.HasOne("Data.Entities.ContactEntity", "ContactEntity")
                        .WithMany("Reservations")
                        .HasForeignKey("ContactEntityContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Data.Models.Adress", "Adress", b1 =>
                        {
                            b1.Property<int>("ReservationEntityId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("PostalCode")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.HasKey("ReservationEntityId");

                            b1.ToTable("Reservations");

                            b1.WithOwner()
                                .HasForeignKey("ReservationEntityId");

                            b1.HasData(
                                new
                                {
                                    ReservationEntityId = 1,
                                    City = "Liberty City",
                                    PostalCode = "10004",
                                    Street = "Central Sq 1"
                                },
                                new
                                {
                                    ReservationEntityId = 2,
                                    City = "Liberty City",
                                    PostalCode = "10005",
                                    Street = "Main St 99"
                                });
                        });

                    b.Navigation("Adress");

                    b.Navigation("ContactEntity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.ContactEntity", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Data.Entities.OrganizationEntity", b =>
                {
                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("Data.Entities.ReservationEntity", b =>
                {
                    b.Navigation("PokojDetailsEntity")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
