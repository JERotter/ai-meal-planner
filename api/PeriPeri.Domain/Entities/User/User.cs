using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using PeriPeri.Domain.Entities.AppEntities;
using PeriPeri.Domain.Enums;
namespace PeriPeri.Domain.Entities.User;
public class User : IdentityUser<Guid>
{
    public string AbbreviatedId { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public Address? Address { get; set; }
    public string DateOfBirth { get; set; } = string.Empty;
    public UserStatus Status { get; set; }
    public List<Recipe>? Recipes { get; set; }

    public Guid CreatedBy { get; set; }

    private DateTime? createdOn;

    [DataType(DataType.DateTime)]
    public DateTime? CreatedOn
    {
        get { return createdOn ?? DateTime.UtcNow; }
        set { createdOn = value; }
    }

    private DateTime? lastUpdated;

    public Guid LastUpdatedBy { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime? LastUpdated
    {
        get { return lastUpdated ?? DateTime.UtcNow; }
        set { lastUpdated = value; }
    }

    public void Create(Guid author)
    {
        this.CreatedBy = author;
        this.CreatedOn = DateTime.UtcNow;
        this.LastUpdatedBy = author;
        this.LastUpdated = DateTime.UtcNow;
    }
}