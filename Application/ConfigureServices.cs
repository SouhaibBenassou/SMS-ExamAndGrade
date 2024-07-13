using Application.IServices;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services) {

            services.AddScoped<ISupervisorService, SupervisorService>();
            services.AddScoped<IExamService, ExamService>();

            //configuration of mediator
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            //configuration of auto mapper
            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
