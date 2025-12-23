using EcoQuest.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcoQuest.Web.Data.Configurations;

public class GroupConfig : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.ToTable("Groups");

        builder.HasKey(g => g.Id)
            .HasName("PK_Groups");

        builder.HasIndex(g => g.InvitationCode)
            .IsUnique();

        builder.Property(g => g.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(g => g.Type)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(g => g.InvitationCode)
            .HasMaxLength(50)
            .IsRequired();
    }
}