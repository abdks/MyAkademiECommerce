using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAkademiECommerce.Discount.Migrations
{
    public partial class mig_Add_dene2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Coupons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Coupons");
        }
    }
}
