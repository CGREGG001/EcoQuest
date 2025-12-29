using EcoQuest.Web.Models.Domain;
using EcoQuest.Domain.ValueObjects;

namespace EcoQuest.Web.Repositories;

public interface IGroupRepository
{
    Task<Group?> GetByIdAsync(int groupId);
    Task<Group?> GetByInvitationCodeAsync(InvitationCode invitationCode);
    Task<IReadOnlyCollection<Group>> GetGroupForUserAsync(UserId userId);
    Task AddAsync(Group group);
    Task UpdateAsync(Group group);
    Task<bool> SaveChangesAsync();
}