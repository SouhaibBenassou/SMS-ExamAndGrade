using Domain;
using Domain.Entities;
using Domain.EntitiesFromOtherServices.FiliereService;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ExamAttendance> ExamAttendances { get; set; }
        public DbSet<ExamResult> ExamResults { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestResult> TestResults { get; set; }
        public DbSet<VariantsExams> VariantsExams { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Supervisor> Supervisors { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<AllResults> AllResults { get; set; }
        public DbSet<IndividualWork> IndividualWorks { get; set; }
        public DbSet<IndividualWorkUOF> IndividualWorkUOFs { get; set; }
        public DbSet<ExamSession> ExamSessions { get; set; }
        public DbSet<Filiere> Filieres { get; set; }
        public DbSet<FiliereUnitOfFormation> FiliereUnitOfFormations { get; set; }
        public DbSet<UnitOfFormation> UnitOfFormations { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IndividualWorkUOF>()
                .HasOne(iwuof => iwuof.IndividualWork)
                .WithMany(iw => iw.individualWorkUOFs)
                .HasForeignKey(iwuof => iwuof.IndividualWorkId);

            modelBuilder.Entity<AllResults>()
                .HasOne(g => g.TestResults)
                .WithMany() // Assuming TestResult doesn't have a collection of Grades
                .HasForeignKey(g => g.TestResultsId);
            modelBuilder.Entity<AllResults>()
                .HasOne(g => g.ExamResult)
                .WithMany() // Assuming ExamResult doesn't have a collection of Grades
                .HasForeignKey(g => g.ExamResultId);

            // Exam relationships
            modelBuilder.Entity<Exam>()
                .HasMany(e => e.VariantsExams)
                .WithOne(ve => ve.Exam)
                .HasForeignKey(ve => ve.ExamId);
            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Filiere)
                .WithMany(f => f.Exams)
                .HasForeignKey(e => e.FiliereId);
            modelBuilder.Entity<Exam>()
                .HasOne(e => e.UnitOfFormation)
                .WithMany(uof => uof.Exams)
                .HasForeignKey(e => e.UnitOfFormationId);
            
            // Filiere Relationships 
            modelBuilder.Entity<FiliereUnitOfFormation>()
                .HasOne(fuf => fuf.Filiere)
                .WithMany(f => f.FiliereUnitOfFormations)
                .HasForeignKey(fuf => fuf.FiliereId);

            modelBuilder.Entity<FiliereUnitOfFormation>()
                .HasOne(fuf => fuf.UnitOfFormation)
                .WithMany(u => u.FiliereUnitOfFormations)
                .HasForeignKey(fuf => fuf.UnitOfFormationId);
            
            modelBuilder.Entity<FiliereUnitOfFormation>()
                .HasKey(fuf => new { fuf.FiliereId, fuf.UnitOfFormationId });
            
            // Test relationships
            modelBuilder.Entity<Test>()
                .HasMany(t => t.TestResults)
                .WithOne(tr => tr.Test)
                .HasForeignKey(tr => tr.TestId);
            modelBuilder.Entity<Test>()
                .HasOne(t=>t.UnitOfFormation)
                .WithMany(uof => uof.Tests)
                .HasForeignKey(t => t.UnitOfFormationId);
        

            // ExamAttendance relationships
            modelBuilder.Entity<ExamAttendance>()
                .HasOne(ea => ea.Exam)
                .WithMany(e => e.ExamAttendances)
                .HasForeignKey(ea => ea.ExamId);



            // ExamResult relationships
            modelBuilder.Entity<ExamResult>()
                .HasOne(er => er.Exam)
                .WithMany(e => e.ExamResults)
                .HasForeignKey(er => er.ExamId);



            // VariantsExams relationships
            modelBuilder.Entity<VariantsExams>()
                .HasOne(ve => ve.Exam)
                .WithMany(e => e.VariantsExams)
                .HasForeignKey(ve => ve.ExamId);
            modelBuilder.Entity<VariantsExams>()
                .HasOne(va=>va.UnitOfFormation)
                .WithMany(uof => uof.VariantsExams)
                .HasForeignKey(va => va.UnitOfFormationId);
            
            //ExamSession relationships
            modelBuilder.Entity<ExamSession>()
                .HasOne(es => es.Exam)
                .WithOne(e => e.ExamSession)
                .HasForeignKey<ExamSession>(es => es.ExamId);
            
            modelBuilder.Entity<ExamSession>()
                .HasOne(es => es.Room)
                .WithMany(e => e.ExamSessions)
                .HasForeignKey(es => es.RoomId);
            
            modelBuilder.Entity<ExamSession>()
                .HasOne(es => es.Supervisor)
                .WithMany(s => s.ExamSessions)
                .HasForeignKey(es => es.SupervisorId);

        }
    }
}
