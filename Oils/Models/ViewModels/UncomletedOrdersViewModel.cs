using System;
using System.Collections.Generic;
using System.Linq;
namespace Oils.Models.ViewModels
{
    public class UncomletedOrdersViewModel
    {
        public string OrderId { get; set; }
        public int Sequence { get; set; }
        public string ReceiverName { get; set; }
        public int OrderedPackagesCount { get; set; }
        public decimal OrderedPackagesWeight { get; set; }
        public string DeliveryAddress { get; set; }
    }
}
