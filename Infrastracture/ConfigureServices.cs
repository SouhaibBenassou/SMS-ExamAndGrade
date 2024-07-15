using Application.Interfaces;
using Application.IRepository;
using Infrastracture;
using Infrastracture.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration) {

            string? con = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(con)); // Ensure this uses the correct connection string
            //dependency injection 
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IExamRepository, ExamRepository>();
            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddScoped<ISupervisorRepository, SupervisorRepository>();

            return services;
        }
    }
}