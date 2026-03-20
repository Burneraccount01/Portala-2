using Microsoft.EntityFrameworkCore;
using PorTala.Models;
using System.Reflection.Metadata;

namespace PorTala.Data
{
    public class PorTalaContext : DbContext
    {
        public PorTalaContext(DbContextOptions<PorTalaContext> options)
            : base(options)
        {
        }

        public DbSet<NavigationMenu> NavigationMenu { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Documents> Documents { get; set; }
        public DbSet<Link> Links { get; set; }
    }
}