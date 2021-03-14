using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicGamesDataTransfer.Models
{
    public class CountryListViewModel : CountryViewModel
    {
        public List<Country> Countries { get; set; }

        // use full properties for Games and Categories
        // so can add 'All' item at beginning
        private List<Game> games;
        public List<Game> Games
        {
            get => games;
            set
            {
                games = value;
                games.Insert(0,
                    new Game { GameID = "all", Name = "All" });
            }
        }

        private List<Category> categories;
        public List<Category> Categories
        {
            get => categories;
            set
            {
                categories = value;
                categories.Insert(0,
                    new Category { CategoryID = "all", Name = "All" });
            }
        }

        private List<Sport> sports;
        public List<Sport> Sports
        {
            get => sports;
            set
            {
                sports = value;
                sports.Insert(0,
                    new Sport { SportID = "all", Name = "All" });
            }
        }

        // methods to help view determine active link
        public string CheckActiveGame(string c) =>
            c.ToLower() == ActiveGame.ToLower() ? "active" : "";

        public string CheckActiveCatg(string d) =>
        d.ToLower() == ActiveCatg.ToLower() ? "active" : "";

        public string CheckActiveSport(string s) =>
        s.ToLower() == ActiveSport.ToLower() ? "active" : "";
    }
}
