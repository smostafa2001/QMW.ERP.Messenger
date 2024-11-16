using Microsoft.EntityFrameworkCore;
using QMW.ERP.Messenger.Persistence;

namespace QMW.ERP.Messenger.API.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<MessengerContext>(opt => opt.UseSqlServer(config.GetConnectionString("LocalConnection")));

        services.AddCors(opt
            => opt.AddPolicy("CorsPolicy", p => p.AllowAnyHeader()
                .AllowCredentials()
                .AllowAnyMethod()
                .WithOrigins("https://localhost:3001")
            )
        );

        services.AddHttpContextAccessor();

        services.AddSignalR();

        return services;
    }
}