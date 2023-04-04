using PokeLanches.Models;

namespace PokeLanches.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
