using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oils.Data.Domains
{
    public class Carrier
    {
        public Carrier()
        {
            this.Vehicles = new List<Vehicle>();
            this.Drivers = new List<Driver>();
        }
        public string Id { get; set; }

        public string Name { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
        public ICollection<Driver> Drivers { get; set; }
    }
}
