using Microsoft.EntityFrameworkCore;
using MVCMovieCF.Models;

namespace MVCMovieCF.Data
{
    public class MVCMovieCFContext : DbContext
    {
        public MVCMovieCFContext (DbContextOptions<MVCMovieCFContext> options) 
            : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
    }
}
