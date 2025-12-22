using EcoQuest.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcoQuest.Web.Data.Configurations;

public class TypeActionConfig : IEntityTypeConfiguration<TypeAction>
{
    public void Configure(EntityTypeBuilder<TypeAction> builder)
    {
        builder.ToTable("TypeActions");

        builder.HasKey(ta => ta.Id);

        builder.HasIndex(ta => ta.Name).IsUnique();

        builder.Property(ta => ta.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(ta => ta.Unit)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(ta => ta.ImpactFactor)
            .HasColumnType("decimal(5,2)");
    }
}