using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekti_GamesWebsite.Controllers
{
    
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            return Redirect(Url.Content("~/"));
        }
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Models.LoginModelView loginInfo)
        {
            Models.Person user = Core.GamesManager.Admins.Where(x => x.Username == loginInfo.Name && x.Password == loginInfo.Password).FirstOrDefault();
            if (user == null)
                user = Core.GamesManager.Users.Where(x => x.Username == loginInfo.Name && x.Password == loginInfo.Password).FirstOrDefault();
            if (user != null)
            {
                Session["username"] = user.Username;
                Session["personType"] = user.PersonType;
                Session["products"] = new Dictionary<string, int>();
                return Redirect(Url.Content("~/"));
            }
            else
            {
                loginInfo.Error = "Nuk u autorizua me sukses";
                return View(loginInfo);
            }
        }
        [HttpGet]
        public ActionResult Logout()
        {
            Session.Abandon();
            return Redirect("~/");
        }
        public string Add()
        {
            if (Session["username"] == null)
                return "Login fillimisht";
            if (Request.Form["reference"] != null)
            {
                var reference = Request.Form["reference"];
                var quantity = int.Parse(Request.Form["quantity"]);
                var book = Core.GamesManager.Games.Where(x => x.Referenca == reference).FirstOrDefault();
                if (book != null)
                {
                    if (book.Quantity > quantity)
                    {
                        ((Dictionary<string, int>)Session["products"]).Add(book.Referenca, quantity);
                        return "Book added";
                    }
                    else
                    {
                        return "S'ka gjendje";
                    }
                }
            }
            return "Error!";
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        

    }
}