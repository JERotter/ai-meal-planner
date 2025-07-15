using Microsoft.AspNetCore.Identity;

namespace PeriPeri.Domain.User.Entities;
public class AppUser : IdentityUser<Guid>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}
