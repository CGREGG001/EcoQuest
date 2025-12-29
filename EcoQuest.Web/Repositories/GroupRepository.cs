using EcoQuest.Domain.ValueObjects;
using EcoQuest.Web.Models.Domain;

namespace EcoQuest.Web.Repositories;

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

    public Task<IReadOnlyCollection<Group>> GetGroupForUserAsync(UserId userId)
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