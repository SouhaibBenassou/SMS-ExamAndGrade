using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class hhhjjjj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndividualWorkUOFs_IndividualWorks_IndividualWorkId",
                table: "IndividualWorkUOFs");

            migrationBuilder.DropIndex(
                name: "IX_IndividualWorkUOFs_IndividualWorkId",
                table: "IndividualWorkUOFs");

            migrationBuilder.DropColumn(
                name: "IndividualWorkId",
                table: "IndividualWorkUOFs");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "IndividualWorkUOFs");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "IndividualWorkUOFs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Confusion",
                table: "IndividualWorkUOFs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<Guid>(
                name: "IndividualWorkUOFId",
                table: "IndividualWorks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Note",
                table: "IndividualWorks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_IndividualWorks_IndividualWorkUOFId",
                table: "IndividualWorks",
                column: "IndividualWorkUOFId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndividualWorks_IndividualWorkUOFs_IndividualWorkUOFId",
                table: "IndividualWorks",
                column: "IndividualWorkUOFId",
                principalTable: "IndividualWorkUOFs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndividualWorks_IndividualWorkUOFs_IndividualWorkUOFId",
                table: "IndividualWorks");

            migrationBuilder.DropIndex(
                name: "IX_IndividualWorks_IndividualWorkUOFId",
                table: "IndividualWorks");

            migrationBuilder.DropColumn(
                name: "IndividualWorkUOFId",
                table: "IndividualWorks");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "IndividualWorks");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "IndividualWorkUOFs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Confusion",
                table: "IndividualWorkUOFs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IndividualWorkId",
                table: "IndividualWorkUOFs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Note",
                table: "IndividualWorkUOFs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_IndividualWorkUOFs_IndividualWorkId",
                table: "IndividualWorkUOFs",
                column: "IndividualWorkId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndividualWorkUOFs_IndividualWorks_IndividualWorkId",
                table: "IndividualWorkUOFs",
                column: "IndividualWorkId",
                principalTable: "IndividualWorks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
