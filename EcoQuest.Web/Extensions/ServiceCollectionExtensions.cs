namespace EcoQuest.Web.Extensions;
// Extension pour l’injection de dépendances (D.I.) des services de l’application
// Évite de surcharger Program.cs
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddEcoQuestServices(this IServiceCollection services)
    {
        // services.AddScoped<IUserService, UserService>();
        // services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}