using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OlympicGamesDataTransfer.Models;
using System.Collections.Generic;
using System.Linq;

namespace OlympicGamesDataTransfer.Controllers
{
    public class HomeController : Controller
    {
        private CountryContext context;

        public HomeController(CountryContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index(CountryListViewModel model)
        {
            model.Categories = context.Categories.ToList();
            model.Games = context.Games.ToList();
            model.Sports = context.Sports.ToList();

            var session = new OlympicSession(HttpContext.Session);
            session.SetActiveGame(model.ActiveGame);
            session.SetActiveCatg(model.ActiveCatg);
            session.SetActiveSport(model.ActiveSport);

            int? count = session.GetMyCountryCount();
            if(count == null)
            {
                var cookies = new OlympicCookies(Request.Cookies);
                string[] ids = cookies.GetMyCountryIds();

                List<Country> mycountries = new List<Country>();
                if (ids.Length > 0)
                    mycountries = context.Countries.Include(t => t.Game)
                        .Include(t => t.Category)
                        .Include(t => t.Sport)
                        .Where(t => ids.Contains(t.CountryID)).ToList();
                session.SetMyCountries(mycountries);
            }


            IQueryable<Country> query = context.Countries;
            if (model.ActiveGame != "all")
                query = query.Where(
                    t => t.Game.GameID.ToLower() == model.ActiveGame.ToLower());
            if (model.ActiveCatg != "all")
                query = query.Where(
                    t => t.Category.CategoryID.ToLower() == model.ActiveCatg.ToLower());
            if (model.ActiveSport != "all")
                query = query.Where(
                    t => t.Sport.SportID.ToLower() == model.ActiveSport.ToLower());
            model.Countries = query.ToList();

            return View(model);
        }

        public IActionResult Details(string id)
        {
            var session = new OlympicSession(HttpContext.Session);
            var model = new CountryViewModel
            {
                Country = context.Countries
                .Include(t => t.Game)
                .Include(t => t.Category)
                .Include(t => t.Sport)
                .FirstOrDefault(testc => testc.CountryID == id),
                ActiveCatg = session.GetActiveCatg(),
                ActiveGame = session.GetActiveGame(),
                ActiveSport = session.GetActiveSport()
            };
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Add(CountryViewModel model)
        {
            model.Country = context.Countries
                .Include(t => t.Game)
                .Include(t => t.Category)
                .Include(t => t.Sport)
                .Where(t => t.CountryID == model.Country.CountryID)
                .FirstOrDefault();

            var session = new OlympicSession(HttpContext.Session);
            var countries = session.GetMyCountries();
            countries.Add(model.Country);
            session.SetMyCountries(countries);

            var cookies = new OlympicCookies(HttpContext.Response.Cookies);
            cookies.SetMyCountryIds(countries);

            TempData["message"] = $"{model.Country.Name} added to your favorites";

            return RedirectToAction("Index",
                new
                {
                    ActiveGame = session.GetActiveGame(),
                    ActiveCatg = session.GetActiveCatg(),
                    ActiveSport = session.GetActiveSport()
                });
        }
    }
}
