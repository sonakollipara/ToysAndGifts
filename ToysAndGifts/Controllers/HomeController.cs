using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToysAndGifts.Interfaces;
using ToysAndGifts.Models;
using ToysAndGifts.ViewModels;

namespace ToysAndGifts.Controllers
{
    public class HomeController : Controller
    {
        private readonly IToysRepository _toysRepository;
        public HomeController(IToysRepository toysRepository)
        {
            _toysRepository = toysRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredToys = _toysRepository.PreferredToys
            };
            return View(homeViewModel);
        }
    }
}
