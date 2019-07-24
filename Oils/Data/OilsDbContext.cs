using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Oils.Data.Domains;

namespace Oils.Data
{
    public class OilsDbContext : IdentityDbContext<OilsUser>
    {
        public OilsDbContext(DbContextOptions<OilsDbContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderedProducts> OrderedProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Lot> Lots { get; set; }
        public DbSet<DeliveryAddress> DeliveryAddresses { get; set; }
        public DbSet<Receiver> Receivers { get; set; }
        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<OrderedProducts>().HasKey(x => new { x.OrderId, x.ProductId });
        }
    }
}
