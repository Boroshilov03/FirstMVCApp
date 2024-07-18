using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {

        private static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()
        {
            return View(dogs);
        }

        //Shows the form
        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }


        //Submits the form
        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            //return View("Index");
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }
        public string Hello()
        {
            return "Hello";
        }
    }
}
