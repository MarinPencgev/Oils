using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oils.Services
{
    public interface IDataSeeder
    {
        void Seed();
        void OrderSeeding();
    }
}
