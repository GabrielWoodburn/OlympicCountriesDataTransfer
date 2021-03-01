using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicGamesDataTransfer.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options)
            : base(options)
        { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Game>().HasData(
                new Game { GameID = "winter", Name = "Winter" },
                new Game { GameID = "summer", Name = "Summer" },
                new Game { GameID = "paralympics", Name = "Paralympics"},
                new Game { GameID = "youth", Name = "Youth"}
            );
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = "indoor", Name = "Indoor" },
                new Category { CategoryID = "outdoor", Name = "Outdoor" }
            );
            modelBuilder.Entity<Country>().HasData(
                new { CountryID = "at", Name = "Austria", GameID = "paralympics", CategoryID = "outdoor", LogoImage = "at.png" },
                new { CountryID = "br", Name = "Brazil", GameID = "summer", CategoryID = "outdoor", LogoImage = "br.png" },
                new { CountryID = "ca", Name = "Canada", GameID = "winter", CategoryID = "indoor", LogoImage = "ca.png" },
                new { CountryID = "cn", Name = "China", GameID = "summer", CategoryID = "indoor", LogoImage = "cn.png" },
                new { CountryID = "cy", Name = "Cyprus", GameID = "youth", CategoryID = "indoor", LogoImage = "cy.png" },
                new { CountryID = "fi", Name = "Finland", GameID = "youth", CategoryID = "outdoor", LogoImage = "fi.png" },
                new { CountryID = "fr", Name = "France", GameID = "youth", CategoryID = "indoor", LogoImage = "fr.png" },
                new { CountryID = "de", Name = "Germany", GameID = "summer", CategoryID = "indoor", LogoImage = "de.png" },
                new { CountryID = "gb", Name = "Great Britain", GameID = "winter", CategoryID = "indoor", LogoImage = "gb.png" },
                new { CountryID = "it", Name = "Italy", GameID = "winter", CategoryID = "outdoor", LogoImage = "it.png" },
                new { CountryID = "jm", Name = "Jamaica", GameID = "winter", CategoryID = "outdoor", LogoImage = "jm.png" },
                new { CountryID = "jp", Name = "Japan", GameID = "winter", CategoryID = "outdoor", LogoImage = "jp.png" },
                new { CountryID = "mx", Name = "Mexico", GameID = "summer", CategoryID = "indoor", LogoImage = "mx.png" },
                new { CountryID = "nl", Name = "Netherlands", GameID = "summer", CategoryID = "outdoor", LogoImage = "nl.png" },
                new { CountryID = "pk", Name = "Pakistan", GameID = "paralympics", CategoryID = "outdoor", LogoImage = "pk.png" },
                new { CountryID = "pt", Name = "Portugal", GameID = "youth", CategoryID = "outdoor", LogoImage = "pt.png" },
                new { CountryID = "ru", Name = "Russia", GameID = "youth", CategoryID = "indoor", LogoImage = "ru.png" },
                new { CountryID = "sk", Name = "Slovakia", GameID = "youth", CategoryID = "outdoor", LogoImage = "sk.png" },
                new { CountryID = "se", Name = "Sweden", GameID = "winter", CategoryID = "indoor", LogoImage = "se.png" },
                new { CountryID = "th", Name = "Thailand", GameID = "paralympics", CategoryID = "indoor", LogoImage = "th.png" },
                new { CountryID = "us", Name = "USA", GameID = "summer", CategoryID = "outdoor", LogoImage = "us.png" },
                new { CountryID = "ua", Name = "Ukraine", GameID = "paralympics", CategoryID = "indoor", LogoImage = "ua.png" },
                new { CountryID = "uy", Name = "Uruguay", GameID = "paralympics", CategoryID = "indoor", LogoImage = "uy.png" },
                new { CountryID = "zw", Name = "Zimbabwe", GameID = "paralympics", CategoryID = "outdoor", LogoImage = "zw.png" }
            );
        }
    }
}
