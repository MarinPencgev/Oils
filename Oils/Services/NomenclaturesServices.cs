using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oils.Data;

namespace Oils.Services
{
    public class NomenclaturesServices : INomenclaturesService
    {
        private readonly OilsDbContext _context;

        public NomenclaturesServices(OilsDbContext context)
        {
            _context = context;
        }
        public int GetRecordings(string entityName)
        {
            var recordings = 0;
            switch (entityName)
            {
                case "Products":
                    recordings = _context.Products.Count();
                    break;
                case "Receivers":
                    recordings = _context.Receivers.Count();
                    break;
                case "Carriers":
                    recordings = _context.Carriers.Count();
                    break;
                case "Vehicles":
                    recordings = _context.Vehicles.Count();
                    break;
                case "Drivers":
                    recordings = _context.Drivers.Count();
                    break;
            }

            return recordings;
        }

        public ICollection All(string entityType)
        {
            switch (entityType)
            {
                case "Products":
                    return _context.Products.ToList();
                case "Receivers":
                    return _context.Receivers.ToList();
                case "Carriers":
                    return _context.Carriers.ToList();
                case "Vehicles":
                    return _context.Vehicles.ToList();
                case "Drivers":
                    return _context.Drivers.ToList();
            }

            return null;
        }
    }
}
