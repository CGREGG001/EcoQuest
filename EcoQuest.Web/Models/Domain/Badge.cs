namespace EcoQuest.Web.Models.Domain;

/// <summary>
/// Represents a badge that can be awarded to users for completing
/// objectives or reaching milestones.
/// </summary>
public class Badge
{
    /// <summary>
    /// Primary key of the badge.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Display name of the badge.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Description of the badge and how it is earned.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Number of points granted when the badge is obtained.
    /// </summary>
    public int PointsAwarded { get; set; }

    /// <summary>
    /// List of users who have obtained this badge through the UserBadge linking entity.
    /// </summary>
    public ICollection<UserBadge> UserBadges { get; set; } = new List<UserBadge>();
}