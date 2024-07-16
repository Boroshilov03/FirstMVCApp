using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel() { Name="Ball", Age=13};
            return View(doggo);
        }

        public string Hello()
        {
            return "Hello";
        }
    }
}
