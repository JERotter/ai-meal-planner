using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PeriPeri.Persistence.Contexts;

namespace PeriPeri.Persistence.ContextFactories;

public class DomainEntityDbContextFactory : IDesignTimeDbContextFactory<DomainEntityDbContext>
{
    public DomainEntityDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false)
            .Build();

        var optionsBuilder = new DbContextOptionsBuilder<DomainEntityDbContext>();
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        optionsBuilder.UseNpgsql(connectionString);

        return new DomainEntityDbContext(optionsBuilder.Options);
    }
}
