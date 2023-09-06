using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicStore.Data.Migrations
{
    public partial class fixplaylist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlaylistId",
                table: "Song",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Playlist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlist", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Song_AlbumId",
                table: "Song",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_PlaylistId",
                table: "Song",
                column: "PlaylistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Album_AlbumId",
                table: "Song",
                column: "AlbumId",
                principalTable: "Album",
                principalColumn: "AlbumId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Playlist_PlaylistId",
                table: "Song",
                column: "PlaylistId",
                principalTable: "Playlist",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Song_Album_AlbumId",
                table: "Song");

            migrationBuilder.DropForeignKey(
                name: "FK_Song_Playlist_PlaylistId",
                table: "Song");

            migrationBuilder.DropTable(
                name: "Playlist");

            migrationBuilder.DropIndex(
                name: "IX_Song_AlbumId",
                table: "Song");

            migrationBuilder.DropIndex(
                name: "IX_Song_PlaylistId",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "PlaylistId",
                table: "Song");
        }
    }
}
