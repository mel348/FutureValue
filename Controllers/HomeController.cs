using Microsoft.AspNetCore.Mvc;
using FutureValue.Models;

namespace FutureValue.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]                               //a get method that's going to display the empty form
        public IActionResult Index()            //data to be shared with the view
        {
            ViewBag.FV = 0;
            return View();
        }
        [HttpPost]
        /*a post action method that is going to be executed when that form is submitted 
        it's going to come back to the controller and we're going to create a 
        model object, because we are going to have the model data.  We can then take
        that data and store it.  Then call/route our view, pass the data, and get passed to the view bag*/
        public IActionResult Index(FutureValueModel model)
        {
            if (ModelState.IsValid) { 
                ViewBag.FV = model.CalculateFutureValue();
            }
            else { 
                ViewBag.FV = 0;
            }

            return View(model);
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Welcome()
        {
            return View();
        }
    }
}
