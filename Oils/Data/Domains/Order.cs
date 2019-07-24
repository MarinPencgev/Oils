using System;
using System.Collections.Generic;
using Oils.Models;

namespace Oils.Data.Domains
{
    public class Order
    {
        public Order()
        {
            this.Products = new List<OrderedProducts>();
        }
        public string Id { get; set; }

        public string SequenceNumber { get; set; } 

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public DateTime ReleaseDate { get; set; }

        public bool isDeleted { get; set; }

        public OrderPurpose Purpose { get; set; } = OrderPurpose.Consumption;

        public OrderStatus Status { get; set; } = OrderStatus.Uncompleted;

        public string DeliveryAddressId { get; set; }
        public virtual DeliveryAddress DeliveryAddress { get; set; }

        public string CarrierId { get; set; }
        public virtual Carrier Carrier { get; set; }

        public string ReceiverId { get; set; }
        public virtual Receiver Receiver { get; set; }

        public string DriverId { get; set; }
        public virtual Driver Driver { get; set; }

        public string VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }

        public ICollection<OrderedProducts> Products { get; set; }
    }
}
