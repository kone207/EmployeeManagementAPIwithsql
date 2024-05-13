using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTable_Address_AddressStreet",
                table: "EmployeeTable");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeTable_AddressStreet",
                table: "EmployeeTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "AddressStreet",
                table: "EmployeeTable");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "AddressTable");

            migrationBuilder.AlterColumn<string>(
                name: "Department",
                table: "EmployeeTable",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Contact",
                table: "EmployeeTable",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Addressid",
                table: "EmployeeTable",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Surbub",
                table: "AddressTable",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "AddressTable",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "AddressTable",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "AddressTable",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddressTable",
                table: "AddressTable",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTable_Addressid",
                table: "EmployeeTable",
                column: "Addressid");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTable_AddressTable_Addressid",
                table: "EmployeeTable",
                column: "Addressid",
                principalTable: "AddressTable",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTable_AddressTable_Addressid",
                table: "EmployeeTable");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeTable_Addressid",
                table: "EmployeeTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddressTable",
                table: "AddressTable");

            migrationBuilder.DropColumn(
                name: "Addressid",
                table: "EmployeeTable");

            migrationBuilder.DropColumn(
                name: "id",
                table: "AddressTable");

            migrationBuilder.RenameTable(
                name: "AddressTable",
                newName: "Address");

            migrationBuilder.AlterColumn<string>(
                name: "Department",
                table: "EmployeeTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Contact",
                table: "EmployeeTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressStreet",
                table: "EmployeeTable",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Surbub",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Address",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Street");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTable_AddressStreet",
                table: "EmployeeTable",
                column: "AddressStreet");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTable_Address_AddressStreet",
                table: "EmployeeTable",
                column: "AddressStreet",
                principalTable: "Address",
                principalColumn: "Street",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
