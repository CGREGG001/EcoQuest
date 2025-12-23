using EcoQuest.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcoQuest.Web.Data.Configurations;

public class UserActionConfig : IEntityTypeConfiguration<UserAction>
{
    public void Configure(EntityTypeBuilder<UserAction> builder)
    {
        builder.ToTable("UserActions");

        builder.HasKey(ua => ua.Id)
            .HasName("PK_UserActions");

        // Relation : UserAction → User (many-to-one)
        builder.HasOne(ua => ua.User)
            .WithMany()
            .HasForeignKey(ua => ua.UserId)
            .OnDelete(DeleteBehavior.SetNull);

        // Relation : UserAction → TypeAction (many-to-one)
        builder.HasOne(ua => ua.TypeAction)
            .WithMany(ta => ta.Actions)
            .HasForeignKey(ua => ua.TypeActionId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.Property(ua => ua.Date)
            .IsRequired()
            .HasColumnType("datetime2");

        builder.Property(ua => ua.Value)
            .HasColumnType("decimal(10,2)");

        builder.Property(ua => ua.CalculatedImpact)
            .HasColumnType("decimal(10,2)");
    }
}