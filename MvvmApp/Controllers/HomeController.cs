using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvvmApp.Models;
using MvvmApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MvvmApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("GetVm")]
        public IActionResult GetVm()
        {
            var m = new OrderInfoVm()
            {
                Order = new Order()
                {
                    Id = 1001,
                    Customer = new Customer
                    {
                        Id = 1,
                        Name = "Ken Ling"
                    },
                    OrderNote = "This is the note",
                    Products = new List<Product>()
                    {
                         new Product()
                        {
                            ID = 201,
                            Name = "Product 1"
                        },
                         new Product()
                         {
                             ID = 203,
                             Name = "Product 2"
                         }
                    }

                }
                ,
                Profile = new Profile()
                {
                    Id = 100001,
                    Hobby = "Play badminton"
                }
            };
            return Json(m);
        }

        public IActionResult Index()
        {
            

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
