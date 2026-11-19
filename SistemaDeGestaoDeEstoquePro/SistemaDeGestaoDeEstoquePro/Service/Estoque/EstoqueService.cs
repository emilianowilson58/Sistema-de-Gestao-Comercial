using Microsoft.EntityFrameworkCore;
using SistemaDeGestaoDeEstoquePro.Data;
using SistemaDeGestaoDeEstoquePro.Models;
using SistemaDeGestaoDeEstoquePro.ViewModel;

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

        public async Task<List<ProdutoModel>> ListaDosProdutosBaixo()
        {
            try
            {
                return await _context.Produto.Where(produto => produto.QuantidadeActual < 5).Include(produto => produto.Categoria).ToListAsync();

            }catch(Exception erro)
            {
                throw;
            }
        }

        public async Task<List<ProdutoModel>> TodosProdutos()
        {
            try
            {
                return await _context.Produto.Include(p => p.Categoria).ToListAsync();

            }catch(Exception erro)
            {
                throw;
            }
        }

        public async Task<List<CategoriaModel>> Categorias()
        {
            var Categoria = await _context.Categoria.ToListAsync();

            return Categoria;
        }

        public async Task<ProdutoModel?> RegistrarEntradas(ProdutosViewModel DadosProduto)
        {
            
            try
            {
                var buscarProduto = await _context.Produto.FirstOrDefaultAsync(p => p.NomeDoProduto == DadosProduto.NomeDoProduto);

                if(buscarProduto == null)
                {
                    
                }

                buscarProduto.QuantidadeActual = DadosProduto.QuantidadeActual;

                _context.Update(buscarProduto);
                await _context.SaveChangesAsync();

                return buscarProduto;
            }
            catch(Exception erro)
            {
                throw;
            }
        }
    }
}
