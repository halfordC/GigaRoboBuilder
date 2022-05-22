using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class BuildSystem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pilot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Heart = table.Column<int>(type: "INTEGER", nullable: false),
                    Rage = table.Column<int>(type: "INTEGER", nullable: false),
                    Power = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxFightingSpirit = table.Column<int>(type: "INTEGER", nullable: false),
                    MainImage = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pilot", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PilotAbility",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PilotId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Rules = table.Column<string>(type: "TEXT", nullable: true),
                    MainArtImage = table.Column<string>(type: "TEXT", nullable: true),
                    LogoImage = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PilotAbility", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Robot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Speed = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxArmour = table.Column<int>(type: "INTEGER", nullable: false),
                    Defence = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Robot", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Builds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BuildOwnerId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    ChosenRobotId = table.Column<int>(type: "INTEGER", nullable: true),
                    ChosenPilotId = table.Column<int>(type: "INTEGER", nullable: true),
                    ChosenPilotAbilityId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Builds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Builds_Pilot_ChosenPilotId",
                        column: x => x.ChosenPilotId,
                        principalTable: "Pilot",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Builds_PilotAbility_ChosenPilotAbilityId",
                        column: x => x.ChosenPilotAbilityId,
                        principalTable: "PilotAbility",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Builds_Robot_ChosenRobotId",
                        column: x => x.ChosenRobotId,
                        principalTable: "Robot",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Builds_Users_BuildOwnerId",
                        column: x => x.BuildOwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PilotCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PilotId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    Cost = table.Column<int>(type: "INTEGER", nullable: false),
                    Cooldown = table.Column<int>(type: "INTEGER", nullable: false),
                    MinRange = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxRange = table.Column<int>(type: "INTEGER", nullable: false),
                    Requirements = table.Column<string>(type: "TEXT", nullable: true),
                    Rules = table.Column<string>(type: "TEXT", nullable: true),
                    MainArtImage = table.Column<string>(type: "TEXT", nullable: true),
                    CooldownImage = table.Column<string>(type: "TEXT", nullable: true),
                    DiceImage = table.Column<string>(type: "TEXT", nullable: true),
                    TypeImage = table.Column<string>(type: "TEXT", nullable: true),
                    LogoImage = table.Column<string>(type: "TEXT", nullable: true),
                    BuildId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PilotCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PilotCard_Builds_BuildId",
                        column: x => x.BuildId,
                        principalTable: "Builds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RobotAbility",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RobotId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Rules = table.Column<string>(type: "TEXT", nullable: true),
                    PowerTokens = table.Column<int>(type: "INTEGER", nullable: false),
                    LogoImage = table.Column<string>(type: "TEXT", nullable: true),
                    BuildId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RobotAbility", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RobotAbility_Builds_BuildId",
                        column: x => x.BuildId,
                        principalTable: "Builds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RobotCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RobotId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Cost = table.Column<int>(type: "INTEGER", nullable: false),
                    IsUltimate = table.Column<bool>(type: "INTEGER", nullable: false),
                    CardType = table.Column<string>(type: "TEXT", nullable: true),
                    SubType = table.Column<string>(type: "TEXT", nullable: true),
                    Cooldown = table.Column<int>(type: "INTEGER", nullable: false),
                    BaseDamage = table.Column<int>(type: "INTEGER", nullable: false),
                    AttackDice = table.Column<int>(type: "INTEGER", nullable: false),
                    MinRange = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxRange = table.Column<int>(type: "INTEGER", nullable: false),
                    Requirements = table.Column<string>(type: "TEXT", nullable: true),
                    Rules = table.Column<string>(type: "TEXT", nullable: true),
                    MainArtImage = table.Column<string>(type: "TEXT", nullable: true),
                    CooldownImage = table.Column<string>(type: "TEXT", nullable: true),
                    DiceImage = table.Column<string>(type: "TEXT", nullable: true),
                    DamageImage = table.Column<string>(type: "TEXT", nullable: true),
                    TypeImage = table.Column<string>(type: "TEXT", nullable: true),
                    CounterImage = table.Column<string>(type: "TEXT", nullable: true),
                    ComboImage = table.Column<string>(type: "TEXT", nullable: true),
                    LogoImage = table.Column<string>(type: "TEXT", nullable: true),
                    BuildId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RobotCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RobotCard_Builds_BuildId",
                        column: x => x.BuildId,
                        principalTable: "Builds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Builds_BuildOwnerId",
                table: "Builds",
                column: "BuildOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_ChosenPilotAbilityId",
                table: "Builds",
                column: "ChosenPilotAbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_ChosenPilotId",
                table: "Builds",
                column: "ChosenPilotId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_ChosenRobotId",
                table: "Builds",
                column: "ChosenRobotId");

            migrationBuilder.CreateIndex(
                name: "IX_PilotCard_BuildId",
                table: "PilotCard",
                column: "BuildId");

            migrationBuilder.CreateIndex(
                name: "IX_RobotAbility_BuildId",
                table: "RobotAbility",
                column: "BuildId");

            migrationBuilder.CreateIndex(
                name: "IX_RobotCard_BuildId",
                table: "RobotCard",
                column: "BuildId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PilotCard");

            migrationBuilder.DropTable(
                name: "RobotAbility");

            migrationBuilder.DropTable(
                name: "RobotCard");

            migrationBuilder.DropTable(
                name: "Builds");

            migrationBuilder.DropTable(
                name: "Pilot");

            migrationBuilder.DropTable(
                name: "PilotAbility");

            migrationBuilder.DropTable(
                name: "Robot");
        }
    }
}
