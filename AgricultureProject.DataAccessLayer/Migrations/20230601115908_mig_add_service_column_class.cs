using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgricultureProject.DataAccessLayer.Migrations
{
    public partial class mig_add_service_column_class : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ServiceClass1",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServiceClass2",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceClass1",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ServiceClass2",
                table: "Services");
        }
    }
}
