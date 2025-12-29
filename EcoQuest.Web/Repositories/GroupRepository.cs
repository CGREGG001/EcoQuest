using EcoQuest.Domain.ValueObjects;
using EcoQuest.Web.Models.Domain;
using EcoQuest.Web.Models.Domain.Entities;

namespace EcoQuest.Web.Repositories;

/// <summary>
/// Implémentation EF Core du repository Group.
/// Contient uniquement la logique d’accès aux données.
/// </summary>
public class GroupRepository : IGroupRepository
{
    public Task<Group?> GetByIdAsync(int groupId)
    {
        throw new NotImplementedException();
    }

    public Task<Group?> GetByInvitationCodeAsync(InvitationCode invitationCode)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyCollection<Group>> GetGroupsForUserAsync(UserId userId)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Group group)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Group group)
    {
        throw new NotImplementedException();
    }

    public Task<bool> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}