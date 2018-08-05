using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeStack.Data.Migrations {
    public partial class InitialCreate : Migration {
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.CreateTable(
                name: "NavRoute",
                columns : table => new {
                    NavRouteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                        Name = table.Column<string>(nullable: true),
                        Routerlink = table.Column<string>(nullable: true),
                        Details = table.Column<string>(nullable: true)
                },
                constraints : table => {
                    table.PrimaryKey("PK_NavRoute", x => x.NavRouteID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(
                name: "NavRoute");
        }
    }
}