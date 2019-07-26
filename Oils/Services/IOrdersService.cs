using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oils.Data.Domains;
using Oils.Models;
using Oils.Models.ViewModels;

namespace Oils.Services
{
    public interface IOrdersService
    {
        Order Create(string userId,
                    string purpose,
                    string deliveryAddress, 
                    string receiverName, 
                    string carrierName, 
                    string driverName,
                    string vehicleNumber);
        Order GetOrderById(string id);

        IQueryable<Order> GetAllUncomleted();

        ICollection<Vehicle> GetVehiclesByCarrierName(string name);
        ICollection<Driver> GetDriversByCarrierName(string name);
        void Edit(CreateOrderViewModel input);
        Order Remove(string id);
        Order Release(string id);
    }
}
