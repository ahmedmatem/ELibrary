using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ELibrary.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class RoleSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "1309dd3d-67bc-49c5-8a28-4c5bdce64d4c");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "16f0c324-207e-4e36-9e69-b1e8f447aee3");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "275a0138-d7c6-434b-a1bf-76e892243458");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "37133ed9-2051-4523-9352-c155b379bb71");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "64b9dcfa-ffc1-4477-846d-227a5600a1d2");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "86cbb2ea-2e5f-4b33-8d83-14fc78eb1a71");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "8e683884-f2b5-4fd0-b759-df10270a73d6");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "a247d2cc-8715-480b-8866-241a35e3fb5d");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "b04098ec-f6ba-4e44-a4dc-677ff5247efb");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "b0b29c65-dab2-4eb2-ab65-8c7f745f798f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2510b9d7-7243-4ec6-b155-3db252a73e1f", "978651ca-1831-49de-ab61-27d34e265659", "Student", "STUDENT" },
                    { "2fd1ba41-11c4-406e-87ec-c13a29b37a9f", "282f97d0-43e6-413a-90ba-5cdd01b9fd0d", "Admin", "ADMIN" },
                    { "417f62a3-df1a-4b50-8b49-28eca725cb23", "1c77591e-13df-47df-ac3c-5568adda30d4", "Teacher", "TEACHER" }
                });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "FilePath", "IsDeleted", "LastModifiedOn", "Subject", "Title", "Type", "UploadedOn" },
                values: new object[,]
                {
                    { "0f7fb3cd-5362-4f90-82a1-ab8d7fb3ff85", null, null, "Basic algebra concepts for beginners.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTu5dP-doCEi_ENZ0MohLSohexccNWBwwYlVg&s", false, null, "Mathematics", "Introduction to Algebra", 0, new DateTime(2025, 8, 20, 20, 23, 33, 405, DateTimeKind.Utc).AddTicks(1641) },
                    { "21c96b3f-0d63-40fe-9c43-2d9490f80112", null, null, "Short video explaining photosynthesis process.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR-z4VBEey9QK4XPYMXK3lkFI9zec7AVUM8sg&s", false, null, "Biology", "Photosynthesis Explained", 1, new DateTime(2025, 8, 20, 20, 23, 33, 405, DateTimeKind.Utc).AddTicks(1641) },
                    { "2b1b7307-7e56-4413-986f-77e8753192bc", null, null, "An overview of Newton's three laws of motion.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQHRGvbwPxrbxNYWyGFtHsuTPtrEwVJWDJf4A&s", false, null, "Physics", "Newton's Laws of Motion", 0, new DateTime(2025, 8, 20, 20, 23, 33, 405, DateTimeKind.Utc).AddTicks(1641) },
                    { "437788d2-c02b-49de-af1e-2d2493c5fc6c", null, null, "Video lessons for basic French vocabulary.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT7YTHf1DDxgEYh5S8wRH9rPYj4gHwTGf1GTQ&s", false, null, "Languages", "Learn French Basics", 1, new DateTime(2025, 8, 20, 20, 23, 33, 405, DateTimeKind.Utc).AddTicks(1641) },
                    { "537bef53-0528-4aa1-8908-238009656c80", null, null, "PDF guide to understanding geometric shapes.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTQ2_Bw8irY9VYn2pk5r9LcjSfopOg01evB3w&s", false, null, "Mathematics", "Basic Geometry Shapes", 0, new DateTime(2025, 8, 20, 20, 23, 33, 405, DateTimeKind.Utc).AddTicks(1641) },
                    { "5a20c2f9-72e6-45c2-84ff-2ff0757669b1", null, null, "Beginner-friendly programming concepts.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSWshjlQbu3zszK0jh2L_TwIc5Sm81KaSp63A&s", false, null, "Computer Science", "Introduction to Programming", 0, new DateTime(2025, 8, 20, 20, 23, 33, 405, DateTimeKind.Utc).AddTicks(1641) },
                    { "6071da99-a740-419e-a9cf-440ddf440374", null, null, "Reference guide to elements in the periodic table.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSraYINVd1T85796jgxTNZkOsdIFgB9kwx2rw&s", false, null, "Chemistry", "Periodic Table Reference", 0, new DateTime(2025, 8, 20, 20, 23, 33, 405, DateTimeKind.Utc).AddTicks(1641) },
                    { "65913930-0706-4708-9eb6-19481b879fd1", null, null, "Video lecture explaining supply and demand.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWLOImHrZv1Gi5dPoLPOa7YnPaYDgAvf6tfA&s", false, null, "Economics", "Introduction to Economics", 1, new DateTime(2025, 8, 20, 20, 23, 33, 405, DateTimeKind.Utc).AddTicks(1641) },
                    { "e0e98002-8168-4d5b-bede-17c3a6b6926f", null, null, "Article about global warming and its effects.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTwMtF9HZNRaZHdTiKVcfPAo37lZXoUD0eOMQ&s", false, null, "Environmental Science", "Climate Change and Its Impact", 3, new DateTime(2025, 8, 20, 20, 23, 33, 405, DateTimeKind.Utc).AddTicks(1641) },
                    { "f580e2f3-be60-404b-99b3-8610e948afeb", null, null, "A timeline of major world history events.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTAhAgn6PoF2RrL0mTnTVKq4DXHrbIKd5G20w&s", false, null, "History", "World History Overview", 0, new DateTime(2025, 8, 20, 20, 23, 33, 405, DateTimeKind.Utc).AddTicks(1641) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2510b9d7-7243-4ec6-b155-3db252a73e1f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fd1ba41-11c4-406e-87ec-c13a29b37a9f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "417f62a3-df1a-4b50-8b49-28eca725cb23");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "0f7fb3cd-5362-4f90-82a1-ab8d7fb3ff85");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "21c96b3f-0d63-40fe-9c43-2d9490f80112");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "2b1b7307-7e56-4413-986f-77e8753192bc");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "437788d2-c02b-49de-af1e-2d2493c5fc6c");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "537bef53-0528-4aa1-8908-238009656c80");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "5a20c2f9-72e6-45c2-84ff-2ff0757669b1");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "6071da99-a740-419e-a9cf-440ddf440374");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "65913930-0706-4708-9eb6-19481b879fd1");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "e0e98002-8168-4d5b-bede-17c3a6b6926f");

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: "f580e2f3-be60-404b-99b3-8610e948afeb");

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "FilePath", "IsDeleted", "LastModifiedOn", "Subject", "Title", "Type", "UploadedOn" },
                values: new object[,]
                {
                    { "1309dd3d-67bc-49c5-8a28-4c5bdce64d4c", null, null, "Video lessons for basic French vocabulary.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT7YTHf1DDxgEYh5S8wRH9rPYj4gHwTGf1GTQ&s", false, null, "Languages", "Learn French Basics", 1, new DateTime(2025, 8, 2, 18, 18, 4, 479, DateTimeKind.Utc).AddTicks(4370) },
                    { "16f0c324-207e-4e36-9e69-b1e8f447aee3", null, null, "PDF guide to understanding geometric shapes.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTQ2_Bw8irY9VYn2pk5r9LcjSfopOg01evB3w&s", false, null, "Mathematics", "Basic Geometry Shapes", 0, new DateTime(2025, 8, 2, 18, 18, 4, 479, DateTimeKind.Utc).AddTicks(4370) },
                    { "275a0138-d7c6-434b-a1bf-76e892243458", null, null, "A timeline of major world history events.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTAhAgn6PoF2RrL0mTnTVKq4DXHrbIKd5G20w&s", false, null, "History", "World History Overview", 0, new DateTime(2025, 8, 2, 18, 18, 4, 479, DateTimeKind.Utc).AddTicks(4370) },
                    { "37133ed9-2051-4523-9352-c155b379bb71", null, null, "Beginner-friendly programming concepts.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSWshjlQbu3zszK0jh2L_TwIc5Sm81KaSp63A&s", false, null, "Computer Science", "Introduction to Programming", 0, new DateTime(2025, 8, 2, 18, 18, 4, 479, DateTimeKind.Utc).AddTicks(4370) },
                    { "64b9dcfa-ffc1-4477-846d-227a5600a1d2", null, null, "Video lecture explaining supply and demand.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWLOImHrZv1Gi5dPoLPOa7YnPaYDgAvf6tfA&s", false, null, "Economics", "Introduction to Economics", 1, new DateTime(2025, 8, 2, 18, 18, 4, 479, DateTimeKind.Utc).AddTicks(4370) },
                    { "86cbb2ea-2e5f-4b33-8d83-14fc78eb1a71", null, null, "Reference guide to elements in the periodic table.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSraYINVd1T85796jgxTNZkOsdIFgB9kwx2rw&s", false, null, "Chemistry", "Periodic Table Reference", 0, new DateTime(2025, 8, 2, 18, 18, 4, 479, DateTimeKind.Utc).AddTicks(4370) },
                    { "8e683884-f2b5-4fd0-b759-df10270a73d6", null, null, "Short video explaining photosynthesis process.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR-z4VBEey9QK4XPYMXK3lkFI9zec7AVUM8sg&s", false, null, "Biology", "Photosynthesis Explained", 1, new DateTime(2025, 8, 2, 18, 18, 4, 479, DateTimeKind.Utc).AddTicks(4370) },
                    { "a247d2cc-8715-480b-8866-241a35e3fb5d", null, null, "Basic algebra concepts for beginners.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTu5dP-doCEi_ENZ0MohLSohexccNWBwwYlVg&s", false, null, "Mathematics", "Introduction to Algebra", 0, new DateTime(2025, 8, 2, 18, 18, 4, 479, DateTimeKind.Utc).AddTicks(4370) },
                    { "b04098ec-f6ba-4e44-a4dc-677ff5247efb", null, null, "Article about global warming and its effects.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTwMtF9HZNRaZHdTiKVcfPAo37lZXoUD0eOMQ&s", false, null, "Environmental Science", "Climate Change and Its Impact", 3, new DateTime(2025, 8, 2, 18, 18, 4, 479, DateTimeKind.Utc).AddTicks(4370) },
                    { "b0b29c65-dab2-4eb2-ab65-8c7f745f798f", null, null, "An overview of Newton's three laws of motion.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQHRGvbwPxrbxNYWyGFtHsuTPtrEwVJWDJf4A&s", false, null, "Physics", "Newton's Laws of Motion", 0, new DateTime(2025, 8, 2, 18, 18, 4, 479, DateTimeKind.Utc).AddTicks(4370) }
                });
        }
    }
}
