using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekti_GamesWebsite.Controllers
{
    public class GameController : Controller
    {
        public ActionResult Search(string search = "")
        {
            var books = new List<Models.Games>();
            foreach (var game in Core.GamesManager.Games)
            {
                if (game.Title.ToLower().IndexOf(search.ToLower()) > -1 ||
                    game.Platform.ToLower().IndexOf(search.ToLower()) > -1 ||
                        game.SKU.ToLower().IndexOf(search.ToLower()) > -1)
                    books.Add(game);
            }
            return View(books);
        }
        public ActionResult Details(string referenca = "")
        {
            if (string.IsNullOrEmpty(referenca))
                return Redirect(Url.Content("~/"));
            var book = Core.GamesManager.Games.Where(x => x.Referenca.Replace("-", "") == referenca.Replace("-", "")).FirstOrDefault();
            return View("Book", book);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.Games game)
        {
            if (ModelState.IsValid)
            {
                var categories = new List<string>();
                if (Request.Form["Categories"] != null)
                    categories = Request.Form["Categories"].Split(',').ToList();
                game.Categories = categories;
                Core.GamesManager.Games.Add(game);
                return Redirect("Details?referenca=" + game.Referenca);
            }
            return Redirect("Create");
        }
    }
}