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
                    FiliereName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    RoomName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Semesters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SemesterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Semesters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supervisors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "UnitsOfFormation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_UnitsOfFormation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Years",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    YearName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Years", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YearsOfStudy",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_YearsOfStudy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExamDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    YearId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SemesterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    YearOfStudyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FiliereId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitOfFormationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_Exams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exams_Filieres_FiliereId",
                        column: x => x.FiliereId,
                        principalTable: "Filieres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exams_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exams_Semesters_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "Semesters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exams_Supervisors_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Supervisors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exams_UnitsOfFormation_UnitOfFormationId",
                        column: x => x.UnitOfFormationId,
                        principalTable: "UnitsOfFormation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exams_YearsOfStudy_YearOfStudyId",
                        column: x => x.YearOfStudyId,
                        principalTable: "YearsOfStudy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exams_Years_YearId",
                        column: x => x.YearId,
                        principalTable: "Years",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Filieres",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "FiliereName", "IsDeleted", "ModifiedBy", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5080fad5-cb86-4eb4-a1cd-e827678f5336"), new DateTime(2024, 7, 15, 0, 25, 57, 263, DateTimeKind.Utc).AddTicks(7022), null, null, null, "Mechanical Engineering", false, null, null },
                    { new Guid("eba0435d-8a9c-4d1b-a68c-ea9c27f8be20"), new DateTime(2024, 7, 15, 0, 25, 57, 263, DateTimeKind.Utc).AddTicks(7018), null, null, null, "Computer Science", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "RoomName", "RoomType", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("10f8ef92-3dda-4f0d-a45c-7bea700b7853"), 25, new DateTime(2024, 7, 15, 0, 25, 57, 263, DateTimeKind.Utc).AddTicks(7069), null, null, null, false, null, "Room B", 0, null },
                    { new Guid("80298b58-3bab-4004-ba8a-21b198af33c1"), 30, new DateTime(2024, 7, 15, 0, 25, 57, 263, DateTimeKind.Utc).AddTicks(7065), null, null, null, false, null, "Room A", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "SemesterName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("181270d6-a5b3-4dc5-918e-7f78e3be3bb2"), new DateTime(2024, 7, 15, 0, 25, 57, 263, DateTimeKind.Utc).AddTicks(6973), null, null, null, false, null, "Spring", null },
                    { new Guid("b9e9a8af-9aa1-428e-8912-0c0339057389"), new DateTime(2024, 7, 15, 0, 25, 57, 263, DateTimeKind.Utc).AddTicks(6970), null, null, null, false, null, "Fall", null }
                });

            migrationBuilder.InsertData(
                table: "Supervisors",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "FirstName", "IsDeleted", "LastName", "ModifiedBy", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("b6846ac2-3ccd-4846-8e85-b5c9d8f90cde"), new DateTime(2024, 7, 15, 0, 25, 57, 263, DateTimeKind.Utc).AddTicks(7085), null, null, null, "John", false, "Smith", null, "Professor", null },
                    { new Guid("d4b65fe7-e749-4f14-972a-b38236b24163"), new DateTime(2024, 7, 15, 0, 25, 57, 263, DateTimeKind.Utc).AddTicks(7087), null, null, null, "Emily", false, "Johnson", null, "Associate Professor", null }
                });

            migrationBuilder.InsertData(
                table: "UnitsOfFormation",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "UnitName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("50da306a-61da-484e-9680-b69dbcf4b166"), new DateTime(2024, 7, 15, 0, 25, 57, 263, DateTimeKind.Utc).AddTicks(7045), null, null, null, false, null, "Thermodynamics", null },
                    { new Guid("c77500d8-b67e-4b9d-bd73-c2ba969e8a7b"), new DateTime(2024, 7, 15, 0, 25, 57, 263, DateTimeKind.Utc).AddTicks(7044), null, null, null, false, null, "Programming 101", null }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "UpdatedAt", "YearName" },
                values: new object[,]
                {
                    { new Guid("3cea7bfc-9e10-42f3-887e-961e0d25963c"), new DateTime(2024, 7, 15, 0, 25, 57, 263, DateTimeKind.Utc).AddTicks(6764), null, null, null, false, null, null, "2025" },
                    { new Guid("b19bcf7c-d23b-4b9b-9989-7bcbe222cdf5"), new DateTime(2024, 7, 15, 0, 25, 57, 263, DateTimeKind.Utc).AddTicks(6760), null, null, null, false, null, null, "2024" }
                });

            migrationBuilder.InsertData(
                table: "YearsOfStudy",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "UpdatedAt", "Year" },
                values: new object[,]
                {
                    { new Guid("6a5b849b-9e52-4362-bbea-2242c425c922"), new DateTime(2024, 7, 15, 0, 25, 57, 263, DateTimeKind.Utc).AddTicks(6998), null, null, null, false, null, null, "First Year" },
                    { new Guid("b3e65ba1-444c-4e25-a1a4-10b32b7c8919"), new DateTime(2024, 7, 15, 0, 25, 57, 263, DateTimeKind.Utc).AddTicks(6999), null, null, null, false, null, null, "Second Year" }
                });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Duration", "ExamDate", "FiliereId", "IsDeleted", "ModifiedBy", "RoomId", "SemesterId", "StartTime", "SupervisorId", "UnitOfFormationId", "UpdatedAt", "YearId", "YearOfStudyId" },
                values: new object[,]
                {
                    { new Guid("93878d0b-0b86-4fc8-8533-3e784838723f"), new DateTime(2024, 7, 15, 0, 25, 57, 263, DateTimeKind.Utc).AddTicks(7106), null, null, null, new TimeSpan(0, 0, 0, 0, 0), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eba0435d-8a9c-4d1b-a68c-ea9c27f8be20"), false, null, new Guid("80298b58-3bab-4004-ba8a-21b198af33c1"), new Guid("b9e9a8af-9aa1-428e-8912-0c0339057389"), new TimeSpan(0, 0, 0, 0, 0), new Guid("b6846ac2-3ccd-4846-8e85-b5c9d8f90cde"), new Guid("c77500d8-b67e-4b9d-bd73-c2ba969e8a7b"), null, new Guid("b19bcf7c-d23b-4b9b-9989-7bcbe222cdf5"), new Guid("6a5b849b-9e52-4362-bbea-2242c425c922") },
                    { new Guid("e76094af-dd94-45df-adb2-dff295cee8da"), new DateTime(2024, 7, 15, 0, 25, 57, 263, DateTimeKind.Utc).AddTicks(7162), null, null, null, new TimeSpan(0, 0, 0, 0, 0), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5080fad5-cb86-4eb4-a1cd-e827678f5336"), false, null, new Guid("10f8ef92-3dda-4f0d-a45c-7bea700b7853"), new Guid("181270d6-a5b3-4dc5-918e-7f78e3be3bb2"), new TimeSpan(0, 0, 0, 0, 0), new Guid("d4b65fe7-e749-4f14-972a-b38236b24163"), new Guid("50da306a-61da-484e-9680-b69dbcf4b166"), null, new Guid("3cea7bfc-9e10-42f3-887e-961e0d25963c"), new Guid("b3e65ba1-444c-4e25-a1a4-10b32b7c8919") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exams_FiliereId",
                table: "Exams",
                column: "FiliereId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_RoomId",
                table: "Exams",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_SemesterId",
                table: "Exams",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_SupervisorId",
                table: "Exams",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_UnitOfFormationId",
                table: "Exams",
                column: "UnitOfFormationId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_YearId",
                table: "Exams",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_YearOfStudyId",
                table: "Exams",
                column: "YearOfStudyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Filieres");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Semesters");

            migrationBuilder.DropTable(
                name: "Supervisors");

            migrationBuilder.DropTable(
                name: "UnitsOfFormation");

            migrationBuilder.DropTable(
                name: "YearsOfStudy");

            migrationBuilder.DropTable(
                name: "Years");
        }
    }
}
