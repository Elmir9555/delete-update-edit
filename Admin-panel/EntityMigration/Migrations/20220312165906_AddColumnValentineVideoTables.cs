using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityMigration.Migrations
{
    public partial class AddColumnValentineVideoTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Footer",
                table: "Valentines");

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Videos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LiOne",
                table: "Valentines",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LiSecond",
                table: "Valentines",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LiThird",
                table: "Valentines",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "LiOne",
                table: "Valentines");

            migrationBuilder.DropColumn(
                name: "LiSecond",
                table: "Valentines");

            migrationBuilder.DropColumn(
                name: "LiThird",
                table: "Valentines");

            migrationBuilder.AddColumn<string>(
                name: "Footer",
                table: "Valentines",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
