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
                name: "IndividualWorks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StagiaireId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "IndividualWorkUOFs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Confusion = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<int>(type: "int", nullable: false),
                    IndividualWorkId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_IndividualWorkUOFs_IndividualWorks_IndividualWorkId",
                        column: x => x.IndividualWorkId,
                        principalTable: "IndividualWorks",
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
                    { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), 135, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(1728), null, null, null, "Description for International Relations", 3, 6400m, 44, false, null, 29000m, 2700m, 7250m, "Bachelor", "International Relations", null },
                    { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), 110, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(1303), null, null, null, "Description for Psychology", 2, 5400m, 34, false, null, 24000m, 2200m, 6000m, "Master", "Psychology", null },
                    { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), 125, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(1549), null, null, null, "Description for Philosophy", 5, 6000m, 40, false, null, 27000m, 2500m, 6750m, "Bachelor", "Philosophy", null },
                    { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), 115, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(1400), null, null, null, "Description for Sociology", 3, 5600m, 36, false, null, 25000m, 2300m, 6250m, "Bachelor", "Sociology", null },
                    { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), 90, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(970), null, null, null, "Description for Chemistry", 2, 4600m, 26, false, null, 20000m, 1800m, 5000m, "Master", "Chemistry", null },
                    { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), 55, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(348), null, null, null, "Description for Electrical Engineering", 3, 3200m, 12, false, null, 13000m, 1100m, 3250m, "Bachelor", "Electrical Engineering", null },
                    { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), 130, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(1652), null, null, null, "Description for Political Science", 2, 6200m, 42, false, null, 28000m, 2600m, 7000m, "Master", "Political Science", null },
                    { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), 85, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(889), null, null, null, "Description for Physics", 5, 4400m, 24, false, null, 19000m, 1700m, 4750m, "Bachelor", "Physics", null },
                    { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), 95, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(1061), null, null, null, "Description for Biology", 3, 4800m, 28, false, null, 21000m, 1900m, 5250m, "Bachelor", "Biology", null },
                    { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), 70, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(664), null, null, null, "Description for Chemical Engineering", 2, 3800m, 18, false, null, 16000m, 1400m, 4000m, "Master", "Chemical Engineering", null },
                    { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), 75, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(735), null, null, null, "Description for Biotechnology", 3, 4000m, 20, false, null, 17000m, 1500m, 4250m, "Bachelor", "Biotechnology", null },
                    { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), 120, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(1481), null, null, null, "Description for History", 4, 5800m, 38, false, null, 26000m, 2400m, 6500m, "Master", "History", null },
                    { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), 105, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(1223), null, null, null, "Description for Economics", 5, 5200m, 32, false, null, 23000m, 2100m, 5750m, "Bachelor", "Economics", null },
                    { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), 80, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(801), null, null, null, "Description for Mathematics", 4, 4200m, 22, false, null, 18000m, 1600m, 4500m, "Master", "Mathematics", null },
                    { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), 50, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(196), null, null, null, "Description for Computer Science", 2, 3000m, 10, false, null, 12000m, 1000m, 3000m, "Master", "Computer Science", null },
                    { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), 100, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(1160), null, null, null, "Description for Environmental Science", 4, 5000m, 30, false, null, 22000m, 2000m, 5500m, "Master", "Environmental Science", null },
                    { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), 60, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(430), null, null, null, "Description for Mechanical Engineering", 4, 3400m, 14, false, null, 14000m, 1200m, 3500m, "Master", "Mechanical Engineering", null },
                    { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), 65, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(509), null, null, null, "Description for Civil Engineering", 5, 3600m, 16, false, null, 15000m, 1300m, 3750m, "Bachelor", "Civil Engineering", null }
                });

            migrationBuilder.InsertData(
                table: "UnitOfFormations",
                columns: new[] { "Id", "Coefficient", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Duration", "IsDeleted", "ModifiedBy", "Name", "Semestre", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("02e39b46-c4a7-4d42-a9d6-1e3fd226c9cc"), 2, new DateTime(2024, 8, 17, 15, 53, 18, 326, DateTimeKind.Utc).AddTicks(9978), null, null, null, 45, false, null, "Français", "Semester 2", null },
                    { new Guid("12729145-e357-4c4a-95be-fc5fd7cc1ff0"), 2, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(118), null, null, null, 50, false, null, "Astrophysics", "Semester 1", null },
                    { new Guid("1c0bd733-0447-4351-b42a-6a595a73a87d"), 3, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(129), null, null, null, 46, false, null, "Data Science", "Semester 1", null },
                    { new Guid("1d35297d-32ee-42e9-92f1-2b7abb779109"), 2, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(109), null, null, null, 45, false, null, "Ethics", "Semester 2", null },
                    { new Guid("1fb74f8f-ca61-40d0-84d6-c339ff274343"), 2, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(51), null, null, null, 45, false, null, "Music", "Semester 2", null },
                    { new Guid("22105920-ef53-452d-b5f5-ae48495f4abb"), 2, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(71), null, null, null, 45, false, null, "Spanish", "Semester 2", null },
                    { new Guid("2df477a2-3532-4e56-82d9-4f81eb8b2e7f"), 4, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(103), null, null, null, 52, false, null, "Dance", "Semester 1", null },
                    { new Guid("31abd8c8-dafb-4608-9f5b-8dd53941bd6b"), 5, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(47), null, null, null, 53, false, null, "Computer Science", "Semester 2", null },
                    { new Guid("3358e7b2-03de-4973-a035-cf063663043a"), 5, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(57), null, null, null, 48, false, null, "Psychology", "Semester 1", null },
                    { new Guid("39f69cb4-fa6a-4413-8991-072f39ac2587"), 4, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(112), null, null, null, 47, false, null, "Statistics", "Semester 2", null },
                    { new Guid("4433a66f-3c0f-421e-94ab-5bcbbd6bb259"), 3, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(82), null, null, null, 51, false, null, "Latin", "Semester 2", null },
                    { new Guid("45878b1e-7de5-4186-a4e7-d70f862f40ce"), 2, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(100), null, null, null, 50, false, null, "Information Technology", "Semester 1", null },
                    { new Guid("474aebdb-309d-4ab8-8009-d7905b897a6c"), 3, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(102), null, null, null, 51, false, null, "Theater", "Semester 2", null },
                    { new Guid("4996ea2f-2108-4867-a0e2-3e80d4e4243a"), 4, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(85), null, null, null, 52, false, null, "Greek", "Semester 1", null },
                    { new Guid("542786a4-aa6a-4f6e-846e-c4905b2f831d"), 3, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(110), null, null, null, 46, false, null, "Mathematics", "Semester 1", null },
                    { new Guid("54c683d7-24a7-470b-94ba-1cf6566665a3"), 6, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(58), null, null, null, 49, false, null, "Philosophy", "Semester 2", null },
                    { new Guid("5816ef91-c7a5-471e-8691-350dfd91d36e"), 6, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(6), null, null, null, 49, false, null, "Geography", "Semester 2", null },
                    { new Guid("59f005c6-c7d4-485f-8562-83bbcf410f1b"), 5, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(67), null, null, null, 53, false, null, "Engineering", "Semester 2", null },
                    { new Guid("5b63d6a5-1953-4749-90f4-b28a39312b13"), 6, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(125), null, null, null, 54, false, null, "Robotics", "Semester 1", null },
                    { new Guid("5d6432aa-bf15-4075-a6f5-878111716d31"), 6, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(79), null, null, null, 49, false, null, "Japanese", "Semester 2", null },
                    { new Guid("67481c6d-a50a-47a0-8ff1-79e1660ea2eb"), 5, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(115), null, null, null, 48, false, null, "Cryptography", "Semester 1", null },
                    { new Guid("70ca9d34-ce0c-4855-a654-2eed5d25921a"), 4, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(131), null, null, null, 47, false, null, "Artificial Intelligence", "Semester 2", null },
                    { new Guid("74f4b891-170f-47ca-87b4-aca8c97a860d"), 3, new DateTime(2024, 8, 17, 15, 53, 18, 326, DateTimeKind.Utc).AddTicks(9985), null, null, null, 46, false, null, "English", "Semester 1", null },
                    { new Guid("7831768e-3318-4d88-80db-e5958e1e208c"), 2, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(9), null, null, null, 50, false, null, "Biology", "Semester 1", null },
                    { new Guid("7bb97700-c70f-4c29-86dc-285c3c08c98f"), 3, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(119), null, null, null, 51, false, null, "Geology", "Semester 2", null },
                    { new Guid("7d8faff0-e229-4de9-90b8-edef5949f00a"), 4, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(122), null, null, null, 52, false, null, "Oceanography", "Semester 1", null },
                    { new Guid("8006677a-5c4e-43fc-8821-7f96bc1bf5cf"), 5, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(105), null, null, null, 53, false, null, "Media Studies", "Semester 2", null },
                    { new Guid("80f385d8-78a7-452b-86e0-90b51c048df4"), 3, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(63), null, null, null, 51, false, null, "Political Science", "Semester 2", null },
                    { new Guid("86579e8d-e0bd-4452-a317-07185a7e3bbf"), 5, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(4), null, null, null, 48, false, null, "History", "Semester 1", null },
                    { new Guid("869901df-1465-4ee1-a456-dc781223b89b"), 6, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(70), null, null, null, 54, false, null, "Literature", "Semester 1", null },
                    { new Guid("9276ebf7-81bb-49d6-a77f-bed83fb72c2a"), 6, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(97), null, null, null, 49, false, null, "Engineering Design", "Semester 2", null },
                    { new Guid("ab5be28a-c494-4def-b58e-151dc8ff1767"), 4, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(46), null, null, null, 52, false, null, "Physics", "Semester 1", null },
                    { new Guid("ae939676-456a-4190-8223-3ea7d3563922"), 5, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(77), null, null, null, 48, false, null, "Chinese", "Semester 1", null },
                    { new Guid("aff588b9-d077-4f68-899b-2a6b24feea10"), 5, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(86), null, null, null, 53, false, null, "Religion", "Semester 2", null },
                    { new Guid("b2ab7da5-c4fc-404d-990c-d057a75b88d8"), 5, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(123), null, null, null, 53, false, null, "Meteorology", "Semester 2", null },
                    { new Guid("b3b5a92b-d6e9-4e79-aa78-1e1854173bf3"), 2, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(80), null, null, null, 50, false, null, "Arabic", "Semester 1", null },
                    { new Guid("b56c7ac9-bc20-426e-9ab9-92e1c3c26991"), 4, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(56), null, null, null, 47, false, null, "Economics", "Semester 2", null },
                    { new Guid("b8d0b66c-d031-48a7-ae86-aa90bb9109b6"), 3, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(54), null, null, null, 46, false, null, "Physical Education", "Semester 1", null },
                    { new Guid("b92a1ca6-e08c-4d72-b218-87e4601915d8"), 2, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(89), null, null, null, 45, false, null, "Environmental Science", "Semester 2", null },
                    { new Guid("c00be947-6491-4240-acd2-24aa86c806ef"), 6, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(50), null, null, null, 54, false, null, "Art", "Semester 1", null },
                    { new Guid("c040c2e2-7bcf-438d-9a57-4a8c4db32710"), 6, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(116), null, null, null, 49, false, null, "Pharmacology", "Semester 2", null },
                    { new Guid("c92538d1-ee3e-4e6a-94c8-bfe81bc3127d"), 5, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(96), null, null, null, 48, false, null, "Law", "Semester 1", null },
                    { new Guid("cbf22d7b-01a9-4d8e-b0fc-ebda0e18a6f8"), 2, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(126), null, null, null, 45, false, null, "Machine Learning", "Semester 2", null },
                    { new Guid("d4bf9b84-4a3f-45eb-bf9d-00c5b69f48bb"), 4, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(65), null, null, null, 52, false, null, "Statistics", "Semester 1", null },
                    { new Guid("d50fe33b-a67d-467c-9a0f-cd3ddd718e71"), 6, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(108), null, null, null, 54, false, null, "Anthropology", "Semester 1", null },
                    { new Guid("d9d63f44-055b-449e-b532-93b7a30873d6"), 3, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(10), null, null, null, 51, false, null, "Chemistry", "Semester 2", null },
                    { new Guid("ddbe9864-01a6-495c-8f23-5ba0ebd84f68"), 4, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(93), null, null, null, 47, false, null, "Business Studies", "Semester 2", null },
                    { new Guid("e8649f72-24b7-48da-b631-84f8f5abada6"), 4, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(74), null, null, null, 47, false, null, "Italian", "Semester 2", null },
                    { new Guid("f0578c80-dbfb-44df-9f63-d15c06a3ead6"), 4, new DateTime(2024, 8, 17, 15, 53, 18, 326, DateTimeKind.Utc).AddTicks(9987), null, null, null, 47, false, null, "Math", "Semester 2", null },
                    { new Guid("f06e9631-fff9-43db-b218-eca32d5e4270"), 2, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(62), null, null, null, 50, false, null, "Sociology", "Semester 1", null },
                    { new Guid("f4ca0c58-93ac-4e6f-8c3b-e732394d908d"), 6, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(87), null, null, null, 54, false, null, "Astronomy", "Semester 1", null },
                    { new Guid("fc78bd31-fa21-45fb-ab89-ab928f155041"), 3, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(73), null, null, null, 46, false, null, "German", "Semester 1", null },
                    { new Guid("fd8c3808-1799-49c4-be17-eacf53773a16"), 3, new DateTime(2024, 8, 17, 15, 53, 18, 327, DateTimeKind.Utc).AddTicks(92), null, null, null, 46, false, null, "Health Education", "Semester 1", null }
                });

            migrationBuilder.InsertData(
                table: "FiliereUnitOfFormations",
                columns: new[] { "FiliereId", "UnitOfFormationId" },
                values: new object[,]
                {
                    { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("1c0bd733-0447-4351-b42a-6a595a73a87d") },
                    { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("39f69cb4-fa6a-4413-8991-072f39ac2587") },
                    { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("59f005c6-c7d4-485f-8562-83bbcf410f1b") },
                    { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("ab5be28a-c494-4def-b58e-151dc8ff1767") },
                    { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("b56c7ac9-bc20-426e-9ab9-92e1c3c26991") },
                    { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("2df477a2-3532-4e56-82d9-4f81eb8b2e7f") },
                    { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("45878b1e-7de5-4186-a4e7-d70f862f40ce") },
                    { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("70ca9d34-ce0c-4855-a654-2eed5d25921a") },
                    { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("b56c7ac9-bc20-426e-9ab9-92e1c3c26991") },
                    { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("f4ca0c58-93ac-4e6f-8c3b-e732394d908d") },
                    { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("02e39b46-c4a7-4d42-a9d6-1e3fd226c9cc") },
                    { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("2df477a2-3532-4e56-82d9-4f81eb8b2e7f") },
                    { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("4433a66f-3c0f-421e-94ab-5bcbbd6bb259") },
                    { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("8006677a-5c4e-43fc-8821-7f96bc1bf5cf") },
                    { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("ae939676-456a-4190-8223-3ea7d3563922") },
                    { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("1fb74f8f-ca61-40d0-84d6-c339ff274343") },
                    { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("542786a4-aa6a-4f6e-846e-c4905b2f831d") },
                    { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("59f005c6-c7d4-485f-8562-83bbcf410f1b") },
                    { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("cbf22d7b-01a9-4d8e-b0fc-ebda0e18a6f8") },
                    { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("f4ca0c58-93ac-4e6f-8c3b-e732394d908d") },
                    { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("4996ea2f-2108-4867-a0e2-3e80d4e4243a") },
                    { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("5d6432aa-bf15-4075-a6f5-878111716d31") },
                    { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("b2ab7da5-c4fc-404d-990c-d057a75b88d8") },
                    { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("c040c2e2-7bcf-438d-9a57-4a8c4db32710") },
                    { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("fc78bd31-fa21-45fb-ab89-ab928f155041") },
                    { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("22105920-ef53-452d-b5f5-ae48495f4abb") },
                    { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("39f69cb4-fa6a-4413-8991-072f39ac2587") },
                    { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("7bb97700-c70f-4c29-86dc-285c3c08c98f") },
                    { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("c92538d1-ee3e-4e6a-94c8-bfe81bc3127d") },
                    { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("cbf22d7b-01a9-4d8e-b0fc-ebda0e18a6f8") },
                    { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("1d35297d-32ee-42e9-92f1-2b7abb779109") },
                    { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("b2ab7da5-c4fc-404d-990c-d057a75b88d8") },
                    { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("f4ca0c58-93ac-4e6f-8c3b-e732394d908d") },
                    { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("fc78bd31-fa21-45fb-ab89-ab928f155041") },
                    { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("fd8c3808-1799-49c4-be17-eacf53773a16") },
                    { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("2df477a2-3532-4e56-82d9-4f81eb8b2e7f") },
                    { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("3358e7b2-03de-4973-a035-cf063663043a") },
                    { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("7d8faff0-e229-4de9-90b8-edef5949f00a") },
                    { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("b2ab7da5-c4fc-404d-990c-d057a75b88d8") },
                    { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("c00be947-6491-4240-acd2-24aa86c806ef") },
                    { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("3358e7b2-03de-4973-a035-cf063663043a") },
                    { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("59f005c6-c7d4-485f-8562-83bbcf410f1b") },
                    { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("70ca9d34-ce0c-4855-a654-2eed5d25921a") },
                    { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("7831768e-3318-4d88-80db-e5958e1e208c") },
                    { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("b2ab7da5-c4fc-404d-990c-d057a75b88d8") },
                    { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("1c0bd733-0447-4351-b42a-6a595a73a87d") },
                    { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("3358e7b2-03de-4973-a035-cf063663043a") },
                    { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("5b63d6a5-1953-4749-90f4-b28a39312b13") },
                    { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("d4bf9b84-4a3f-45eb-bf9d-00c5b69f48bb") },
                    { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("fc78bd31-fa21-45fb-ab89-ab928f155041") },
                    { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("02e39b46-c4a7-4d42-a9d6-1e3fd226c9cc") },
                    { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("12729145-e357-4c4a-95be-fc5fd7cc1ff0") },
                    { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("22105920-ef53-452d-b5f5-ae48495f4abb") },
                    { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("4996ea2f-2108-4867-a0e2-3e80d4e4243a") },
                    { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("70ca9d34-ce0c-4855-a654-2eed5d25921a") },
                    { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("4433a66f-3c0f-421e-94ab-5bcbbd6bb259") },
                    { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("59f005c6-c7d4-485f-8562-83bbcf410f1b") },
                    { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("aff588b9-d077-4f68-899b-2a6b24feea10") },
                    { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("f0578c80-dbfb-44df-9f63-d15c06a3ead6") },
                    { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("f4ca0c58-93ac-4e6f-8c3b-e732394d908d") },
                    { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("31abd8c8-dafb-4608-9f5b-8dd53941bd6b") },
                    { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("542786a4-aa6a-4f6e-846e-c4905b2f831d") },
                    { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("b56c7ac9-bc20-426e-9ab9-92e1c3c26991") },
                    { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("b8d0b66c-d031-48a7-ae86-aa90bb9109b6") },
                    { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("e8649f72-24b7-48da-b631-84f8f5abada6") },
                    { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("54c683d7-24a7-470b-94ba-1cf6566665a3") },
                    { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("59f005c6-c7d4-485f-8562-83bbcf410f1b") },
                    { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("86579e8d-e0bd-4452-a317-07185a7e3bbf") },
                    { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("c92538d1-ee3e-4e6a-94c8-bfe81bc3127d") },
                    { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("f0578c80-dbfb-44df-9f63-d15c06a3ead6") },
                    { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("22105920-ef53-452d-b5f5-ae48495f4abb") },
                    { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("4433a66f-3c0f-421e-94ab-5bcbbd6bb259") },
                    { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("aff588b9-d077-4f68-899b-2a6b24feea10") },
                    { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("b56c7ac9-bc20-426e-9ab9-92e1c3c26991") },
                    { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("cbf22d7b-01a9-4d8e-b0fc-ebda0e18a6f8") },
                    { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("12729145-e357-4c4a-95be-fc5fd7cc1ff0") },
                    { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("5d6432aa-bf15-4075-a6f5-878111716d31") },
                    { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("74f4b891-170f-47ca-87b4-aca8c97a860d") },
                    { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("8006677a-5c4e-43fc-8821-7f96bc1bf5cf") },
                    { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("e8649f72-24b7-48da-b631-84f8f5abada6") },
                    { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("1d35297d-32ee-42e9-92f1-2b7abb779109") },
                    { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("80f385d8-78a7-452b-86e0-90b51c048df4") },
                    { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("b8d0b66c-d031-48a7-ae86-aa90bb9109b6") },
                    { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("c040c2e2-7bcf-438d-9a57-4a8c4db32710") },
                    { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("ddbe9864-01a6-495c-8f23-5ba0ebd84f68") },
                    { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("70ca9d34-ce0c-4855-a654-2eed5d25921a") },
                    { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("b8d0b66c-d031-48a7-ae86-aa90bb9109b6") },
                    { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("c92538d1-ee3e-4e6a-94c8-bfe81bc3127d") },
                    { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("f0578c80-dbfb-44df-9f63-d15c06a3ead6") },
                    { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("f06e9631-fff9-43db-b218-eca32d5e4270") }
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
                name: "IX_IndividualWorkUOFs_IndividualWorkId",
                table: "IndividualWorkUOFs",
                column: "IndividualWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_TestResults_TestId",
                table: "TestResults",
                column: "TestId");

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
                name: "IndividualWorkUOFs");

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
                name: "IndividualWorks");

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
