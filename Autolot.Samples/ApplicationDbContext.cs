using AutoLot.Samples.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoLot.Samples
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            SavingChanges += (sender, args) =>
            {
                Console.WriteLine($"Saving changes for " +
                    $"{((DbContext)sender).Database.GetConnectionString()}");
            };
            SavedChanges += (sender, args) =>
            {
                Console.WriteLine($"Saved {args.EntitiesSavedCount} entities");
            };
            SaveChangesFailed += (sender, args) =>
            {
                Console.WriteLine($"An exception occurred! {args.Exception.Message} entities");
            };
            Database.Migrate();
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Radio> Radios { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Make>().ToTable("Makes");
            modelBuilder.Entity<Car>().ToTable("Inventory");
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
