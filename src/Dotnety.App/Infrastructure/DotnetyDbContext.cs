using Dotnety.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnety.App.Infrastructure
{
    public class DotnetyDbContext: DbContext
    {
        public DotnetyDbContext(DbContextOptions<DotnetyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Connection> Connections { get; set; }
    }
}
