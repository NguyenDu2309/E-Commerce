using E_Commerce__API.Entities;

namespace E_Commerce__API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;
            var products = new List<Product>
            {
                new Product
                {
                    Name = "Product 1",
                    Description = "Description for product 1",
                    Price = 10.99M,
                    PictureUrl = "/images/products/product1.png",
                    Brand = "Brand A",
                    Type = "Type X",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Product 2",
                    Description = "Description for product 2",
                    Price = 20.99M,
                    PictureUrl = "/images/products/product2.png",
                    Brand = "Brand B",
                    Type = "Type Y",
                    QuantityInStock = 200
                },
                // Add more products as needed
            };
        }
    }
}
