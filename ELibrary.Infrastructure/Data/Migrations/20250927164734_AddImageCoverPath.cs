using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ELibrary.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddImageCoverPath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "CoverImagePath",
                table: "Resources",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CoverImagePath",
                table: "Resources");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
    }
}
