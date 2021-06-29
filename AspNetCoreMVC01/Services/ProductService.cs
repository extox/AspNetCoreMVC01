using AspNetCoreMVC01.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVC01.Services
{
    public class ProductService : IProductService
    {
        private readonly IConfiguration _configuration;

        public ProductService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public List<Product> GetProductList()
        {
            using (var db = new BaseDbContext(_configuration))
            {
                return db.ProductList
                    .OrderByDescending(n => n.Id)
                    .ToList();
            }
            throw new NotImplementedException();
        }

        public Product GetProduct(int Id)
        {
            throw new NotImplementedException();
        }

        public bool AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public bool EditProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProduct(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
