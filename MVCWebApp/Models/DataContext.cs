using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCWebApp.Models
{
    public class DataContext : DbContext
    {
        public DbSet<CustomerModel> CustomerModels { get; set; }

        public DbSet<LocationModel> LocationModels { get; set; }

        public DbSet<ProductModel> ProductModels { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
