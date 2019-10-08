using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lesson5.Models;

namespace Lesson5.Controllers
{
    public class Exercise03Controller : Controller

    {
        [HttpPost]
        public IActionResult Index(BreakfastOrder breakfastOrder)
        {
            return View("Receipt", breakfastOrder);
        }

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