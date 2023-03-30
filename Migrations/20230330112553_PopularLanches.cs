using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokeLanches.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Eevee Latte','A signature latte with a comforting flavor. Enjoy the cute latte art of Eevee!',1, 'https://archives.bulbagarden.net/media/upload/0/01/Caf%C3%A9_ReMix_Eevee_Latte.png','https://archives.bulbagarden.net/media/upload/0/01/Caf%C3%A9_ReMix_Eevee_Latte.png', 0, 'Eevee Latte', 8.00)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
