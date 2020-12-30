using Microsoft.EntityFrameworkCore.Migrations;

namespace CarDealer.Data.Migrations
{
    public partial class UpdateSoldCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Cars_CarId",
                table: "Invoices");

            migrationBuilder.DropTable(
                name: "InvoiceOption");

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Sold",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "InvoiceOptionModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    OptionId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceOptionModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceOptionModel_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceOptionModel_Option_OptionId",
                        column: x => x.OptionId,
                        principalTable: "Option",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceOptionModel_InvoiceId",
                table: "InvoiceOptionModel",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceOptionModel_OptionId",
                table: "InvoiceOptionModel",
                column: "OptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Cars_CarId",
                table: "Invoices",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Cars_CarId",
                table: "Invoices");

            migrationBuilder.DropTable(
                name: "InvoiceOptionModel");

            migrationBuilder.DropColumn(
                name: "Sold",
                table: "Cars");

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "Invoices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "InvoiceOption",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    OptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceOption_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceOption_Option_OptionId",
                        column: x => x.OptionId,
                        principalTable: "Option",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceOption_InvoiceId",
                table: "InvoiceOption",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceOption_OptionId",
                table: "InvoiceOption",
                column: "OptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Cars_CarId",
                table: "Invoices",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
