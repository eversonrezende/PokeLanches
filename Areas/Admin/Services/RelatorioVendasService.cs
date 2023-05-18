using Microsoft.EntityFrameworkCore;
using PokeLanches.Context;
using PokeLanches.Models;

namespace PokeLanches.Areas.Admin.Services
{
    public class RelatorioVendasService
    {
        private readonly AppDbContext appDbContext;

        public RelatorioVendasService(AppDbContext _appDbContext)
        {
            appDbContext = _appDbContext;
        }

        public async Task<List<Pedido>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var resultado = from obj in appDbContext.Pedidos select obj;

            if (minDate.HasValue)
            {
                resultado = resultado.Where(x => x.PedidoEnviado >= minDate.Value);
            }

            if (maxDate.HasValue)
            {
                resultado = resultado.Where(x => x.PedidoEnviado <= maxDate.Value);
            }

            return await resultado
                    .Include(l => l.PedidoItens)
                    .ThenInclude(l => l.Lanche)
                    .OrderByDescending(x => x.PedidoEnviado)
                    .ToListAsync();
        }
    }
}
