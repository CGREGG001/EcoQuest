using EcoQuest.Web.Models.Domain.Identity;

namespace EcoQuest.Web.Models.Domain.Entities;

/// <summary>
/// Represents the association between a user and a badge they have earned.
/// Stores when the badge was obtained.
/// </summary>
public class UserBadge
{
    /// <summary>
    /// Foreign key referencing the user who earned the badge.
    /// </summary>
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// Navigation property to the EcoQuest user.
    /// </summary>
    public EcoQuestUser User { get; set; } = null!;

    /// <summary>
    /// Foreign key referencing the earned badge.
    /// </summary>
    public int BadgeId { get; set; }

    /// <summary>
    /// Navigation property to the badge.
    /// </summary>
    public Badge Badge { get; set; } = null!;

    /// <summary>
    /// Date when the badge was obtained.
    /// </summary>
    public DateTime ObtainAt { get; set; }
}