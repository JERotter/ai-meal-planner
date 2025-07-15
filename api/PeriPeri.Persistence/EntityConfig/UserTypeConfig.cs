using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PeriPeri.Domain.Entities.User;

namespace PeriPeri.Persistence.EntityConfig;
public class UserTypeConfig : IEntityTypeConfiguration<UserTypes>
{
    public void Configure(EntityTypeBuilder<UserTypes> builder)
    {
        builder.HasData
        (
            new UserTypes
            {
                Id = Guid.Parse("5617b3cb-ce15-44a7-9802-a81b077843fd"),
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = "5db87a60-3445-4d5f-bec7-930bfeadf227"
            },
            new UserTypes
            {
                Id = Guid.Parse("e7e2be53-63db-4a96-b081-bdba579cf6f0"),
                Name = "Member",
                NormalizedName = "MEMBR",
                ConcurrencyStamp = "39e3ccf8-dd30-42d1-bed1-e8313c13422d"
            },
            new UserTypes
            {
                Id = Guid.Parse("31e9fad7-5194-4041-abdc-1d0a0bab9ed0"),
                Name = "Guest",
                NormalizedName = "GUEST",
                ConcurrencyStamp = "cb7cc3da-e06d-4d53-ac89-5c00e0d79e55"
            }
        );
    }
}