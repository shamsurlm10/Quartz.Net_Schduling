using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Quartz;

namespace ABX_RMO.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection InfrastructurePersistence(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ABXRMODbContext>(options => options.UseSqlServer(
                config.GetConnectionString("DefaultConnection")));
            
            services.AddQuartz(q =>
            {
                q.UseMicrosoftDependencyInjectionJobFactory();
            });
            services.AddQuartzHostedService(options => options.WaitForJobsToComplete = true);
            services.ConfigureOptions<LoggingBackgroundJobSetup>();
            return services;
        }
    }
}
