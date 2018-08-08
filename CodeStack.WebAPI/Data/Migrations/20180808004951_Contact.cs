using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeStack.WebAPI.Migrations
{
    public partial class Contact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Data");

            migrationBuilder.CreateTable(
                name: "Contact",
                schema: "Data",
                columns: table => new
                {
                    ContactID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    LastName = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    EmailAddress = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    Message = table.Column<string>(type: "VARCHAR(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ContactID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact",
                schema: "Data");
        }
    }
}
