using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PeriPeri.Domain.Entities.AppEntities;
using PeriPeri.Domain.Entities.User;
using PeriPeri.Domain.Enums;
namespace PeriPeri.Persistence.EntityConfig;

public class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasData
        (
            new User
            {
                Id = Guid.Parse("3f3b3f90-7ad6-4388-9d08-70487409aa1d"),
                AbbreviatedId = "3f3b",
                UserName = "DemoUser",
                Email = "DemoUser@aiMeals.org",
                NormalizedEmail = "DemoUser@aiMeals.org".ToUpper(),
                NormalizedUserName = "DEMOUSER",
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                DateOfBirth = "5/9/1998",
                Status = UserStatus.Inactive,
                Recipes = null,
                CreatedBy = Guid.Empty,
                CreatedOn = DateTime.UnixEpoch,
                LastUpdatedBy = Guid.Empty,
                LastUpdated = DateTime.UnixEpoch,
                PhoneNumber = "987654321",
                PhoneNumberConfirmed = true,
                FirstName = "Demo",
                LastName = "User",
                ConcurrencyStamp = "858212b7-fe3c-4bae-819b-f64c5c22daa9",
                SecurityStamp = "49216b43-1303-4b40-bd6c-a17f3242322c"

            });

        builder.OwnsOne(e => e.Address).HasData(new Address
        {
            Id = Guid.Parse("8852f60f-538f-41fc-86de-5759d41ca076"),
            StreetAddress = "123 four st",
            StreetAddressLine2 = null,
            City = "CityTowneShire",
            Country = "United States",
            ZipCode = "12345",
            State = "PA",
            CreatedBy = new Guid(),
            LastUpdatedBy = new Guid(),
            CreatedOn = DateTime.UnixEpoch,
            LastUpdated = DateTime.UnixEpoch,
            UserId = Guid.Parse("f14dda6f-3d9c-41d6-85f0-4f79d9c7115f")
        });
    }
}