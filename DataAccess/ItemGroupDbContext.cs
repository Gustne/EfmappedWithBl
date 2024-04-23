
using EntityModels;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace DataAccess
{
    internal class ItemGroupDbContext : DbContext
    {
        public DbSet<ItemGroup> ItemGroups { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connString = ConfigurationManager.ConnectionStrings["BojeSQL"].ConnectionString;
            optionsBuilder.UseSqlServer(connString).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
    }
}
