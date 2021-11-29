using Microsoft.EntityFrameworkCore.Migrations;

namespace helloaspnet.Migrations
{
    public partial class AddRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Sellers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SellerId",
                table: "SalesRecords",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_DepartmentId",
                table: "Sellers",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesRecords_SellerId",
                table: "SalesRecords",
                column: "SellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecords_Sellers_SellerId",
                table: "SalesRecords",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sellers_Departments_DepartmentId",
                table: "Sellers",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecords_Sellers_SellerId",
                table: "SalesRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_Sellers_Departments_DepartmentId",
                table: "Sellers");

            migrationBuilder.DropIndex(
                name: "IX_Sellers_DepartmentId",
                table: "Sellers");

            migrationBuilder.DropIndex(
                name: "IX_SalesRecords_SellerId",
                table: "SalesRecords");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "SalesRecords");
        }
    }
}
