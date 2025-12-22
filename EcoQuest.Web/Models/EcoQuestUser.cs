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
}