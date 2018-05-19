using BethanyPieShop.Models;
using BethanyPieShop.Repositories;
using BethanyPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BethanyPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Title = "Welcome to Bethny's Pie Store",
                Pies = _pieRepository
                       .GetAllPies()
                       .OrderBy(p => p.Name)
            };
            return View(homeViewModel);
        }


        public IActionResult Details(int id)
        {
            Pie pie = _pieRepository.GetPieById(id);

            return View(pie);
        }
    }
}