using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UdemyCarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_Sec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BannerID",
                table: "Cars");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BannerID",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
