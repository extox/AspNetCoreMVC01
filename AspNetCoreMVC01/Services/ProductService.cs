using AspNetCoreMVC01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVC01.Services
{
    public class ProductService : IProductService
    {
        public List<Product> GetProductList()
        {
            return new List<Product>
            {
                new Product() {PNo=1001, Name="Apple Iphone12", Price=800.00m},
                new Product() {PNo=1002, Name="Samesung Gallaxy20", Price=900.00m},
                new Product() {PNo=1003, Name="Samesung Gallaxy10", Price=500.00m},
                new Product() {PNo=1004, Name="Apple MacBook Pro M1", Price=2100.00m}

            };
            throw new NotImplementedException();
        }

        public Product GetProduct(int PNo)
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

        public bool DeleteProduct(int PNo)
        {
            throw new NotImplementedException();
        }
    }
}
