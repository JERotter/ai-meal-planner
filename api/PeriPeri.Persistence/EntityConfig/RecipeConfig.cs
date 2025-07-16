using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PeriPeri.Domain.Entities.AppEntities;

namespace PeriPeri.Persistence.EntityConfig;
public class RecipeConfig : IEntityTypeConfiguration<Recipe>
{
    public void Configure(EntityTypeBuilder<Recipe> builder)
    {
        builder.HasData
        (
            new Recipe
            {
                Id = Guid.Parse("5718348e-983e-4091-a1fa-c38a957c34d5"),
                Name = "Green Eggs and Ham",
                Description = "A tasty and nostalgic breakfast!",
                IsKeto = true,
                IsHighProtein = true,
                IsLowCarb = true,
                IsPaleo = true,
                IsDairyFree = true,
                CreatedOn = DateTime.UnixEpoch,
                CreatedBy = Guid.NewGuid(),
                IngredientsJson = "Century eggs and Spam",
                InstructionsJson = "Chop up and fry spam. Sprinkle onto halved century eggs and enjoy!"
            },
            new Recipe
            {
                Id = Guid.Parse("42ba20af-b004-4ef9-bdbb-bd4931d874ae"),
                Name = "Chicken Alfredo with Zoodles",
                Description = "Keto and low carb chicken alfredo.",
                IsKeto = true,
                IsHighProtein = true,
                IsLowCarb = true,
                IsPaleo = true,
                IsDairyFree = false,
                CreatedOn = DateTime.UnixEpoch,
                CreatedBy = Guid.NewGuid(),
                IngredientsJson = "Lean chicken breast, Rao's Alfredo sauce, zuchinni, butter, olive oil",
                InstructionsJson = "Spiralize a medium zuchinni. Massage with olive oil and seasonings." +
                "Set aside. Sautee chicken in 2T butter. Place onto zoodles and toss with 1/4C alfredo sauce"
            },
            new Recipe
            {
                Id = Guid.Parse("c3bc3531-eaa7-4221-9be7-3005f46c2e1f"),
                Name = "Beef and Butter Bars",
                Description = "A cheap and delcious alternative to the Carnivore Bar. Each bar contains 3oz beef and 2.6T butter.",
                IsKeto = true,
                IsHighProtein = true,
                IsLowCarb = true,
                IsPaleo = true,
                CreatedOn = DateTime.UnixEpoch,
                CreatedBy = Guid.NewGuid(),
                IngredientsJson = "Lean ground beef, salted butter, dessicated beef liver(optional)",
                InstructionsJson = "Cook beef completely. Drain and press dry with paper towels. Dehydrate beef at 165F for 4 hours." +
                "Pulverize dried beef into a fine powder and add beef liver powder. Melt one stick of butter. Combine ingredients and pour into silicone molds." +
                "Freeze for at least 4hrs."
            }
        );
    }
}