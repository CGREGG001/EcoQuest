using EcoQuest.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcoQuest.Web.Data.Configurations;

public class BadgeConfig : IEntityTypeConfiguration<Badge>
{
    public void Configure(EntityTypeBuilder<Badge> builder)
    {
        builder.ToTable("Badges");

        builder.HasKey(badge => badge.Id)
            .HasName("PK_Badges");

        builder.HasIndex(badge => badge.Name)
            .IsUnique();

        builder.Property(badge => badge.Name)
            .IsRequired();

        builder.Property(badge => badge.Description)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(badge => badge.PointsAwarded)
            .IsRequired();
    }
}