using Domain;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Year> Years { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<YearOfStudy> YearsOfStudy { get; set; }
        public DbSet<Filiere> Filieres { get; set; }
        public DbSet<UnitOfFormation> UnitsOfFormation { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Supervisor> Supervisors { get; set; }
        public DbSet<Exam> Exams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Year)
                .WithMany(y => y.Exams)
                .HasForeignKey(e => e.YearId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Semester)
                .WithMany(s => s.Exams)
                .HasForeignKey(e => e.SemesterId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Exam>()
                .HasOne(e => e.YearOfStudy)
                .WithMany(yos => yos.Exams)
                .HasForeignKey(e => e.YearOfStudyId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Filiere)
                .WithMany(f => f.Exams)
                .HasForeignKey(e => e.FiliereId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Exam>()
                .HasOne(e => e.UnitOfFormation)
                .WithMany(uof => uof.Exams)
                .HasForeignKey(e => e.UnitOfFormationId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Room)
                .WithMany(r => r.Exams)
                .HasForeignKey(e => e.RoomId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Supervisor)
                .WithMany(s => s.Exams)
                .HasForeignKey(e => e.SupervisorId)
                .OnDelete(DeleteBehavior.SetNull);

            // Seed data
            var year2024Id = Guid.NewGuid();
            var year2025Id = Guid.NewGuid();
            var fallSemesterId = Guid.NewGuid();
            var springSemesterId = Guid.NewGuid();
            var firstYearId = Guid.NewGuid();
            var secondYearId = Guid.NewGuid();
            var csFiliereId = Guid.NewGuid();
            var meFiliereId = Guid.NewGuid();
            var prog101Id = Guid.NewGuid();
            var thermoId = Guid.NewGuid();
            var roomAId = Guid.NewGuid();
            var roomBId = Guid.NewGuid();
            var drSmithId = Guid.NewGuid();
            var drJohnsonId = Guid.NewGuid();
            var exam1Id = Guid.NewGuid();
            var exam2Id = Guid.NewGuid();

            modelBuilder.Entity<Year>().HasData(
                new Year { Id = year2024Id, YearName = "2024" },
                new Year { Id = year2025Id, YearName = "2025" }
            );

            modelBuilder.Entity<Semester>().HasData(
                new Semester { Id = fallSemesterId, SemesterName = "Fall" },
                new Semester { Id = springSemesterId, SemesterName = "Spring" }
            );

            modelBuilder.Entity<YearOfStudy>().HasData(
                new YearOfStudy { Id = firstYearId, Year = "First Year" },
                new YearOfStudy { Id = secondYearId, Year = "Second Year" }
            );

            modelBuilder.Entity<Filiere>().HasData(
                new Filiere { Id = csFiliereId, FiliereName = "Computer Science" },
                new Filiere { Id = meFiliereId, FiliereName = "Mechanical Engineering" }
            );

            modelBuilder.Entity<UnitOfFormation>().HasData(
                new UnitOfFormation { Id = prog101Id, UnitName = "Programming 101" },
                new UnitOfFormation { Id = thermoId, UnitName = "Thermodynamics" }
            );

            modelBuilder.Entity<Room>().HasData(
                new Room { Id = roomAId, RoomName = "Room A", Capacity = 30, RoomType = RoomType.emphi },
                new Room { Id = roomBId, RoomName = "Room B", Capacity = 25, RoomType = RoomType.partice }
            );

            modelBuilder.Entity<Supervisor>().HasData(
                new Supervisor { Id = drSmithId, FirstName = "John", LastName = "Smith", Title = "Professor" },
                new Supervisor { Id = drJohnsonId, FirstName = "Emily", LastName = "Johnson", Title = "Associate Professor" }
            );

            modelBuilder.Entity<Exam>().HasData(
                new Exam
                {
                    Id = exam1Id,
                    YearId = year2024Id,
                    SemesterId = fallSemesterId,
                    YearOfStudyId = firstYearId,
                    FiliereId = csFiliereId,
                    UnitOfFormationId = prog101Id,
                    RoomId = roomAId,
                    SupervisorId = drSmithId,
                    ExamDate = DateTime.Now,
                    Duration = DateTime.Now,
                    StartTime = DateTime.Now
                },
                new Exam
                {
                    Id = exam2Id,
                    YearId = year2025Id,
                    SemesterId = springSemesterId,
                    YearOfStudyId = secondYearId,
                    FiliereId = meFiliereId,
                    UnitOfFormationId = thermoId,
                    RoomId = roomBId,
                    SupervisorId = drJohnsonId,
                    ExamDate = DateTime.Now,
                    Duration = DateTime.Now,
                    StartTime = DateTime.Now
                }
            );
        }
    }
}
