using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OlympicGamesDataTransfer.Models;
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
            var data = new CountryListViewModel
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
            data.Countries = query.ToList();

            return View(data);
        }

        [HttpPost]
        public IActionResult Details(CountryViewModel model)
        {
            Utility.LogTeamClick(model.Country.CountryID);

            TempData["ActiveGame"] = model.ActiveGame;
            TempData["ActiveCatg"] = model.ActiveCatg;
            return RedirectToAction("Details", new { ID = model.Country.CountryID });
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            var model = new CountryViewModel
            {
                Country = context.Countries
                    .Include(t => t.Game)
                    .Include(t => t.Category)
                    .FirstOrDefault(t => t.CountryID == id),
                ActiveCatg = TempData?["ActiveCatg"]?.ToString() ?? "all",
                ActiveGame = TempData?["ActiveGame"]?.ToString() ?? "all"
            };
            return View(model);
        }
    }
}
