using Microsoft.EntityFrameworkCore.Migrations;

namespace FizzBuzz_Web.Migrations
{
    public partial class AddingfieldAuthortoFizzBuzz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "FizzBuzz_Data",
                maxLength: 256,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "FizzBuzz_Data");
        }
    }
}
