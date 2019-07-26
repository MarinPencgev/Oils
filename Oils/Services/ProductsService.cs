using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oils.Data;
using Oils.Data.Domains;
using Oils.Models;
using Remotion.Linq.Parsing.Structure.IntermediateModel;

namespace Oils.Services
{
    public class ProductsService : IProductsService
    {
        private readonly OilsDbContext _context;

        public ProductsService(OilsDbContext context)
        {
            _context = context;
        }

        public OrderedProducts Add(string orderId, string productCode, string productName, string packegesCount, string packegesWeight)
        {
            var product = _context.Products.FirstOrDefault(x => x.ProductCode == productCode && x.Name == productName);

            var orderedProduct = new OrderedProducts()
            {
                OrderedPackagesCount = int.Parse(packegesCount),
                OrderedPackagesWeight = decimal.Parse(packegesWeight),
                ProductId = product.Id,
                OrderId = orderId, // TODO to find current orderId
            };

            _context.OrderedProducts.Add(orderedProduct);
            _context.SaveChanges();

            return orderedProduct;
        }

        public OrderedProducts Remove(string id)
        {
           var orderedProduct = _context.OrderedProducts.First(x => x.OrderId + x.ProductId == id);

           _context.OrderedProducts.Remove(orderedProduct);
           _context.SaveChanges();

           return orderedProduct;
        }

        public ICollection<OrderedProducts> GetProductsByOrderId(string id)
        {
            return _context.OrderedProducts.Where(x => x.OrderId == id).ToList();
        }

        public ICollection<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product Create(string name, string productCode, string viscosity, int packagesCapacity, decimal packagesWeight)
        {
            var product = new Product()
            {
                Name = name,
                ProductCode = productCode,
                Viscosity = viscosity,
                PackageCapacity = packagesCapacity,
                PackageWeight = packagesWeight,
            };

            _context.Products.Add(product);
            _context.SaveChanges();

            return product;
        }
    }
}
