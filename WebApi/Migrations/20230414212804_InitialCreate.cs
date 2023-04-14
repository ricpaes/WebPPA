using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MODELODOCUMENTO",
                columns: table => new
                {
                    MODG_ID = table.Column<int>(type: "integer", nullable: false),
                    MODG_TITULO = table.Column<string>(type: "text", nullable: true),
                    MODG_TEXTO = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: true),
                    MODG_LOGDATAHORA = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    MODG_USER = table.Column<int>(type: "integer", nullable: true),
                    MODG_STATUS = table.Column<char>(type: "char", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("MODELOGUIA_pkey", x => x.MODG_ID);
                },
                comment: "Modelos de documentos, guias, notas fiscais, emails, etc");

            migrationBuilder.CreateTable(
                name: "SETOR",
                columns: table => new
                {
                    SET_ID = table.Column<int>(type: "integer", nullable: false),
                    SET_NOME = table.Column<string>(type: "text", nullable: false),
                    SET_RESPONSAVEL = table.Column<int>(type: "integer", nullable: true),
                    SET_LOGDATAHORA = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    SET_USER = table.Column<int>(type: "integer", nullable: true),
                    SET_STATUS = table.Column<char>(type: "char", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SETOR_pkey", x => x.SET_ID);
                });

            migrationBuilder.CreateTable(
                name: "SYSTEMUSER",
                columns: table => new
                {
                    SUSR_ID = table.Column<decimal>(type: "numeric", nullable: false),
                    SUSR_NOME = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    SUSR_LOGIN = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    SUSR_SENHA = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    SUSR_LOGDATAHORA = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    SUSR_STATUS = table.Column<char>(type: "char", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYSTEMUSER_pkey", x => x.SUSR_ID);
                });

            migrationBuilder.CreateTable(
                name: "TIPOACAO",
                columns: table => new
                {
                    TPA_ID = table.Column<int>(type: "integer", nullable: false),
                    TPA_DESCRICAO = table.Column<string>(type: "text", nullable: false),
                    TPA_LOGDATAHORA = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    TPA_USER = table.Column<int>(type: "integer", nullable: true),
                    TPA_STATUS = table.Column<char>(type: "char", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TIPOACAO_pkey", x => x.TPA_ID);
                });

            migrationBuilder.CreateTable(
                name: "TIPOLINHAPRODUTO",
                columns: table => new
                {
                    TLP_ID = table.Column<int>(type: "integer", nullable: false),
                    TLP_DESCRICAO = table.Column<string>(type: "text", nullable: false),
                    TLP_LOGDATAHORA = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    TLP_USER = table.Column<int>(type: "integer", nullable: true),
                    TLP_STATUS = table.Column<char>(type: "char", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TIPOLINHAPRODUTO_pkey", x => x.TLP_ID);
                });

            migrationBuilder.CreateTable(
                name: "TIPOPARAMETROMODELO",
                columns: table => new
                {
                    TPPM_ID = table.Column<int>(type: "integer", nullable: false),
                    TPPM_NOME = table.Column<string>(type: "text", nullable: false),
                    TPPM_TABELA = table.Column<string>(type: "text", nullable: false),
                    TPPM_COLUNA = table.Column<string>(type: "text", nullable: false),
                    TPPM_LOGDATAHORA = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    TPPM_USER = table.Column<int>(type: "integer", nullable: true),
                    TPPM_STATUS = table.Column<char>(type: "char", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TIPOPARAMETROMODELO_pkey", x => x.TPPM_ID);
                },
                comment: "tabela com lista de parâmetros que podem ser usados nos modelos de email, guia e outros.");

            migrationBuilder.CreateTable(
                name: "TIPOSAIDA",
                columns: table => new
                {
                    TPS_ID = table.Column<int>(type: "integer", nullable: false),
                    TPS_DESCRICAO = table.Column<string>(type: "text", nullable: false),
                    TPS_LOGDATAHORA = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    TPS_USER = table.Column<int>(type: "integer", nullable: true),
                    TPS_STATUS = table.Column<char>(type: "char", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TIPOSAIDA_pkey", x => x.TPS_ID);
                });

            migrationBuilder.CreateTable(
                name: "PESSOA",
                columns: table => new
                {
                    PES_IS = table.Column<int>(type: "integer", nullable: false),
                    PES_NOME = table.Column<string>(type: "text", nullable: false),
                    PES_CPF = table.Column<int>(type: "integer", nullable: true),
                    PES_EMAIL = table.Column<string>(type: "text", nullable: true),
                    SET_ID = table.Column<int>(type: "integer", nullable: true),
                    PES_LOGDATAHORA = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    PES_USER = table.Column<int>(type: "integer", nullable: true),
                    PES_STATUS = table.Column<char>(type: "char", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PESSOA_pkey", x => x.PES_IS);
                    table.ForeignKey(
                        name: "FK_PESSOA_SETOR",
                        column: x => x.SET_ID,
                        principalTable: "SETOR",
                        principalColumn: "SET_ID");
                });

            migrationBuilder.CreateTable(
                name: "WORKFLOW",
                columns: table => new
                {
                    WRK_ID = table.Column<int>(type: "integer", nullable: false),
                    WRK_DESCRICAO = table.Column<string>(type: "text", nullable: true),
                    TLP_ID = table.Column<int>(type: "integer", nullable: false),
                    TPA_ID = table.Column<int>(type: "integer", nullable: false),
                    TPS_ID = table.Column<int>(type: "integer", nullable: false),
                    WRK_SEQUENCIA = table.Column<int>(type: "integer", nullable: false),
                    WRK_DESTINO = table.Column<int>(type: "integer", nullable: true),
                    WRK_AGUARDARAPROVACAO = table.Column<bool>(type: "boolean", nullable: true),
                    WRK_POSSUIMODELO = table.Column<bool>(type: "boolean", nullable: true),
                    MODG_ID = table.Column<int>(type: "integer", nullable: true),
                    WRK_DATAINICIO = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WRK_DATAFIM = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WRK_LOGDATAHORA = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WRK_USER = table.Column<int>(type: "integer", nullable: true),
                    WRK_STATUS = table.Column<char>(type: "char", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("WORKFLOW_pkey", x => x.WRK_ID);
                    table.ForeignKey(
                        name: "FK_WORKFLOW_MODG_ID",
                        column: x => x.MODG_ID,
                        principalTable: "MODELODOCUMENTO",
                        principalColumn: "MODG_ID");
                    table.ForeignKey(
                        name: "FK_WORKFLOW_SET_ID",
                        column: x => x.WRK_DESTINO,
                        principalTable: "SETOR",
                        principalColumn: "SET_ID");
                    table.ForeignKey(
                        name: "FK_WORKFLOW_TLP_ID",
                        column: x => x.TLP_ID,
                        principalTable: "TIPOLINHAPRODUTO",
                        principalColumn: "TLP_ID");
                    table.ForeignKey(
                        name: "FK_WORKFLOW_TPA_ID",
                        column: x => x.TPA_ID,
                        principalTable: "TIPOACAO",
                        principalColumn: "TPA_ID");
                    table.ForeignKey(
                        name: "FK_WORKFLOW_TPS_ID",
                        column: x => x.TPS_ID,
                        principalTable: "TIPOSAIDA",
                        principalColumn: "TPS_ID");
                },
                comment: "Tabela com os terefas que de devem ser realizadas para cada linha de produto e ação");

            migrationBuilder.CreateIndex(
                name: "IX_PESSOA_SET_ID",
                table: "PESSOA",
                column: "SET_ID");

            migrationBuilder.CreateIndex(
                name: "IX_WORKFLOW_MODG_ID",
                table: "WORKFLOW",
                column: "MODG_ID");

            migrationBuilder.CreateIndex(
                name: "IX_WORKFLOW_TLP_ID",
                table: "WORKFLOW",
                column: "TLP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_WORKFLOW_TPA_ID",
                table: "WORKFLOW",
                column: "TPA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_WORKFLOW_TPS_ID",
                table: "WORKFLOW",
                column: "TPS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_WORKFLOW_WRK_DESTINO",
                table: "WORKFLOW",
                column: "WRK_DESTINO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PESSOA");

            migrationBuilder.DropTable(
                name: "SYSTEMUSER");

            migrationBuilder.DropTable(
                name: "TIPOPARAMETROMODELO");

            migrationBuilder.DropTable(
                name: "WORKFLOW");

            migrationBuilder.DropTable(
                name: "MODELODOCUMENTO");

            migrationBuilder.DropTable(
                name: "SETOR");

            migrationBuilder.DropTable(
                name: "TIPOLINHAPRODUTO");

            migrationBuilder.DropTable(
                name: "TIPOACAO");

            migrationBuilder.DropTable(
                name: "TIPOSAIDA");
        }
    }
}
