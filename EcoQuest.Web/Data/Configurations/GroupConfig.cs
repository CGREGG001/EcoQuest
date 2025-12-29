using EcoQuest.Domain.ValueObjects;
using EcoQuest.Web.Models.Domain.Entities;
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

        // --- InvitationCode (Value Object) ---
        builder.Property(g => g.InvitationCode)
            .HasConversion(
                ic => ic.Value,                          // VO → string (DB)
                ic => InvitationCode.Create(ic))    // string → VO
            .HasColumnName("InvitationCode")
            .HasMaxLength(8)
            .IsRequired();

        builder.HasIndex(g => g.InvitationCode)
            .IsUnique();

        // --- Name ---
        builder.Property(g => g.Name)
            .HasMaxLength(100)
            .IsRequired();

        // --- GroupType (enum) ---
        builder.Property(g => g.Type)
            .HasConversion<string>()   // stocké en string dans la DB
            .HasMaxLength(50)
            .IsRequired();

        // --- Users relation ---
        builder.HasMany(g => g.Users)
            .WithMany(u => u.Groups); // si tu as la relation Many-to-Many
    }
}