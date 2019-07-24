using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oils.Data.Domains
{
    public class Driver
    {
        public string Id { get; set; }

        public string FullName { get; set; }

        public string CarrierId { get; set; }
        public Carrier Carrier { get; set; }
    }
}
