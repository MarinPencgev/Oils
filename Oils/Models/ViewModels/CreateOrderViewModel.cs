using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Oils.Data.Domains;

namespace Oils.Models.ViewModels
{
    public class CreateOrderViewModel
    {
        public CreateOrderViewModel()
        {
            this.OrderedProducts = new List<OrderedProducts>();
        }
        public string Id { get; set; }

        public int SequenceNumber { get; set; }
        
        [Display(Name = "Creation date")]
        [DataType(DataType.Date)]    
        public DateTime CreatedOn { get; set; }

        public OrderPurpose Purpose { get; set; } = OrderPurpose.Consumption;

        public OrderStatus Status { get; set; } = OrderStatus.Uncompleted;

        public DeliveryAddress DeliveryAddress { get; set; }

        [Display(Name = "Receiver Name")]
        [DataType(DataType.Text)]
        public Receiver Receiver { get; set; }

        public Carrier Carrier { get; set; }

        public Vehicle Vehicle { get; set; }

        public Driver Driver { get; set; }

        public ICollection<OrderedProducts> OrderedProducts { get; set; }
    }
}
