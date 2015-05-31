namespace ProductWebApi.Migrations
{
    using ProductWebApi.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductWebApi.Models.ProductContext>
    {
        /// <summary>
        /// Configuration constructor
        /// </summary>
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        /// <summary>
        /// Seed
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(ProductWebApi.Models.ProductContext context)
        {
            //  This method will be called after migrating to the latest version.
            //  Add records to Products table
            context.Products.AddOrUpdate(p => p.Id,
                new Product { Id = 1, Name = "Sudhir Product 1", Category = "Category 1", Price = 100 },
                new Product { Id = 2, Name = "Sudhir Product 2", Category = "Category 2", Price = 200 },
                new Product { Id = 3, Name = "Sudhir Product 3", Category = "Category 3", Price = 300 },
                new Product { Id = 4, Name = "Sudhir Product 4", Category = "Category 4", Price = 400 },
                new Product { Id = 5, Name = "Sudhir Product 5", Category = "Category 5", Price = 500 },
                new Product { Id = 6, Name = "Sudhir Product 6", Category = "Category 6", Price = 600 },
                new Product { Id = 7, Name = "Sudhir Product 7", Category = "Category 7", Price = 700 },
                new Product { Id = 8, Name = "Sudhir Product 8", Category = "Category 8", Price = 800 },
                new Product { Id = 9, Name = "Sudhir Product 9", Category = "Category 9", Price = 900 },
                new Product { Id = 10, Name = "Sudhir Product 10", Category = "Category 10", Price = 1000 }
                );
        }
    }
}
