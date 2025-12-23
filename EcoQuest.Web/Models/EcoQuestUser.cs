using EcoQuest.Web.Models.Domain;
using Microsoft.AspNetCore.Identity;

namespace EcoQuest.Web.Models;

public class EcoQuestUser : IdentityUser
{
    public string FirstName { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;

    // Email et UserType déjà gérés par IdentityUser

    // Gamification
    public int TotalPoints { get; set; } = 0;

    // Date d'inscription
    public DateTime CreatedAt { get; set; }

    public bool RGPDConsent { get; set; } = false;

    /// <summary>
    /// List of badges assigned to the user through the UserBadge linking entity.
    /// </summary>
    public ICollection<UserBadge> UserBadges { get; set; } = new List<UserBadge>();

    /// <summary>
    /// List of objectives assigned to the user through the UserObjective linking entity
    /// </summary>
    public ICollection<UserObjective> UserObjectives { get; set; } = new List<UserObjective>();

    /// <summary>
    /// List of groups assigned to the user through the UserGroup linking entity
    /// </summary>
    public ICollection<Group> Groups { get; set; } = new List<Group>();
}