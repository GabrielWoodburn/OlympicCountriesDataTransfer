﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OlympicGamesDataTransfer.Models;

namespace OlympicGamesDataTransfer.Migrations
{
    [DbContext(typeof(CountryContext))]
    [Migration("20210314053350_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OlympicGamesDataTransfer.Models.Category", b =>
                {
                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = "indoor",
                            Name = "Indoor"
                        },
                        new
                        {
                            CategoryID = "outdoor",
                            Name = "Outdoor"
                        });
                });

            modelBuilder.Entity("OlympicGamesDataTransfer.Models.Country", b =>
                {
                    b.Property<string>("CountryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LogoImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SportID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CountryID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("GameID");

                    b.HasIndex("SportID");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryID = "at",
                            CategoryID = "outdoor",
                            GameID = "paralympics",
                            LogoImage = "at.png",
                            Name = "Austria",
                            SportID = "canoe sprint"
                        },
                        new
                        {
                            CountryID = "br",
                            CategoryID = "outdoor",
                            GameID = "summer",
                            LogoImage = "br.png",
                            Name = "Brazil",
                            SportID = "road cycling"
                        },
                        new
                        {
                            CountryID = "ca",
                            CategoryID = "indoor",
                            GameID = "winter",
                            LogoImage = "ca.png",
                            Name = "Canada",
                            SportID = "curling"
                        },
                        new
                        {
                            CountryID = "cn",
                            CategoryID = "indoor",
                            GameID = "summer",
                            LogoImage = "cn.png",
                            Name = "China",
                            SportID = "diving"
                        },
                        new
                        {
                            CountryID = "cy",
                            CategoryID = "indoor",
                            GameID = "youth",
                            LogoImage = "cy.png",
                            Name = "Cyprus",
                            SportID = "breakdancing"
                        },
                        new
                        {
                            CountryID = "fi",
                            CategoryID = "outdoor",
                            GameID = "youth",
                            LogoImage = "fi.png",
                            Name = "Finland",
                            SportID = "skateboarding"
                        },
                        new
                        {
                            CountryID = "fr",
                            CategoryID = "indoor",
                            GameID = "youth",
                            LogoImage = "fr.png",
                            Name = "France",
                            SportID = "breakdancing"
                        },
                        new
                        {
                            CountryID = "de",
                            CategoryID = "indoor",
                            GameID = "summer",
                            LogoImage = "de.png",
                            Name = "Germany",
                            SportID = "diving"
                        },
                        new
                        {
                            CountryID = "gb",
                            CategoryID = "indoor",
                            GameID = "winter",
                            LogoImage = "gb.png",
                            Name = "Great Britain",
                            SportID = "curling"
                        },
                        new
                        {
                            CountryID = "it",
                            CategoryID = "outdoor",
                            GameID = "winter",
                            LogoImage = "it.png",
                            Name = "Italy",
                            SportID = "bobsleigh"
                        },
                        new
                        {
                            CountryID = "jm",
                            CategoryID = "outdoor",
                            GameID = "winter",
                            LogoImage = "jm.png",
                            Name = "Jamaica",
                            SportID = "bobsleigh"
                        },
                        new
                        {
                            CountryID = "jp",
                            CategoryID = "outdoor",
                            GameID = "winter",
                            LogoImage = "jp.png",
                            Name = "Japan",
                            SportID = "bobsleigh"
                        },
                        new
                        {
                            CountryID = "mx",
                            CategoryID = "indoor",
                            GameID = "summer",
                            LogoImage = "mx.png",
                            Name = "Mexico",
                            SportID = "diving"
                        },
                        new
                        {
                            CountryID = "nl",
                            CategoryID = "outdoor",
                            GameID = "summer",
                            LogoImage = "nl.png",
                            Name = "Netherlands",
                            SportID = "road cycling"
                        },
                        new
                        {
                            CountryID = "pk",
                            CategoryID = "outdoor",
                            GameID = "paralympics",
                            LogoImage = "pk.png",
                            Name = "Pakistan",
                            SportID = "canoe sprint"
                        },
                        new
                        {
                            CountryID = "pt",
                            CategoryID = "outdoor",
                            GameID = "youth",
                            LogoImage = "pt.png",
                            Name = "Portugal",
                            SportID = "skateboarding"
                        },
                        new
                        {
                            CountryID = "ru",
                            CategoryID = "indoor",
                            GameID = "youth",
                            LogoImage = "ru.png",
                            Name = "Russia",
                            SportID = "breakdancing"
                        },
                        new
                        {
                            CountryID = "sk",
                            CategoryID = "outdoor",
                            GameID = "youth",
                            LogoImage = "sk.png",
                            Name = "Slovakia",
                            SportID = "skateboarding"
                        },
                        new
                        {
                            CountryID = "se",
                            CategoryID = "indoor",
                            GameID = "winter",
                            LogoImage = "se.png",
                            Name = "Sweden",
                            SportID = "curling"
                        },
                        new
                        {
                            CountryID = "th",
                            CategoryID = "indoor",
                            GameID = "paralympics",
                            LogoImage = "th.png",
                            Name = "Thailand",
                            SportID = "archery"
                        },
                        new
                        {
                            CountryID = "us",
                            CategoryID = "outdoor",
                            GameID = "summer",
                            LogoImage = "us.png",
                            Name = "USA",
                            SportID = "road cycling"
                        },
                        new
                        {
                            CountryID = "ua",
                            CategoryID = "indoor",
                            GameID = "paralympics",
                            LogoImage = "ua.png",
                            Name = "Ukraine",
                            SportID = "archery"
                        },
                        new
                        {
                            CountryID = "uy",
                            CategoryID = "indoor",
                            GameID = "paralympics",
                            LogoImage = "uy.png",
                            Name = "Uruguay",
                            SportID = "archery"
                        },
                        new
                        {
                            CountryID = "zw",
                            CategoryID = "outdoor",
                            GameID = "paralympics",
                            LogoImage = "zw.png",
                            Name = "Zimbabwe",
                            SportID = "canoe sprint"
                        });
                });

            modelBuilder.Entity("OlympicGamesDataTransfer.Models.Game", b =>
                {
                    b.Property<string>("GameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameID");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameID = "winter",
                            Name = "Winter"
                        },
                        new
                        {
                            GameID = "summer",
                            Name = "Summer"
                        },
                        new
                        {
                            GameID = "paralympics",
                            Name = "Paralympics"
                        },
                        new
                        {
                            GameID = "youth",
                            Name = "Youth"
                        });
                });

            modelBuilder.Entity("OlympicGamesDataTransfer.Models.Sport", b =>
                {
                    b.Property<string>("SportID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SportID");

                    b.ToTable("Sports");

                    b.HasData(
                        new
                        {
                            SportID = "curling",
                            Name = "Curling"
                        },
                        new
                        {
                            SportID = "bobsleigh",
                            Name = "Bobsleigh"
                        },
                        new
                        {
                            SportID = "diving",
                            Name = "Diving"
                        },
                        new
                        {
                            SportID = "road cycling",
                            Name = "Road Cycling"
                        },
                        new
                        {
                            SportID = "archery",
                            Name = "Archery"
                        },
                        new
                        {
                            SportID = "canoe sprint",
                            Name = "Canoe Sprint"
                        },
                        new
                        {
                            SportID = "breakdancing",
                            Name = "Breakdancing"
                        },
                        new
                        {
                            SportID = "skateboarding",
                            Name = "Skateboarding"
                        });
                });

            modelBuilder.Entity("OlympicGamesDataTransfer.Models.Country", b =>
                {
                    b.HasOne("OlympicGamesDataTransfer.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID");

                    b.HasOne("OlympicGamesDataTransfer.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameID");

                    b.HasOne("OlympicGamesDataTransfer.Models.Sport", "Sport")
                        .WithMany()
                        .HasForeignKey("SportID");
                });
#pragma warning restore 612, 618
        }
    }
}