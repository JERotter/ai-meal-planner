using Microsoft.EntityFrameworkCore;
using PeriPeri.Domain.Entities.AppEntities;
using PeriPeri.Persistence.EntityConfig;

namespace PeriPeri.Persistence.Contexts;
public class DomainEntityDbContext : DbContext
{
    public DomainEntityDbContext(DbContextOptions<DomainEntityDbContext> options): base(options){}
    public DomainEntityDbContext() {}
    public virtual DbSet<Recipe> Recipies { get; set; }
    public virtual DbSet<Address> Addresses { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfiguration(new RecipeConfig());
    }
}