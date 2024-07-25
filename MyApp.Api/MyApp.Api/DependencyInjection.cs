using MyApp.Application;
using MyApp.Infrastructure;

namespace MyApp.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiDI(this IServiceCollection services)
        {
            services.AddApplicaitonDI()
                .AddInfrastructureDI();
            return services;
        }
    }
}
