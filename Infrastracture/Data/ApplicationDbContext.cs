using Domain;
using Domain.Entities;
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
        public DbSet<Stagiaire> Stagiaires { get; set; }
        public DbSet<AllResults> AllResults { get; set; }
        public DbSet<IndividualWork> IndividualWorks { get; set; }
        public DbSet<IndividualWorkUOF> IndividualWorkUOFs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IndividualWork>()
                 .HasOne(iw => iw.Stagiaire)
                 .WithMany(s => s.IndividualWorks)
                 .HasForeignKey(iw => iw.StagiaireId);

            modelBuilder.Entity<IndividualWorkUOF>()
                .HasOne(iwuof => iwuof.IndividualWork)
                .WithMany(iw => iw.individualWorkUOFs)
                .HasForeignKey(iwuof => iwuof.IndividualWorkId);

            modelBuilder.Entity<AllResults>()
                .HasOne(g => g.TestResults)
                .WithMany() // Assuming TestResults doesn't have a collection of Grades
                .HasForeignKey(g => g.TestResultsId);
            modelBuilder.Entity<AllResults>()
                .HasOne(g => g.ExamResult)
                .WithMany() // Assuming ExamResult doesn't have a collection of Grades
                .HasForeignKey(g => g.ExamResultId);

            // Stagiaire relationships
            modelBuilder.Entity<Stagiaire>()
                .HasMany(s => s.TestResults)
                .WithOne(tr => tr.Stagiaire)
                .HasForeignKey(tr => tr.StagiaireId);

            modelBuilder.Entity<Stagiaire>()
                .HasMany(s => s.ExamAttendances)
                .WithOne(ea => ea.Stagiaire)
                .HasForeignKey(ea => ea.StagiaireId);

            modelBuilder.Entity<Stagiaire>()
                .HasMany(s => s.ExamResults)
                .WithOne(er => er.Stagiaire)
                .HasForeignKey(er => er.StagiaireId);

            // Exam relationships
            modelBuilder.Entity<Exam>()
                .HasMany(e => e.VariantsExams)
                .WithOne(ve => ve.Exam)
                .HasForeignKey(ve => ve.ExamId);

            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Year)
                .WithMany(y => y.Exams)
                .HasForeignKey(e => e.YearId);

            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Filiere)
                .WithMany(f => f.Exams)
                .HasForeignKey(e => e.FiliereId);

            modelBuilder.Entity<Exam>()
                .HasOne(e => e.UnitOfFormation)
                .WithMany(uof => uof.Exams)
                .HasForeignKey(e => e.UnitOfFormationId);

            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Room)
                .WithMany(r => r.Exams)
                .HasForeignKey(e => e.RoomId);

            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Supervisor)
                .WithMany(s => s.Exams)
                .HasForeignKey(e => e.SupervisorId);

            // Filiere relationships
            modelBuilder.Entity<Filiere>()
                .HasMany(f => f.Exams)
                .WithOne(e => e.Filiere)
                .HasForeignKey(e => e.FiliereId);

            modelBuilder.Entity<Filiere>()
                .HasMany(f => f.UnitOfFormationFilieres)
                .WithOne(uoff => uoff.Filiere)
                .HasForeignKey(uoff => uoff.FiliereId);

            // UnitOfFormation relationships
            modelBuilder.Entity<UnitOfFormation>()
                .HasMany(uof => uof.Exams)
                .WithOne(e => e.UnitOfFormation)
                .HasForeignKey(e => e.UnitOfFormationId);

            modelBuilder.Entity<UnitOfFormation>()
                .HasMany(uof => uof.UnitOfFormationFilieres)
                .WithOne(uoff => uoff.UnitOfFormation)
                .HasForeignKey(uoff => uoff.UnitFormationId);

            // Test relationships
            modelBuilder.Entity<Test>()
                .HasMany(t => t.TestResults)
                .WithOne(tr => tr.Test)
                .HasForeignKey(tr => tr.TestId);

            modelBuilder.Entity<Test>()
                .HasOne(t => t.UnitOfFormation)
                .WithMany(t => t.Tests)
                .HasForeignKey(t => t.UnitOfFormationId);

            // UnitOfFormationFiliere relationships
            modelBuilder.Entity<UnitOfFormationFiliere>()
                .HasKey(uf => new { uf.FiliereId, uf.UnitFormationId });

            modelBuilder.Entity<UnitOfFormationFiliere>()
                .HasOne(uf => uf.Filiere)
                .WithMany(f => f.UnitOfFormationFilieres)
                .HasForeignKey(uf => uf.FiliereId);

            modelBuilder.Entity<UnitOfFormationFiliere>()
                .HasOne(uf => uf.UnitOfFormation)
                .WithMany(u => u.UnitOfFormationFilieres)
                .HasForeignKey(uf => uf.UnitFormationId);

            // ExamAttendance relationships
            modelBuilder.Entity<ExamAttendance>()
                .HasOne(ea => ea.Exam)
                .WithMany(e => e.ExamAttendances)
                .HasForeignKey(ea => ea.ExamId);

            modelBuilder.Entity<ExamAttendance>()
                .HasOne(ea => ea.Stagiaire)
                .WithMany(s => s.ExamAttendances)
                .HasForeignKey(ea => ea.StagiaireId);

            // ExamResult relationships
            modelBuilder.Entity<ExamResult>()
                .HasOne(er => er.Exam)
                .WithMany(e => e.ExamResults)
                .HasForeignKey(er => er.ExamId);

            modelBuilder.Entity<ExamResult>()
                .HasOne(er => er.Stagiaire)
                .WithMany(s => s.ExamResults)
                .HasForeignKey(er => er.StagiaireId);

            // VariantsExams relationships
            modelBuilder.Entity<VariantsExams>()
                .HasOne(ve => ve.Exam)
                .WithMany(e => e.VariantsExams)
                .HasForeignKey(ve => ve.ExamId);

            // Room relationships
            modelBuilder.Entity<Room>()
                .HasMany(r => r.Exams)
                .WithOne(e => e.Room)
                .HasForeignKey(e => e.RoomId);

            modelBuilder.Entity<VariantsExams>()
                .HasOne(r => r.UnitOfFormation)
                .WithMany()
                .HasForeignKey(r => r.UnitOfFormationId);

            modelBuilder.Entity<VariantsExams>()
                .HasOne(t => t.Trainer)
                .WithMany(t => t.VariantsExams)
                .HasForeignKey(t => t.TrainerId);


        }
    }
}
