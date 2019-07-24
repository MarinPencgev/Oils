using System.Collections.Generic;

namespace Oils.Data.Domains
{
    public class Vehicle
    {
        public string Id { get; set; }

        public string RegNumber { get; set; }

        public string CarrierId { get; set; }
        public Carrier Carrier { get; set; }
    }
}