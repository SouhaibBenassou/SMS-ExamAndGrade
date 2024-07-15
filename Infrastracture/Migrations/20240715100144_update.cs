using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Filieres_FiliereId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Rooms_RoomId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Semesters_SemesterId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Supervisors_SupervisorId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_UnitsOfFormation_UnitOfFormationId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_YearsOfStudy_YearOfStudyId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Years_YearId",
                table: "Exams");

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: new Guid("46226e86-5e23-41c7-b5a8-ff09ef6a1980"));

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: new Guid("dba8176d-c4fe-4dd9-a26d-c9e75346ff56"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("42c689fa-f8da-4942-a821-53afec2a5e62"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("5997359b-d377-45d6-a067-fa43c6ffbbd5"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("9c16e638-6e72-4f55-a2a8-890fc6740ea1"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("fef8bc31-8ebf-41ae-82cc-eb7b4a4b48ed"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("9bfe4770-4034-449b-8dc1-d1e1491039fc"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("a0bcea9c-5f5e-4e00-9f7a-7f199c414b8e"));

            migrationBuilder.DeleteData(
                table: "Supervisors",
                keyColumn: "Id",
                keyValue: new Guid("5bd2a8ba-1765-4f0d-99e5-e6ed20744725"));

            migrationBuilder.DeleteData(
                table: "Supervisors",
                keyColumn: "Id",
                keyValue: new Guid("8f36b3e8-214a-4cd6-8bf2-28b913311689"));

            migrationBuilder.DeleteData(
                table: "UnitsOfFormation",
                keyColumn: "Id",
                keyValue: new Guid("5a75f600-5426-4fd2-a525-9095f456b42b"));

            migrationBuilder.DeleteData(
                table: "UnitsOfFormation",
                keyColumn: "Id",
                keyValue: new Guid("6aaac244-5f03-4c61-8f7e-ed5a1751e037"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("6dcc2622-7a87-4cdc-aac8-348c4a903903"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("d2bd1630-b801-4527-b184-8e96dcb825f8"));

            migrationBuilder.DeleteData(
                table: "YearsOfStudy",
                keyColumn: "Id",
                keyValue: new Guid("367069ea-dae2-4f02-b04a-62fe48da853c"));

            migrationBuilder.DeleteData(
                table: "YearsOfStudy",
                keyColumn: "Id",
                keyValue: new Guid("3c8e724c-e12e-4118-99f7-667473202618"));

            migrationBuilder.AlterColumn<Guid>(
                name: "YearOfStudyId",
                table: "Exams",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "YearId",
                table: "Exams",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UnitOfFormationId",
                table: "Exams",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "SupervisorId",
                table: "Exams",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Exams",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "SemesterId",
                table: "Exams",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomId",
                table: "Exams",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "FiliereId",
                table: "Exams",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExamDate",
                table: "Exams",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Duration",
                table: "Exams",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Filieres",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "FiliereName", "IsDeleted", "ModifiedBy", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("9f25c450-8192-411a-b0ef-156697fd0613"), new DateTime(2024, 7, 15, 10, 1, 43, 462, DateTimeKind.Utc).AddTicks(4302), null, null, null, "Computer Science", false, null, null },
                    { new Guid("bbb00a0e-fb4e-4c2c-9e37-b76c460a7ce5"), new DateTime(2024, 7, 15, 10, 1, 43, 462, DateTimeKind.Utc).AddTicks(4303), null, null, null, "Mechanical Engineering", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "RoomName", "RoomType", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0f1a754e-2eba-4caf-b859-ea05cdbe3406"), 30, new DateTime(2024, 7, 15, 10, 1, 43, 462, DateTimeKind.Utc).AddTicks(4350), null, null, null, false, null, "Room A", 1, null },
                    { new Guid("f52dda1b-7b43-4733-b341-9cdb98a5d8e8"), 25, new DateTime(2024, 7, 15, 10, 1, 43, 462, DateTimeKind.Utc).AddTicks(4353), null, null, null, false, null, "Room B", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "SemesterName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("13b87a91-480d-4b46-8bec-196ced60d71d"), new DateTime(2024, 7, 15, 10, 1, 43, 462, DateTimeKind.Utc).AddTicks(4153), null, null, null, false, null, "Fall", null },
                    { new Guid("b0a42931-39a4-4f5b-9634-adc335c1e356"), new DateTime(2024, 7, 15, 10, 1, 43, 462, DateTimeKind.Utc).AddTicks(4241), null, null, null, false, null, "Spring", null }
                });

            migrationBuilder.InsertData(
                table: "Supervisors",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "FirstName", "IsDeleted", "LastName", "ModifiedBy", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("9faf32de-2014-436c-a8cb-61215d9a5fdd"), new DateTime(2024, 7, 15, 10, 1, 43, 462, DateTimeKind.Utc).AddTicks(4379), null, null, null, "Emily", false, "Johnson", null, "Associate Professor", null },
                    { new Guid("b3127068-9258-43e8-a314-2634ac5fe893"), new DateTime(2024, 7, 15, 10, 1, 43, 462, DateTimeKind.Utc).AddTicks(4374), null, null, null, "John", false, "Smith", null, "Professor", null }
                });

            migrationBuilder.InsertData(
                table: "UnitsOfFormation",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "UnitName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2811585a-5a41-4f3d-b447-ab9b3355b92f"), new DateTime(2024, 7, 15, 10, 1, 43, 462, DateTimeKind.Utc).AddTicks(4325), null, null, null, false, null, "Programming 101", null },
                    { new Guid("d9f02132-e313-46fe-9015-a8d14815d602"), new DateTime(2024, 7, 15, 10, 1, 43, 462, DateTimeKind.Utc).AddTicks(4327), null, null, null, false, null, "Thermodynamics", null }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "UpdatedAt", "YearName" },
                values: new object[,]
                {
                    { new Guid("7db11100-1e8d-4f3c-8e8b-c7f9bdbdfd98"), new DateTime(2024, 7, 15, 10, 1, 43, 462, DateTimeKind.Utc).AddTicks(3966), null, null, null, false, null, null, "2024" },
                    { new Guid("9da79938-a79c-4735-b6a3-a2d49b31c1ff"), new DateTime(2024, 7, 15, 10, 1, 43, 462, DateTimeKind.Utc).AddTicks(3970), null, null, null, false, null, null, "2025" }
                });

            migrationBuilder.InsertData(
                table: "YearsOfStudy",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "UpdatedAt", "Year" },
                values: new object[,]
                {
                    { new Guid("3a88be03-d1e4-4e5c-9e33-273f01eed508"), new DateTime(2024, 7, 15, 10, 1, 43, 462, DateTimeKind.Utc).AddTicks(4275), null, null, null, false, null, null, "First Year" },
                    { new Guid("aac2dcbf-776c-438c-ac97-bda862a308a6"), new DateTime(2024, 7, 15, 10, 1, 43, 462, DateTimeKind.Utc).AddTicks(4280), null, null, null, false, null, null, "Second Year" }
                });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Duration", "ExamDate", "FiliereId", "IsDeleted", "ModifiedBy", "RoomId", "SemesterId", "StartTime", "SupervisorId", "UnitOfFormationId", "UpdatedAt", "YearId", "YearOfStudyId" },
                values: new object[,]
                {
                    { new Guid("10ad8669-9f9b-4e13-b243-1071f139a320"), new DateTime(2024, 7, 15, 10, 1, 43, 462, DateTimeKind.Utc).AddTicks(4400), null, null, null, new DateTime(2024, 7, 15, 11, 1, 43, 462, DateTimeKind.Local).AddTicks(4456), new DateTime(2024, 7, 15, 11, 1, 43, 462, DateTimeKind.Local).AddTicks(4409), new Guid("9f25c450-8192-411a-b0ef-156697fd0613"), false, null, new Guid("0f1a754e-2eba-4caf-b859-ea05cdbe3406"), new Guid("13b87a91-480d-4b46-8bec-196ced60d71d"), new DateTime(2024, 7, 15, 11, 1, 43, 462, DateTimeKind.Local).AddTicks(4458), new Guid("b3127068-9258-43e8-a314-2634ac5fe893"), new Guid("2811585a-5a41-4f3d-b447-ab9b3355b92f"), null, new Guid("7db11100-1e8d-4f3c-8e8b-c7f9bdbdfd98"), new Guid("3a88be03-d1e4-4e5c-9e33-273f01eed508") },
                    { new Guid("4cf2db50-18f9-45eb-9a2a-c00b3b65dcc6"), new DateTime(2024, 7, 15, 10, 1, 43, 462, DateTimeKind.Utc).AddTicks(4461), null, null, null, new DateTime(2024, 7, 15, 11, 1, 43, 462, DateTimeKind.Local).AddTicks(4467), new DateTime(2024, 7, 15, 11, 1, 43, 462, DateTimeKind.Local).AddTicks(4465), new Guid("bbb00a0e-fb4e-4c2c-9e37-b76c460a7ce5"), false, null, new Guid("f52dda1b-7b43-4733-b341-9cdb98a5d8e8"), new Guid("b0a42931-39a4-4f5b-9634-adc335c1e356"), new DateTime(2024, 7, 15, 11, 1, 43, 462, DateTimeKind.Local).AddTicks(4468), new Guid("9faf32de-2014-436c-a8cb-61215d9a5fdd"), new Guid("d9f02132-e313-46fe-9015-a8d14815d602"), null, new Guid("9da79938-a79c-4735-b6a3-a2d49b31c1ff"), new Guid("aac2dcbf-776c-438c-ac97-bda862a308a6") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Filieres_FiliereId",
                table: "Exams",
                column: "FiliereId",
                principalTable: "Filieres",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Rooms_RoomId",
                table: "Exams",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Semesters_SemesterId",
                table: "Exams",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Supervisors_SupervisorId",
                table: "Exams",
                column: "SupervisorId",
                principalTable: "Supervisors",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_UnitsOfFormation_UnitOfFormationId",
                table: "Exams",
                column: "UnitOfFormationId",
                principalTable: "UnitsOfFormation",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_YearsOfStudy_YearOfStudyId",
                table: "Exams",
                column: "YearOfStudyId",
                principalTable: "YearsOfStudy",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Years_YearId",
                table: "Exams",
                column: "YearId",
                principalTable: "Years",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Filieres_FiliereId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Rooms_RoomId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Semesters_SemesterId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Supervisors_SupervisorId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_UnitsOfFormation_UnitOfFormationId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_YearsOfStudy_YearOfStudyId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Years_YearId",
                table: "Exams");

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: new Guid("10ad8669-9f9b-4e13-b243-1071f139a320"));

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: new Guid("4cf2db50-18f9-45eb-9a2a-c00b3b65dcc6"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("9f25c450-8192-411a-b0ef-156697fd0613"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("bbb00a0e-fb4e-4c2c-9e37-b76c460a7ce5"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("0f1a754e-2eba-4caf-b859-ea05cdbe3406"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f52dda1b-7b43-4733-b341-9cdb98a5d8e8"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("13b87a91-480d-4b46-8bec-196ced60d71d"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("b0a42931-39a4-4f5b-9634-adc335c1e356"));

            migrationBuilder.DeleteData(
                table: "Supervisors",
                keyColumn: "Id",
                keyValue: new Guid("9faf32de-2014-436c-a8cb-61215d9a5fdd"));

            migrationBuilder.DeleteData(
                table: "Supervisors",
                keyColumn: "Id",
                keyValue: new Guid("b3127068-9258-43e8-a314-2634ac5fe893"));

            migrationBuilder.DeleteData(
                table: "UnitsOfFormation",
                keyColumn: "Id",
                keyValue: new Guid("2811585a-5a41-4f3d-b447-ab9b3355b92f"));

            migrationBuilder.DeleteData(
                table: "UnitsOfFormation",
                keyColumn: "Id",
                keyValue: new Guid("d9f02132-e313-46fe-9015-a8d14815d602"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("7db11100-1e8d-4f3c-8e8b-c7f9bdbdfd98"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("9da79938-a79c-4735-b6a3-a2d49b31c1ff"));

            migrationBuilder.DeleteData(
                table: "YearsOfStudy",
                keyColumn: "Id",
                keyValue: new Guid("3a88be03-d1e4-4e5c-9e33-273f01eed508"));

            migrationBuilder.DeleteData(
                table: "YearsOfStudy",
                keyColumn: "Id",
                keyValue: new Guid("aac2dcbf-776c-438c-ac97-bda862a308a6"));

            migrationBuilder.AlterColumn<Guid>(
                name: "YearOfStudyId",
                table: "Exams",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "YearId",
                table: "Exams",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UnitOfFormationId",
                table: "Exams",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "SupervisorId",
                table: "Exams",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Exams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "SemesterId",
                table: "Exams",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomId",
                table: "Exams",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "FiliereId",
                table: "Exams",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExamDate",
                table: "Exams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Duration",
                table: "Exams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Filieres",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "FiliereName", "IsDeleted", "ModifiedBy", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("42c689fa-f8da-4942-a821-53afec2a5e62"), new DateTime(2024, 7, 15, 9, 53, 57, 738, DateTimeKind.Utc).AddTicks(4864), null, null, null, "Mechanical Engineering", false, null, null },
                    { new Guid("5997359b-d377-45d6-a067-fa43c6ffbbd5"), new DateTime(2024, 7, 15, 9, 53, 57, 738, DateTimeKind.Utc).AddTicks(4857), null, null, null, "Computer Science", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "RoomName", "RoomType", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("9c16e638-6e72-4f55-a2a8-890fc6740ea1"), 30, new DateTime(2024, 7, 15, 9, 53, 57, 738, DateTimeKind.Utc).AddTicks(5263), null, null, null, false, null, "Room A", 1, null },
                    { new Guid("fef8bc31-8ebf-41ae-82cc-eb7b4a4b48ed"), 25, new DateTime(2024, 7, 15, 9, 53, 57, 738, DateTimeKind.Utc).AddTicks(5273), null, null, null, false, null, "Room B", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "SemesterName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("9bfe4770-4034-449b-8dc1-d1e1491039fc"), new DateTime(2024, 7, 15, 9, 53, 57, 738, DateTimeKind.Utc).AddTicks(4744), null, null, null, false, null, "Spring", null },
                    { new Guid("a0bcea9c-5f5e-4e00-9f7a-7f199c414b8e"), new DateTime(2024, 7, 15, 9, 53, 57, 738, DateTimeKind.Utc).AddTicks(4740), null, null, null, false, null, "Fall", null }
                });

            migrationBuilder.InsertData(
                table: "Supervisors",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "FirstName", "IsDeleted", "LastName", "ModifiedBy", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5bd2a8ba-1765-4f0d-99e5-e6ed20744725"), new DateTime(2024, 7, 15, 9, 53, 57, 738, DateTimeKind.Utc).AddTicks(5306), null, null, null, "Emily", false, "Johnson", null, "Associate Professor", null },
                    { new Guid("8f36b3e8-214a-4cd6-8bf2-28b913311689"), new DateTime(2024, 7, 15, 9, 53, 57, 738, DateTimeKind.Utc).AddTicks(5303), null, null, null, "John", false, "Smith", null, "Professor", null }
                });

            migrationBuilder.InsertData(
                table: "UnitsOfFormation",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "UnitName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5a75f600-5426-4fd2-a525-9095f456b42b"), new DateTime(2024, 7, 15, 9, 53, 57, 738, DateTimeKind.Utc).AddTicks(5039), null, null, null, false, null, "Thermodynamics", null },
                    { new Guid("6aaac244-5f03-4c61-8f7e-ed5a1751e037"), new DateTime(2024, 7, 15, 9, 53, 57, 738, DateTimeKind.Utc).AddTicks(5035), null, null, null, false, null, "Programming 101", null }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "UpdatedAt", "YearName" },
                values: new object[,]
                {
                    { new Guid("6dcc2622-7a87-4cdc-aac8-348c4a903903"), new DateTime(2024, 7, 15, 9, 53, 57, 738, DateTimeKind.Utc).AddTicks(4030), null, null, null, false, null, null, "2024" },
                    { new Guid("d2bd1630-b801-4527-b184-8e96dcb825f8"), new DateTime(2024, 7, 15, 9, 53, 57, 738, DateTimeKind.Utc).AddTicks(4039), null, null, null, false, null, null, "2025" }
                });

            migrationBuilder.InsertData(
                table: "YearsOfStudy",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "UpdatedAt", "Year" },
                values: new object[,]
                {
                    { new Guid("367069ea-dae2-4f02-b04a-62fe48da853c"), new DateTime(2024, 7, 15, 9, 53, 57, 738, DateTimeKind.Utc).AddTicks(4799), null, null, null, false, null, null, "Second Year" },
                    { new Guid("3c8e724c-e12e-4118-99f7-667473202618"), new DateTime(2024, 7, 15, 9, 53, 57, 738, DateTimeKind.Utc).AddTicks(4797), null, null, null, false, null, null, "First Year" }
                });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Duration", "ExamDate", "FiliereId", "IsDeleted", "ModifiedBy", "RoomId", "SemesterId", "StartTime", "SupervisorId", "UnitOfFormationId", "UpdatedAt", "YearId", "YearOfStudyId" },
                values: new object[,]
                {
                    { new Guid("46226e86-5e23-41c7-b5a8-ff09ef6a1980"), new DateTime(2024, 7, 15, 9, 53, 57, 738, DateTimeKind.Utc).AddTicks(5534), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("42c689fa-f8da-4942-a821-53afec2a5e62"), false, null, new Guid("fef8bc31-8ebf-41ae-82cc-eb7b4a4b48ed"), new Guid("9bfe4770-4034-449b-8dc1-d1e1491039fc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5bd2a8ba-1765-4f0d-99e5-e6ed20744725"), new Guid("5a75f600-5426-4fd2-a525-9095f456b42b"), null, new Guid("d2bd1630-b801-4527-b184-8e96dcb825f8"), new Guid("367069ea-dae2-4f02-b04a-62fe48da853c") },
                    { new Guid("dba8176d-c4fe-4dd9-a26d-c9e75346ff56"), new DateTime(2024, 7, 15, 9, 53, 57, 738, DateTimeKind.Utc).AddTicks(5526), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5997359b-d377-45d6-a067-fa43c6ffbbd5"), false, null, new Guid("9c16e638-6e72-4f55-a2a8-890fc6740ea1"), new Guid("a0bcea9c-5f5e-4e00-9f7a-7f199c414b8e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8f36b3e8-214a-4cd6-8bf2-28b913311689"), new Guid("6aaac244-5f03-4c61-8f7e-ed5a1751e037"), null, new Guid("6dcc2622-7a87-4cdc-aac8-348c4a903903"), new Guid("3c8e724c-e12e-4118-99f7-667473202618") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Filieres_FiliereId",
                table: "Exams",
                column: "FiliereId",
                principalTable: "Filieres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Rooms_RoomId",
                table: "Exams",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Semesters_SemesterId",
                table: "Exams",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Supervisors_SupervisorId",
                table: "Exams",
                column: "SupervisorId",
                principalTable: "Supervisors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_UnitsOfFormation_UnitOfFormationId",
                table: "Exams",
                column: "UnitOfFormationId",
                principalTable: "UnitsOfFormation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_YearsOfStudy_YearOfStudyId",
                table: "Exams",
                column: "YearOfStudyId",
                principalTable: "YearsOfStudy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Years_YearId",
                table: "Exams",
                column: "YearId",
                principalTable: "Years",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
