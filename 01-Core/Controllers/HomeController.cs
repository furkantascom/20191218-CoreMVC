using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_Core.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace _01_Core.Controllers
{

    public class HomeController : Controller
    {
        IProductRepository _repository;
        public HomeController(IProductRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View(_repository.Products);
        }
    }
}