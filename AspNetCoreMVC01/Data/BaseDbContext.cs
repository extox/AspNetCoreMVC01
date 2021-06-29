using AspNetCoreMVC01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVC01.Data
{
    public class BaseDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public BaseDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Product> ProductList { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("AzureSQLServerConnection"));
            }

        }
    }
}
