using Microsoft.EntityFrameworkCore;

namespace AuthentIdMobileMvpWebApi.Models
{
    public class AuthentIdDbContext : DbContext
    {
        public AuthentIdDbContext(DbContextOptions<AuthentIdDbContext> options) : base(options)
        {
        }

        public DbSet<AuthentIdUser> AuthentIdUsers { get; set; }
        public DbSet<AuthentIdAgent> AuthentIdAgents { get; set; }
        public DbSet<AuthentIdScan> AuthentIdScans { get; set; }
    }
}
