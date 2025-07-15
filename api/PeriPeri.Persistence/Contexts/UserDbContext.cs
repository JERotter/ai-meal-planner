using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PeriPeri.Domain.Entities.User;
using PeriPeri.Persistence.EntityConfig;

namespace PeriPeri.Persistence.Contexts;
public class UserDbContext : IdentityDbContext<User, UserTypes, Guid>
{
    public UserDbContext(DbContextOptions<UserDbContext> options): base(options){}

	protected override void OnModelCreating(ModelBuilder builder)
	{
		base.OnModelCreating(builder);
		
		builder.ApplyConfiguration(new UserTypeConfig());
        builder.ApplyConfiguration(new UserConfig());
    }
}