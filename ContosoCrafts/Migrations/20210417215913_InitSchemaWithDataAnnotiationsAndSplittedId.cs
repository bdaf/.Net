using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoCrafts.Migrations
{
    public partial class InitSchemaWithDataAnnotiationsAndSplittedId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Maker = table.Column<string>(maxLength: 250, nullable: false),
                    Image = table.Column<string>(type: "varchar(600)", maxLength: 600, nullable: false),
                    Url = table.Column<string>(type: "varchar(600)", maxLength: 600, nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
