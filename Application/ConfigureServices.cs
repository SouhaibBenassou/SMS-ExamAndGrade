using Application.Interfaces;
using Application.IServices;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Application.IRepository;

namespace Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services) {

            services.AddScoped<IUnitOfService, UnitOfService>();
            services.AddScoped<ITestService, TestService>();
            services.AddScoped<IExamService, ExamService>();
            services.AddScoped<IRoomService, RoomService>();
            services.AddScoped<ISupervisorService, SupervisorService>();
            services.AddScoped<IVariantsExamService, VariantsExamService>();
            services.AddScoped<IExamResultsService, ExamResultsService>();
            services.AddScoped<ITestResultService, TestResultService>();
            services.AddScoped<IStagiereNoteService, StagiereNoteService>();
            services.AddScoped<IExamSessionService, ExamSessionService>();
            //configuration of mediator
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            //configuration of auto mapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
