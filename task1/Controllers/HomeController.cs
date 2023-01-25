using Microsoft.AspNetCore.Mvc;
using task1.Models;

namespace task1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Brands> brands = new List<Brands>
           {
                new Brands{Id=1,BrandNames="BMW"},
                new Brands{Id=2,BrandNames="Geely"},
                new Brands{Id=3,BrandNames="Lamborghini"},
           };
            return View(brands);
        }
    }
}
