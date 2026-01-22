using E_Commerce__API.Entities;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce__API.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Basket> Baskets { get; set; }
    }
}
