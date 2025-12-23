using EcoQuest.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcoQuest.Web.Data.Configurations;

public class UserObjectiveConfig : IEntityTypeConfiguration<UserObjective>
{
    public void Configure(EntityTypeBuilder<UserObjective> builder)
    {
        builder.ToTable("UserObjectives");

        builder.HasKey(uo => new { uo.UserId, uo.ObjectiveId })
            .HasName("PK_UserObjectives");

        // Relation: UserObjective -> Objective (many-to-one)
        builder.HasOne(uo => uo.Objective)
            .WithMany(o => o.UserObjectives)
            .HasForeignKey(uo => uo.ObjectiveId)
            .HasConstraintName("FK_UserObjectives_Objective")
            .OnDelete(DeleteBehavior.Restrict);

        // Relation: UserObjective -> User (many-to-one)
        builder.HasOne(uo => uo.User)
            .WithMany(u => u.UserObjectives)
            .HasForeignKey(uo => uo.UserId)
            .HasConstraintName("FK_UserObjectives_User")
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(uo => uo.DateStart)
            .HasColumnType("datetime2")
            .IsRequired();

        builder.Property(uo => uo.DateEnd)
            .HasColumnType("datetime2")
            .IsRequired();

        builder.Property((uo) => uo.ObjectiveAchieved)
            .HasColumnType("bit")
            .IsRequired();
    }
}