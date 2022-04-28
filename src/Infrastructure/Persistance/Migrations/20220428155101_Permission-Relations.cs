using Microsoft.EntityFrameworkCore.Migrations;

namespace N5.Persistance.Migrations
{
    public partial class PermissionRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Permission_PermissionTypeId",
                table: "Permission",
                column: "PermissionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Permission_PermissionType_PermissionTypeId",
                table: "Permission",
                column: "PermissionTypeId",
                principalTable: "PermissionType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permission_PermissionType_PermissionTypeId",
                table: "Permission");

            migrationBuilder.DropIndex(
                name: "IX_Permission_PermissionTypeId",
                table: "Permission");
        }
    }
}
