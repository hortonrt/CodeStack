using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeStack.Data.Migrations {
    public partial class schema : Migration {
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Route",
                table: "Route");

            migrationBuilder.EnsureSchema(
                name: "Options");

            migrationBuilder.RenameTable(
                name: "Route",
                newName: "Routes",
                newSchema: "Options");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Routes",
                schema: "Options",
                table: "Routes",
                column: "RouteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Routes",
                schema: "Options",
                table: "Routes");

            migrationBuilder.RenameTable(
                name: "Routes",
                schema: "Options",
                newName: "Route");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Route",
                table: "Route",
                column: "RouteID");
        }
    }
}