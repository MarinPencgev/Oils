using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oils.Data.Domains;

namespace Oils.Services
{
    public interface IReceiverService
    {
        Receiver GetReceiverById(string id);
    }
}
