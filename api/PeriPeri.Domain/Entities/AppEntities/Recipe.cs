using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PeriPeri.Domain.Common;

namespace PeriPeri.Domain.Entities.AppEntities;

public class Recipe : BaseEntity
{
        [Required]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;

        [StringLength(1000)]
        public string? Description { get; set; }

        [Required]
        [StringLength(500)]
        public string ImageUrl { get; set; } = string.Empty;

        // Diet/WOE (Way of Eating) Properties
        public bool IsKeto { get; set; }
        public bool IsVegan { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsPaleo { get; set; }
        public bool IsGlutenFree { get; set; }
        public bool IsDairyFree { get; set; }
        public bool IsLowCarb { get; set; }
        public bool IsHighProtein { get; set; }

        // Recipe Details
        public int? PrepTimeMinutes { get; set; }
        public int? CookTimeMinutes { get; set; }
        public int? Servings { get; set; }

        // Ingredients (JSON stored as string, or separate table)
        [Required]
        [Column(TypeName = "text")]
        public string IngredientsJson { get; set; } = string.Empty;

        // Instructions (JSON stored as string, or separate table)
        [Required]
        [Column(TypeName = "text")]
        public string InstructionsJson { get; set; } = string.Empty;

        // Macros per serving
        [Column(TypeName = "decimal(6,2)")]
        public decimal Calories { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal Protein { get; set; } // grams

        [Column(TypeName = "decimal(6,2)")]
        public decimal Carbs { get; set; } // grams

        [Column(TypeName = "decimal(6,2)")]
        public decimal Fat { get; set; } // grams

        [Column(TypeName = "decimal(6,2)")]
        public decimal Fiber { get; set; } // grams

        [Column(TypeName = "decimal(6,2)")]
        public decimal Sugar { get; set; } // grams

        [Column(TypeName = "decimal(6,2)")]
        public decimal Sodium { get; set; } // milligrams

        // Additional useful properties
        public string? Tags { get; set; } // e.g., "breakfast,quick,meal-prep"
        
        [StringLength(100)]
        public string? CreatedBy { get; set; } // User who created the recipe
        
        public bool IsPublic { get; set; } = true;
        
        public int Rating { get; set; } = 0; // 1-5 stars
        
        public int RatingCount { get; set; } = 0;

        // Navigation properties (if using separate tables)
        // public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();
        // public virtual ICollection<RecipeInstruction> RecipeInstructions { get; set; } = new List<RecipeInstruction>();
        // public virtual ICollection<RecipeReview> Reviews { get; set; } = new List<RecipeReview>();
    }

// Alternative: If you want separate tables for ingredients/instructions
public class RecipeIngredient : BaseEntity
{
    public int RecipeId { get; set; }
    public virtual Recipe Recipe { get; set; } = null!;
    
    [Required]
    [StringLength(200)]
    public string Name { get; set; } = string.Empty;
    
    [Required]
    [StringLength(50)]
    public string Amount { get; set; } = string.Empty;
    
    [Required]
    [StringLength(50)]
    public string Unit { get; set; } = string.Empty;
    
    public int Order { get; set; }
}

public class RecipeInstruction : BaseEntity
{
    public int RecipeId { get; set; }
    public virtual Recipe Recipe { get; set; } = null!;
    
    [Required]
    public int StepNumber { get; set; }
    
    [Required]
    [StringLength(1000)]
    public string Description { get; set; } = string.Empty;
    
    public int? TimeMinutes { get; set; } // Optional time for this step
}