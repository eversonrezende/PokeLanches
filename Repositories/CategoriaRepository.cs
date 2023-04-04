using PokeLanches.Context;
using PokeLanches.Models;
using PokeLanches.Repositories.Interfaces;

namespace PokeLanches.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
