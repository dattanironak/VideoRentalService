using Microsoft.EntityFrameworkCore.Migrations;

namespace VRSystem.Migrations
{
    public partial class FifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_AspNetUsers_Uid",
                table: "Subscriptions");

            migrationBuilder.DropIndex(
                name: "IX_Subscriptions_Uid",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "Uid",
                table: "Subscriptions");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Subscriptions",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Subscriptions");

            migrationBuilder.AddColumn<string>(
                name: "Uid",
                table: "Subscriptions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_Uid",
                table: "Subscriptions",
                column: "Uid");

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_AspNetUsers_Uid",
                table: "Subscriptions",
                column: "Uid",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
