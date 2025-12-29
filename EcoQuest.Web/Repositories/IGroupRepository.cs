using EcoQuest.Web.Models.Domain;
using EcoQuest.Domain.ValueObjects;

namespace EcoQuest.Web.Repositories;

/// <summary>
/// Accès aux données pour les entités Group.
/// Interface orientée DDD, isolant la couche d’infrastructure.
/// </summary>
public interface IGroupRepository
{
    /// <summary>
    /// Récupère un groupe par son identifiant.
    /// </summary>
    Task<Group?> GetByIdAsync(int groupId);

    /// <summary>
    /// Récupère un groupe via son code d’invitation.
    /// </summary>
    Task<Group?> GetByInvitationCodeAsync(InvitationCode invitationCode);

    /// <summary>
    /// Récupère tous les groupes auxquels appartient un utilisateur.
    /// </summary>
    Task<IReadOnlyCollection<Group>> GetGroupsForUserAsync(UserId userId);

    /// <summary>
    /// Ajoute un nouveau groupe au contexte.
    /// </summary>
    Task AddAsync(Group group);

    /// <summary>
    /// Met à jour un groupe existant.
    /// </summary>
    Task UpdateAsync(Group group);

    /// <summary>
    /// Persiste les modifications dans la base.
    /// </summary>
    Task<bool> SaveChangesAsync();
}