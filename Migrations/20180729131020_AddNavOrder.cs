using Microsoft.EntityFrameworkCore.Migrations;

namespace codestack.Migrations {
    public partial class AddNavOrder : Migration {
        protected override void Up (MigrationBuilder migrationBuilder) {
            migrationBuilder.AddColumn<int> (
                name: "NavOrder",
                table: "NavRoute",
                nullable : false,
                defaultValue : 0);
        }

        protected override void Down (MigrationBuilder migrationBuilder) {
            migrationBuilder.DropColumn (
                name: "NavOrder",
                table: "NavRoute");
        }
    }
}