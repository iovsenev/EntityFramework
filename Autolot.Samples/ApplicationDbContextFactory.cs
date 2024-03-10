using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AutoLot.Samples
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = "Data Source=ILYA\\SQLEXPRESS;" +
                                   "Integrated Security=true;" +
                                   "Initial Catalog=AutoLot;" +
                                    "TrustServerCertificate=True";

            optionsBuilder.UseSqlServer(connectionString);
            Console.WriteLine(connectionString);
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
