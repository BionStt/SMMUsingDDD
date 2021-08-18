using Microsoft.EntityFrameworkCore.Migrations;

namespace Smm.ContohMvcCQRS.Data.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "WelcomeEmailWasSent",
                table: "DataKonsumen",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WelcomeEmailWasSent",
                table: "DataKonsumen");
        }
    }
}
