using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_Core.Models;
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


        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(Product product)
        {
            _repository.Insert(product);
            return RedirectToAction("Index");
        }


        public IActionResult Update(int id)
        {
            
            return View(_repository.GetByID(id));
        }
        [HttpPost]


        public IActionResult Update(Product product)
        {
            _repository.Update(product);
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }


    }
}