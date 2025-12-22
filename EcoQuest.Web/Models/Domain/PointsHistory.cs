namespace EcoQuest.Web.Models.Domain;

/// <summary>
/// Stores a record of points earned by a user, including the origin
/// of the points and the optional link to a specific user action.
/// </summary>
public class PointsHistory
{
    /// <summary>
    /// Primary key of the points history entry.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Describes the source of the points (e.g., "Action", "Badge", "Objective").
    /// </summary>
    public string Source { get; set; } = string.Empty;

    /// <summary>
    /// Number of points awarded.
    /// </summary>
    public int Points { get; set; }

    /// <summary>
    /// Date when the points were granted.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Optional link to the user action that generated these points.
    /// </summary>
    public int? UserActionId { get; set; }

    /// <summary>
    /// Navigation property to the related user action.
    /// </summary>
    public UserAction? UserAction { get; set; }
}