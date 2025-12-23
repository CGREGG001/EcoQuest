using EcoQuest.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcoQuest.Web.Data.Configurations;

public class UserBadgeConfig : IEntityTypeConfiguration<UserBadge>
{
    public void Configure(EntityTypeBuilder<UserBadge> builder)
    {
        builder.ToTable("UserBadges");

        builder.HasKey(ub => new { ub.UserId, ub.BadgeId })
            .HasName("PK_UserBadges");

        // Relation : UserBadge → User (many-to-one)
        builder.HasOne(ub => ub.User)
            .WithMany(u => u.UserBadges)
            .HasForeignKey(ub => ub.UserId)
            .OnDelete(DeleteBehavior.SetNull);

        // Relation : UserBadge → Badge (many-to-one)
        builder.HasOne(ub => ub.Badge)
            .WithMany(b => b.UserBadges)
            .HasForeignKey(ub => ub.BadgeId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.Property(ub => ub.ObtainAt)
            .HasColumnType("timestamp")
            .IsRequired();
    }
}