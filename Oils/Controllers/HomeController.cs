using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Oils.Data;
using Oils.Data.Domains;
using Oils.Models;
using Oils.Models.ViewModels;
using Oils.Services;

namespace Oils.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataSeeder _seeder;
        private readonly IOrdersService ordersService;

        public HomeController(IDataSeeder seeder, IOrdersService ordersService)
        {
            _seeder = seeder;
            this.ordersService = ordersService;
        }
        public IActionResult Index()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                //_seeder.Seed();      // Първо се сийдват всички ентитита 
                //_seeder.OrderSeeding(); // После се сийдват ордърите

                var uncompletedOrders = this.ordersService.GetAllUncomleted();

                var model = uncompletedOrders.Select(x => new CreateOrderViewModel
                {
                    Id = x.Id,
                    SequenceNumber = x.SequenceNumber,
                    CreatedOn = x.CreatedOn,
                    Purpose = x.Purpose,
                    Status = x.Status,
                    Receiver = x.Receiver,
                    Carrier = x.Carrier,
                    Driver = x.Driver,
                    Vehicle = x.Vehicle,
                    DeliveryAddress =x.DeliveryAddress,
                    OrderedProducts = x.Products,

                })
                    .OrderBy(x=>x.SequenceNumber)
                    .ToList(); ;

                return this.View("IndexLoggedIn", model);
            }
            else
            {
                return this.View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
