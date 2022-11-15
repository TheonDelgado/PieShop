using System;
using PieShop.Models;
using PieShop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace PieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            this.pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PiesOfTheWeek = pieRepository.PiesOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
