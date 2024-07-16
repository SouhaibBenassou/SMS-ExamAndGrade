using Domain;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ExamAttendance> ExamAttendances { get; set; }
        public DbSet<ExamResult> ExamResults { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestResults> TestResults { get; set; }
        public DbSet<VariantsExams> VariantsExams { get; set; }
        public DbSet<Year> Years { get; set; }
        public DbSet<Filiere> Filieres { get; set; }
        public DbSet<UnitOfFormation> UnitsOfFormation { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Supervisor> Supervisors { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<UnitOfFormationFiliere> UnitOfFormationFilieres { get; set; }
        public DbSet<Stagiaire> Stagiairestagiaires { get; set; }

    }
}
