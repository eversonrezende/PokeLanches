using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokeLanches.Migrations
{
    public partial class PopularLanchesV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Lilligant Floral Tea','Original blended tea. The soothing scent has calming benefits, just like the flower on Lilligants head.',1, 'https://archives.bulbagarden.net/media/upload/a/aa/Caf%C3%A9_ReMix_Lilligant_Floral_Tea.png','https://archives.bulbagarden.net/media/upload/a/aa/Caf%C3%A9_ReMix_Lilligant_Floral_Tea.png', 0, 'Lilligant Floral Tea', 11.00)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Fluffy Eevee Pancakes','The whipped cream (as fluffy as Eevees fur!) is a huge hit. Pure delight until the very last bite!',1,'https://archives.bulbagarden.net/media/upload/c/c6/Caf%C3%A9_ReMix_Fluffy_Eevee_Pancakes.png','https://archives.bulbagarden.net/media/upload/c/c6/Caf%C3%A9_ReMix_Fluffy_Eevee_Pancakes.png', 0, 'Fluffy Eevee Pancakes', 12.00)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(2,'Dugtrio Sandwich Trio','A signature latte with a comforting flavor. Enjoy the cute latte art of Eevee!',1,'https://archives.bulbagarden.net/media/upload/f/f8/Caf%C3%A9_ReMix_Dugtrio_Sandwich_Trio.png','https://archives.bulbagarden.net/media/upload/f/f8/Caf%C3%A9_ReMix_Dugtrio_Sandwich_Trio.png', 1, 'Dugtrio Sandwich Trio', 7.50)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
