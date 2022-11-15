using System;
using System.Collections.Generic;

namespace PieShop.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}
