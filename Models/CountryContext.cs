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
        public DbSet<Sport> Sports { get; set; }

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
            modelBuilder.Entity<Sport>().HasData(
                new Sport { SportID = "curling", Name = "Curling" },
                new Sport { SportID = "bobsleigh", Name = "Bobsleigh" },
                new Sport { SportID = "diving", Name = "Diving" },
                new Sport { SportID = "road cycling", Name = "Road Cycling" },
                new Sport { SportID = "archery", Name = "Archery" },
                new Sport { SportID = "canoe sprint", Name = "Canoe Sprint" },
                new Sport { SportID = "breakdancing", Name = "Breakdancing" },
                new Sport { SportID = "skateboarding", Name = "Skateboarding" }
                );
            modelBuilder.Entity<Country>().HasData(
                new { CountryID = "at", Name = "Austria", GameID = "paralympics", CategoryID = "outdoor", SportID = "canoe sprint", LogoImage = "at.png" },
                new { CountryID = "br", Name = "Brazil", GameID = "summer", CategoryID = "outdoor", SportID = "road cycling", LogoImage = "br.png" },
                new { CountryID = "ca", Name = "Canada", GameID = "winter", CategoryID = "indoor", SportID = "curling", LogoImage = "ca.png" },
                new { CountryID = "cn", Name = "China", GameID = "summer", CategoryID = "indoor", SportID = "diving", LogoImage = "cn.png" },
                new { CountryID = "cy", Name = "Cyprus", GameID = "youth", CategoryID = "indoor", SportID = "breakdancing", LogoImage = "cy.png" },
                new { CountryID = "fi", Name = "Finland", GameID = "youth", CategoryID = "outdoor", SportID = "skateboarding", LogoImage = "fi.png" },
                new { CountryID = "fr", Name = "France", GameID = "youth", CategoryID = "indoor", SportID = "breakdancing", LogoImage = "fr.png" },
                new { CountryID = "de", Name = "Germany", GameID = "summer", CategoryID = "indoor", SportID = "diving", LogoImage = "de.png" },
                new { CountryID = "gb", Name = "Great Britain", GameID = "winter", CategoryID = "indoor", SportID = "curling", LogoImage = "gb.png" },
                new { CountryID = "it", Name = "Italy", GameID = "winter", CategoryID = "outdoor", SportID = "bobsleigh", LogoImage = "it.png" },
                new { CountryID = "jm", Name = "Jamaica", GameID = "winter", CategoryID = "outdoor", SportID = "bobsleigh", LogoImage = "jm.png" },
                new { CountryID = "jp", Name = "Japan", GameID = "winter", CategoryID = "outdoor", SportID = "bobsleigh", LogoImage = "jp.png" },
                new { CountryID = "mx", Name = "Mexico", GameID = "summer", CategoryID = "indoor", SportID = "diving", LogoImage = "mx.png" },
                new { CountryID = "nl", Name = "Netherlands", GameID = "summer", CategoryID = "outdoor", SportID = "road cycling", LogoImage = "nl.png" },
                new { CountryID = "pk", Name = "Pakistan", GameID = "paralympics", CategoryID = "outdoor", SportID = "canoe sprint", LogoImage = "pk.png" },
                new { CountryID = "pt", Name = "Portugal", GameID = "youth", CategoryID = "outdoor", SportID = "skateboarding", LogoImage = "pt.png" },
                new { CountryID = "ru", Name = "Russia", GameID = "youth", CategoryID = "indoor", SportID = "breakdancing", LogoImage = "ru.png" },
                new { CountryID = "sk", Name = "Slovakia", GameID = "youth", CategoryID = "outdoor", SportID = "skateboarding", LogoImage = "sk.png" },
                new { CountryID = "se", Name = "Sweden", GameID = "winter", CategoryID = "indoor", SportID = "curling", LogoImage = "se.png" },
                new { CountryID = "th", Name = "Thailand", GameID = "paralympics", CategoryID = "indoor", SportID = "archery", LogoImage = "th.png" },
                new { CountryID = "us", Name = "USA", GameID = "summer", CategoryID = "outdoor", SportID = "road cycling", LogoImage = "us.png" },
                new { CountryID = "ua", Name = "Ukraine", GameID = "paralympics", CategoryID = "indoor", SportID = "archery", LogoImage = "ua.png" },
                new { CountryID = "uy", Name = "Uruguay", GameID = "paralympics", CategoryID = "indoor", SportID = "archery", LogoImage = "uy.png" },
                new { CountryID = "zw", Name = "Zimbabwe", GameID = "paralympics", CategoryID = "outdoor", SportID = "canoe sprint", LogoImage = "zw.png" }
            );
        }
    }
}
