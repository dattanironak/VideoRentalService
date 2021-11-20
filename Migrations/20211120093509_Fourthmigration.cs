using Microsoft.EntityFrameworkCore.Migrations;

namespace VRSystem.Migrations
{
    public partial class Fourthmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Uid",
                table: "Subscriptions",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_AspNetUsers_Uid",
                table: "Subscriptions");

            migrationBuilder.DropIndex(
                name: "IX_Subscriptions_Uid",
                table: "Subscriptions");

            migrationBuilder.AlterColumn<int>(
                name: "Uid",
                table: "Subscriptions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
