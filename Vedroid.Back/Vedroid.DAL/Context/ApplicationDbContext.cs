using Microsoft.EntityFrameworkCore;
using Vedroid.DAL.Entities;

namespace Vedroid.DAL.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Snack> Snacks { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}