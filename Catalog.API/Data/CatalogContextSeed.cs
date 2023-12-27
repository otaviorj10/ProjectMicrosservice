using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();

            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetMyProducts());
            }
        }

        public static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "Iphone X",
                    Description = "Lorem ipsum dolor sit amet , consectetur adipisicng",
                    Image="product-1.png",
                    Price = 950.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f6",
                    Name = "Xiami",
                    Description = "Lorem ipsum dolor sit amet , consectetur adipisicng",
                    Image="product-1.png",
                    Price = 950.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f7",
                    Name = "Samsung Galaxy S21",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Image = "product-2.png",
                    Price = 1100.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f8",
                    Name = "Dell XPS 13 Laptop",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Image = "product-3.png",
                    Price = 1500.00M,
                    Category = "Laptop"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f9",
                    Name = "Sony 65-inch 4K Smart TV",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Image = "product-4.png",
                    Price = 2000.00M,
                    Category = "Smart TV"
                }

        };
        }
    }
}