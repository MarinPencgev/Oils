using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Oils.Data;
using Oils.Data.Domains;
using Oils.Models;
using Oils.Models.ViewModels;

namespace Oils.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly OilsDbContext _context;

        public OrdersService(OilsDbContext context)
        {
            _context = context;
        }

        public Order Create(string purpose,
                            string deliveryAddress,
                            string receiverName,
                            string carrierName,
                            string driverName,
                            string vehicleNumber)
        {
            OrderPurpose deliveryPurpose = Enum.Parse<OrderPurpose>(purpose);
            DeliveryAddress address = _context.DeliveryAddresses.FirstOrDefault(x => x.Street == deliveryAddress);
            Receiver receiver = _context.Receivers.FirstOrDefault(x => x.Name == receiverName);
            Carrier carrier = _context.Carriers.FirstOrDefault(x => x.Name == carrierName);
            Driver driver = _context.Drivers.FirstOrDefault(x => x.FullName == driverName && x.CarrierId == carrier.Id);
            Vehicle vehicle = _context.Vehicles.FirstOrDefault(x => x.RegNumber == vehicleNumber && x.CarrierId == carrier.Id);

            int lastSequence = _context.Orders.Max(x => int.Parse(x.SequenceNumber));

            var order = new Order()
            {
                SequenceNumber = (lastSequence + 1).ToString(),
                CreatedOn = DateTime.UtcNow,
                Purpose = deliveryPurpose,
                Status = OrderStatus.Uncompleted,

                DeliveryAddress = address,
                Receiver = receiver,
                Carrier = carrier,
                Driver = driver,
                Vehicle = vehicle
            };

            _context.Orders.Add(order);
            _context.SaveChanges();

            return order;
        }

        public Order GetOrderById(string id)
        {
            var order = _context.Orders
                .Include(x => x.DeliveryAddress)
                .Include(x => x.Receiver)
                .Include(x => x.Carrier)
                .Include(x => x.Driver)
                .Include(x => x.Vehicle)
                .Include(x => x.Products)
                .ThenInclude(x => x.Product)
                .SingleOrDefault(x => x.Id == id);
            return order;
        }


        public IQueryable<Order> GetAllUncomleted()
        {
            return _context.Orders
                .Include(x => x.DeliveryAddress)
                .Include(x => x.Driver)
                .Include(x => x.Vehicle)
                .Include(x => x.Receiver)
                .Include(x => x.Carrier)
                .Include(x => x.Products)
                .ThenInclude(x => x.Product)
                .Where(x => x.Status == OrderStatus.Uncompleted && x.isDeleted == false);
        }

        public ICollection<Vehicle> GetVehiclesByCarrierName(string name)
        {
            return _context.Vehicles.Where(x => x.Carrier.Name == name).ToList();
        }

        public ICollection<Driver> GetDriversByCarrierName(string name)
        {
            return _context.Drivers.Where(x => x.Carrier.Name == name).ToList();
        }

        public void Edit(CreateOrderViewModel input)
        {
            var order = _context.Orders
                .Include(x => x.Products)
                .ThenInclude(x => x.Product)
                .FirstOrDefault(x => x.Id == input.Id);

            order.CreatedOn = input.CreatedOn;
            order.Purpose = input.Purpose;
            order.SequenceNumber = input.SequenceNumber;
            order.Status = input.Status;
            order.DeliveryAddress = input.DeliveryAddress;
            order.Receiver = input.Receiver;
            order.Carrier = input.Carrier;
            order.Driver = input.Driver;
            order.Vehicle = input.Vehicle;
            order.Products = input.OrderedProducts;

            _context.SaveChanges();
        }

        public Order Remove(string id)
        {
            var order = _context.Orders.First(x => x.Id == id);
            order.isDeleted = true;

            _context.SaveChanges();

            return order;
        }

        public Order Release(string id)
        {
            var order = _context.Orders.First(x => x.Id == id);
            order.Status = OrderStatus.Completed;
            order.ReleaseDate = DateTime.UtcNow;

            _context.SaveChanges();

            return order;
        }
    }

}
