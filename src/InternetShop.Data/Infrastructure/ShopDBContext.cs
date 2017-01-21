
using System;
using InternetShop.Model;
using InternetShop.Model.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace InternetShop.Data.Infrastructure
{
    public partial class ShopDBContext : DbContext
    {
        DbContextOptions<ShopDBContext> _options;
        static ShopDBContext()
        {
          //  Database.SetInitializer<ShopDBContext>(new ShopDBContextInitializer());
        }

        public ShopDBContext() : base()
        {

        }
        public ShopDBContext(DbContextOptions<ShopDBContext> options) : base(options)
        {
            this._options = options;
        }
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<FactorItem> FactorItems { get; set; }
        public DbSet<Factor> Factors { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<User> Users { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            new AgencyMap(modelBuilder.Entity<Agency>());
            new CityMap(modelBuilder.Entity<City>());
            new FactorItemMap(modelBuilder.Entity<FactorItem>());
            new FactorMap(modelBuilder.Entity<Factor>());
            new GroupMap(modelBuilder.Entity<Group>());
            new MessageMap(modelBuilder.Entity<Message>());
            new ProductMap(modelBuilder.Entity<Product>());
            new ProvinceMap(modelBuilder.Entity<Province>());
            new SettingMap(modelBuilder.Entity<Setting>());
            new UserMap(modelBuilder.Entity<User>());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var extension = _options.FindExtension<SqlServerOptionsExtension>();
            if (extension != null)
            {
                optionsBuilder.UseSqlServer(extension.ConnectionString);
            }

            // use this when we want add migration
          //  optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ShopDBContext;Data Source=D-N-PC-12190\\MSSQL2016");
        }

    }
}
