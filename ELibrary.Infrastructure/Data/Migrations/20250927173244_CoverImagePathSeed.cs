using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ELibrary.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class CoverImagePathSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b554c9b-6465-4f8a-a8ff-02c1dee1167f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc2725a2-a6da-4074-95b6-f4e0522ec5d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2967836-9098-4236-a1d5-e73a4ca4f8dc");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "14240c9e-b57d-4f2c-ae73-2ad059db27f2");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "3c848653-3a9a-495f-8b2e-10e92bc518f5");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "5a19fcf9-1a8b-495b-8248-f58549cec107");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "5cc33554-0efd-4a38-b9f9-f44b5377a075");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "5e74eaf2-d2f8-4f0f-b272-0841177c00f8");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "61051064-eb2b-402f-8152-bc1b3a63d685");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "632fe130-60da-481d-9001-2787f6f78429");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "6826cfb9-576d-414a-976e-00a38bf65da1");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "a2644b51-3219-4e16-9315-d16fff656bd5");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "ec4a054f-52be-4869-a88e-dfcfa67f1de1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "865d31da-4bb6-4663-8e7c-cbfdbdbfe380", "0f4b813b-b13c-47bf-8758-bcdfd57fd1bb", "Student", "STUDENT" },
                    { "adeac8a4-eb6f-4089-9443-8dc547b1fca6", "8b17c420-5b95-45d6-b44d-de3cde5e0ec2", "Admin", "ADMIN" },
                    { "d0b85c97-0bb1-4e8f-be48-cb3cd44b5308", "9f2c086f-200e-49f2-a3a3-1fd82c43d8d2", "Teacher", "TEACHER" }
                });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "CoverImagePath", "CreatedOn", "DeletedOn", "Description", "FilePath", "IsDeleted", "LastModifiedOn", "Subject", "Title", "Type", "UploadedOn" },
                values: new object[,]
                {
                    { "33a2716e-df38-4050-a223-45191a2205b3", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSraYINVd1T85796jgxTNZkOsdIFgB9kwx2rw&s", null, null, "Reference guide to elements in the periodic table.", "", false, null, "Chemistry", "Periodic Table Reference", 0, new DateTime(2025, 9, 27, 17, 32, 43, 317, DateTimeKind.Utc).AddTicks(4792) },
                    { "56a6f0ff-3612-4bc5-bfbe-bfb5c4c0d071", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTQ2_Bw8irY9VYn2pk5r9LcjSfopOg01evB3w&s", null, null, "PDF guide to understanding geometric shapes.", "", false, null, "Mathematics", "Basic Geometry Shapes", 0, new DateTime(2025, 9, 27, 17, 32, 43, 317, DateTimeKind.Utc).AddTicks(4792) },
                    { "91f882d8-1765-4912-9f45-ea4bc25a0e93", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR-z4VBEey9QK4XPYMXK3lkFI9zec7AVUM8sg&s", null, null, "Short video explaining photosynthesis process.", "", false, null, "Biology", "Photosynthesis Explained", 1, new DateTime(2025, 9, 27, 17, 32, 43, 317, DateTimeKind.Utc).AddTicks(4792) },
                    { "9311918f-bb81-4b2f-b2c7-66918308adb0", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTAhAgn6PoF2RrL0mTnTVKq4DXHrbIKd5G20w&s", null, null, "A timeline of major world history events.", "", false, null, "History", "World History Overview", 0, new DateTime(2025, 9, 27, 17, 32, 43, 317, DateTimeKind.Utc).AddTicks(4792) },
                    { "9d28e790-8981-4b34-9975-4d51e164b845", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQHRGvbwPxrbxNYWyGFtHsuTPtrEwVJWDJf4A&s", null, null, "An overview of Newton's three laws of motion.", "", false, null, "Physics", "Newton's Laws of Motion", 0, new DateTime(2025, 9, 27, 17, 32, 43, 317, DateTimeKind.Utc).AddTicks(4792) },
                    { "c665888c-8ae4-492c-b766-4128a7e828ee", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTu5dP-doCEi_ENZ0MohLSohexccNWBwwYlVg&s", null, null, "Basic algebra concepts for beginners.", "", false, null, "Mathematics", "Introduction to Algebra", 0, new DateTime(2025, 9, 27, 17, 32, 43, 317, DateTimeKind.Utc).AddTicks(4792) },
                    { "cb1eb638-4679-4146-9d9a-485ad0976002", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSWshjlQbu3zszK0jh2L_TwIc5Sm81KaSp63A&s", null, null, "Beginner-friendly programming concepts.", "", false, null, "Computer Science", "Introduction to Programming", 0, new DateTime(2025, 9, 27, 17, 32, 43, 317, DateTimeKind.Utc).AddTicks(4792) },
                    { "d272c554-0ef6-467b-91b2-2009aecc861a", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTwMtF9HZNRaZHdTiKVcfPAo37lZXoUD0eOMQ&s", null, null, "Article about global warming and its effects.", "", false, null, "Environmental Science", "Climate Change and Its Impact", 3, new DateTime(2025, 9, 27, 17, 32, 43, 317, DateTimeKind.Utc).AddTicks(4792) },
                    { "f3d038b3-2702-4c42-9ee6-0eae131d7a79", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWLOImHrZv1Gi5dPoLPOa7YnPaYDgAvf6tfA&s", null, null, "Video lecture explaining supply and demand.", "", false, null, "Economics", "Introduction to Economics", 1, new DateTime(2025, 9, 27, 17, 32, 43, 317, DateTimeKind.Utc).AddTicks(4792) },
                    { "fdba7d71-696b-4183-a306-f95918c9a6e9", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT7YTHf1DDxgEYh5S8wRH9rPYj4gHwTGf1GTQ&s", null, null, "Video lessons for basic French vocabulary.", "", false, null, "Languages", "Learn French Basics", 1, new DateTime(2025, 9, 27, 17, 32, 43, 317, DateTimeKind.Utc).AddTicks(4792) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "865d31da-4bb6-4663-8e7c-cbfdbdbfe380");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adeac8a4-eb6f-4089-9443-8dc547b1fca6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0b85c97-0bb1-4e8f-be48-cb3cd44b5308");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "33a2716e-df38-4050-a223-45191a2205b3");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "56a6f0ff-3612-4bc5-bfbe-bfb5c4c0d071");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "91f882d8-1765-4912-9f45-ea4bc25a0e93");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "9311918f-bb81-4b2f-b2c7-66918308adb0");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "9d28e790-8981-4b34-9975-4d51e164b845");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "c665888c-8ae4-492c-b766-4128a7e828ee");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "cb1eb638-4679-4146-9d9a-485ad0976002");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "d272c554-0ef6-467b-91b2-2009aecc861a");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "f3d038b3-2702-4c42-9ee6-0eae131d7a79");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "fdba7d71-696b-4183-a306-f95918c9a6e9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8b554c9b-6465-4f8a-a8ff-02c1dee1167f", "5555d156-e315-45a4-b12f-15bf054cc511", "Admin", "ADMIN" },
                    { "dc2725a2-a6da-4074-95b6-f4e0522ec5d0", "40f74b2e-96dc-4418-a73b-f87ff347f247", "Teacher", "TEACHER" },
                    { "e2967836-9098-4236-a1d5-e73a4ca4f8dc", "7203e684-087c-450c-93be-87bbbf0322d2", "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "CoverImagePath", "CreatedOn", "DeletedOn", "Description", "FilePath", "IsDeleted", "LastModifiedOn", "Subject", "Title", "Type", "UploadedOn" },
                values: new object[,]
                {
                    { "14240c9e-b57d-4f2c-ae73-2ad059db27f2", null, null, null, "PDF guide to understanding geometric shapes.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTQ2_Bw8irY9VYn2pk5r9LcjSfopOg01evB3w&s", false, null, "Mathematics", "Basic Geometry Shapes", 0, new DateTime(2025, 9, 27, 16, 47, 32, 994, DateTimeKind.Utc).AddTicks(6153) },
                    { "3c848653-3a9a-495f-8b2e-10e92bc518f5", null, null, null, "Short video explaining photosynthesis process.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR-z4VBEey9QK4XPYMXK3lkFI9zec7AVUM8sg&s", false, null, "Biology", "Photosynthesis Explained", 1, new DateTime(2025, 9, 27, 16, 47, 32, 994, DateTimeKind.Utc).AddTicks(6153) },
                    { "5a19fcf9-1a8b-495b-8248-f58549cec107", null, null, null, "Video lecture explaining supply and demand.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWLOImHrZv1Gi5dPoLPOa7YnPaYDgAvf6tfA&s", false, null, "Economics", "Introduction to Economics", 1, new DateTime(2025, 9, 27, 16, 47, 32, 994, DateTimeKind.Utc).AddTicks(6153) },
                    { "5cc33554-0efd-4a38-b9f9-f44b5377a075", null, null, null, "A timeline of major world history events.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTAhAgn6PoF2RrL0mTnTVKq4DXHrbIKd5G20w&s", false, null, "History", "World History Overview", 0, new DateTime(2025, 9, 27, 16, 47, 32, 994, DateTimeKind.Utc).AddTicks(6153) },
                    { "5e74eaf2-d2f8-4f0f-b272-0841177c00f8", null, null, null, "Beginner-friendly programming concepts.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSWshjlQbu3zszK0jh2L_TwIc5Sm81KaSp63A&s", false, null, "Computer Science", "Introduction to Programming", 0, new DateTime(2025, 9, 27, 16, 47, 32, 994, DateTimeKind.Utc).AddTicks(6153) },
                    { "61051064-eb2b-402f-8152-bc1b3a63d685", null, null, null, "An overview of Newton's three laws of motion.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQHRGvbwPxrbxNYWyGFtHsuTPtrEwVJWDJf4A&s", false, null, "Physics", "Newton's Laws of Motion", 0, new DateTime(2025, 9, 27, 16, 47, 32, 994, DateTimeKind.Utc).AddTicks(6153) },
                    { "632fe130-60da-481d-9001-2787f6f78429", null, null, null, "Article about global warming and its effects.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTwMtF9HZNRaZHdTiKVcfPAo37lZXoUD0eOMQ&s", false, null, "Environmental Science", "Climate Change and Its Impact", 3, new DateTime(2025, 9, 27, 16, 47, 32, 994, DateTimeKind.Utc).AddTicks(6153) },
                    { "6826cfb9-576d-414a-976e-00a38bf65da1", null, null, null, "Reference guide to elements in the periodic table.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSraYINVd1T85796jgxTNZkOsdIFgB9kwx2rw&s", false, null, "Chemistry", "Periodic Table Reference", 0, new DateTime(2025, 9, 27, 16, 47, 32, 994, DateTimeKind.Utc).AddTicks(6153) },
                    { "a2644b51-3219-4e16-9315-d16fff656bd5", null, null, null, "Video lessons for basic French vocabulary.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT7YTHf1DDxgEYh5S8wRH9rPYj4gHwTGf1GTQ&s", false, null, "Languages", "Learn French Basics", 1, new DateTime(2025, 9, 27, 16, 47, 32, 994, DateTimeKind.Utc).AddTicks(6153) },
                    { "ec4a054f-52be-4869-a88e-dfcfa67f1de1", null, null, null, "Basic algebra concepts for beginners.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTu5dP-doCEi_ENZ0MohLSohexccNWBwwYlVg&s", false, null, "Mathematics", "Introduction to Algebra", 0, new DateTime(2025, 9, 27, 16, 47, 32, 994, DateTimeKind.Utc).AddTicks(6153) }
                });
        }
    }
}
