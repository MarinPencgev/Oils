using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Oils.Models.ViewModels;
using Oils.Services;

namespace Oils.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsService _productsService;
        private readonly IOrdersService _ordersService;

        public ProductsController(IProductsService productsService, IOrdersService ordersService)
        {
            _productsService = productsService;
            _ordersService = ordersService;
        }

        public IActionResult Add(string id)
        {
            var model = new ProductInputViewModel
            {
                OrderId = id
            };

            return this.View(model);
        }

        [HttpPost]
        public IActionResult Add(string id, ProductInputViewModel productInput)
        {
            if (!ModelState.IsValid)
            {
                return this.View(productInput); 
            }
            var currentOrderId = id;
            var orderedProduct = _productsService.Add(currentOrderId,
                                                      productInput.ProductCode,
                                                      productInput.ProductName,
                                                      productInput.Count,
                                                      productInput.Weight);

            return Redirect($"/Orders/Edit?id={orderedProduct.OrderId}");
        }

        public IActionResult Remove(string id)
        {
            _productsService.Remove(id);

            var currentOrderId = id.Substring(0,36);
            return Redirect($"/Orders/Edit?id={currentOrderId}");
        }
    }
}