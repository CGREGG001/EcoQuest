namespace EcoQuest.Web.Models.Domain;

/// <summary>
/// Represents the association between a user and an objective.
/// This entity tracks the user's progress toward a specific objective,
/// including start/end dates and whether the goal has been achieved.
/// </summary>
public class UserObjective
{
    /// <summary>
    /// Foreign key referencing the user assigned to this objective.
    /// Uses string because IdentityUser keys are strings.
    /// </summary>
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// Navigation property to the EcoQuest user.
    /// </summary>
    public EcoQuestUser User { get; set; } = null!;

    /// <summary>
    /// Foreign key referencing the objective being tracked.
    /// </summary>
    public int ObjectiveId { get; set; }

    /// <summary>
    /// Navigation property to the objective definition.
    /// </summary>
    public Objective Objective { get; set; } = null!;

    /// <summary>
    /// Date when the user started working on this objective.
    /// </summary>
    public DateTime DateStart { get; set; }

    /// <summary>
    /// Expected or actual end date for the objective.
    /// </summary>
    public DateTime DateEnd { get; set; }

    /// <summary>
    /// Indicates whether the user has successfully achieved the objective.
    /// </summary>
    public bool ObjectiveAchieved { get; set; }
}