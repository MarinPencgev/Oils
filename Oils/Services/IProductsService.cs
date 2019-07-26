using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oils.Data.Domains;
using Oils.Models;

namespace Oils.Services
{
    public interface IProductsService
    {
        OrderedProducts Add(string orderId, string productCode, string productName, string packegesCount, string packegesWeight);
        OrderedProducts Remove(string id);
        ICollection<OrderedProducts> GetProductsByOrderId(string inputId);
        ICollection<Product> GetAll();
        Product Create(string name, string productCode, string viscosity, int packagesCapacity, decimal packagesWeight);
    }
}
