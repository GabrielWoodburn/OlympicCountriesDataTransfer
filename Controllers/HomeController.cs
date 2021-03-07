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

        public IActionResult Index(string activeGame = "all",
                                   string activeCatg = "all")
        {
            var session = new OlympicSession(HttpContext.Session);
            session.SetActiveGame(activeGame);
            session.SetActiveCatg(activeCatg);

            int? count = session.GetMyCountryCount();
            if(count == null)
            {
                var cookies = new OlympicCookies(Request.Cookies);
                string[] ids = cookies.GetMyCountryIds();

                List<Country> mycountries = new List<Country>();
                if (ids.Length > 0)
                    mycountries = context.Countries.Include(t => t.Game)
                        .Include(t => t.Category)
                        .Where(t => ids.Contains(t.CountryID)).ToList();
                session.SetMyCountries(mycountries);
            }

            var model = new CountryListViewModel
            {
                ActiveGame = activeGame,
                ActiveCatg = activeCatg,
                Games = context.Games.ToList(),
                Categories = context.Categories.ToList()
            };


            IQueryable<Country> query = context.Countries;
            if (activeGame != "all")
                query = query.Where(
                    t => t.Game.GameID.ToLower() == activeGame.ToLower());
            if (activeCatg != "all")
                query = query.Where(
                    t => t.Category.CategoryID.ToLower() == activeCatg.ToLower());
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
                .FirstOrDefault(testc => testc.CountryID == id),
                ActiveCatg = session.GetActiveCatg(),
                ActiveGame = session.GetActiveGame()
            };
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Add(CountryViewModel model)
        {
            model.Country = context.Countries
                .Include(t => t.Game)
                .Include(t => t.Category)
                .Where(t => t.CountryID == model.Country.CountryID)
                .FirstOrDefault();

            var session = new OlympicSession(HttpContext.Session);
            var countries = session.GetMyCountries();
            countries.Add(model.Country);
            session.SetMyCountries(countries);

            var cookies = new OlympicCookies(Response.Cookies);
            cookies.SetMyCountryIds(countries);

            TempData["message"] = $"{model.Country.Name} added to your favorites";

            return RedirectToAction("Index",
                new
                {
                    ActiveGame = session.GetActiveGame(),
                    ActiveCatg = session.GetActiveCatg()
                });
        }
    }
}
