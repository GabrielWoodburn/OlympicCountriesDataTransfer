﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OlympicGamesDataTransfer.Models;

namespace OlympicGamesDataTransfer.Migrations
{
    [DbContext(typeof(CountryContext))]
    partial class CountryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasKey("CountryID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("GameID");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryID = "at",
                            CategoryID = "outdoor",
                            GameID = "paralympics",
                            LogoImage = "at.png",
                            Name = "Austria"
                        },
                        new
                        {
                            CountryID = "br",
                            CategoryID = "outdoor",
                            GameID = "summer",
                            LogoImage = "br.png",
                            Name = "Brazil"
                        },
                        new
                        {
                            CountryID = "ca",
                            CategoryID = "indoor",
                            GameID = "winter",
                            LogoImage = "ca.png",
                            Name = "Canada"
                        },
                        new
                        {
                            CountryID = "cn",
                            CategoryID = "indoor",
                            GameID = "summer",
                            LogoImage = "cn.png",
                            Name = "China"
                        },
                        new
                        {
                            CountryID = "cy",
                            CategoryID = "indoor",
                            GameID = "youth",
                            LogoImage = "cy.png",
                            Name = "Cyprus"
                        },
                        new
                        {
                            CountryID = "fi",
                            CategoryID = "outdoor",
                            GameID = "youth",
                            LogoImage = "fi.png",
                            Name = "Finland"
                        },
                        new
                        {
                            CountryID = "fr",
                            CategoryID = "indoor",
                            GameID = "youth",
                            LogoImage = "fr.png",
                            Name = "France"
                        },
                        new
                        {
                            CountryID = "de",
                            CategoryID = "indoor",
                            GameID = "summer",
                            LogoImage = "de.png",
                            Name = "Germany"
                        },
                        new
                        {
                            CountryID = "gb",
                            CategoryID = "indoor",
                            GameID = "winter",
                            LogoImage = "gb.png",
                            Name = "Great Britain"
                        },
                        new
                        {
                            CountryID = "it",
                            CategoryID = "outdoor",
                            GameID = "winter",
                            LogoImage = "it.png",
                            Name = "Italy"
                        },
                        new
                        {
                            CountryID = "jm",
                            CategoryID = "outdoor",
                            GameID = "winter",
                            LogoImage = "jm.png",
                            Name = "Jamaica"
                        },
                        new
                        {
                            CountryID = "jp",
                            CategoryID = "outdoor",
                            GameID = "winter",
                            LogoImage = "jp.png",
                            Name = "Japan"
                        },
                        new
                        {
                            CountryID = "mx",
                            CategoryID = "indoor",
                            GameID = "summer",
                            LogoImage = "mx.png",
                            Name = "Mexico"
                        },
                        new
                        {
                            CountryID = "nl",
                            CategoryID = "outdoor",
                            GameID = "summer",
                            LogoImage = "nl.png",
                            Name = "Netherlands"
                        },
                        new
                        {
                            CountryID = "pk",
                            CategoryID = "outdoor",
                            GameID = "paralympics",
                            LogoImage = "pk.png",
                            Name = "Pakistan"
                        },
                        new
                        {
                            CountryID = "pt",
                            CategoryID = "outdoor",
                            GameID = "youth",
                            LogoImage = "pt.png",
                            Name = "Portugal"
                        },
                        new
                        {
                            CountryID = "ru",
                            CategoryID = "indoor",
                            GameID = "youth",
                            LogoImage = "ru.png",
                            Name = "Russia"
                        },
                        new
                        {
                            CountryID = "sk",
                            CategoryID = "outdoor",
                            GameID = "youth",
                            LogoImage = "sk.png",
                            Name = "Slovakia"
                        },
                        new
                        {
                            CountryID = "se",
                            CategoryID = "indoor",
                            GameID = "winter",
                            LogoImage = "se.png",
                            Name = "Sweden"
                        },
                        new
                        {
                            CountryID = "th",
                            CategoryID = "indoor",
                            GameID = "paralympics",
                            LogoImage = "th.png",
                            Name = "Thailand"
                        },
                        new
                        {
                            CountryID = "us",
                            CategoryID = "outdoor",
                            GameID = "summer",
                            LogoImage = "us.png",
                            Name = "USA"
                        },
                        new
                        {
                            CountryID = "ua",
                            CategoryID = "indoor",
                            GameID = "paralympics",
                            LogoImage = "ua.png",
                            Name = "Ukraine"
                        },
                        new
                        {
                            CountryID = "uy",
                            CategoryID = "indoor",
                            GameID = "paralympics",
                            LogoImage = "uy.png",
                            Name = "Uruguay"
                        },
                        new
                        {
                            CountryID = "zw",
                            CategoryID = "outdoor",
                            GameID = "paralympics",
                            LogoImage = "zw.png",
                            Name = "Zimbabwe"
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

            modelBuilder.Entity("OlympicGamesDataTransfer.Models.Country", b =>
                {
                    b.HasOne("OlympicGamesDataTransfer.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID");

                    b.HasOne("OlympicGamesDataTransfer.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameID");
                });
#pragma warning restore 612, 618
        }
    }
}
