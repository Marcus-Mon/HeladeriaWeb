using Microsoft.AspNetCore.Mvc;

namespace HeladeriaWeb.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            if (username == "admin" && password == "1234")
            {
                return RedirectToAction("Index", "Sabores");
            }

            ViewBag.Error = "Credenciales incorrectas";
            return View();
        }
    }
}
