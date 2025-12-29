namespace EcoQuest.Web.Models.Domain.Entities;

/// <summary>
/// Represents a category of action a user can perform
/// (e.g., recycling, biking, reducing water usage).
/// Defines how the action is measured and how impactful it is.
/// </summary>
public class TypeAction
{
    /// <summary>
    /// Primary key of the action type.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Name of the action type (e.g., "Recycling").
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Optional measurement unit (kg, km, L, etc.).
    /// </summary>
    public string? Unit { get; set; }

    /// <summary>
    /// Factor used to compute the environmental impact of the action.
    /// </summary>
    public double ImpactFactor { get; set; }

    /// <summary>
    /// Collection of user actions linked to this type.
    /// </summary>
    public ICollection<UserAction> Actions { get; set; } = new List<UserAction>();
}