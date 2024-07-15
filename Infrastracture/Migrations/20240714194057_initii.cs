using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class initii : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Filieres",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "FiliereName", "IsDeleted", "ModifiedBy", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("723b06b8-cca1-4d8b-96ef-f5ce5ccb96a4"), new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8821), null, null, null, "Computer Science", false, null, null },
                    { new Guid("cac8ec54-4883-4880-bfc6-c99ebc30a44d"), new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8823), null, null, null, "Mechanical Engineering", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "RoomName", "RoomType", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("686c756d-9891-4047-9c18-7e198d67f2b1"), 30, new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8866), null, null, null, false, null, "Room A", 1, null },
                    { new Guid("7e59257a-0ffb-451a-98a4-cc706c8abee3"), 25, new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8868), null, null, null, false, null, "Room B", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "SemesterName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("296ad516-265c-4853-a4e7-44c4ce099677"), new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8778), null, null, null, false, null, "Spring", null },
                    { new Guid("b8ba9a2c-1d55-4245-a3fe-0a07fbe589b9"), new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8775), null, null, null, false, null, "Fall", null }
                });

            migrationBuilder.InsertData(
                table: "Supervisors",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "FirstName", "IsDeleted", "LastName", "ModifiedBy", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1a1b8644-9b79-4062-a378-1afcbf72caf4"), new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8885), null, null, null, "John", false, "Smith", null, "Professor", null },
                    { new Guid("6328e90e-3d32-45f3-b391-1beaa367cef7"), new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8888), null, null, null, "Emily", false, "Johnson", null, "Associate Professor", null }
                });

            migrationBuilder.InsertData(
                table: "UnitsOfFormation",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "UnitName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("6bf06c26-18a5-4168-bf47-ae0c2a11de88"), new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8845), null, null, null, false, null, "Programming 101", null },
                    { new Guid("9c6d916b-06c4-464d-b5c7-fe6339382f9d"), new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8847), null, null, null, false, null, "Thermodynamics", null }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "UpdatedAt", "YearName" },
                values: new object[,]
                {
                    { new Guid("b8871638-912e-44f9-b03d-86705fae0b4a"), new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8638), null, null, null, false, null, null, "2025" },
                    { new Guid("f591d45f-0900-4a52-ad35-874d61790720"), new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8635), null, null, null, false, null, null, "2024" }
                });

            migrationBuilder.InsertData(
                table: "YearsOfStudy",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ModifiedBy", "UpdatedAt", "Year" },
                values: new object[,]
                {
                    { new Guid("ac02626c-55a6-484d-86da-4770144a76fd"), new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8799), null, null, null, false, null, null, "First Year" },
                    { new Guid("d1f1303e-9cef-4ad2-ba20-d32bd4852774"), new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8800), null, null, null, false, null, null, "Second Year" }
                });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Duration", "ExamDate", "FiliereId", "IsDeleted", "ModifiedBy", "RoomId", "SemesterId", "StartTime", "SupervisorId", "UnitOfFormationId", "UpdatedAt", "YearId", "YearOfStudyId" },
                values: new object[,]
                {
                    { new Guid("1aaf8797-8f33-4a0b-a4e9-7bda99104345"), new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8918), null, null, null, new TimeSpan(0, 0, 0, 0, 0), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cac8ec54-4883-4880-bfc6-c99ebc30a44d"), false, null, new Guid("7e59257a-0ffb-451a-98a4-cc706c8abee3"), new Guid("296ad516-265c-4853-a4e7-44c4ce099677"), new TimeSpan(0, 0, 0, 0, 0), new Guid("6328e90e-3d32-45f3-b391-1beaa367cef7"), new Guid("9c6d916b-06c4-464d-b5c7-fe6339382f9d"), null, new Guid("b8871638-912e-44f9-b03d-86705fae0b4a"), new Guid("d1f1303e-9cef-4ad2-ba20-d32bd4852774") },
                    { new Guid("f9daf367-47f6-4677-9aaf-cbf09704ee43"), new DateTime(2024, 7, 14, 19, 40, 56, 767, DateTimeKind.Utc).AddTicks(8908), null, null, null, new TimeSpan(0, 0, 0, 0, 0), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("723b06b8-cca1-4d8b-96ef-f5ce5ccb96a4"), false, null, new Guid("686c756d-9891-4047-9c18-7e198d67f2b1"), new Guid("b8ba9a2c-1d55-4245-a3fe-0a07fbe589b9"), new TimeSpan(0, 0, 0, 0, 0), new Guid("1a1b8644-9b79-4062-a378-1afcbf72caf4"), new Guid("6bf06c26-18a5-4168-bf47-ae0c2a11de88"), null, new Guid("f591d45f-0900-4a52-ad35-874d61790720"), new Guid("ac02626c-55a6-484d-86da-4770144a76fd") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: new Guid("1aaf8797-8f33-4a0b-a4e9-7bda99104345"));

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: new Guid("f9daf367-47f6-4677-9aaf-cbf09704ee43"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("723b06b8-cca1-4d8b-96ef-f5ce5ccb96a4"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("cac8ec54-4883-4880-bfc6-c99ebc30a44d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("686c756d-9891-4047-9c18-7e198d67f2b1"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("7e59257a-0ffb-451a-98a4-cc706c8abee3"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("296ad516-265c-4853-a4e7-44c4ce099677"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("b8ba9a2c-1d55-4245-a3fe-0a07fbe589b9"));

            migrationBuilder.DeleteData(
                table: "Supervisors",
                keyColumn: "Id",
                keyValue: new Guid("1a1b8644-9b79-4062-a378-1afcbf72caf4"));

            migrationBuilder.DeleteData(
                table: "Supervisors",
                keyColumn: "Id",
                keyValue: new Guid("6328e90e-3d32-45f3-b391-1beaa367cef7"));

            migrationBuilder.DeleteData(
                table: "UnitsOfFormation",
                keyColumn: "Id",
                keyValue: new Guid("6bf06c26-18a5-4168-bf47-ae0c2a11de88"));

            migrationBuilder.DeleteData(
                table: "UnitsOfFormation",
                keyColumn: "Id",
                keyValue: new Guid("9c6d916b-06c4-464d-b5c7-fe6339382f9d"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("b8871638-912e-44f9-b03d-86705fae0b4a"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("f591d45f-0900-4a52-ad35-874d61790720"));

            migrationBuilder.DeleteData(
                table: "YearsOfStudy",
                keyColumn: "Id",
                keyValue: new Guid("ac02626c-55a6-484d-86da-4770144a76fd"));

            migrationBuilder.DeleteData(
                table: "YearsOfStudy",
                keyColumn: "Id",
                keyValue: new Guid("d1f1303e-9cef-4ad2-ba20-d32bd4852774"));
        }
    }
}
