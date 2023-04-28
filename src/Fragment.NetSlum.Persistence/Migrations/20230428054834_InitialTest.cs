﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fragment.NetSlum.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "player_accounts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    save_id = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_player_accounts", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "characters",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    player_account_id = table.Column<int>(type: "int", nullable: false),
                    character_name = table.Column<string>(type: "longtext", nullable: false, collation: "sjis_japanese_ci")
                        .Annotation("MySql:CharSet", "sjis"),
                    greeting_message = table.Column<string>(type: "longtext", nullable: false, collation: "sjis_japanese_ci")
                        .Annotation("MySql:CharSet", "sjis"),
                    save_slot_id = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    current_level = table.Column<int>(type: "int", nullable: false),
                    full_model_id = table.Column<uint>(type: "int unsigned", nullable: false),
                    @class = table.Column<byte>(name: "class", type: "tinyint unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_characters", x => x.id);
                    table.ForeignKey(
                        name: "fk_characters_player_accounts_player_account_id",
                        column: x => x.player_account_id,
                        principalTable: "player_accounts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "character_currencies",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    character_id = table.Column<int>(type: "int", nullable: false),
                    gold_amount = table.Column<int>(type: "int", nullable: false),
                    silver_amount = table.Column<int>(type: "int", nullable: false),
                    bronze_amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_character_currencies", x => x.id);
                    table.ForeignKey(
                        name: "fk_character_currencies_characters_character_id",
                        column: x => x.character_id,
                        principalTable: "characters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "character_stats",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    character_id = table.Column<int>(type: "int", nullable: false),
                    current_hp = table.Column<int>(type: "int", nullable: false),
                    current_sp = table.Column<int>(type: "int", nullable: false),
                    current_gp = table.Column<uint>(type: "int unsigned", nullable: false),
                    god_online = table.Column<int>(type: "int", nullable: false),
                    god_offline = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_character_stats", x => x.id);
                    table.ForeignKey(
                        name: "fk_character_stats_characters_character_id",
                        column: x => x.character_id,
                        principalTable: "characters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "ix_character_currencies_character_id",
                table: "character_currencies",
                column: "character_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_character_stats_character_id",
                table: "character_stats",
                column: "character_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_characters_player_account_id",
                table: "characters",
                column: "player_account_id");

            migrationBuilder.CreateIndex(
                name: "ix_player_accounts_save_id",
                table: "player_accounts",
                column: "save_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "character_currencies");

            migrationBuilder.DropTable(
                name: "character_stats");

            migrationBuilder.DropTable(
                name: "characters");

            migrationBuilder.DropTable(
                name: "player_accounts");
        }
    }
}
