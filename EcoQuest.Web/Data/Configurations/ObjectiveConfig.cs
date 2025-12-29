using EcoQuest.Web.Models.Domain;
using EcoQuest.Web.Models.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcoQuest.Web.Data.Configurations;

public class ObjectiveConfig : IEntityTypeConfiguration<Objective>
{
    public void Configure(EntityTypeBuilder<Objective> builder)
    {
        builder.ToTable("Objectives");

        builder.HasKey(o => o.Id)
            .HasName("PK_Objectives");

        builder.Property(o => o.ObjectiveType)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(o => o.Value)
            .HasColumnType("decimal(10,2)")
            .IsRequired();

        builder.Property(o => o.PeriodType)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(o => o.PointsReward)
            .IsRequired();
    }
}