using EcoQuest.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcoQuest.Web.Data.Configurations;

public class PointsHistoryConfig : IEntityTypeConfiguration<PointsHistory>
{
    public void Configure(EntityTypeBuilder<PointsHistory> builder)
    {
        builder.ToTable("PointsHistories");

        builder.HasKey(ph => ph.Id)
            .HasName("PK_PointsHistories");

        builder.HasOne(ph => ph.UserAction)
            .WithMany(ua => ua.PointsHistories)
            .HasForeignKey(ph => ph.UserActionId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.Property(ph => ph.Source)
            .IsRequired();

        builder.Property(ph => ph.Points)
            .IsRequired();

        builder.Property(ph => ph.Date)
            .HasColumnType("timestamp")
            .IsRequired();
    }
}