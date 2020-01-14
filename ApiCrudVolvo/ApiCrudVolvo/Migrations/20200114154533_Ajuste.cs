using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiCrudVolvo.Migrations
{
    public partial class Ajuste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    IdStatus = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.IdStatus);
                });

            migrationBuilder.CreateTable(
                name: "Caminhao",
                columns: table => new
                {
                    IdCaminhao = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 50, nullable: false),
                    AnoFabricacao = table.Column<DateTime>(nullable: false),
                    AnoModelo = table.Column<DateTime>(nullable: false),
                    CorCaminhao = table.Column<string>(nullable: false),
                    IdStatus = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caminhao", x => x.IdCaminhao);
                    table.ForeignKey(
                        name: "FK_Caminhao_Status_IdStatus",
                        column: x => x.IdStatus,
                        principalTable: "Status",
                        principalColumn: "IdStatus",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "IdStatus", "Descricao" },
                values: new object[] { 100, "Liberabo" });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "IdStatus", "Descricao" },
                values: new object[] { 101, "Bloqueado" });

            migrationBuilder.CreateIndex(
                name: "IX_Caminhao_IdStatus",
                table: "Caminhao",
                column: "IdStatus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Caminhao");

            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
