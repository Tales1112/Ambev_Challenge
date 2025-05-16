using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ambev.DeveloperEvaluation.ORM.Migrations
{
    /// <inheritdoc />
    public partial class InsertDefaultUserAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PurchaseStatus",
                table: "Carts",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Carts",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedById",
                table: "Carts",
                type: "uuid",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PurchaseStatus",
                table: "CartItems",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "CartItems",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedById",
                table: "CartItems",
                type: "uuid",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Password", "Phone", "Role", "Status", "UpdatedAt", "Username" },
                values: new object[] { new Guid("90b65dcd-3e65-4ffc-ab6f-5b88578dd818"), new DateTime(2025, 5, 16, 10, 15, 54, 457, DateTimeKind.Utc).AddTicks(2735), "admin@gmail.com", "$2a$11$uXrL7R90QQ4G1bILyQjFNeoFZZPXG2hDtW37kp2fN.5Gpc5Zg1Qv2", "51981344567", "Admin", "Active", null, "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_DeletedById",
                table: "Carts",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_DeletedById",
                table: "CartItems",
                column: "DeletedById");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Users_DeletedById",
                table: "CartItems",
                column: "DeletedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_DeletedById",
                table: "Carts",
                column: "DeletedById",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Users_DeletedById",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_DeletedById",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_DeletedById",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_DeletedById",
                table: "CartItems");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("90b65dcd-3e65-4ffc-ab6f-5b88578dd818"));

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "CartItems");

            migrationBuilder.AlterColumn<int>(
                name: "PurchaseStatus",
                table: "Carts",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<int>(
                name: "PurchaseStatus",
                table: "CartItems",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);
        }
    }
}
