using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class innvi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SemesterId",
                table: "Exams");

            migrationBuilder.RenameColumn(
                name: "Note",
                table: "ExamResults",
                newName: "TheoreticalNote");

            migrationBuilder.AddColumn<Guid>(
                name: "UnitOfFormationId",
                table: "VariantsExams",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Confusion",
                table: "UnitsOfFormation",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StartTime",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(TimeOnly),
                oldType: "time",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExamDate",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(TimeOnly),
                oldType: "time",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PracticalNote",
                table: "ExamResults",
                type: "float",
                nullable: true);

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
                    table.ForeignKey(
                        name: "FK_IndividualWorks_Stagiaires_StagiaireId",
                        column: x => x.StagiaireId,
                        principalTable: "Stagiaires",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateIndex(
                name: "IX_VariantsExams_UnitOfFormationId",
                table: "VariantsExams",
                column: "UnitOfFormationId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualWorks_StagiaireId",
                table: "IndividualWorks",
                column: "StagiaireId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualWorkUOFs_IndividualWorkId",
                table: "IndividualWorkUOFs",
                column: "IndividualWorkId");

            migrationBuilder.AddForeignKey(
                name: "FK_VariantsExams_UnitsOfFormation_UnitOfFormationId",
                table: "VariantsExams",
                column: "UnitOfFormationId",
                principalTable: "UnitsOfFormation",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VariantsExams_UnitsOfFormation_UnitOfFormationId",
                table: "VariantsExams");

            migrationBuilder.DropTable(
                name: "IndividualWorkUOFs");

            migrationBuilder.DropTable(
                name: "IndividualWorks");

            migrationBuilder.DropIndex(
                name: "IX_VariantsExams_UnitOfFormationId",
                table: "VariantsExams");

            migrationBuilder.DropColumn(
                name: "UnitOfFormationId",
                table: "VariantsExams");

            migrationBuilder.DropColumn(
                name: "Confusion",
                table: "UnitsOfFormation");

            migrationBuilder.DropColumn(
                name: "PracticalNote",
                table: "ExamResults");

            migrationBuilder.RenameColumn(
                name: "TheoreticalNote",
                table: "ExamResults",
                newName: "Note");

            migrationBuilder.AlterColumn<TimeOnly>(
                name: "StartTime",
                table: "Exams",
                type: "time",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "ExamDate",
                table: "Exams",
                type: "date",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeOnly>(
                name: "Duration",
                table: "Exams",
                type: "time",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SemesterId",
                table: "Exams",
                type: "uniqueidentifier",
                nullable: true);
        }
    }
}
