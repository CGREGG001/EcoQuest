namespace EcoQuest.Web.Models.Domain;

/// <summary>
/// Represents the association between a user and a group.
/// This is a join entity with a composite key (UserId, GroupId).
/// </summary>
public class UserGroup
{
    /// <summary>
    /// Foreign key referencing the user in the group.
    /// </summary>
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// Navigation property to the EcoQuest user.
    /// </summary>
    public EcoQuestUser User { get; set; } = null!;

    /// <summary>
    /// Foreign key referencing the group.
    /// </summary>
    public int GroupId { get; set; }

    /// <summary>
    /// Navigation property to the group.
    /// </summary>
    public Group Group { get; set; } = null!;
}