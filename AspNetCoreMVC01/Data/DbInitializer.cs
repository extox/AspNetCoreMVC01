using AspNetCoreMVC01.Models;
using System;
using System.Linq;

namespace AspNetCoreMVC01.Data
{
    public static class DbInitializer
    {
        public static void Initialize(BaseDbContext context)
        {
            // Look for any students.
            if (context.ProductList.Any())
            {
                return;   // DB has been seeded
            }

            var ProductList = new Product[]
            {
                new Product{Id=1,Name="Apple iPhone 12",Price=1200.00m},
                new Product{Id=2,Name="Apple iPhone 11",Price=1100.00m},
                new Product{Id=3,Name="Apple iPhone 10",Price=1000.00m},
                new Product{Id=4,Name="Apple iPhone 8",Price=900.00m}
            };

            context.ProductList.AddRange(ProductList);
            context.SaveChanges();

        }
    }
}