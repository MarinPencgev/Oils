using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oils.Data.Domains
{
    public class DeliveryAddress
    {
        public string Id { get; set; }

        public string Town { get; set; }

        public string Street { get; set; }

        public string ReceiverId { get; set; }
        public Receiver Receiver { get; set; }
    }
}
