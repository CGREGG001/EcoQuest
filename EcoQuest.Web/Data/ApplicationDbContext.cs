using EcoQuest.Web.Models;
using EcoQuest.Web.Models.Domain;
using EcoQuest.Web.Models.Domain.Entities;
using EcoQuest.Web.Models.Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EcoQuest.Web.Data;

public class ApplicationDbContext : IdentityDbContext<EcoQuestUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<TypeAction> TypeActions { get; set; }
    public DbSet<UserAction> UserActions { get; set; }
    public DbSet<Badge> Badges { get; set; }
    public DbSet<UserBadge> UserBadges { get; set; }
    public DbSet<PointsHistory> PointsHistories { get; set; }
    public DbSet<Objective> Objectives { get; set; }
    public DbSet<UserObjective> UserObjectives { get; set; }
    public DbSet<Group> Groups { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Many-to-many relationship between users and groups.
        // EF Core generates the join table "UserGroups" automatically since no extra attributes are needed.
        // This keeps the model clean for V1, while allowing an easy transition to a full UserGroup entity in V2.
        modelBuilder.Entity<EcoQuestUser>()
            .HasMany(u => u.Groups)
            .WithMany(g => g.Users)
            .UsingEntity(join => join.ToTable("UserGroups"));

        // EF Core configurations are applied automatically via assembly scanning.
        // Manual registration with ApplyConfiguration(...) is also possible but avoided for scalability.
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}