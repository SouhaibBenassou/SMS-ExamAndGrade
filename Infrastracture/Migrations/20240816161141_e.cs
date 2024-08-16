using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class e : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Filieres",
                columns: new[] { "Id", "Capacite", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "Duree", "FraisInscription", "GroupCapacity", "IsDeleted", "ModifiedBy", "MontantAnnuel", "MontantMensuel", "MontantTrimestre", "Niveau", "NomFiliere", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), 145, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(4261), null, null, null, "Description for Filiere 19", 5, 6800m, 48, false, null, 31000m, 2900m, 7750m, "Bachelor", "Filiere 19", null },
                    { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), 100, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(2916), null, null, null, "Description for Filiere 10", 4, 5000m, 30, false, null, 22000m, 2000m, 5500m, "Master", "Filiere 10", null },
                    { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), 110, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(3239), null, null, null, "Description for Filiere 12", 2, 5400m, 34, false, null, 24000m, 2200m, 6000m, "Master", "Filiere 12", null },
                    { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), 65, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1830), null, null, null, "Description for Filiere 3", 5, 3600m, 16, false, null, 15000m, 1300m, 3750m, "Bachelor", "Filiere 3", null },
                    { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), 70, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1954), null, null, null, "Description for Filiere 4", 2, 3800m, 18, false, null, 16000m, 1400m, 4000m, "Master", "Filiere 4", null },
                    { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), 125, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(3704), null, null, null, "Description for Filiere 15", 5, 6000m, 40, false, null, 27000m, 2500m, 6750m, "Bachelor", "Filiere 15", null },
                    { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), 85, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(2405), null, null, null, "Description for Filiere 7", 5, 4400m, 24, false, null, 19000m, 1700m, 4750m, "Bachelor", "Filiere 7", null },
                    { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), 115, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(3362), null, null, null, "Description for Filiere 13", 3, 5600m, 36, false, null, 25000m, 2300m, 6250m, "Bachelor", "Filiere 13", null },
                    { new Guid("39b26171-decb-43f1-bc6f-8b88622878f1"), 90, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(2525), null, null, null, "Description for Filiere 8", 2, 4600m, 26, false, null, 20000m, 1800m, 5000m, "Master", "Filiere 8", null },
                    { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), 80, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(2268), null, null, null, "Description for Filiere 6", 4, 4200m, 22, false, null, 18000m, 1600m, 4500m, "Master", "Filiere 6", null },
                    { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), 95, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(2772), null, null, null, "Description for Filiere 9", 3, 4800m, 28, false, null, 21000m, 1900m, 5250m, "Bachelor", "Filiere 9", null },
                    { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), 130, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(3845), null, null, null, "Description for Filiere 16", 2, 6200m, 42, false, null, 28000m, 2600m, 7000m, "Master", "Filiere 16", null },
                    { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), 150, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(4362), null, null, null, "Description for Filiere 20", 2, 7000m, 50, false, null, 32000m, 3000m, 8000m, "Master", "Filiere 20", null },
                    { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), 135, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(3984), null, null, null, "Description for Filiere 17", 3, 6400m, 44, false, null, 29000m, 2700m, 7250m, "Bachelor", "Filiere 17", null },
                    { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), 75, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(2151), null, null, null, "Description for Filiere 5", 3, 4000m, 20, false, null, 17000m, 1500m, 4250m, "Bachelor", "Filiere 5", null },
                    { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), 55, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1382), null, null, null, "Description for Filiere 1", 3, 3200m, 12, false, null, 13000m, 1100m, 3250m, "Bachelor", "Filiere 1", null },
                    { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), 120, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(3485), null, null, null, "Description for Filiere 14", 4, 5800m, 38, false, null, 26000m, 2400m, 6500m, "Master", "Filiere 14", null },
                    { new Guid("e85aabb3-532c-44e7-909b-9c6fd7e9251c"), 140, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(4147), null, null, null, "Description for Filiere 18", 4, 6600m, 46, false, null, 30000m, 2800m, 7500m, "Master", "Filiere 18", null },
                    { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), 105, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(3045), null, null, null, "Description for Filiere 11", 5, 5200m, 32, false, null, 23000m, 2100m, 5750m, "Bachelor", "Filiere 11", null },
                    { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), 60, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1700), null, null, null, "Description for Filiere 2", 4, 3400m, 14, false, null, 14000m, 1200m, 3500m, "Master", "Filiere 2", null }
                });

            migrationBuilder.InsertData(
                table: "UnitOfFormations",
                columns: new[] { "Id", "Coefficient", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Duration", "IsDeleted", "ModifiedBy", "Name", "Semestre", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0106bd99-264d-494a-83c0-9bdcebfffa56"), 2, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(735), null, null, null, 50, false, null, "Unit 5", "Semester 1", null },
                    { new Guid("05a37095-749c-45ba-8dec-2f0c4d44c7b3"), 5, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1266), null, null, null, 53, false, null, "Unit 28", "Semester 2", null },
                    { new Guid("09408396-133e-406b-abd7-c036c1c0f929"), 4, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1262), null, null, null, 52, false, null, "Unit 27", "Semester 1", null },
                    { new Guid("0bda9a33-6b0a-41ed-a1ea-99182da98b4c"), 3, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1280), null, null, null, 46, false, null, "Unit 31", "Semester 1", null },
                    { new Guid("0fe0b0db-e61b-48c6-83e7-7bf2e3ae1305"), 4, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(752), null, null, null, 52, false, null, "Unit 7", "Semester 1", null },
                    { new Guid("1cd26635-c768-45e7-b67a-22d734d3eaac"), 4, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1357), null, null, null, 52, false, null, "Unit 47", "Semester 1", null },
                    { new Guid("1ed92ec6-1014-49de-8c70-3cfa32c79c04"), 2, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1346), null, null, null, 50, false, null, "Unit 45", "Semester 1", null },
                    { new Guid("1f10462d-0fef-4bb5-a6d9-d11b1ccfc9c9"), 5, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1361), null, null, null, 53, false, null, "Unit 48", "Semester 2", null },
                    { new Guid("1f8983ec-a58c-495c-a744-64ecdf8a51fe"), 3, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(302), null, null, null, 46, false, null, "Unit 1", "Semester 1", null },
                    { new Guid("23f6687d-7025-4040-af7c-85c871803627"), 5, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(809), null, null, null, 53, false, null, "Unit 18", "Semester 2", null },
                    { new Guid("2c87aa39-6e53-4d7d-9b1a-312f793d7ba9"), 5, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(782), null, null, null, 48, false, null, "Unit 13", "Semester 1", null },
                    { new Guid("2e347f2b-92ff-465b-a920-6bdafe76fce9"), 6, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1342), null, null, null, 49, false, null, "Unit 44", "Semester 2", null },
                    { new Guid("2f595d7e-d0c1-4fda-b83d-87faf0200c0a"), 2, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1371), null, null, null, 45, false, null, "Unit 50", "Semester 2", null },
                    { new Guid("2f957da3-ff9e-4598-bca1-584af705e6f0"), 6, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1299), null, null, null, 49, false, null, "Unit 34", "Semester 2", null },
                    { new Guid("39b48c14-dc43-4666-bc1f-e253693d6475"), 6, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(813), null, null, null, 54, false, null, "Unit 19", "Semester 1", null },
                    { new Guid("3a40e288-d364-4a85-95ef-767f71d5b14a"), 6, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(789), null, null, null, 49, false, null, "Unit 14", "Semester 2", null },
                    { new Guid("3ab693af-fa63-4e2b-aac7-fbf4e4d47ef6"), 2, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(793), null, null, null, 50, false, null, "Unit 15", "Semester 1", null },
                    { new Guid("3b70b9c1-f588-44e5-a9eb-1aa941cbab10"), 6, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1246), null, null, null, 49, false, null, "Unit 24", "Semester 2", null },
                    { new Guid("46bdfbf2-d95f-4487-938c-373abd581afc"), 5, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1288), null, null, null, 48, false, null, "Unit 33", "Semester 1", null },
                    { new Guid("47276ba0-7a72-43c6-ad70-d35197b6dd96"), 3, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(820), null, null, null, 46, false, null, "Unit 21", "Semester 1", null },
                    { new Guid("4986dab7-78d7-48ed-8f6c-40563c09625f"), 3, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1307), null, null, null, 51, false, null, "Unit 36", "Semester 2", null },
                    { new Guid("4c1d6ce0-f23e-4d61-a2c5-91fbd983e6e4"), 6, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(760), null, null, null, 54, false, null, "Unit 9", "Semester 1", null },
                    { new Guid("4cc2938d-57f6-4ec6-9986-88cc81e30d11"), 3, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1258), null, null, null, 51, false, null, "Unit 26", "Semester 2", null },
                    { new Guid("5502ba60-4022-4537-af8e-ec09dc2ada35"), 4, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(800), null, null, null, 52, false, null, "Unit 17", "Semester 1", null },
                    { new Guid("56395327-fc14-4566-9c66-8caed4c39a1a"), 4, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(778), null, null, null, 47, false, null, "Unit 12", "Semester 2", null },
                    { new Guid("59c0ca51-e0ca-435a-84b5-c63d6180d943"), 4, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(708), null, null, null, 47, false, null, "Unit 2", "Semester 2", null },
                    { new Guid("60a7adf0-ac39-4597-89fd-8571deb77a92"), 2, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1276), null, null, null, 45, false, null, "Unit 30", "Semester 2", null },
                    { new Guid("62aceb55-3e34-4919-b289-50d0c4e8d95a"), 6, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1269), null, null, null, 54, false, null, "Unit 29", "Semester 1", null },
                    { new Guid("659e8e83-7614-4fc6-bf16-55b68848faaf"), 3, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1328), null, null, null, 46, false, null, "Unit 41", "Semester 1", null },
                    { new Guid("6df75ed0-196e-49a6-bdcf-dc2ba3561615"), 3, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(774), null, null, null, 46, false, null, "Unit 11", "Semester 1", null },
                    { new Guid("6e0a9224-cfe9-428f-b34e-2d0374f088ae"), 3, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(797), null, null, null, 51, false, null, "Unit 16", "Semester 2", null },
                    { new Guid("7f06b2a8-75f0-45ce-a14f-b48c8da9ee6d"), 5, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1339), null, null, null, 48, false, null, "Unit 43", "Semester 1", null },
                    { new Guid("888d0f23-ae5d-4c8e-a38b-ac36575fe458"), 3, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(748), null, null, null, 51, false, null, "Unit 6", "Semester 2", null },
                    { new Guid("91d8b08f-6644-4695-93b8-c01b757c1f3b"), 6, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(730), null, null, null, 49, false, null, "Unit 4", "Semester 2", null },
                    { new Guid("94c52e73-2d72-4943-b1f4-238a007793a7"), 2, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1325), null, null, null, 45, false, null, "Unit 40", "Semester 2", null },
                    { new Guid("aac103e7-0409-45da-93c2-34fdf9518146"), 2, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(817), null, null, null, 45, false, null, "Unit 20", "Semester 2", null },
                    { new Guid("b9a2526a-44e2-46be-b543-1b66ce2f4154"), 2, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1251), null, null, null, 50, false, null, "Unit 25", "Semester 1", null },
                    { new Guid("bfe72488-4235-460a-a9d3-8069a5d7977c"), 3, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1353), null, null, null, 51, false, null, "Unit 46", "Semester 2", null },
                    { new Guid("c449cd72-5f8b-46d5-b387-c4ed45027973"), 4, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1335), null, null, null, 47, false, null, "Unit 42", "Semester 2", null },
                    { new Guid("c589f177-b4d5-4c09-be3d-3451711bd835"), 4, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1230), null, null, null, 47, false, null, "Unit 22", "Semester 2", null },
                    { new Guid("c84c0406-89ed-43eb-920d-0fd0cf92596b"), 4, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1284), null, null, null, 47, false, null, "Unit 32", "Semester 2", null },
                    { new Guid("cac8b83b-3528-49b7-aa56-3064100fd9ea"), 5, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1242), null, null, null, 48, false, null, "Unit 23", "Semester 1", null },
                    { new Guid("df23b698-cf9c-407b-ab0f-97a0c6c6981a"), 5, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(756), null, null, null, 53, false, null, "Unit 8", "Semester 2", null },
                    { new Guid("e06dc7bd-9527-4165-865f-fcdceb662c5b"), 6, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1365), null, null, null, 54, false, null, "Unit 49", "Semester 1", null },
                    { new Guid("e2cc5fdd-6d0c-407d-8099-4ca50d811ad4"), 5, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1317), null, null, null, 53, false, null, "Unit 38", "Semester 2", null },
                    { new Guid("e65242f7-e1d0-4794-a091-ffb151996a34"), 2, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1303), null, null, null, 50, false, null, "Unit 35", "Semester 1", null },
                    { new Guid("e6ac9df6-4244-4042-bc89-47f97df18c17"), 6, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1321), null, null, null, 54, false, null, "Unit 39", "Semester 1", null },
                    { new Guid("e865d06b-3b55-45c9-af65-12eb86088778"), 4, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(1311), null, null, null, 52, false, null, "Unit 37", "Semester 1", null },
                    { new Guid("f6f4e22c-c80f-439b-a333-4315cdbc1e77"), 5, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(726), null, null, null, 48, false, null, "Unit 3", "Semester 1", null },
                    { new Guid("fe43314a-4eb4-4751-bfe2-f8a1363546b3"), 2, new DateTime(2024, 8, 16, 16, 11, 40, 297, DateTimeKind.Utc).AddTicks(768), null, null, null, 45, false, null, "Unit 10", "Semester 2", null }
                });

            migrationBuilder.InsertData(
                table: "FiliereUnitOfFormations",
                columns: new[] { "FiliereId", "UnitOfFormationId" },
                values: new object[,]
                {
                    { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("0106bd99-264d-494a-83c0-9bdcebfffa56") },
                    { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("1cd26635-c768-45e7-b67a-22d734d3eaac") },
                    { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("46bdfbf2-d95f-4487-938c-373abd581afc") },
                    { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("62aceb55-3e34-4919-b289-50d0c4e8d95a") },
                    { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("c589f177-b4d5-4c09-be3d-3451711bd835") },
                    { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("1cd26635-c768-45e7-b67a-22d734d3eaac") },
                    { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("2c87aa39-6e53-4d7d-9b1a-312f793d7ba9") },
                    { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("39b48c14-dc43-4666-bc1f-e253693d6475") },
                    { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("47276ba0-7a72-43c6-ad70-d35197b6dd96") },
                    { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("e06dc7bd-9527-4165-865f-fcdceb662c5b") },
                    { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("23f6687d-7025-4040-af7c-85c871803627") },
                    { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("47276ba0-7a72-43c6-ad70-d35197b6dd96") },
                    { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("4986dab7-78d7-48ed-8f6c-40563c09625f") },
                    { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("c84c0406-89ed-43eb-920d-0fd0cf92596b") },
                    { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("e865d06b-3b55-45c9-af65-12eb86088778") },
                    { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("39b48c14-dc43-4666-bc1f-e253693d6475") },
                    { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("3a40e288-d364-4a85-95ef-767f71d5b14a") },
                    { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("4c1d6ce0-f23e-4d61-a2c5-91fbd983e6e4") },
                    { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("62aceb55-3e34-4919-b289-50d0c4e8d95a") },
                    { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("659e8e83-7614-4fc6-bf16-55b68848faaf") },
                    { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("1f10462d-0fef-4bb5-a6d9-d11b1ccfc9c9") },
                    { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("39b48c14-dc43-4666-bc1f-e253693d6475") },
                    { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("df23b698-cf9c-407b-ab0f-97a0c6c6981a") },
                    { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("e865d06b-3b55-45c9-af65-12eb86088778") },
                    { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("f6f4e22c-c80f-439b-a333-4315cdbc1e77") },
                    { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("2c87aa39-6e53-4d7d-9b1a-312f793d7ba9") },
                    { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("6e0a9224-cfe9-428f-b34e-2d0374f088ae") },
                    { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("7f06b2a8-75f0-45ce-a14f-b48c8da9ee6d") },
                    { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("bfe72488-4235-460a-a9d3-8069a5d7977c") },
                    { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("e2cc5fdd-6d0c-407d-8099-4ca50d811ad4") },
                    { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("05a37095-749c-45ba-8dec-2f0c4d44c7b3") },
                    { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("1f8983ec-a58c-495c-a744-64ecdf8a51fe") },
                    { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("3a40e288-d364-4a85-95ef-767f71d5b14a") },
                    { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("4c1d6ce0-f23e-4d61-a2c5-91fbd983e6e4") },
                    { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("60a7adf0-ac39-4597-89fd-8571deb77a92") },
                    { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("0106bd99-264d-494a-83c0-9bdcebfffa56") },
                    { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("1f10462d-0fef-4bb5-a6d9-d11b1ccfc9c9") },
                    { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("5502ba60-4022-4537-af8e-ec09dc2ada35") },
                    { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("659e8e83-7614-4fc6-bf16-55b68848faaf") },
                    { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("e2cc5fdd-6d0c-407d-8099-4ca50d811ad4") },
                    { new Guid("39b26171-decb-43f1-bc6f-8b88622878f1"), new Guid("1f8983ec-a58c-495c-a744-64ecdf8a51fe") },
                    { new Guid("39b26171-decb-43f1-bc6f-8b88622878f1"), new Guid("2e347f2b-92ff-465b-a920-6bdafe76fce9") },
                    { new Guid("39b26171-decb-43f1-bc6f-8b88622878f1"), new Guid("39b48c14-dc43-4666-bc1f-e253693d6475") },
                    { new Guid("39b26171-decb-43f1-bc6f-8b88622878f1"), new Guid("4c1d6ce0-f23e-4d61-a2c5-91fbd983e6e4") },
                    { new Guid("39b26171-decb-43f1-bc6f-8b88622878f1"), new Guid("62aceb55-3e34-4919-b289-50d0c4e8d95a") },
                    { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("3ab693af-fa63-4e2b-aac7-fbf4e4d47ef6") },
                    { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("4c1d6ce0-f23e-4d61-a2c5-91fbd983e6e4") },
                    { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("56395327-fc14-4566-9c66-8caed4c39a1a") },
                    { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("659e8e83-7614-4fc6-bf16-55b68848faaf") },
                    { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("e2cc5fdd-6d0c-407d-8099-4ca50d811ad4") },
                    { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("0fe0b0db-e61b-48c6-83e7-7bf2e3ae1305") },
                    { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("62aceb55-3e34-4919-b289-50d0c4e8d95a") },
                    { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("e06dc7bd-9527-4165-865f-fcdceb662c5b") },
                    { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("e2cc5fdd-6d0c-407d-8099-4ca50d811ad4") },
                    { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("e65242f7-e1d0-4794-a091-ffb151996a34") },
                    { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("1f10462d-0fef-4bb5-a6d9-d11b1ccfc9c9") },
                    { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("3b70b9c1-f588-44e5-a9eb-1aa941cbab10") },
                    { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("6e0a9224-cfe9-428f-b34e-2d0374f088ae") },
                    { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("91d8b08f-6644-4695-93b8-c01b757c1f3b") },
                    { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("e865d06b-3b55-45c9-af65-12eb86088778") },
                    { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("1cd26635-c768-45e7-b67a-22d734d3eaac") },
                    { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("3ab693af-fa63-4e2b-aac7-fbf4e4d47ef6") },
                    { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("56395327-fc14-4566-9c66-8caed4c39a1a") },
                    { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("b9a2526a-44e2-46be-b543-1b66ce2f4154") },
                    { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("c589f177-b4d5-4c09-be3d-3451711bd835") },
                    { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("5502ba60-4022-4537-af8e-ec09dc2ada35") },
                    { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("60a7adf0-ac39-4597-89fd-8571deb77a92") },
                    { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("c589f177-b4d5-4c09-be3d-3451711bd835") },
                    { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("df23b698-cf9c-407b-ab0f-97a0c6c6981a") },
                    { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("fe43314a-4eb4-4751-bfe2-f8a1363546b3") },
                    { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("23f6687d-7025-4040-af7c-85c871803627") },
                    { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("46bdfbf2-d95f-4487-938c-373abd581afc") },
                    { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("91d8b08f-6644-4695-93b8-c01b757c1f3b") },
                    { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("df23b698-cf9c-407b-ab0f-97a0c6c6981a") },
                    { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("e06dc7bd-9527-4165-865f-fcdceb662c5b") },
                    { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("09408396-133e-406b-abd7-c036c1c0f929") },
                    { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("2e347f2b-92ff-465b-a920-6bdafe76fce9") },
                    { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("3b70b9c1-f588-44e5-a9eb-1aa941cbab10") },
                    { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("46bdfbf2-d95f-4487-938c-373abd581afc") },
                    { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("4cc2938d-57f6-4ec6-9986-88cc81e30d11") },
                    { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("0fe0b0db-e61b-48c6-83e7-7bf2e3ae1305") },
                    { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("1cd26635-c768-45e7-b67a-22d734d3eaac") },
                    { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("2f595d7e-d0c1-4fda-b83d-87faf0200c0a") },
                    { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("4c1d6ce0-f23e-4d61-a2c5-91fbd983e6e4") },
                    { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("df23b698-cf9c-407b-ab0f-97a0c6c6981a") },
                    { new Guid("e85aabb3-532c-44e7-909b-9c6fd7e9251c"), new Guid("0106bd99-264d-494a-83c0-9bdcebfffa56") },
                    { new Guid("e85aabb3-532c-44e7-909b-9c6fd7e9251c"), new Guid("09408396-133e-406b-abd7-c036c1c0f929") },
                    { new Guid("e85aabb3-532c-44e7-909b-9c6fd7e9251c"), new Guid("0fe0b0db-e61b-48c6-83e7-7bf2e3ae1305") },
                    { new Guid("e85aabb3-532c-44e7-909b-9c6fd7e9251c"), new Guid("2e347f2b-92ff-465b-a920-6bdafe76fce9") },
                    { new Guid("e85aabb3-532c-44e7-909b-9c6fd7e9251c"), new Guid("3ab693af-fa63-4e2b-aac7-fbf4e4d47ef6") },
                    { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("23f6687d-7025-4040-af7c-85c871803627") },
                    { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("659e8e83-7614-4fc6-bf16-55b68848faaf") },
                    { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("cac8b83b-3528-49b7-aa56-3064100fd9ea") },
                    { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("e65242f7-e1d0-4794-a091-ffb151996a34") },
                    { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("e865d06b-3b55-45c9-af65-12eb86088778") },
                    { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("09408396-133e-406b-abd7-c036c1c0f929") },
                    { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("1cd26635-c768-45e7-b67a-22d734d3eaac") },
                    { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("3a40e288-d364-4a85-95ef-767f71d5b14a") },
                    { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("47276ba0-7a72-43c6-ad70-d35197b6dd96") },
                    { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("5502ba60-4022-4537-af8e-ec09dc2ada35") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("0106bd99-264d-494a-83c0-9bdcebfffa56") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("1cd26635-c768-45e7-b67a-22d734d3eaac") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("46bdfbf2-d95f-4487-938c-373abd581afc") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("62aceb55-3e34-4919-b289-50d0c4e8d95a") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"), new Guid("c589f177-b4d5-4c09-be3d-3451711bd835") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("1cd26635-c768-45e7-b67a-22d734d3eaac") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("2c87aa39-6e53-4d7d-9b1a-312f793d7ba9") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("39b48c14-dc43-4666-bc1f-e253693d6475") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("47276ba0-7a72-43c6-ad70-d35197b6dd96") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"), new Guid("e06dc7bd-9527-4165-865f-fcdceb662c5b") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("23f6687d-7025-4040-af7c-85c871803627") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("47276ba0-7a72-43c6-ad70-d35197b6dd96") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("4986dab7-78d7-48ed-8f6c-40563c09625f") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("c84c0406-89ed-43eb-920d-0fd0cf92596b") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"), new Guid("e865d06b-3b55-45c9-af65-12eb86088778") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("39b48c14-dc43-4666-bc1f-e253693d6475") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("3a40e288-d364-4a85-95ef-767f71d5b14a") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("4c1d6ce0-f23e-4d61-a2c5-91fbd983e6e4") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("62aceb55-3e34-4919-b289-50d0c4e8d95a") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"), new Guid("659e8e83-7614-4fc6-bf16-55b68848faaf") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("1f10462d-0fef-4bb5-a6d9-d11b1ccfc9c9") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("39b48c14-dc43-4666-bc1f-e253693d6475") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("df23b698-cf9c-407b-ab0f-97a0c6c6981a") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("e865d06b-3b55-45c9-af65-12eb86088778") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"), new Guid("f6f4e22c-c80f-439b-a333-4315cdbc1e77") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("2c87aa39-6e53-4d7d-9b1a-312f793d7ba9") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("6e0a9224-cfe9-428f-b34e-2d0374f088ae") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("7f06b2a8-75f0-45ce-a14f-b48c8da9ee6d") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("bfe72488-4235-460a-a9d3-8069a5d7977c") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("21aef537-d19e-48bf-a523-23db8e193522"), new Guid("e2cc5fdd-6d0c-407d-8099-4ca50d811ad4") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("05a37095-749c-45ba-8dec-2f0c4d44c7b3") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("1f8983ec-a58c-495c-a744-64ecdf8a51fe") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("3a40e288-d364-4a85-95ef-767f71d5b14a") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("4c1d6ce0-f23e-4d61-a2c5-91fbd983e6e4") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"), new Guid("60a7adf0-ac39-4597-89fd-8571deb77a92") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("0106bd99-264d-494a-83c0-9bdcebfffa56") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("1f10462d-0fef-4bb5-a6d9-d11b1ccfc9c9") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("5502ba60-4022-4537-af8e-ec09dc2ada35") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("659e8e83-7614-4fc6-bf16-55b68848faaf") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"), new Guid("e2cc5fdd-6d0c-407d-8099-4ca50d811ad4") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("39b26171-decb-43f1-bc6f-8b88622878f1"), new Guid("1f8983ec-a58c-495c-a744-64ecdf8a51fe") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("39b26171-decb-43f1-bc6f-8b88622878f1"), new Guid("2e347f2b-92ff-465b-a920-6bdafe76fce9") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("39b26171-decb-43f1-bc6f-8b88622878f1"), new Guid("39b48c14-dc43-4666-bc1f-e253693d6475") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("39b26171-decb-43f1-bc6f-8b88622878f1"), new Guid("4c1d6ce0-f23e-4d61-a2c5-91fbd983e6e4") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("39b26171-decb-43f1-bc6f-8b88622878f1"), new Guid("62aceb55-3e34-4919-b289-50d0c4e8d95a") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("3ab693af-fa63-4e2b-aac7-fbf4e4d47ef6") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("4c1d6ce0-f23e-4d61-a2c5-91fbd983e6e4") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("56395327-fc14-4566-9c66-8caed4c39a1a") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("659e8e83-7614-4fc6-bf16-55b68848faaf") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"), new Guid("e2cc5fdd-6d0c-407d-8099-4ca50d811ad4") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("0fe0b0db-e61b-48c6-83e7-7bf2e3ae1305") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("62aceb55-3e34-4919-b289-50d0c4e8d95a") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("e06dc7bd-9527-4165-865f-fcdceb662c5b") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("e2cc5fdd-6d0c-407d-8099-4ca50d811ad4") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"), new Guid("e65242f7-e1d0-4794-a091-ffb151996a34") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("1f10462d-0fef-4bb5-a6d9-d11b1ccfc9c9") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("3b70b9c1-f588-44e5-a9eb-1aa941cbab10") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("6e0a9224-cfe9-428f-b34e-2d0374f088ae") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("91d8b08f-6644-4695-93b8-c01b757c1f3b") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"), new Guid("e865d06b-3b55-45c9-af65-12eb86088778") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("1cd26635-c768-45e7-b67a-22d734d3eaac") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("3ab693af-fa63-4e2b-aac7-fbf4e4d47ef6") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("56395327-fc14-4566-9c66-8caed4c39a1a") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("b9a2526a-44e2-46be-b543-1b66ce2f4154") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"), new Guid("c589f177-b4d5-4c09-be3d-3451711bd835") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("5502ba60-4022-4537-af8e-ec09dc2ada35") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("60a7adf0-ac39-4597-89fd-8571deb77a92") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("c589f177-b4d5-4c09-be3d-3451711bd835") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("df23b698-cf9c-407b-ab0f-97a0c6c6981a") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"), new Guid("fe43314a-4eb4-4751-bfe2-f8a1363546b3") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("23f6687d-7025-4040-af7c-85c871803627") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("46bdfbf2-d95f-4487-938c-373abd581afc") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("91d8b08f-6644-4695-93b8-c01b757c1f3b") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("df23b698-cf9c-407b-ab0f-97a0c6c6981a") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"), new Guid("e06dc7bd-9527-4165-865f-fcdceb662c5b") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("09408396-133e-406b-abd7-c036c1c0f929") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("2e347f2b-92ff-465b-a920-6bdafe76fce9") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("3b70b9c1-f588-44e5-a9eb-1aa941cbab10") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("46bdfbf2-d95f-4487-938c-373abd581afc") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"), new Guid("4cc2938d-57f6-4ec6-9986-88cc81e30d11") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("0fe0b0db-e61b-48c6-83e7-7bf2e3ae1305") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("1cd26635-c768-45e7-b67a-22d734d3eaac") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("2f595d7e-d0c1-4fda-b83d-87faf0200c0a") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("4c1d6ce0-f23e-4d61-a2c5-91fbd983e6e4") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"), new Guid("df23b698-cf9c-407b-ab0f-97a0c6c6981a") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("e85aabb3-532c-44e7-909b-9c6fd7e9251c"), new Guid("0106bd99-264d-494a-83c0-9bdcebfffa56") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("e85aabb3-532c-44e7-909b-9c6fd7e9251c"), new Guid("09408396-133e-406b-abd7-c036c1c0f929") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("e85aabb3-532c-44e7-909b-9c6fd7e9251c"), new Guid("0fe0b0db-e61b-48c6-83e7-7bf2e3ae1305") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("e85aabb3-532c-44e7-909b-9c6fd7e9251c"), new Guid("2e347f2b-92ff-465b-a920-6bdafe76fce9") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("e85aabb3-532c-44e7-909b-9c6fd7e9251c"), new Guid("3ab693af-fa63-4e2b-aac7-fbf4e4d47ef6") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("23f6687d-7025-4040-af7c-85c871803627") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("659e8e83-7614-4fc6-bf16-55b68848faaf") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("cac8b83b-3528-49b7-aa56-3064100fd9ea") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("e65242f7-e1d0-4794-a091-ffb151996a34") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"), new Guid("e865d06b-3b55-45c9-af65-12eb86088778") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("09408396-133e-406b-abd7-c036c1c0f929") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("1cd26635-c768-45e7-b67a-22d734d3eaac") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("3a40e288-d364-4a85-95ef-767f71d5b14a") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("47276ba0-7a72-43c6-ad70-d35197b6dd96") });

            migrationBuilder.DeleteData(
                table: "FiliereUnitOfFormations",
                keyColumns: new[] { "FiliereId", "UnitOfFormationId" },
                keyValues: new object[] { new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"), new Guid("5502ba60-4022-4537-af8e-ec09dc2ada35") });

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("0bda9a33-6b0a-41ed-a1ea-99182da98b4c"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("1ed92ec6-1014-49de-8c70-3cfa32c79c04"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("2f957da3-ff9e-4598-bca1-584af705e6f0"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("59c0ca51-e0ca-435a-84b5-c63d6180d943"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("6df75ed0-196e-49a6-bdcf-dc2ba3561615"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("888d0f23-ae5d-4c8e-a38b-ac36575fe458"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("94c52e73-2d72-4943-b1f4-238a007793a7"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("aac103e7-0409-45da-93c2-34fdf9518146"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("c449cd72-5f8b-46d5-b387-c4ed45027973"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("e6ac9df6-4244-4042-bc89-47f97df18c17"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("06f1a5e9-8864-40e3-b6d6-f8945f97e205"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("08ce7b0a-5642-4337-80ce-aef919a0b2d9"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("109d52af-6448-4280-bcb8-c9ed03570c8c"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("16822560-9848-4a88-80f2-bb716ce8c18d"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("1c75a28a-7091-42d4-8a13-5b37515d7a4a"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("21aef537-d19e-48bf-a523-23db8e193522"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("27039911-d1ef-4662-ad01-f5b0260bfa96"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("310b5fae-6446-4590-b08f-55047f4a78e9"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("39b26171-decb-43f1-bc6f-8b88622878f1"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("48bc9d15-e2bc-4741-97af-621693a1ebb5"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("a82c929f-5567-4248-b31b-3dac539c18c6"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("bce4bd92-9359-4303-b629-513e17ccf10f"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("c094c44b-cac4-4fb9-88e0-c29a43bb7edb"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("c1c6fbc9-2fde-4c9e-b6cf-78a06f299de7"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("c42fa17d-e149-46a6-b2ae-53e972da0585"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("c4677026-cb1e-4741-9685-0f56b9758e65"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("e817e565-faad-42b8-9dca-70e03d67bdfd"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("e85aabb3-532c-44e7-909b-9c6fd7e9251c"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("ed9a86d0-0ff8-4585-b8a9-2852465959c2"));

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "Id",
                keyValue: new Guid("fc17e25e-7453-4924-a4ca-2c036306622b"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("0106bd99-264d-494a-83c0-9bdcebfffa56"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("05a37095-749c-45ba-8dec-2f0c4d44c7b3"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("09408396-133e-406b-abd7-c036c1c0f929"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("0fe0b0db-e61b-48c6-83e7-7bf2e3ae1305"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("1cd26635-c768-45e7-b67a-22d734d3eaac"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("1f10462d-0fef-4bb5-a6d9-d11b1ccfc9c9"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("1f8983ec-a58c-495c-a744-64ecdf8a51fe"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("23f6687d-7025-4040-af7c-85c871803627"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("2c87aa39-6e53-4d7d-9b1a-312f793d7ba9"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("2e347f2b-92ff-465b-a920-6bdafe76fce9"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("2f595d7e-d0c1-4fda-b83d-87faf0200c0a"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("39b48c14-dc43-4666-bc1f-e253693d6475"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("3a40e288-d364-4a85-95ef-767f71d5b14a"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("3ab693af-fa63-4e2b-aac7-fbf4e4d47ef6"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("3b70b9c1-f588-44e5-a9eb-1aa941cbab10"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("46bdfbf2-d95f-4487-938c-373abd581afc"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("47276ba0-7a72-43c6-ad70-d35197b6dd96"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("4986dab7-78d7-48ed-8f6c-40563c09625f"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("4c1d6ce0-f23e-4d61-a2c5-91fbd983e6e4"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("4cc2938d-57f6-4ec6-9986-88cc81e30d11"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("5502ba60-4022-4537-af8e-ec09dc2ada35"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("56395327-fc14-4566-9c66-8caed4c39a1a"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("60a7adf0-ac39-4597-89fd-8571deb77a92"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("62aceb55-3e34-4919-b289-50d0c4e8d95a"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("659e8e83-7614-4fc6-bf16-55b68848faaf"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("6e0a9224-cfe9-428f-b34e-2d0374f088ae"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("7f06b2a8-75f0-45ce-a14f-b48c8da9ee6d"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("91d8b08f-6644-4695-93b8-c01b757c1f3b"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("b9a2526a-44e2-46be-b543-1b66ce2f4154"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("bfe72488-4235-460a-a9d3-8069a5d7977c"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("c589f177-b4d5-4c09-be3d-3451711bd835"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("c84c0406-89ed-43eb-920d-0fd0cf92596b"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("cac8b83b-3528-49b7-aa56-3064100fd9ea"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("df23b698-cf9c-407b-ab0f-97a0c6c6981a"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("e06dc7bd-9527-4165-865f-fcdceb662c5b"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("e2cc5fdd-6d0c-407d-8099-4ca50d811ad4"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("e65242f7-e1d0-4794-a091-ffb151996a34"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("e865d06b-3b55-45c9-af65-12eb86088778"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("f6f4e22c-c80f-439b-a333-4315cdbc1e77"));

            migrationBuilder.DeleteData(
                table: "UnitOfFormations",
                keyColumn: "Id",
                keyValue: new Guid("fe43314a-4eb4-4751-bfe2-f8a1363546b3"));
        }
    }
}
