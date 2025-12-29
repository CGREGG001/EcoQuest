namespace EcoQuest.Web.Models.Domain.Entities;

/// <summary>
/// Represents an environmental objective a user can work toward,
/// such as reducing waste or increasing eco-friendly actions.
/// </summary>
public class Objective
{
    /// <summary>
    /// Primary key of the objective.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Type of objective (e.g., "Recycling", "Energy", "Transport").
    /// </summary>
    public string ObjectiveType { get; set; } = string.Empty;

    /// <summary>
    /// Target value the user must reach to complete the objective.
    /// </summary>
    public double Value { get; set; }

    /// <summary>
    /// Period over which the objective applies (e.g., "Daily", "Weekly").
    /// </summary>
    public string PeriodType { get; set; } = string.Empty;

    /// <summary>
    /// Points awarded when the objective is successfully completed.
    /// </summary>
    public int PointsReward { get; set; }

    /// <summary>
    /// Collection of user-specific instances of this objective.
    /// Each entry represents a user who has started or completed this objective.
    /// </summary>
    public ICollection<UserObjective> UserObjectives { get; set; } = new List<UserObjective>();
}