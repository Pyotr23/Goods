using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Goods.Models;
using Microsoft.AspNetCore.Mvc;

namespace Goods.Controllers
{
    public class HomeController : Controller
    {
        private IGoodsRepository repository;

        public HomeController(IGoodsRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index()
        {
            return View(repository.Goods);
        }

    }
}
