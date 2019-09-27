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
        // GET: /<controller>/
        public IActionResult Index()
        {
            BreakfastOrder breakfastOrder = new BreakfastOrder();
            breakfastOrder.AddBreakfastFood(new BreakfastFood { BreakfastFoodId = 1, Name = "Cornflakes", Price = 36, Selected = false });
            breakfastOrder.AddBreakfastFood(new BreakfastFood { BreakfastFoodId = 2, Name = "Egg", Price = 7, Selected = false });
            breakfastOrder.AddBreakfastFood(new BreakfastFood { BreakfastFoodId = 3, Name = "Toast", Price = 18, Selected = false });
            breakfastOrder.AddBreakfastFood(new BreakfastFood { BreakfastFoodId = 4, Name = "Juice", Price = 40, Selected = false });
            breakfastOrder.AddBreakfastFood(new BreakfastFood { BreakfastFoodId = 5, Name = "Milk", Price = 20, Selected = false });
            breakfastOrder.AddBreakfastFood(new BreakfastFood { BreakfastFoodId = 6, Name = "Coffee", Price = 25, Selected = false });
            breakfastOrder.AddBreakfastFood(new BreakfastFood { BreakfastFoodId = 7, Name = "Tea", Price = 32, Selected = false });

            return View(breakfastOrder);
        }
    }
}
