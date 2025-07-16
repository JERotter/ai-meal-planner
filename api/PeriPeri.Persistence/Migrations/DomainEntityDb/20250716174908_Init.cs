using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PeriPeri.Persistence.Migrations.DomainEntityDb
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    IsKeto = table.Column<bool>(type: "boolean", nullable: false),
                    IsVegan = table.Column<bool>(type: "boolean", nullable: false),
                    IsVegetarian = table.Column<bool>(type: "boolean", nullable: false),
                    IsPaleo = table.Column<bool>(type: "boolean", nullable: false),
                    IsGlutenFree = table.Column<bool>(type: "boolean", nullable: false),
                    IsDairyFree = table.Column<bool>(type: "boolean", nullable: false),
                    IsLowCarb = table.Column<bool>(type: "boolean", nullable: false),
                    IsHighProtein = table.Column<bool>(type: "boolean", nullable: false),
                    PrepTimeMinutes = table.Column<int>(type: "integer", nullable: true),
                    CookTimeMinutes = table.Column<int>(type: "integer", nullable: true),
                    Servings = table.Column<int>(type: "integer", nullable: true),
                    IngredientsJson = table.Column<string>(type: "text", nullable: false),
                    InstructionsJson = table.Column<string>(type: "text", nullable: true),
                    Calories = table.Column<decimal>(type: "numeric", nullable: true),
                    Protein = table.Column<decimal>(type: "numeric", nullable: true),
                    Carbs = table.Column<decimal>(type: "numeric", nullable: true),
                    Fat = table.Column<decimal>(type: "numeric", nullable: true),
                    Fiber = table.Column<decimal>(type: "numeric", nullable: true),
                    Sugar = table.Column<decimal>(type: "numeric", nullable: true),
                    Sodium = table.Column<decimal>(type: "numeric", nullable: true),
                    Tags = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastUpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Recipies",
                columns: new[] { "Id", "Calories", "Carbs", "CookTimeMinutes", "CreatedBy", "CreatedOn", "Description", "Fat", "Fiber", "IngredientsJson", "InstructionsJson", "IsDairyFree", "IsGlutenFree", "IsHighProtein", "IsKeto", "IsLowCarb", "IsPaleo", "IsVegan", "IsVegetarian", "LastUpdated", "LastUpdatedBy", "Name", "PrepTimeMinutes", "Protein", "Servings", "Sodium", "Sugar", "Tags" },
                values: new object[,]
                {
                    { new Guid("42ba20af-b004-4ef9-bdbb-bd4931d874ae"), null, null, null, new Guid("693e1cee-8d47-493d-8a89-8221f2e6bb21"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Keto and low carb chicken alfredo.", null, null, "Lean chicken breast, Rao's Alfredo sauce, zuchinni, butter, olive oil", "Spiralize a medium zuchinni. Massage with olive oil and seasonings.Set aside. Sautee chicken in 2T butter. Place onto zoodles and toss with 1/4C alfredo sauce", false, false, true, true, true, true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Chicken Alfredo with Zoodles", null, null, null, null, null, null },
                    { new Guid("5718348e-983e-4091-a1fa-c38a957c34d5"), null, null, null, new Guid("c5187e52-f963-4960-a130-b71d1825f9ab"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "A tasty and nostalgic breakfast!", null, null, "Century eggs and Spam", "Chop up and fry spam. Sprinkle onto halved century eggs and enjoy!", true, false, true, true, true, true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Green Eggs and Ham", null, null, null, null, null, null },
                    { new Guid("c3bc3531-eaa7-4221-9be7-3005f46c2e1f"), null, null, null, new Guid("6a808e59-21fc-4686-b3b8-2e93713bc284"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "A cheap and delcious alternative to the Carnivore Bar. Each bar contains 3oz beef and 2.6T butter.", null, null, "Lean ground beef, salted butter, dessicated beef liver(optional)", "Cook beef completely. Drain and press dry with paper towels. Dehydrate beef at 165F for 4 hours.Pulverize dried beef into a fine powder and add beef liver powder. Melt one stick of butter. Combine ingredients and pour into silicone molds.Freeze for at least 4hrs.", false, false, true, true, true, true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Beef and Butter Bars", null, null, null, null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipies");
        }
    }
}
