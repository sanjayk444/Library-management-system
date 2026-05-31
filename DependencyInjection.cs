using LibraryManagement.Application.Helpers;
using LibraryManagement.Application.Interfaces.Services;
using LibraryManagement.Application.Services;
using LibraryManagement.Application.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagement.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IBookService, BookService>();
        services.AddScoped<IMemberService, MemberService>();
        services.AddScoped<ITransactionService, TransactionService>();
        services.AddScoped<IDashboardService, DashboardService>();
        services.AddSingleton<JwtTokenHelper>();
        return services;
    }

    public static IServiceCollection AddApplicationSettings(this IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configuration)
    {
        services.AddOptions<JwtSettings>()
            .Bind(configuration.GetSection(JwtSettings.SectionName));
        services.AddOptions<LibrarySettings>()
            .Bind(configuration.GetSection(LibrarySettings.SectionName));
        return services;
    }
}
