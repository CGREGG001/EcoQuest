using EcoQuest.Domain.Enums;
using EcoQuest.Domain.ValueObjects;
using EcoQuest.Web.Models.Domain.Identity;

namespace EcoQuest.Web.Models.Domain.Entities;

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
    public GroupType Type { get; set; }

    /// <summary>
    /// Code used to allow users to join the group.
    /// Value Object ensuring validation and immutability.
    /// </summary>
    public InvitationCode InvitationCode { get; set; }

    /// <summary>
    /// Collection of users associations.
    /// </summary>
    public ICollection<EcoQuestUser> Users { get; set; } = new List<EcoQuestUser>();
}