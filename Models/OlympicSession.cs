using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicGamesDataTransfer.Models
{
    public class OlympicSession
    {
        private const string CountriesKey = "mycountries";
        private const string CountKey = "countriescount";
        private const string GameKey = "game";
        private const string CatgKey = "catg";

        private ISession session { get; set; }
        public OlympicSession(ISession session)
        {
            this.session = session;
        }

        public void SetMyCountries(List<Country> countries)
        {
            session.SetObject(CountriesKey, countries);
            session.SetInt32(CountKey, countries.Count);
        }
        public List<Country> GetMyCountries() =>
            session.GetObject<List<Country>>(CountriesKey) ?? new List<Country>();
        public int? GetMyCountryCount() => session.GetInt32(CountKey);

        public void SetActiveGame(string game) =>
            session.SetString(GameKey, game);
        public string GetActiveGame() => session.GetString(GameKey);

        public void SetActiveCatg(string category) =>
            session.SetString(CatgKey, category);
        public string GetActiveCatg() => session.GetString(CatgKey);

        public void RemoveMyCountries()
        {
            session.Remove(CountriesKey);
            session.Remove(CountKey);
        }
    }
}
