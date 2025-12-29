using EcoQuest.Domain.ValueObjects;
using EcoQuest.Domain.Enums;
using EcoQuest.Web.Models.Domain.Entities;

namespace EcoQuest.Web.Services;

public interface IGroupService
{
    Task<Group?> GetByIdAsync(int groupId);
    Task<Group?> GetByInvitationCodeAsync(InvitationCode invitationCode);
    Task<IReadOnlyCollection<Group>> GetGroupsForUserAsync(UserId userId);
    Task<Group> CreateAsync(string name, GroupType type, UserId creatorId);
    Task JoinAsync(InvitationCode invitationCode, UserId userId);
}