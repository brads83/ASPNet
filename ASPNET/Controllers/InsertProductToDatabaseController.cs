using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNET.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET.Controllers
{
    public class InsertProductToDatabaseController : Controller
    {
        private readonly IProductRepository repo;

        public InsertProductToDatabaseController(IProductRepository repo)
        {
            this.repo = repo;
        }
            public IActionResult InsertProductToDatabase(Product productToInsert)
        {
            repo.InsertProduct(productToInsert);

            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}