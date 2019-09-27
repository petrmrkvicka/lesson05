using System;
namespace Lesson05.Models
{
    public class BreakfastFood
    {
        public int BreakfastFoodId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool Selected { get; set; }


        public BreakfastFood()
        {
        }
    }
}
