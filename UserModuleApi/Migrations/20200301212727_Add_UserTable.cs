using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserModuleApi.Migrations
{
    public partial class Add_UserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Info = table.Column<string>(nullable: true),
                    BirthDate = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "BirthDate", "Created", "Info", "IsActive", "Name", "UserName" },
                values: new object[] { 1, "Yerevan", 1998, new DateTime(2020, 3, 2, 1, 27, 27, 237, DateTimeKind.Local).AddTicks(5294), "Doc", true, "Ruben", "Ruben@gmail.com" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "BirthDate", "Created", "Info", "IsActive", "Name", "UserName" },
                values: new object[] { 2, "Alaverdi", 2001, new DateTime(2020, 3, 2, 1, 27, 27, 238, DateTimeKind.Local).AddTicks(5601), "Custom", true, "Mukuch", "Mko@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
