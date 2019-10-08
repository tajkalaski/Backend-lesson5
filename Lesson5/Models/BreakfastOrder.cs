
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lesson5.Models
{
    public class BreakfastOrder
    {
        public string Fullname { get; set; }
        public int? RoomNumber { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy hh: mm}", ApplyFormatInEditMode = true)]
        public DateTime Delivery { get; set; } = DateTime.Now;
        public List<BreakfastFood> BreakfastFoods { get; set; } = new List<BreakfastFood>();

        public void AddBreakfastFood(BreakfastFood thisFood)
        {
            BreakfastFoods.Add(thisFood);
        }

        public BreakfastOrder()
        {
        }

    }
}
