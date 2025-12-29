using EcoQuest.Domain.Enums;
using EcoQuest.Domain.ValueObjects;
using EcoQuest.Web.Models.Domain;

namespace EcoQuest.Web.Services;

public class GroupService : IGroupService
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

    public Task<Group> CreateAsync(string name, GroupType type, UserId creatorId)
    {
        throw new NotImplementedException();
    }

    public Task JoinAsync(InvitationCode invitationCode, UserId userId)
    {
        throw new NotImplementedException();
    }
}