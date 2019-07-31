using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oils.Data;
using Oils.Data.Domains;

namespace Oils.Services
{
    public class ReceiverService:IReceiverService
    {
        private readonly OilsDbContext _context;

        public ReceiverService(OilsDbContext context)
        {
            _context = context;
        }
        public Receiver GetReceiverById(string id)
        {
            var receiver = _context.Receivers.First(x => x.Id == id);
            return receiver;
        }


    }
}
