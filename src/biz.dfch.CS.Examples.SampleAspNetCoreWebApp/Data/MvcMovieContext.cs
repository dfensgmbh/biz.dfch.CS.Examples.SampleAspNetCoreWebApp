using Microsoft.EntityFrameworkCore;
using biz.dfch.CS.Examples.SampleAspNetCoreWebApp.Models;

namespace biz.dfch.CS.Examples.SampleAspNetCoreWebApp.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
