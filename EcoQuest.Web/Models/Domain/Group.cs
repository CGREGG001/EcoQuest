namespace EcoQuest.Web.Models.Domain;

/// <summary>
/// Represents a user group within EcoQuest, such as a class,
/// a community team, or an organization. Groups allow users
/// to collaborate and compare progress.
/// </summary>
public class Group
{
    /// <summary>
    /// Primary key of the group.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Display name of the group.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Type of group (e.g., "School", "Company", "Community").
    /// </summary>
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// Code used to allow users to join the group.
    /// </summary>
    public string InvitationCode { get; set; } = string.Empty;

    /// <summary>
    /// Collection of users associations.
    /// </summary>
    public ICollection<EcoQuestUser> Users { get; set; } = new List<EcoQuestUser>();
}