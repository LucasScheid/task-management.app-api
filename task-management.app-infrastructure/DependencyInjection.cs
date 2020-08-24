using Microsoft.Extensions.DependencyInjection;
using task_management.app_application.interfaces;
using task_management.app_infrastructure.repositories;

namespace task_management.app_infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<ITaskRepository, TaskRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
