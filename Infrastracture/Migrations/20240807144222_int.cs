using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class @int : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamSession_Exams_ExamId",
                table: "ExamSession");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamSession_Rooms_RoomId",
                table: "ExamSession");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExamSession",
                table: "ExamSession");

            migrationBuilder.RenameTable(
                name: "ExamSession",
                newName: "ExamSessions");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "ExamSessions",
                newName: "StartTime");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "ExamSessions",
                newName: "EndTime");

            migrationBuilder.RenameIndex(
                name: "IX_ExamSession_RoomId",
                table: "ExamSessions",
                newName: "IX_ExamSessions_RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_ExamSession_ExamId",
                table: "ExamSessions",
                newName: "IX_ExamSessions_ExamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExamSessions",
                table: "ExamSessions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamSessions_Exams_ExamId",
                table: "ExamSessions",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamSessions_Rooms_RoomId",
                table: "ExamSessions",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamSessions_Exams_ExamId",
                table: "ExamSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamSessions_Rooms_RoomId",
                table: "ExamSessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExamSessions",
                table: "ExamSessions");

            migrationBuilder.RenameTable(
                name: "ExamSessions",
                newName: "ExamSession");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "ExamSession",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "EndTime",
                table: "ExamSession",
                newName: "EndDate");

            migrationBuilder.RenameIndex(
                name: "IX_ExamSessions_RoomId",
                table: "ExamSession",
                newName: "IX_ExamSession_RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_ExamSessions_ExamId",
                table: "ExamSession",
                newName: "IX_ExamSession_ExamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExamSession",
                table: "ExamSession",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamSession_Exams_ExamId",
                table: "ExamSession",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamSession_Rooms_RoomId",
                table: "ExamSession",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
