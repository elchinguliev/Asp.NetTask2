using Asp_task2.Entities;
using Asp_task2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_task2.Controllers
{
    public class HomeController : Controller
    {
      public static  List<Product> Products = new List<Product>
        {
                new Product
                {
                    ProductId= 1,
                    ProductName = "Badamli",
                    ProductDescription = "Made in Azerbaijan",
                    ProductDiscount=2,
                    ProductPrice=1

                },
                new Product
                {
                    ProductId= 2,
                    ProductName = "Cola",
                    ProductDescription = "Made in Israel",
                    ProductDiscount=3,
                    ProductPrice=2
                },
                new Product
                {
                    ProductId= 3,
                    ProductName = "Jack Daniels",
                    ProductDescription = "Made in America",
                    ProductDiscount=4,
                    ProductPrice=53
                },

        };
        public IActionResult Index()
        {
            var vm = new ProductViewModel()
            {
                Products=Products
            };

            return View(vm);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var apwm = new AddProductViewModell
            {
                Product=new Product()
            };
            return View(apwm);
        }


        [HttpPost]
        public IActionResult Add(AddProductViewModell apwm)
        {
            if (ModelState.IsValid)
            {
                
                Products.Add(apwm.Product);
                apwm.Product.ProductId = Products.Count;
                return RedirectToAction("index");

            }
            return View(apwm);

        }

        public IActionResult Delete(int id)
        {
       
            var prod = Products[--id];
            Products.Remove(prod);
            for (int i = (id); i < Products.Count; i++)
            {
                Products[i].ProductId--;
            }
            return RedirectToAction("index");
        }

    }
}




