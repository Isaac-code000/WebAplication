using System.Diagnostics;
using ContatosWebMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContatosWebMvc.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            HomeModel home = new HomeModel();
            home.Nome = "Isaac";
            home.Email = "isaac.cade18@gmail.com";
            return View(home);
        }

        public IActionResult Privacy()
        {
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
