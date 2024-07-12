using Domain;
using Domain.Entities;
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
                .HasForeignKey(e => e.YearId);

            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Semester)
                .WithMany(s => s.Exams)
                .HasForeignKey(e => e.SemesterId);

            modelBuilder.Entity<Exam>()
                .HasOne(e => e.YearOfStudy)
                .WithMany(yos => yos.Exams)
                .HasForeignKey(e => e.YearOfStudyId);

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

        }
    }

}

