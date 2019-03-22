using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    using System.Data.Entity;
    using DAL.Entities;
    public class dbContext : DbContext
    {
        public dbContext(): base("dbPOS")
        {

        }
        //Schema Configuration
        public DbSet<User> Users { get; set; }
        public DbSet<Filter> Filters { get; set; }
        public DbSet<Consult> Consults { get; set; }
        public DbSet<Container> Containers { get; set; }
        public DbSet<Coding> Codings { get; set; }
        public DbSet<Image> Images { get; set; }
        
        //Schema Product
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<UnitTemplate> UnitTemplates { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
