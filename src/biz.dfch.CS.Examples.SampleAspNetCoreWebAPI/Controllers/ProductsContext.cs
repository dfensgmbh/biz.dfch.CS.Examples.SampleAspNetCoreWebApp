using biz.dfch.CS.Examples.SampleAspNetCoreWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace biz.dfch.CS.Examples.SampleAspNetCoreWebAPI.Controllers
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
