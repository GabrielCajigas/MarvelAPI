using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace M_app.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MarvelImage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Path = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarvelImage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "elchar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Modified = table.Column<string>(nullable: true),
                    ResourceURI = table.Column<string>(nullable: true),
                    ThumbnailId = table.Column<int>(nullable: true),
                    usuarioUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_elchar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_elchar_MarvelImage_ThumbnailId",
                        column: x => x.ThumbnailId,
                        principalTable: "MarvelImage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_elchar_Users_usuarioUserId",
                        column: x => x.usuarioUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MarvelUrl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    CharacterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarvelUrl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarvelUrl_elchar_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "elchar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_elchar_ThumbnailId",
                table: "elchar",
                column: "ThumbnailId");

            migrationBuilder.CreateIndex(
                name: "IX_elchar_usuarioUserId",
                table: "elchar",
                column: "usuarioUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MarvelUrl_CharacterId",
                table: "MarvelUrl",
                column: "CharacterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarvelUrl");

            migrationBuilder.DropTable(
                name: "elchar");

            migrationBuilder.DropTable(
                name: "MarvelImage");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
