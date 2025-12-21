using EcoQuest.Web.Data;
using Microsoft.AspNetCore.Identity;

namespace EcoQuest.Web.Extensions;
// Extension pour l’injection de dépendances (D.I.) des services de l’application
// Extension pour la configuration de Identity
// Évite de surcharger Program.cs
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddEcoQuestServices(this IServiceCollection services)
    {
        // services.AddScoped<IUserService, UserService>();
        // services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }

    public static IServiceCollection AddEcoQuestIdentity(this IServiceCollection services)
    {
        services.AddIdentity<IdentityUser, IdentityRole>()
            // Specifies that Identity data (users, roles, claims…) will be stored in ApplicationDbContext via Entity Framework
            .AddEntityFrameworkStores<ApplicationDbContext>()
            // Adds default token providers for security operations like password reset or email confirmation
            .AddDefaultTokenProviders();

        return services;
    }
}