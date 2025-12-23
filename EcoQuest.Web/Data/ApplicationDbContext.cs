using EcoQuest.Web.Models;
using EcoQuest.Web.Models.Domain;
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
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // EF Core configurations are applied automatically via assembly scanning.
        // Manual registration with ApplyConfiguration(...) is also possible but avoided for scalability.
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}