using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeStack.Data.Migrations {
    public partial class rename : Migration {
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(
                name: "NavRoute");

            migrationBuilder.CreateTable(
                name: "Route",
                columns : table => new {
                    RouteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                        Name = table.Column<string>(type: "VARCHAR(25)", nullable : true),
                        Routerlink = table.Column<string>(type: "VARCHAR(25)", nullable : true),
                        Details = table.Column<string>(type: "VARCHAR(100)", nullable : true),
                        NavOrder = table.Column<int>(nullable: false)
                },
                constraints : table => {
                    table.PrimaryKey("PK_Route", x => x.RouteID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(
                name: "Route");

            migrationBuilder.CreateTable(
                name: "NavRoute",
                columns : table => new {
                    NavRouteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                        Details = table.Column<string>(type: "VARCHAR(100)", nullable : true),
                        Name = table.Column<string>(type: "VARCHAR(25)", nullable : true),
                        NavOrder = table.Column<int>(nullable: false),
                        Routerlink = table.Column<string>(type: "VARCHAR(25)", nullable : true)
                },
                constraints : table => {
                    table.PrimaryKey("PK_NavRoute", x => x.NavRouteID);
                });
        }
    }
}