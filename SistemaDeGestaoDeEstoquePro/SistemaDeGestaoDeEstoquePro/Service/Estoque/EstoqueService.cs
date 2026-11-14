using Microsoft.EntityFrameworkCore;
using SistemaDeGestaoDeEstoquePro.Data;
using SistemaDeGestaoDeEstoquePro.Models;

namespace SistemaDeGestaoDeEstoquePro.Service.Estoque
{
    public class EstoqueService : EstoqueInterface
    {
        private readonly ApplicationDbContext _context;
        public EstoqueService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> TotalEstoqueEsgotado()
        {
            return await _context.Produto.Where(Esgotado => Esgotado.QuantidadeActual == 0).CountAsync();
        }

        public async Task<int> TotalProdutosEstoqueBaixo()
        {
            try
            {

                return await _context.Produto.Where(Quantidade => Quantidade.QuantidadeActual < 5).CountAsync();

            }catch(Exception ex)
            {
                throw;
            }
        }

        public async Task<int> TotalProdutos()
        {
            try
            {
                return await _context.Produto.CountAsync();

            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public async Task<int> TotalUnidades()
        {
            return await _context.Produto.SumAsync(Unidades => Unidades.QuantidadeActual);

        }
    }
}
