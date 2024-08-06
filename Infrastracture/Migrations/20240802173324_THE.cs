using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class THE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamAttendances_Stagiaires_StagiaireId",
                table: "ExamAttendances");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamResults_Stagiaires_StagiaireId",
                table: "ExamResults");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Filieres_FiliereId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_UnitsOfFormation_UnitOfFormationId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Years_YearId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_IndividualWorks_Stagiaires_StagiaireId",
                table: "IndividualWorks");

            migrationBuilder.DropForeignKey(
                name: "FK_TestResults_Stagiaires_StagiaireId",
                table: "TestResults");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Trainer_TrainerId",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_UnitsOfFormation_UnitOfFormationId",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_VariantsExams_Trainer_TrainerId",
                table: "VariantsExams");

            migrationBuilder.DropForeignKey(
                name: "FK_VariantsExams_UnitsOfFormation_UnitOfFormationId",
                table: "VariantsExams");

            migrationBuilder.DropTable(
                name: "Stagiaires");

            migrationBuilder.DropTable(
                name: "Trainer");

            migrationBuilder.DropTable(
                name: "UnitOfFormationFilieres");

            migrationBuilder.DropTable(
                name: "Years");

            migrationBuilder.DropTable(
                name: "UnitsOfFormation");

            migrationBuilder.DropTable(
                name: "Filieres");

            migrationBuilder.DropIndex(
                name: "IX_VariantsExams_TrainerId",
                table: "VariantsExams");

            migrationBuilder.DropIndex(
                name: "IX_VariantsExams_UnitOfFormationId",
                table: "VariantsExams");

            migrationBuilder.DropIndex(
                name: "IX_Tests_TrainerId",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_Tests_UnitOfFormationId",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_TestResults_StagiaireId",
                table: "TestResults");

            migrationBuilder.DropIndex(
                name: "IX_IndividualWorks_StagiaireId",
                table: "IndividualWorks");

            migrationBuilder.DropIndex(
                name: "IX_Exams_FiliereId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_UnitOfFormationId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_YearId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_ExamResults_StagiaireId",
                table: "ExamResults");

            migrationBuilder.DropIndex(
                name: "IX_ExamAttendances_StagiaireId",
                table: "ExamAttendances");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filieres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FiliereName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filieres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stagiaires",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stagiaires", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trainer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Years",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    YearName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Years", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitsOfFormation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FiliereId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Confusion = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SemesterType = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitsOfFormation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnitsOfFormation_Filieres_FiliereId",
                        column: x => x.FiliereId,
                        principalTable: "Filieres",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UnitOfFormationFilieres",
                columns: table => new
                {
                    FiliereId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitFormationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitOfFormationFilieres", x => new { x.FiliereId, x.UnitFormationId });
                    table.ForeignKey(
                        name: "FK_UnitOfFormationFilieres_Filieres_FiliereId",
                        column: x => x.FiliereId,
                        principalTable: "Filieres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnitOfFormationFilieres_UnitsOfFormation_UnitFormationId",
                        column: x => x.UnitFormationId,
                        principalTable: "UnitsOfFormation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VariantsExams_TrainerId",
                table: "VariantsExams",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_VariantsExams_UnitOfFormationId",
                table: "VariantsExams",
                column: "UnitOfFormationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_TrainerId",
                table: "Tests",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_UnitOfFormationId",
                table: "Tests",
                column: "UnitOfFormationId");

            migrationBuilder.CreateIndex(
                name: "IX_TestResults_StagiaireId",
                table: "TestResults",
                column: "StagiaireId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualWorks_StagiaireId",
                table: "IndividualWorks",
                column: "StagiaireId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_FiliereId",
                table: "Exams",
                column: "FiliereId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_UnitOfFormationId",
                table: "Exams",
                column: "UnitOfFormationId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_YearId",
                table: "Exams",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamResults_StagiaireId",
                table: "ExamResults",
                column: "StagiaireId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamAttendances_StagiaireId",
                table: "ExamAttendances",
                column: "StagiaireId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitOfFormationFilieres_UnitFormationId",
                table: "UnitOfFormationFilieres",
                column: "UnitFormationId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitsOfFormation_FiliereId",
                table: "UnitsOfFormation",
                column: "FiliereId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamAttendances_Stagiaires_StagiaireId",
                table: "ExamAttendances",
                column: "StagiaireId",
                principalTable: "Stagiaires",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamResults_Stagiaires_StagiaireId",
                table: "ExamResults",
                column: "StagiaireId",
                principalTable: "Stagiaires",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Filieres_FiliereId",
                table: "Exams",
                column: "FiliereId",
                principalTable: "Filieres",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_UnitsOfFormation_UnitOfFormationId",
                table: "Exams",
                column: "UnitOfFormationId",
                principalTable: "UnitsOfFormation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Years_YearId",
                table: "Exams",
                column: "YearId",
                principalTable: "Years",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IndividualWorks_Stagiaires_StagiaireId",
                table: "IndividualWorks",
                column: "StagiaireId",
                principalTable: "Stagiaires",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TestResults_Stagiaires_StagiaireId",
                table: "TestResults",
                column: "StagiaireId",
                principalTable: "Stagiaires",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Trainer_TrainerId",
                table: "Tests",
                column: "TrainerId",
                principalTable: "Trainer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_UnitsOfFormation_UnitOfFormationId",
                table: "Tests",
                column: "UnitOfFormationId",
                principalTable: "UnitsOfFormation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VariantsExams_Trainer_TrainerId",
                table: "VariantsExams",
                column: "TrainerId",
                principalTable: "Trainer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VariantsExams_UnitsOfFormation_UnitOfFormationId",
                table: "VariantsExams",
                column: "UnitOfFormationId",
                principalTable: "UnitsOfFormation",
                principalColumn: "Id");
        }
    }
}
