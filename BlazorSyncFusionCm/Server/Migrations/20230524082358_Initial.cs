using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorSyncFusionCm.Server.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nots_contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "contacts",
                        principalColumn: "Id");
                });



            migrationBuilder.InsertData(
                table: "contacts",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateOfBirth", "DateUpdated", "FirstName", "IsDeleted", "LastName", "NickName", "Place" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 24, 11, 53, 58, 63, DateTimeKind.Local).AddTicks(4433), null, new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Amir", false, "Ahmadi", "Joe", "Tab" },
                    { 2, new DateTime(2023, 5, 24, 11, 53, 58, 63, DateTimeKind.Local).AddTicks(4436), null, new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Amir2", false, "Ahmadi", "Joe", "Tab" },
                    { 3, new DateTime(2023, 5, 24, 11, 53, 58, 63, DateTimeKind.Local).AddTicks(4438), null, new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Amir3", false, "Ahmadi", "Joe", "Tab" },
                    { 4, new DateTime(2023, 5, 24, 11, 53, 58, 63, DateTimeKind.Local).AddTicks(4439), null, new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Amir4", false, "Ahmadi", "Joe", "Tab" },
                    { 5, new DateTime(2023, 5, 24, 11, 53, 58, 63, DateTimeKind.Local).AddTicks(4441), null, new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Amir5", false, "Ahmadi", "Joe", "Tab" },
                    { 6, new DateTime(2023, 5, 24, 11, 53, 58, 63, DateTimeKind.Local).AddTicks(4442), null, new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Amir6", false, "Ahmadi", "Joe", "Tab" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nots_ContactId",
                table: "Nots",
                column: "ContactId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nots");

            migrationBuilder.DropTable(
                name: "contacts");
        }
    }
}
