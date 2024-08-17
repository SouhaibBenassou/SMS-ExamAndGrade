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

            
            /// adding  objects can delete later
            
            var units = new List<UnitOfFormation>();
            var filieres = new List<Filiere>();
            var filiereUnits = new List<FiliereUnitOfFormation>();
            Guid[] filiereGuids = new Guid[]
            {
                new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"),
                new Guid("21aef537-d19e-48bf-a523-23db8e193522"),
                new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"),
                new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"),
                new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"),
                new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"),
                new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"),
                new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"),
                new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"),
                new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"),
                new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"),
                new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"),
                new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"),
                new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"),
                new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"),
                new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"),
                new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"),
                new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205")
            };
            string[] filiereNames = 
            {
                "Computer Science", "Electrical Engineering", "Mechanical Engineering", "Civil Engineering",
                "Chemical Engineering", "Biotechnology", "Mathematics", "Physics", "Chemistry", "Biology",
                "Environmental Science", "Economics", "Psychology", "Sociology", "History", "Philosophy",
                "Political Science", "International Relations"
            };
            string[] matieres =
            {
                "Français", "English", "Math", "History", "Geography", "Biology", "Chemistry", "Physics", 
                "Computer Science", "Art", "Music", "Physical Education", "Economics", "Psychology", 
                "Philosophy", "Sociology", "Political Science", "Statistics", "Engineering", "Literature", 
                "Spanish", "German", "Italian", "Chinese", "Japanese", "Arabic", "Latin", "Greek", 
                "Religion", "Astronomy", "Environmental Science", "Health Education", "Business Studies", 
                "Law", "Engineering Design", "Information Technology", "Theater", "Dance", "Media Studies", 
                "Anthropology", "Ethics", "Mathematics", "Statistics", "Cryptography", "Pharmacology", 
                "Astrophysics", "Geology", "Oceanography", "Meteorology", "Robotics", "Machine Learning", 
                "Data Science", "Artificial Intelligence"
            };
            
            
            
            for (int i = 0; i < matieres.Length; i++)
            {
                var unit = new UnitOfFormation
                {
                    Id = Guid.NewGuid(),
                    Name = matieres[i],
                    Semestre = i % 2 == 0 ? "Semester 2" : "Semester 1",
                    Duration = 45 + (i % 10),
                    Coefficient = 2 + (i % 5)
                };
                units.Add(unit);
            }
            for (int j = 0; j < filiereGuids.Length; j++)
            {
                var filiere = new Filiere
                {
                    Id = filiereGuids[j],
                    NomFiliere = filiereNames[j],
                    Description = $"Description for {filiereNames[j]}",
                    Niveau = j % 2 == 0 ? "Master" : "Bachelor",
                    Duree = 2 + (j % 4),
                    Capacite = 50 + (j * 5),
                    GroupCapacity = 10 + (j * 2),
                    FraisInscription = 3000 + (j * 200),
                    MontantMensuel = 1000 + (j * 100),
                    MontantAnnuel = 12000 + (j * 1000),
                    MontantTrimestre = 3000 + (j * 250)
                };
                filieres.Add(filiere);

                // Link each Filiere to random Units
                foreach (var unit in units.OrderBy(u => Guid.NewGuid()).Take(5))
                {
                    var filiereUnit = new FiliereUnitOfFormation
                    {
                        FiliereId = filiere.Id,
                        UnitOfFormationId = unit.Id
                    };
                    filiereUnits.Add(filiereUnit);
                }
            }
            
            modelBuilder.Entity<UnitOfFormation>().HasData(units.ToArray());
            modelBuilder.Entity<Filiere>().HasData(filieres.ToArray());
            modelBuilder.Entity<FiliereUnitOfFormation>().HasData(filiereUnits.ToArray());
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
