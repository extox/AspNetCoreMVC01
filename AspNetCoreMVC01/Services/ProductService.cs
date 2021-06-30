using AspNetCoreMVC01.Data;
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
        private readonly BaseDbContext _context;

        public ProductService(BaseDbContext context)
        {
            _context = context;

            DbInitializer.Initialize(_context);
        }

        public List<Product> GetProductList()
        {
            return _context.ProductList
                    .OrderByDescending(n => n.Id)
                    .ToList();
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
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

        public bool DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
