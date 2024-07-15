using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class updatesssss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Filieres",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "FiliereName", "IsDeleted", "ModifiedBy", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("bba5cac6-1137-4de1-8730-ada291e022d7"), new DateTime(2024, 7, 15, 10, 7, 33, 604, DateTimeKind.Utc).AddTicks(2108), null, null, null, "Computer Science", false, null, null },
                    { new Guid("c4d20149-5c11-44d5-857f-e1f200ec23d4"), new DateTime(2024, 7, 15, 10, 7, 33, 604, DateTimeKind.Utc).AddTicks(2110), null, null, null, "Mechanical Engineering", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "RoomName", "RoomType", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("632021de-0b43-4659-98ab-799008829b28"), 25, new DateTime(2024, 7, 15, 10, 7, 33, 604, DateTimeKind.Utc).AddTicks(2163), null, null, null, false, null, "Room B", 0, null },
                    { new Guid("7d2e9d3f-9a1a-4cae-9e5c-35599571f55d"), 30, new DateTime(2024, 7, 15, 10, 7, 33, 604, DateTimeKind.Utc).AddTicks(2160), null, null, null, false, null, "Room A", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "SemesterName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5ec0b7d8-fd8a-40c6-9377-0f8aaade684d"), new DateTime(2024, 7, 15, 10, 7, 33, 604, DateTimeKind.Utc).AddTicks(2048), null, null, null, false, null, "Spring", null },
                    { new Guid("f142e3d5-5dd0-489d-8b76-1e3f8b1ffc6d"), new DateTime(2024, 7, 15, 10, 7, 33, 604, DateTimeKind.Utc).AddTicks(2046), null, null, null, false, null, "Fall", null }
                });

            migrationBuilder.InsertData(
                table: "Supervisors",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "FirstName", "IsDeleted", "LastName", "ModifiedBy", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("a1f5b552-7716-42ad-9ed0-7ca33eaa6d5f"), new DateTime(2024, 7, 15, 10, 7, 33, 604, DateTimeKind.Utc).AddTicks(2185), null, null, null, "John", false, "Smith", null, "Professor", null },
                    { new Guid("c5ab09c1-a3b8-4582-a8d6-c9ae9df2168d"), new DateTime(2024, 7, 15, 10, 7, 33, 604, DateTimeKind.Utc).AddTicks(2190), null, null, null, "Emily", false, "Johnson", null, "Associate Professor", null }
                });

            migrationBuilder.InsertData(
                table: "UnitsOfFormation",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "UnitName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0e47f31c-c374-4c38-b42e-a6a5bce00b2d"), new DateTime(2024, 7, 15, 10, 7, 33, 604, DateTimeKind.Utc).AddTicks(2134), null, null, null, false, null, "Thermodynamics", null },
                    { new Guid("7986fd89-577a-483a-a866-2ffa3d1a7967"), new DateTime(2024, 7, 15, 10, 7, 33, 604, DateTimeKind.Utc).AddTicks(2132), null, null, null, false, null, "Programming 101", null }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "UpdatedAt", "YearName" },
                values: new object[,]
                {
                    { new Guid("14ee2101-00e4-44dc-85f2-9f4d97842871"), new DateTime(2024, 7, 15, 10, 7, 33, 604, DateTimeKind.Utc).AddTicks(1816), null, null, null, false, null, null, "2024" },
                    { new Guid("cf1b1db5-671b-4ab8-8704-795a3121f50c"), new DateTime(2024, 7, 15, 10, 7, 33, 604, DateTimeKind.Utc).AddTicks(1822), null, null, null, false, null, null, "2025" }
                });

            migrationBuilder.InsertData(
                table: "YearsOfStudy",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "UpdatedAt", "Year" },
                values: new object[,]
                {
                    { new Guid("7f595bdf-45ec-4324-b15a-1b91991e5bc1"), new DateTime(2024, 7, 15, 10, 7, 33, 604, DateTimeKind.Utc).AddTicks(2080), null, null, null, false, null, null, "First Year" },
                    { new Guid("d1dd8303-39e1-4445-80db-4a7619291c0b"), new DateTime(2024, 7, 15, 10, 7, 33, 604, DateTimeKind.Utc).AddTicks(2085), null, null, null, false, null, null, "Second Year" }
                });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Duration", "ExamDate", "FiliereId", "IsDeleted", "ModifiedBy", "RoomId", "SemesterId", "StartTime", "SupervisorId", "UnitOfFormationId", "UpdatedAt", "YearId", "YearOfStudyId" },
                values: new object[,]
                {
                    { new Guid("376928d2-1449-4738-8e64-fdd351a8bfb3"), new DateTime(2024, 7, 15, 10, 7, 33, 604, DateTimeKind.Utc).AddTicks(2212), null, null, null, new DateTime(2024, 7, 15, 11, 7, 33, 604, DateTimeKind.Local).AddTicks(2266), new DateTime(2024, 7, 15, 11, 7, 33, 604, DateTimeKind.Local).AddTicks(2220), new Guid("bba5cac6-1137-4de1-8730-ada291e022d7"), false, null, new Guid("7d2e9d3f-9a1a-4cae-9e5c-35599571f55d"), new Guid("f142e3d5-5dd0-489d-8b76-1e3f8b1ffc6d"), new DateTime(2024, 7, 15, 11, 7, 33, 604, DateTimeKind.Local).AddTicks(2268), new Guid("a1f5b552-7716-42ad-9ed0-7ca33eaa6d5f"), new Guid("7986fd89-577a-483a-a866-2ffa3d1a7967"), null, new Guid("14ee2101-00e4-44dc-85f2-9f4d97842871"), new Guid("7f595bdf-45ec-4324-b15a-1b91991e5bc1") },
                    { new Guid("dcd8fd1d-9e90-43c9-87eb-e343679099eb"), new DateTime(2024, 7, 15, 10, 7, 33, 604, DateTimeKind.Utc).AddTicks(2271), null, null, null, new DateTime(2024, 7, 15, 11, 7, 33, 604, DateTimeKind.Local).AddTicks(2277), new DateTime(2024, 7, 15, 11, 7, 33, 604, DateTimeKind.Local).AddTicks(2275), new Guid("c4d20149-5c11-44d5-857f-e1f200ec23d4"), false, null, new Guid("632021de-0b43-4659-98ab-799008829b28"), new Guid("5ec0b7d8-fd8a-40c6-9377-0f8aaade684d"), new DateTime(2024, 7, 15, 11, 7, 33, 604, DateTimeKind.Local).AddTicks(2279), new Guid("c5ab09c1-a3b8-4582-a8d6-c9ae9df2168d"), new Guid("0e47f31c-c374-4c38-b42e-a6a5bce00b2d"), null, new Guid("cf1b1db5-671b-4ab8-8704-795a3121f50c"), new Guid("d1dd8303-39e1-4445-80db-4a7619291c0b") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: new Guid("376928d2-1449-4738-8e64-fdd351a8bfb3"));

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: new Guid("dcd8fd1d-9e90-43c9-87eb-e343679099eb"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("bba5cac6-1137-4de1-8730-ada291e022d7"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("c4d20149-5c11-44d5-857f-e1f200ec23d4"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("632021de-0b43-4659-98ab-799008829b28"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("7d2e9d3f-9a1a-4cae-9e5c-35599571f55d"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("5ec0b7d8-fd8a-40c6-9377-0f8aaade684d"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("f142e3d5-5dd0-489d-8b76-1e3f8b1ffc6d"));

            migrationBuilder.DeleteData(
                table: "Supervisors",
                keyColumn: "Id",
                keyValue: new Guid("a1f5b552-7716-42ad-9ed0-7ca33eaa6d5f"));

            migrationBuilder.DeleteData(
                table: "Supervisors",
                keyColumn: "Id",
                keyValue: new Guid("c5ab09c1-a3b8-4582-a8d6-c9ae9df2168d"));

            migrationBuilder.DeleteData(
                table: "UnitsOfFormation",
                keyColumn: "Id",
                keyValue: new Guid("0e47f31c-c374-4c38-b42e-a6a5bce00b2d"));

            migrationBuilder.DeleteData(
                table: "UnitsOfFormation",
                keyColumn: "Id",
                keyValue: new Guid("7986fd89-577a-483a-a866-2ffa3d1a7967"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("14ee2101-00e4-44dc-85f2-9f4d97842871"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("cf1b1db5-671b-4ab8-8704-795a3121f50c"));

            migrationBuilder.DeleteData(
                table: "YearsOfStudy",
                keyColumn: "Id",
                keyValue: new Guid("7f595bdf-45ec-4324-b15a-1b91991e5bc1"));

            migrationBuilder.DeleteData(
                table: "YearsOfStudy",
                keyColumn: "Id",
                keyValue: new Guid("d1dd8303-39e1-4445-80db-4a7619291c0b"));

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
        }
    }
}
