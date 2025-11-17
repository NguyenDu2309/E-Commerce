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
                new Product
                {
                    Name = "Product 3",
                    Description = "Description for product 3",
                    Price = 15.50M,
                    PictureUrl = "/images/products/product3.png",
                    Brand = "Brand C",
                    Type = "Type Z",
                    QuantityInStock = 150
                },
                new Product
                {
                    Name = "Product 4",
                    Description = "Description for product 4",
                    Price = 5.75M,
                    PictureUrl = "/images/products/product4.png",
                    Brand = "Brand D",
                    Type = "Type X",
                    QuantityInStock = 80
                },
                new Product
                {
                    Name = "Product 5",
                    Description = "Description for product 5",
                    Price = 12.00M,
                    PictureUrl = "/images/products/product5.png",
                    Brand = "Brand E",
                    Type = "Type Y",
                    QuantityInStock = 60
                },
                new Product
                {
                    Name = "Product 6",
                    Description = "Description for product 6",
                    Price = 30.00M,
                    PictureUrl = "/images/products/product6.png",
                    Brand = "Brand F",
                    Type = "Type Z",
                    QuantityInStock = 40
                },
                new Product
                {
                    Name = "Product 7",
                    Description = "Description for product 7",
                    Price = 25.99M,
                    PictureUrl = "/images/products/product7.png",
                    Brand = "Brand G",
                    Type = "Type X",
                    QuantityInStock = 70
                }
            };
            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}
