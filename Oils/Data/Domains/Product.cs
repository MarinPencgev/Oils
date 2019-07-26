using System.Collections.Generic;

namespace Oils.Data.Domains
{
    public class Product
    {
        public Product()
        {
            this.Lots = new List<Lot>();
        }
        public string Id { get; set; }

        public string Name { get; set; }

        public string ProductCode { get; set; }

        public string Viscosity { get; set; }

        public int PackageCapacity { get; set; }

        public decimal PackageWeight { get; set; }

        public ICollection<Lot> Lots { get; set; }
    }
}