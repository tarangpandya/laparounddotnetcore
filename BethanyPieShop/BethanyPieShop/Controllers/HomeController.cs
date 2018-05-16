using BethanyPieShop.Repositories;
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
            return View(_pieRepository.GetAllPies().OrderBy(p => p.Name));
        }
    }
}