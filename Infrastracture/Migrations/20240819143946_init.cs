using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filieres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomFiliere = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Niveau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duree = table.Column<int>(type: "int", nullable: false),
                    Capacite = table.Column<int>(type: "int", nullable: false),
                    GroupCapacity = table.Column<int>(type: "int", nullable: false),
                    FraisInscription = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MontantMensuel = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MontantAnnuel = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MontantTrimestre = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filieres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Formateurs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialisation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Statut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formateurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IndividualWorkUOFs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Confusion = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualWorkUOFs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    RoomName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomType = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supervisors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supervisors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitOfFormations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Semestre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Coefficient = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitOfFormations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IndividualWorks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StagiaireId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Note = table.Column<int>(type: "int", nullable: false),
                    IndividualWorkUOFId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualWorks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndividualWorks_IndividualWorkUOFs_IndividualWorkUOFId",
                        column: x => x.IndividualWorkUOFId,
                        principalTable: "IndividualWorkUOFs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExamDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExamType = table.Column<int>(type: "int", nullable: true),
                    YearId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    YearType = table.Column<int>(type: "int", nullable: true),
                    FiliereId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitOfFormationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exams_Filieres_FiliereId",
                        column: x => x.FiliereId,
                        principalTable: "Filieres",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exams_UnitOfFormations_UnitOfFormationId",
                        column: x => x.UnitOfFormationId,
                        principalTable: "UnitOfFormations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FiliereUnitOfFormations",
                columns: table => new
                {
                    FiliereId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitOfFormationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiliereUnitOfFormations", x => new { x.FiliereId, x.UnitOfFormationId });
                    table.ForeignKey(
                        name: "FK_FiliereUnitOfFormations_Filieres_FiliereId",
                        column: x => x.FiliereId,
                        principalTable: "Filieres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FiliereUnitOfFormations_UnitOfFormations_UnitOfFormationId",
                        column: x => x.UnitOfFormationId,
                        principalTable: "UnitOfFormations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestStatement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestCorrection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<double>(type: "float", nullable: true),
                    FiliereId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TrainerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitOfFormationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tests_Filieres_FiliereId",
                        column: x => x.FiliereId,
                        principalTable: "Filieres",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tests_UnitOfFormations_UnitOfFormationId",
                        column: x => x.UnitOfFormationId,
                        principalTable: "UnitOfFormations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamAttendances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Attendance = table.Column<bool>(type: "bit", nullable: true),
                    StagiaireId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamAttendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamAttendances_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExamResults",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StagiaireId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PracticalNote = table.Column<double>(type: "float", nullable: true),
                    TheoreticalNote = table.Column<double>(type: "float", nullable: true),
                    IsValid = table.Column<bool>(type: "bit", nullable: true),
                    DateValidation = table.Column<DateOnly>(type: "date", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamResults_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExamSessions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupervisorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamSessions_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamSessions_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamSessions_Supervisors_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Supervisors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VariantsExams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VariantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExamStatement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExamCorrection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitOfFormationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    VariantType = table.Column<int>(type: "int", nullable: true),
                    NoteMax = table.Column<int>(type: "int", nullable: true),
                    IsValid = table.Column<bool>(type: "bit", nullable: true),
                    TrainerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VariantsExams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VariantsExams_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VariantsExams_UnitOfFormations_UnitOfFormationId",
                        column: x => x.UnitOfFormationId,
                        principalTable: "UnitOfFormations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TestResults",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TestId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StagiaireId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Note = table.Column<double>(type: "float", nullable: true),
                    IsValid = table.Column<bool>(type: "bit", nullable: true),
                    DateValidation = table.Column<DateOnly>(type: "date", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestResults_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AllResults",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExamResultId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TestResultsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AllResults_ExamResults_ExamResultId",
                        column: x => x.ExamResultId,
                        principalTable: "ExamResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AllResults_TestResults_TestResultsId",
                        column: x => x.TestResultsId,
                        principalTable: "TestResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Filieres",
                columns: new[] { "Id", "Capacite", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "Duree", "FraisInscription", "GroupCapacity", "IsDeleted", "ModifiedBy", "MontantAnnuel", "MontantMensuel", "MontantTrimestre", "Niveau", "NomFiliere", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), 135, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(4697), null, null, null, "Description for International Relations", 3, 6400m, 44, false, null, 29000m, 2700m, 7250m, "Bachelor", "International Relations", null },
                    { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), 110, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(3836), null, null, null, "Description for Psychology", 2, 5400m, 34, false, null, 24000m, 2200m, 6000m, "Master", "Psychology", null },
                    { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), 125, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(4405), null, null, null, "Description for Philosophy", 5, 6000m, 40, false, null, 27000m, 2500m, 6750m, "Bachelor", "Philosophy", null },
                    { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), 115, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(3972), null, null, null, "Description for Sociology", 3, 5600m, 36, false, null, 25000m, 2300m, 6250m, "Bachelor", "Sociology", null },
                    { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), 90, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(3247), null, null, null, "Description for Chemistry", 2, 4600m, 26, false, null, 20000m, 1800m, 5000m, "Master", "Chemistry", null },
                    { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), 55, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(2209), null, null, null, "Description for Electrical Engineering", 3, 3200m, 12, false, null, 13000m, 1100m, 3250m, "Bachelor", "Electrical Engineering", null },
                    { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), 130, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(4548), null, null, null, "Description for Political Science", 2, 6200m, 42, false, null, 28000m, 2600m, 7000m, "Master", "Political Science", null },
                    { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), 85, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(3129), null, null, null, "Description for Physics", 5, 4400m, 24, false, null, 19000m, 1700m, 4750m, "Bachelor", "Physics", null },
                    { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), 95, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(3379), null, null, null, "Description for Biology", 3, 4800m, 28, false, null, 21000m, 1900m, 5250m, "Bachelor", "Biology", null },
                    { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), 70, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(2682), null, null, null, "Description for Chemical Engineering", 2, 3800m, 18, false, null, 16000m, 1400m, 4000m, "Master", "Chemical Engineering", null },
                    { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), 75, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(2799), null, null, null, "Description for Biotechnology", 3, 4000m, 20, false, null, 17000m, 1500m, 4250m, "Bachelor", "Biotechnology", null },
                    { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), 120, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(4285), null, null, null, "Description for History", 4, 5800m, 38, false, null, 26000m, 2400m, 6500m, "Master", "History", null },
                    { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), 105, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(3708), null, null, null, "Description for Economics", 5, 5200m, 32, false, null, 23000m, 2100m, 5750m, "Bachelor", "Economics", null },
                    { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), 80, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(2946), null, null, null, "Description for Mathematics", 4, 4200m, 22, false, null, 18000m, 1600m, 4500m, "Master", "Mathematics", null },
                    { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), 50, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1895), null, null, null, "Description for Computer Science", 2, 3000m, 10, false, null, 12000m, 1000m, 3000m, "Master", "Computer Science", null },
                    { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), 100, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(3513), null, null, null, "Description for Environmental Science", 4, 5000m, 30, false, null, 22000m, 2000m, 5500m, "Master", "Environmental Science", null },
                    { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), 60, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(2376), null, null, null, "Description for Mechanical Engineering", 4, 3400m, 14, false, null, 14000m, 1200m, 3500m, "Master", "Mechanical Engineering", null },
                    { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), 65, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(2507), null, null, null, "Description for Civil Engineering", 5, 3600m, 16, false, null, 15000m, 1300m, 3750m, "Bachelor", "Civil Engineering", null }
                });

            migrationBuilder.InsertData(
                table: "Formateurs",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Email", "IsDeleted", "ModifiedBy", "Nom", "Prenom", "Specialisation", "Statut", "Telephone", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("a1b2c3d4-e5f6-7a8b-9c0d-ef1234567890"), new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1536), null, null, null, "mehdi.bennani@example.com", false, null, "Bennani", "Mehdi", "Intelligence Artificielle", "Actif", "0600123456", "Permanent", null },
                    { new Guid("b1c2d3e4-f5a6-7b8c-9d0e-ef0987654321"), new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1556), null, null, null, "yassine.elamrani@example.com", false, null, "El Amrani", "Yassine", "Développement Web", "Actif", "0600654321", "Contractuel", null },
                    { new Guid("c1d2e3f4-a5b6-7c8d-9e0f-ef1234987654"), new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1561), null, null, null, "nadia.kabbaj@example.com", false, null, "Kabbaj", "Nadia", "Big Data", "Actif", "0700123456", "Permanent", null },
                    { new Guid("d1e2f3a4-b5c6-7d8e-9f0a-ef6543210987"), new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1564), null, null, null, "karim.alami@example.com", false, null, "Alami", "Karim", "Sécurité Informatique", "Inactif", "0700654321", "Vacataire", null },
                    { new Guid("e1f2a3b4-c5d6-7e8f-9a0b-ef5678901234"), new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1568), null, null, null, "amina.fassi@example.com", false, null, "Fassi", "Amina", "Gestion de Projet", "Actif", "0800123456", "Permanent", null }
                });

            migrationBuilder.InsertData(
                table: "UnitOfFormations",
                columns: new[] { "Id", "Coefficient", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Duration", "IsDeleted", "ModifiedBy", "Name", "Semestre", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("03ce2b05-1bee-4823-8f09-ee8a54baff53"), 6, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1854), null, null, null, 54, false, null, "Anthropology", "Semester 1", null },
                    { new Guid("08c7d265-8605-44f3-aa5e-0e8d67e47ac2"), 4, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1620), null, null, null, 47, false, null, "Economics", "Semester 2", null },
                    { new Guid("0bbc12bb-8163-457a-a852-ed28f0d6ea86"), 2, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1779), null, null, null, 50, false, null, "Sociology", "Semester 1", null },
                    { new Guid("1239cc38-04cf-4430-9b92-aeb1e8dae76e"), 2, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1871), null, null, null, 50, false, null, "Astrophysics", "Semester 1", null },
                    { new Guid("207dcd58-8e1d-4139-9d34-e12cad4d43b3"), 2, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1575), null, null, null, 45, false, null, "Français", "Semester 2", null },
                    { new Guid("21ca9b68-f335-4533-a02f-b8583f0503f6"), 4, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1891), null, null, null, 47, false, null, "Artificial Intelligence", "Semester 2", null },
                    { new Guid("24e0b880-406e-4c87-a7ad-0ef89cd9a0bb"), 2, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1856), null, null, null, 45, false, null, "Ethics", "Semester 2", null },
                    { new Guid("48b88652-b6db-493f-871a-7de5adb5af05"), 3, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1859), null, null, null, 46, false, null, "Mathematics", "Semester 1", null },
                    { new Guid("4b6e905c-2bd7-44d7-8391-32e75fd550de"), 5, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1607), null, null, null, 53, false, null, "Computer Science", "Semester 2", null },
                    { new Guid("51370ef7-f646-4445-9c8d-c00ba25abca3"), 6, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1868), null, null, null, 49, false, null, "Pharmacology", "Semester 2", null },
                    { new Guid("518056b9-e28c-427d-a02c-9241ad3442d4"), 5, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1806), null, null, null, 48, false, null, "Chinese", "Semester 1", null },
                    { new Guid("597422d1-9775-4777-a79c-b99bd43012e0"), 4, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1786), null, null, null, 52, false, null, "Statistics", "Semester 1", null },
                    { new Guid("59c6e6a0-89e4-4043-9d33-fb0725a2b4f2"), 3, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1844), null, null, null, 51, false, null, "Theater", "Semester 2", null },
                    { new Guid("5e2afd75-7cc1-40ea-a292-61d0aad3b977"), 3, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1782), null, null, null, 51, false, null, "Political Science", "Semester 2", null },
                    { new Guid("67778971-04b1-4c5d-aec5-a24fbb031c89"), 4, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1803), null, null, null, 47, false, null, "Italian", "Semester 2", null },
                    { new Guid("6791aad2-09e4-4cf0-86d3-d5d1339d2c6f"), 2, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1842), null, null, null, 50, false, null, "Information Technology", "Semester 1", null },
                    { new Guid("68b0cb87-46b1-4129-91f2-8f50ff2de83c"), 5, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1852), null, null, null, 53, false, null, "Media Studies", "Semester 2", null },
                    { new Guid("68c73084-72d8-47f7-8551-60bc6c563e32"), 5, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1880), null, null, null, 53, false, null, "Meteorology", "Semester 2", null },
                    { new Guid("69210365-a437-4666-91c3-9fbf33e52904"), 4, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1832), null, null, null, 47, false, null, "Business Studies", "Semester 2", null },
                    { new Guid("73a70be3-32b5-4caf-9a0a-156ee1416793"), 2, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1827), null, null, null, 45, false, null, "Environmental Science", "Semester 2", null },
                    { new Guid("76845ab0-6aac-4873-9563-a5d723b47c90"), 4, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1604), null, null, null, 52, false, null, "Physics", "Semester 1", null },
                    { new Guid("79491fb6-c30b-479a-9545-4f511c3fa87f"), 3, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1798), null, null, null, 46, false, null, "German", "Semester 1", null },
                    { new Guid("7a8364d2-087d-4184-9325-5a3fcdb8c878"), 4, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1847), null, null, null, 52, false, null, "Dance", "Semester 1", null },
                    { new Guid("7c168860-1c57-4ef3-b6b2-fadb326c24dd"), 6, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1809), null, null, null, 49, false, null, "Japanese", "Semester 2", null },
                    { new Guid("7d12a3a0-38b9-4dbb-848b-161d3a973df9"), 2, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1597), null, null, null, 50, false, null, "Biology", "Semester 1", null },
                    { new Guid("812b28ae-aad1-4788-9f87-fc648cfacde0"), 5, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1835), null, null, null, 48, false, null, "Law", "Semester 1", null },
                    { new Guid("96028752-f817-47e3-b24a-9d673dffc367"), 5, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1791), null, null, null, 53, false, null, "Engineering", "Semester 2", null },
                    { new Guid("9aa85501-1ca3-44b1-804d-a362c03c8f41"), 3, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1875), null, null, null, 51, false, null, "Geology", "Semester 2", null },
                    { new Guid("a272f4fa-fd4d-4963-9133-fb66d11a248f"), 5, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1820), null, null, null, 53, false, null, "Religion", "Semester 2", null },
                    { new Guid("a47f14d2-d321-4cf4-96e2-30193053069e"), 4, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1818), null, null, null, 52, false, null, "Greek", "Semester 1", null },
                    { new Guid("a4e49c71-b1c3-4d35-b9df-2c5077bbaa5f"), 2, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1887), null, null, null, 45, false, null, "Machine Learning", "Semester 2", null },
                    { new Guid("a60afdf6-2972-4204-b3e8-bc6301770b7b"), 3, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1602), null, null, null, 51, false, null, "Chemistry", "Semester 2", null },
                    { new Guid("a65b1600-b5b1-4bf0-a48c-ba975a5e9f89"), 3, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1583), null, null, null, 46, false, null, "English", "Semester 1", null },
                    { new Guid("a84528ba-767f-44eb-b42f-52ab30d6f46e"), 6, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1594), null, null, null, 49, false, null, "Geography", "Semester 2", null },
                    { new Guid("a8d9ca92-a72c-4d82-a2dc-9f9109436fb6"), 6, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1822), null, null, null, 54, false, null, "Astronomy", "Semester 1", null },
                    { new Guid("adc04f0d-b874-4a9d-852f-1356e097855b"), 2, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1796), null, null, null, 45, false, null, "Spanish", "Semester 2", null },
                    { new Guid("b0c0524e-9ab5-489f-9cde-c8df84d37443"), 5, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1622), null, null, null, 48, false, null, "Psychology", "Semester 1", null },
                    { new Guid("bd7f31c7-e9f5-49f9-b5b5-530b34463faa"), 4, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1589), null, null, null, 47, false, null, "Math", "Semester 2", null },
                    { new Guid("bef62363-9dd1-4193-bace-bc52eec10c90"), 4, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1863), null, null, null, 47, false, null, "Statistics", "Semester 2", null },
                    { new Guid("bf53b3c5-33e1-4ce6-a5ea-28edc87af26a"), 2, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1615), null, null, null, 45, false, null, "Music", "Semester 2", null },
                    { new Guid("c05ccfef-0963-446a-8896-e52812f93c70"), 3, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1815), null, null, null, 51, false, null, "Latin", "Semester 2", null },
                    { new Guid("c7268c2a-47b9-4084-b76a-581b47de73f0"), 6, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1627), null, null, null, 49, false, null, "Philosophy", "Semester 2", null },
                    { new Guid("cee2f638-2b57-4853-9ce4-d13ac61c664d"), 6, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1882), null, null, null, 54, false, null, "Robotics", "Semester 1", null },
                    { new Guid("d7cb4e59-ffe1-4d88-b025-936dfc26cb46"), 3, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1618), null, null, null, 46, false, null, "Physical Education", "Semester 1", null },
                    { new Guid("dd7beea7-cf54-4f77-8c41-43a2ec8d87ba"), 5, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1591), null, null, null, 48, false, null, "History", "Semester 1", null },
                    { new Guid("ded55607-3c83-40fb-923b-57cac2fa443e"), 3, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1889), null, null, null, 46, false, null, "Data Science", "Semester 1", null },
                    { new Guid("e318506c-22fb-4de5-9056-ee1f8b1e9a79"), 6, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1793), null, null, null, 54, false, null, "Literature", "Semester 1", null },
                    { new Guid("e3626f57-16f9-4e6d-85fc-6048035334d5"), 4, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1877), null, null, null, 52, false, null, "Oceanography", "Semester 1", null },
                    { new Guid("ef617c46-ab87-4954-8d4e-934d9b257818"), 3, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1829), null, null, null, 46, false, null, "Health Education", "Semester 1", null },
                    { new Guid("f07a95f9-d2c0-4f31-b8f8-21e994263b5f"), 6, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1840), null, null, null, 49, false, null, "Engineering Design", "Semester 2", null },
                    { new Guid("f20ca1a9-ed53-4963-815f-1cb43b6fda94"), 6, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1610), null, null, null, 54, false, null, "Art", "Semester 1", null },
                    { new Guid("f9dba3a5-f75f-4051-83f6-29a5051c93ee"), 2, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1811), null, null, null, 50, false, null, "Arabic", "Semester 1", null },
                    { new Guid("fb338b27-aa60-4908-a350-28a39f1b7365"), 5, new DateTime(2024, 8, 19, 14, 39, 45, 52, DateTimeKind.Utc).AddTicks(1866), null, null, null, 48, false, null, "Cryptography", "Semester 1", null }
                });

            migrationBuilder.InsertData(
                table: "FiliereUnitOfFormations",
                columns: new[] { "FiliereId", "UnitOfFormationId" },
                values: new object[,]
                {
                    { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("0bbc12bb-8163-457a-a852-ed28f0d6ea86") },
                    { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("518056b9-e28c-427d-a02c-9241ad3442d4") },
                    { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("5e2afd75-7cc1-40ea-a292-61d0aad3b977") },
                    { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("96028752-f817-47e3-b24a-9d673dffc367") },
                    { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("f07a95f9-d2c0-4f31-b8f8-21e994263b5f") },
                    { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("03ce2b05-1bee-4823-8f09-ee8a54baff53") },
                    { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("21ca9b68-f335-4533-a02f-b8583f0503f6") },
                    { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("c7268c2a-47b9-4084-b76a-581b47de73f0") },
                    { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("cee2f638-2b57-4853-9ce4-d13ac61c664d") },
                    { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("f07a95f9-d2c0-4f31-b8f8-21e994263b5f") },
                    { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("73a70be3-32b5-4caf-9a0a-156ee1416793") },
                    { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("a4e49c71-b1c3-4d35-b9df-2c5077bbaa5f") },
                    { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("d7cb4e59-ffe1-4d88-b025-936dfc26cb46") },
                    { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("f20ca1a9-ed53-4963-815f-1cb43b6fda94") },
                    { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("fb338b27-aa60-4908-a350-28a39f1b7365") },
                    { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("51370ef7-f646-4445-9c8d-c00ba25abca3") },
                    { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("518056b9-e28c-427d-a02c-9241ad3442d4") },
                    { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("68b0cb87-46b1-4129-91f2-8f50ff2de83c") },
                    { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("9aa85501-1ca3-44b1-804d-a362c03c8f41") },
                    { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("a47f14d2-d321-4cf4-96e2-30193053069e") },
                    { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("03ce2b05-1bee-4823-8f09-ee8a54baff53") },
                    { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("73a70be3-32b5-4caf-9a0a-156ee1416793") },
                    { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("a272f4fa-fd4d-4963-9133-fb66d11a248f") },
                    { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("dd7beea7-cf54-4f77-8c41-43a2ec8d87ba") },
                    { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("e318506c-22fb-4de5-9056-ee1f8b1e9a79") },
                    { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("1239cc38-04cf-4430-9b92-aeb1e8dae76e") },
                    { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("76845ab0-6aac-4873-9563-a5d723b47c90") },
                    { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("9aa85501-1ca3-44b1-804d-a362c03c8f41") },
                    { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("a60afdf6-2972-4204-b3e8-bc6301770b7b") },
                    { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("c05ccfef-0963-446a-8896-e52812f93c70") },
                    { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("08c7d265-8605-44f3-aa5e-0e8d67e47ac2") },
                    { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("812b28ae-aad1-4788-9f87-fc648cfacde0") },
                    { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("a4e49c71-b1c3-4d35-b9df-2c5077bbaa5f") },
                    { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("a60afdf6-2972-4204-b3e8-bc6301770b7b") },
                    { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("f20ca1a9-ed53-4963-815f-1cb43b6fda94") },
                    { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("207dcd58-8e1d-4139-9d34-e12cad4d43b3") },
                    { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("21ca9b68-f335-4533-a02f-b8583f0503f6") },
                    { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("69210365-a437-4666-91c3-9fbf33e52904") },
                    { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("9aa85501-1ca3-44b1-804d-a362c03c8f41") },
                    { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("d7cb4e59-ffe1-4d88-b025-936dfc26cb46") },
                    { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("a60afdf6-2972-4204-b3e8-bc6301770b7b") },
                    { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("a84528ba-767f-44eb-b42f-52ab30d6f46e") },
                    { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("a8d9ca92-a72c-4d82-a2dc-9f9109436fb6") },
                    { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("c7268c2a-47b9-4084-b76a-581b47de73f0") },
                    { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("ef617c46-ab87-4954-8d4e-934d9b257818") },
                    { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("24e0b880-406e-4c87-a7ad-0ef89cd9a0bb") },
                    { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("76845ab0-6aac-4873-9563-a5d723b47c90") },
                    { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("d7cb4e59-ffe1-4d88-b025-936dfc26cb46") },
                    { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("dd7beea7-cf54-4f77-8c41-43a2ec8d87ba") },
                    { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("ded55607-3c83-40fb-923b-57cac2fa443e") },
                    { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("597422d1-9775-4777-a79c-b99bd43012e0") },
                    { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("9aa85501-1ca3-44b1-804d-a362c03c8f41") },
                    { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("b0c0524e-9ab5-489f-9cde-c8df84d37443") },
                    { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("ded55607-3c83-40fb-923b-57cac2fa443e") },
                    { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("e3626f57-16f9-4e6d-85fc-6048035334d5") },
                    { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("08c7d265-8605-44f3-aa5e-0e8d67e47ac2") },
                    { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("51370ef7-f646-4445-9c8d-c00ba25abca3") },
                    { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("bef62363-9dd1-4193-bace-bc52eec10c90") },
                    { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("dd7beea7-cf54-4f77-8c41-43a2ec8d87ba") },
                    { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("ded55607-3c83-40fb-923b-57cac2fa443e") },
                    { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("08c7d265-8605-44f3-aa5e-0e8d67e47ac2") },
                    { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("7d12a3a0-38b9-4dbb-848b-161d3a973df9") },
                    { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("c7268c2a-47b9-4084-b76a-581b47de73f0") },
                    { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("f07a95f9-d2c0-4f31-b8f8-21e994263b5f") },
                    { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("f20ca1a9-ed53-4963-815f-1cb43b6fda94") },
                    { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("21ca9b68-f335-4533-a02f-b8583f0503f6") },
                    { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("24e0b880-406e-4c87-a7ad-0ef89cd9a0bb") },
                    { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("597422d1-9775-4777-a79c-b99bd43012e0") },
                    { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("9aa85501-1ca3-44b1-804d-a362c03c8f41") },
                    { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("b0c0524e-9ab5-489f-9cde-c8df84d37443") },
                    { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("08c7d265-8605-44f3-aa5e-0e8d67e47ac2") },
                    { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("518056b9-e28c-427d-a02c-9241ad3442d4") },
                    { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("a47f14d2-d321-4cf4-96e2-30193053069e") },
                    { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("b0c0524e-9ab5-489f-9cde-c8df84d37443") },
                    { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("dd7beea7-cf54-4f77-8c41-43a2ec8d87ba") },
                    { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("207dcd58-8e1d-4139-9d34-e12cad4d43b3") },
                    { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("5e2afd75-7cc1-40ea-a292-61d0aad3b977") },
                    { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("dd7beea7-cf54-4f77-8c41-43a2ec8d87ba") },
                    { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("f07a95f9-d2c0-4f31-b8f8-21e994263b5f") },
                    { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("f20ca1a9-ed53-4963-815f-1cb43b6fda94") },
                    { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("03ce2b05-1bee-4823-8f09-ee8a54baff53") },
                    { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("69210365-a437-4666-91c3-9fbf33e52904") },
                    { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("812b28ae-aad1-4788-9f87-fc648cfacde0") },
                    { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("a4e49c71-b1c3-4d35-b9df-2c5077bbaa5f") },
                    { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("ef617c46-ab87-4954-8d4e-934d9b257818") },
                    { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("4b6e905c-2bd7-44d7-8391-32e75fd550de") },
                    { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("518056b9-e28c-427d-a02c-9241ad3442d4") },
                    { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("68c73084-72d8-47f7-8551-60bc6c563e32") },
                    { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("a4e49c71-b1c3-4d35-b9df-2c5077bbaa5f") },
                    { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("dd7beea7-cf54-4f77-8c41-43a2ec8d87ba") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AllResults_ExamResultId",
                table: "AllResults",
                column: "ExamResultId");

            migrationBuilder.CreateIndex(
                name: "IX_AllResults_TestResultsId",
                table: "AllResults",
                column: "TestResultsId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamAttendances_ExamId",
                table: "ExamAttendances",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamResults_ExamId",
                table: "ExamResults",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_FiliereId",
                table: "Exams",
                column: "FiliereId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_UnitOfFormationId",
                table: "Exams",
                column: "UnitOfFormationId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamSessions_ExamId",
                table: "ExamSessions",
                column: "ExamId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExamSessions_RoomId",
                table: "ExamSessions",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamSessions_SupervisorId",
                table: "ExamSessions",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_FiliereUnitOfFormations_UnitOfFormationId",
                table: "FiliereUnitOfFormations",
                column: "UnitOfFormationId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualWorks_IndividualWorkUOFId",
                table: "IndividualWorks",
                column: "IndividualWorkUOFId");

            migrationBuilder.CreateIndex(
                name: "IX_TestResults_TestId",
                table: "TestResults",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_FiliereId",
                table: "Tests",
                column: "FiliereId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_UnitOfFormationId",
                table: "Tests",
                column: "UnitOfFormationId");

            migrationBuilder.CreateIndex(
                name: "IX_VariantsExams_ExamId",
                table: "VariantsExams",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_VariantsExams_UnitOfFormationId",
                table: "VariantsExams",
                column: "UnitOfFormationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllResults");

            migrationBuilder.DropTable(
                name: "ExamAttendances");

            migrationBuilder.DropTable(
                name: "ExamSessions");

            migrationBuilder.DropTable(
                name: "FiliereUnitOfFormations");

            migrationBuilder.DropTable(
                name: "Formateurs");

            migrationBuilder.DropTable(
                name: "IndividualWorks");

            migrationBuilder.DropTable(
                name: "VariantsExams");

            migrationBuilder.DropTable(
                name: "ExamResults");

            migrationBuilder.DropTable(
                name: "TestResults");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Supervisors");

            migrationBuilder.DropTable(
                name: "IndividualWorkUOFs");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "Filieres");

            migrationBuilder.DropTable(
                name: "UnitOfFormations");
        }
    }
}
