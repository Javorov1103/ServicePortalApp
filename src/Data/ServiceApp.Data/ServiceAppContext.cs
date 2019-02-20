namespace ServiceApp.Web.Models
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using ServiceApp.Data.Models;
    using ServiceApp.Web.Areas.Identity.Data;

    public class ServiceAppContext : IdentityDbContext<ServiceAppUser>
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarOwner> CarOwners { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<OffersPart> OffersParts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<OfferRaw> OfferRaws { get; set; }
        public DbSet<OrderRaw> OrderRaws { get; set; }
        public DbSet<Obligation> Obligations { get; set; }



        public ServiceAppContext(DbContextOptions<ServiceAppContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Warehouse>()
                .HasOne(w => w.Service).WithOne(s => s.Warehouse);

            builder.Entity<CarOwner>()
                .HasOne(co => co.AutoService).WithMany(s => s.Clinets);

            builder.Entity<CarOwner>()
                .HasMany(co => co.Cars)
                .WithOne(c => c.CarOwner);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
