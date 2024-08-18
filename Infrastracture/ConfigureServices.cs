using Application;
using Application.Interfaces;
using Application.IRepository;
using Application.IServices;
using Application.Services;
using Infrastracture.Repositories;
using Infrastracture.UOW;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastracture
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {

            string? con = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(con)); // Ensure this uses the correct connection string
            //dependency injection 
            // services.AddScoped<ITestRepository, TestRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IExamRepository, ExamRepository>();
            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddScoped<IVariantsExamRepository, VariantsExamRepository>();
            services.AddScoped<ISupervisorRepository, SupervisorRepository>();
            services.AddScoped<ITestRepository, TestRepository>();
            services.AddScoped<IExamResultRepository, ExamResultRepository>();
            services.AddScoped<ITestResultRepository, TestResultRepository>();
            services.AddScoped<IExamSessionRepository, ExamSessionRepository>();
            services.AddScoped<IIndividualWorkUOFRepository, IndividualWorkUOFRepository>();
            services.AddScoped<IFiliereRepository, FiliereRepository>();
            services.AddScoped<IFormateurRepository, FormateurRepository>();
            return services;
        }
    }
}