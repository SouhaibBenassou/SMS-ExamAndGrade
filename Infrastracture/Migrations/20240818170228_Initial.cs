using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), 135, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(9876), null, null, null, "Description for International Relations", 3, 6400m, 44, false, null, 29000m, 2700m, 7250m, "Bachelor", "International Relations", null },
                    { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), 110, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(9467), null, null, null, "Description for Psychology", 2, 5400m, 34, false, null, 24000m, 2200m, 6000m, "Master", "Psychology", null },
                    { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), 125, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(9726), null, null, null, "Description for Philosophy", 5, 6000m, 40, false, null, 27000m, 2500m, 6750m, "Bachelor", "Philosophy", null },
                    { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), 115, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(9543), null, null, null, "Description for Sociology", 3, 5600m, 36, false, null, 25000m, 2300m, 6250m, "Bachelor", "Sociology", null },
                    { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), 90, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(9132), null, null, null, "Description for Chemistry", 2, 4600m, 26, false, null, 20000m, 1800m, 5000m, "Master", "Chemistry", null },
                    { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), 55, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8492), null, null, null, "Description for Electrical Engineering", 3, 3200m, 12, false, null, 13000m, 1100m, 3250m, "Bachelor", "Electrical Engineering", null },
                    { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), 130, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(9798), null, null, null, "Description for Political Science", 2, 6200m, 42, false, null, 28000m, 2600m, 7000m, "Master", "Political Science", null },
                    { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), 85, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(9015), null, null, null, "Description for Physics", 5, 4400m, 24, false, null, 19000m, 1700m, 4750m, "Bachelor", "Physics", null },
                    { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), 95, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(9215), null, null, null, "Description for Biology", 3, 4800m, 28, false, null, 21000m, 1900m, 5250m, "Bachelor", "Biology", null },
                    { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), 70, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8753), null, null, null, "Description for Chemical Engineering", 2, 3800m, 18, false, null, 16000m, 1400m, 4000m, "Master", "Chemical Engineering", null },
                    { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), 75, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8862), null, null, null, "Description for Biotechnology", 3, 4000m, 20, false, null, 17000m, 1500m, 4250m, "Bachelor", "Biotechnology", null },
                    { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), 120, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(9640), null, null, null, "Description for History", 4, 5800m, 38, false, null, 26000m, 2400m, 6500m, "Master", "History", null },
                    { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), 105, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(9351), null, null, null, "Description for Economics", 5, 5200m, 32, false, null, 23000m, 2100m, 5750m, "Bachelor", "Economics", null },
                    { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), 80, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8933), null, null, null, "Description for Mathematics", 4, 4200m, 22, false, null, 18000m, 1600m, 4500m, "Master", "Mathematics", null },
                    { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), 50, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8347), null, null, null, "Description for Computer Science", 2, 3000m, 10, false, null, 12000m, 1000m, 3000m, "Master", "Computer Science", null },
                    { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), 100, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(9274), null, null, null, "Description for Environmental Science", 4, 5000m, 30, false, null, 22000m, 2000m, 5500m, "Master", "Environmental Science", null },
                    { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), 60, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8605), null, null, null, "Description for Mechanical Engineering", 4, 3400m, 14, false, null, 14000m, 1200m, 3500m, "Master", "Mechanical Engineering", null },
                    { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), 65, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8678), null, null, null, "Description for Civil Engineering", 5, 3600m, 16, false, null, 15000m, 1300m, 3750m, "Bachelor", "Civil Engineering", null }
                });

            migrationBuilder.InsertData(
                table: "Formateurs",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Email", "IsDeleted", "ModifiedBy", "Nom", "Prenom", "Specialisation", "Statut", "Telephone", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("a1b2c3d4-e5f6-7a8b-9c0d-ef1234567890"), new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8171), null, null, null, "mehdi.bennani@example.com", false, null, "Bennani", "Mehdi", "Intelligence Artificielle", "Actif", "0600123456", "Permanent", null },
                    { new Guid("b1c2d3e4-f5a6-7b8c-9d0e-ef0987654321"), new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8178), null, null, null, "yassine.elamrani@example.com", false, null, "El Amrani", "Yassine", "Développement Web", "Actif", "0600654321", "Contractuel", null },
                    { new Guid("c1d2e3f4-a5b6-7c8d-9e0f-ef1234987654"), new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8180), null, null, null, "nadia.kabbaj@example.com", false, null, "Kabbaj", "Nadia", "Big Data", "Actif", "0700123456", "Permanent", null },
                    { new Guid("d1e2f3a4-b5c6-7d8e-9f0a-ef6543210987"), new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8183), null, null, null, "karim.alami@example.com", false, null, "Alami", "Karim", "Sécurité Informatique", "Inactif", "0700654321", "Vacataire", null },
                    { new Guid("e1f2a3b4-c5d6-7e8f-9a0b-ef5678901234"), new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8202), null, null, null, "amina.fassi@example.com", false, null, "Fassi", "Amina", "Gestion de Projet", "Actif", "0800123456", "Permanent", null }
                });

            migrationBuilder.InsertData(
                table: "UnitOfFormations",
                columns: new[] { "Id", "Coefficient", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Duration", "IsDeleted", "ModifiedBy", "Name", "Semestre", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("010b6d13-2eac-4174-ad65-01465e63a214"), 5, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8328), null, null, null, 48, false, null, "Cryptography", "Semester 1", null },
                    { new Guid("02460a52-624a-4d97-8c19-e6b029224044"), 4, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8225), null, null, null, 52, false, null, "Physics", "Semester 1", null },
                    { new Guid("03e7f340-7554-43df-bfd4-aee9f88303e1"), 4, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8248), null, null, null, 52, false, null, "Statistics", "Semester 1", null },
                    { new Guid("13b9801a-4692-47ad-9098-acdd865de53d"), 2, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8254), null, null, null, 45, false, null, "Spanish", "Semester 2", null },
                    { new Guid("14651434-068f-4188-aca9-75ce57bd9098"), 6, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8262), null, null, null, 49, false, null, "Japanese", "Semester 2", null },
                    { new Guid("159f42b6-5d53-4e17-ab46-035d438ff528"), 4, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8308), null, null, null, 47, false, null, "Business Studies", "Semester 2", null },
                    { new Guid("17f11d00-6a78-4823-96e2-4b775dda89fd"), 3, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8265), null, null, null, 51, false, null, "Latin", "Semester 2", null },
                    { new Guid("1d4672d3-266e-4128-afbf-ef7db1d2d768"), 6, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8312), null, null, null, 49, false, null, "Engineering Design", "Semester 2", null },
                    { new Guid("2097b01b-88b1-417b-8f5f-65e44621c19f"), 2, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8222), null, null, null, 50, false, null, "Biology", "Semester 1", null },
                    { new Guid("25314fd0-5139-4c2d-a26a-eeb92f0394da"), 3, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8334), null, null, null, 51, false, null, "Geology", "Semester 2", null },
                    { new Guid("2c53749d-c57f-4aa3-86e5-eb7ccbddbf37"), 4, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8257), null, null, null, 47, false, null, "Italian", "Semester 2", null },
                    { new Guid("2e649385-a712-40b9-a796-61b3dddb4718"), 2, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8324), null, null, null, 45, false, null, "Ethics", "Semester 2", null },
                    { new Guid("301f120a-7d37-4f90-8798-a22c1bfc4fbe"), 6, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8331), null, null, null, 49, false, null, "Pharmacology", "Semester 2", null },
                    { new Guid("34395123-6532-464b-ac54-f70c286e75e1"), 5, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8338), null, null, null, 53, false, null, "Meteorology", "Semester 2", null },
                    { new Guid("35f2d025-9f4c-4df7-83d7-ee9fd383bcab"), 6, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8321), null, null, null, 54, false, null, "Anthropology", "Semester 1", null },
                    { new Guid("3656ba7a-22d2-49c8-ac85-52620398c521"), 4, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8238), null, null, null, 47, false, null, "Economics", "Semester 2", null },
                    { new Guid("39ddf2b8-c2ac-4f3e-954d-227e8ae86cdc"), 2, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8341), null, null, null, 45, false, null, "Machine Learning", "Semester 2", null },
                    { new Guid("39fa0a0c-55b5-4870-820f-369336293ea4"), 6, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8339), null, null, null, 54, false, null, "Robotics", "Semester 1", null },
                    { new Guid("4233664a-6d06-45c7-ad6f-953d1091422f"), 3, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8224), null, null, null, 51, false, null, "Chemistry", "Semester 2", null },
                    { new Guid("42ff9ab6-5582-4f31-abb5-859efe27702f"), 4, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8318), null, null, null, 52, false, null, "Dance", "Semester 1", null },
                    { new Guid("46ba8658-e724-459d-b470-857289287451"), 3, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8316), null, null, null, 51, false, null, "Theater", "Semester 2", null },
                    { new Guid("4d03bb02-3ac8-44b3-8a06-c2194507c599"), 3, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8325), null, null, null, 46, false, null, "Mathematics", "Semester 1", null },
                    { new Guid("4e3ca126-3306-4b0a-b59f-615ffe3107aa"), 3, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8305), null, null, null, 46, false, null, "Health Education", "Semester 1", null },
                    { new Guid("506b0193-f003-41fa-b980-4a410416320b"), 4, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8266), null, null, null, 52, false, null, "Greek", "Semester 1", null },
                    { new Guid("573ae136-2718-478b-8ef7-0e8db2d20a92"), 5, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8310), null, null, null, 48, false, null, "Law", "Semester 1", null },
                    { new Guid("6b6bd415-0217-4286-a88f-5ba5dbd88c91"), 3, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8342), null, null, null, 46, false, null, "Data Science", "Semester 1", null },
                    { new Guid("6edd67c4-5aea-49ad-af4e-429cde0a6694"), 5, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8229), null, null, null, 53, false, null, "Computer Science", "Semester 2", null },
                    { new Guid("729aeb20-ae67-4885-8f70-c2ba9cff2c6b"), 4, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8326), null, null, null, 47, false, null, "Statistics", "Semester 2", null },
                    { new Guid("81e448c2-06ef-41d2-8c39-987cae266b70"), 5, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8269), null, null, null, 53, false, null, "Religion", "Semester 2", null },
                    { new Guid("828257db-6aa0-4bfa-aab7-f1c92b736924"), 3, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8245), null, null, null, 51, false, null, "Political Science", "Semester 2", null },
                    { new Guid("89cf38a6-2383-4ca6-a3d6-df75e587722c"), 2, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8242), null, null, null, 50, false, null, "Sociology", "Semester 1", null },
                    { new Guid("8a31ebae-7b20-42b8-99db-96b9c57433a4"), 6, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8231), null, null, null, 54, false, null, "Art", "Semester 1", null },
                    { new Guid("8b9d2463-921e-4964-b972-50968f5d6634"), 4, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8335), null, null, null, 52, false, null, "Oceanography", "Semester 1", null },
                    { new Guid("9b47dea2-98d6-4528-9349-1cac8f7d8bc7"), 2, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8313), null, null, null, 50, false, null, "Information Technology", "Semester 1", null },
                    { new Guid("a2210d55-634d-41bf-8096-8d1e74a7dd55"), 2, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8263), null, null, null, 50, false, null, "Arabic", "Semester 1", null },
                    { new Guid("a2b5749b-ae6d-4916-a5d7-66d39b1a5fab"), 3, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8256), null, null, null, 46, false, null, "German", "Semester 1", null },
                    { new Guid("a47fe0a8-e83e-4170-9fbd-34977a50b00f"), 3, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8212), null, null, null, 46, false, null, "English", "Semester 1", null },
                    { new Guid("aacbf1c3-ea65-4792-8779-89d7c5bfb799"), 5, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8239), null, null, null, 48, false, null, "Psychology", "Semester 1", null },
                    { new Guid("ad4d428d-3b45-4d7c-baca-a7a6b6f8239e"), 3, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8235), null, null, null, 46, false, null, "Physical Education", "Semester 1", null },
                    { new Guid("b3946977-e8e7-49c1-a79a-ee84afe0ae72"), 5, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8319), null, null, null, 53, false, null, "Media Studies", "Semester 2", null },
                    { new Guid("b4517ec8-16c1-47a6-9fb0-418de08d2fa8"), 5, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8215), null, null, null, 48, false, null, "History", "Semester 1", null },
                    { new Guid("b58180cb-eaa3-4d99-ad89-6f7ff3d48fba"), 5, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8249), null, null, null, 53, false, null, "Engineering", "Semester 2", null },
                    { new Guid("b581e7a7-8779-4d59-bfb1-bbf0d0e0a9d3"), 2, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8303), null, null, null, 45, false, null, "Environmental Science", "Semester 2", null },
                    { new Guid("ba1998ab-f9a9-4e13-a39d-c8d925dace08"), 6, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8220), null, null, null, 49, false, null, "Geography", "Semester 2", null },
                    { new Guid("c474807b-d826-4f0a-b614-1a21d27a1969"), 5, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8259), null, null, null, 48, false, null, "Chinese", "Semester 1", null },
                    { new Guid("cafc7c2d-fa6c-41fa-86a4-710c85d95359"), 6, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8301), null, null, null, 54, false, null, "Astronomy", "Semester 1", null },
                    { new Guid("ce54dc15-b5a7-4f08-b0a0-48efbb7a6d69"), 4, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8345), null, null, null, 47, false, null, "Artificial Intelligence", "Semester 2", null },
                    { new Guid("de4f3b7a-4a99-4881-aa82-638a096059b5"), 6, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8251), null, null, null, 54, false, null, "Literature", "Semester 1", null },
                    { new Guid("eba4be51-b10a-4c2f-a37b-114e40428b35"), 2, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8332), null, null, null, 50, false, null, "Astrophysics", "Semester 1", null },
                    { new Guid("eed3160b-c071-4de8-a1be-f8c51a49b990"), 4, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8214), null, null, null, 47, false, null, "Math", "Semester 2", null },
                    { new Guid("f3ff0e95-18fb-4417-8771-cb98685d272b"), 2, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8233), null, null, null, 45, false, null, "Music", "Semester 2", null },
                    { new Guid("fa1a1430-e11a-460c-94fc-d64219babc3f"), 6, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8241), null, null, null, 49, false, null, "Philosophy", "Semester 2", null },
                    { new Guid("fb506553-5c27-46a2-970f-932d56f5fba1"), 2, new DateTime(2024, 8, 18, 17, 2, 28, 56, DateTimeKind.Utc).AddTicks(8207), null, null, null, 45, false, null, "Français", "Semester 2", null }
                });

            migrationBuilder.InsertData(
                table: "FiliereUnitOfFormations",
                columns: new[] { "FiliereId", "UnitOfFormationId" },
                values: new object[,]
                {
                    { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("2c53749d-c57f-4aa3-86e5-eb7ccbddbf37") },
                    { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("89cf38a6-2383-4ca6-a3d6-df75e587722c") },
                    { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("b3946977-e8e7-49c1-a79a-ee84afe0ae72") },
                    { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("ba1998ab-f9a9-4e13-a39d-c8d925dace08") },
                    { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("cafc7c2d-fa6c-41fa-86a4-710c85d95359") },
                    { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("159f42b6-5d53-4e17-ab46-035d438ff528") },
                    { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("3656ba7a-22d2-49c8-ac85-52620398c521") },
                    { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("a47fe0a8-e83e-4170-9fbd-34977a50b00f") },
                    { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("b58180cb-eaa3-4d99-ad89-6f7ff3d48fba") },
                    { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("ba1998ab-f9a9-4e13-a39d-c8d925dace08") },
                    { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("03e7f340-7554-43df-bfd4-aee9f88303e1") },
                    { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("25314fd0-5139-4c2d-a26a-eeb92f0394da") },
                    { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("6b6bd415-0217-4286-a88f-5ba5dbd88c91") },
                    { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("b58180cb-eaa3-4d99-ad89-6f7ff3d48fba") },
                    { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("ce54dc15-b5a7-4f08-b0a0-48efbb7a6d69") },
                    { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("34395123-6532-464b-ac54-f70c286e75e1") },
                    { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("46ba8658-e724-459d-b470-857289287451") },
                    { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("573ae136-2718-478b-8ef7-0e8db2d20a92") },
                    { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("89cf38a6-2383-4ca6-a3d6-df75e587722c") },
                    { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("ce54dc15-b5a7-4f08-b0a0-48efbb7a6d69") },
                    { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("25314fd0-5139-4c2d-a26a-eeb92f0394da") },
                    { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("35f2d025-9f4c-4df7-83d7-ee9fd383bcab") },
                    { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("3656ba7a-22d2-49c8-ac85-52620398c521") },
                    { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("b3946977-e8e7-49c1-a79a-ee84afe0ae72") },
                    { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("c474807b-d826-4f0a-b614-1a21d27a1969") },
                    { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("02460a52-624a-4d97-8c19-e6b029224044") },
                    { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("2c53749d-c57f-4aa3-86e5-eb7ccbddbf37") },
                    { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("8a31ebae-7b20-42b8-99db-96b9c57433a4") },
                    { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("a47fe0a8-e83e-4170-9fbd-34977a50b00f") },
                    { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("b581e7a7-8779-4d59-bfb1-bbf0d0e0a9d3") },
                    { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("39fa0a0c-55b5-4870-820f-369336293ea4") },
                    { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("46ba8658-e724-459d-b470-857289287451") },
                    { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("a47fe0a8-e83e-4170-9fbd-34977a50b00f") },
                    { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("c474807b-d826-4f0a-b614-1a21d27a1969") },
                    { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("fb506553-5c27-46a2-970f-932d56f5fba1") },
                    { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("13b9801a-4692-47ad-9098-acdd865de53d") },
                    { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("1d4672d3-266e-4128-afbf-ef7db1d2d768") },
                    { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("573ae136-2718-478b-8ef7-0e8db2d20a92") },
                    { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("ad4d428d-3b45-4d7c-baca-a7a6b6f8239e") },
                    { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("ce54dc15-b5a7-4f08-b0a0-48efbb7a6d69") },
                    { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("17f11d00-6a78-4823-96e2-4b775dda89fd") },
                    { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("2097b01b-88b1-417b-8f5f-65e44621c19f") },
                    { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("6edd67c4-5aea-49ad-af4e-429cde0a6694") },
                    { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("b581e7a7-8779-4d59-bfb1-bbf0d0e0a9d3") },
                    { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("fb506553-5c27-46a2-970f-932d56f5fba1") },
                    { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("17f11d00-6a78-4823-96e2-4b775dda89fd") },
                    { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("1d4672d3-266e-4128-afbf-ef7db1d2d768") },
                    { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("b4517ec8-16c1-47a6-9fb0-418de08d2fa8") },
                    { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("eed3160b-c071-4de8-a1be-f8c51a49b990") },
                    { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("f3ff0e95-18fb-4417-8771-cb98685d272b") },
                    { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("25314fd0-5139-4c2d-a26a-eeb92f0394da") },
                    { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("2e649385-a712-40b9-a796-61b3dddb4718") },
                    { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("42ff9ab6-5582-4f31-abb5-859efe27702f") },
                    { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("aacbf1c3-ea65-4792-8779-89d7c5bfb799") },
                    { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("cafc7c2d-fa6c-41fa-86a4-710c85d95359") },
                    { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("6b6bd415-0217-4286-a88f-5ba5dbd88c91") },
                    { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("aacbf1c3-ea65-4792-8779-89d7c5bfb799") },
                    { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("ad4d428d-3b45-4d7c-baca-a7a6b6f8239e") },
                    { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("cafc7c2d-fa6c-41fa-86a4-710c85d95359") },
                    { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("de4f3b7a-4a99-4881-aa82-638a096059b5") },
                    { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("159f42b6-5d53-4e17-ab46-035d438ff528") },
                    { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("35f2d025-9f4c-4df7-83d7-ee9fd383bcab") },
                    { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("6edd67c4-5aea-49ad-af4e-429cde0a6694") },
                    { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("a47fe0a8-e83e-4170-9fbd-34977a50b00f") },
                    { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("c474807b-d826-4f0a-b614-1a21d27a1969") },
                    { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("39ddf2b8-c2ac-4f3e-954d-227e8ae86cdc") },
                    { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("46ba8658-e724-459d-b470-857289287451") },
                    { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("506b0193-f003-41fa-b980-4a410416320b") },
                    { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("ce54dc15-b5a7-4f08-b0a0-48efbb7a6d69") },
                    { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("fa1a1430-e11a-460c-94fc-d64219babc3f") },
                    { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("1d4672d3-266e-4128-afbf-ef7db1d2d768") },
                    { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("6edd67c4-5aea-49ad-af4e-429cde0a6694") },
                    { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("b4517ec8-16c1-47a6-9fb0-418de08d2fa8") },
                    { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("eba4be51-b10a-4c2f-a37b-114e40428b35") },
                    { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("eed3160b-c071-4de8-a1be-f8c51a49b990") },
                    { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("159f42b6-5d53-4e17-ab46-035d438ff528") },
                    { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("39fa0a0c-55b5-4870-820f-369336293ea4") },
                    { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("b3946977-e8e7-49c1-a79a-ee84afe0ae72") },
                    { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("b581e7a7-8779-4d59-bfb1-bbf0d0e0a9d3") },
                    { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("cafc7c2d-fa6c-41fa-86a4-710c85d95359") },
                    { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("02460a52-624a-4d97-8c19-e6b029224044") },
                    { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("159f42b6-5d53-4e17-ab46-035d438ff528") },
                    { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("17f11d00-6a78-4823-96e2-4b775dda89fd") },
                    { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("3656ba7a-22d2-49c8-ac85-52620398c521") },
                    { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("ba1998ab-f9a9-4e13-a39d-c8d925dace08") },
                    { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("2097b01b-88b1-417b-8f5f-65e44621c19f") },
                    { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("9b47dea2-98d6-4528-9349-1cac8f7d8bc7") },
                    { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("a2b5749b-ae6d-4916-a5d7-66d39b1a5fab") },
                    { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("ce54dc15-b5a7-4f08-b0a0-48efbb7a6d69") },
                    { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("fa1a1430-e11a-460c-94fc-d64219babc3f") }
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
