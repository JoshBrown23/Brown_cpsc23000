using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_MonsterHunter.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hunters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HunterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HunterRank = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hunters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeaponClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DamageValue = table.Column<int>(type: "int", nullable: false),
                    DamageMultiplier = table.Column<double>(type: "float", nullable: false),
                    MotionValue = table.Column<double>(type: "float", nullable: false),
                    SharpnessColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SharpnessMultiplier = table.Column<double>(type: "float", nullable: false),
                    Rank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HunterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapons_Hunters_HunterId",
                        column: x => x.HunterId,
                        principalTable: "Hunters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_HunterId",
                table: "Weapons",
                column: "HunterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Hunters");
        }
    }
}
