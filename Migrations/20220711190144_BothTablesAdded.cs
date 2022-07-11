using Microsoft.EntityFrameworkCore.Migrations;

namespace LumiaProject.Migrations
{
    public partial class BothTablesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "Testimonials",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Testimonials",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Testimonials",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "Testimonials",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Positions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Testimonials_PositionId",
                table: "Testimonials",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Testimonials_Positions_PositionId",
                table: "Testimonials",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Testimonials_Positions_PositionId",
                table: "Testimonials");

            migrationBuilder.DropIndex(
                name: "IX_Testimonials_PositionId",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "Desc",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Positions");
        }
    }
}
