using Microsoft.EntityFrameworkCore.Migrations;

namespace codestack.Migrations {
    public partial class varchartypes : Migration {
        protected override void Up (MigrationBuilder migrationBuilder) {
            migrationBuilder.AlterColumn<string> (
                name: "Routerlink",
                table: "NavRoute",
                type: "VARCHAR(25)",
                nullable : true,
                oldClrType : typeof (string),
                oldNullable : true);

            migrationBuilder.AlterColumn<string> (
                name: "Name",
                table: "NavRoute",
                type: "VARCHAR(25)",
                nullable : true,
                oldClrType : typeof (string),
                oldNullable : true);

            migrationBuilder.AlterColumn<string> (
                name: "Details",
                table: "NavRoute",
                type: "VARCHAR(100)",
                nullable : true,
                oldClrType : typeof (string),
                oldNullable : true);
        }

        protected override void Down (MigrationBuilder migrationBuilder) {
            migrationBuilder.AlterColumn<string> (
                name: "Routerlink",
                table: "NavRoute",
                nullable : true,
                oldClrType : typeof (string),
                oldType: "VARCHAR(25)",
                oldNullable : true);

            migrationBuilder.AlterColumn<string> (
                name: "Name",
                table: "NavRoute",
                nullable : true,
                oldClrType : typeof (string),
                oldType: "VARCHAR(25)",
                oldNullable : true);

            migrationBuilder.AlterColumn<string> (
                name: "Details",
                table: "NavRoute",
                nullable : true,
                oldClrType : typeof (string),
                oldType: "VARCHAR(100)",
                oldNullable : true);
        }
    }
}