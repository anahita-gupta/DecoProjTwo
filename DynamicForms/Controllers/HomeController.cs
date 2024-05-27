using Microsoft.AspNetCore.Mvc;
using DynamicForms.Models;

namespace DynamicForms.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new FormModel());
        }

        [HttpPost]
        public IActionResult Index(FormModel model)
        {
            if (model.AgeMandatory && !model.Age.HasValue)
            {
                ModelState.AddModelError("Age", "Age is required.");
            }

            if (model.GenderMandatory && string.IsNullOrWhiteSpace(model.Gender))
            {
                ModelState.AddModelError("Gender", "Gender is required.");
            }

            if (ModelState.IsValid)
            {
                
                Console.WriteLine($"Name: {model.Name}");
                Console.WriteLine($"Age: {model.Age}");
                Console.WriteLine($"Gender: {model.Gender}");

                return RedirectToAction("Success");
            }

            return View(model);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
