using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson05.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lesson05.Controllers
{
    public class Exercise03Controller : Controller
    {
        [HttpPost]
        public IActionResult Index(BreakfastOrder breakfastOrder)
        {
            return View("Receipt", breakfastOrder);
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            BreakfastOrder breakfastOrder = new BreakfastOrder();
            breakfastOrder.AddBreakfastFood(new BreakfastFood { BreakfastFoodId = 1, Name = "Cornflakes", Price = 36M, Selected = false });
            breakfastOrder.AddBreakfastFood(new BreakfastFood { BreakfastFoodId = 2, Name = "Egg", Price = 7M, Selected = false });
            breakfastOrder.AddBreakfastFood(new BreakfastFood { BreakfastFoodId = 3, Name = "Toast", Price = 18M, Selected = false });
            breakfastOrder.AddBreakfastFood(new BreakfastFood { BreakfastFoodId = 4, Name = "Juice", Price = 40M, Selected = false });
            breakfastOrder.AddBreakfastFood(new BreakfastFood { BreakfastFoodId = 5, Name = "Milk", Price = 20M, Selected = false });
            breakfastOrder.AddBreakfastFood(new BreakfastFood { BreakfastFoodId = 6, Name = "Coffee", Price = 25M, Selected = false });
            breakfastOrder.AddBreakfastFood(new BreakfastFood { BreakfastFoodId = 7, Name = "Tea", Price = 32M, Selected = false });

            return View(breakfastOrder);
        }
    }
}
