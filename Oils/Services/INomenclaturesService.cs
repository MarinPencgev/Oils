using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oils.Services
{
    public interface INomenclaturesService
    {
        int GetRecordings(string entityName);
        ICollection All(string entityType);
    }
}
