using Application.Interfaces;
using Application.IServices;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services) {

            services.AddScoped<IUnitOfService, UnitOfService>();
            services.AddScoped<IExamService, ExamService>();
            services.AddScoped<IRoomService, RoomService>();
            services.AddScoped<ISupervisorService, SupervisorService>();
            services.AddScoped<ITestService, TestService>();
            //configuration of mediator
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            //configuration of auto mapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
