using SistemaDeGestaoDeEstoquePro.Data;
using SistemaDeGestaoDeEstoquePro.Models;
using SistemaDeGestaoDeEstoquePro.ViewModel;

namespace SistemaDeGestaoDeEstoquePro.Service.Admin
{
    public class AdminService : AdminInterface
    {
        private readonly ApplicationDbContext _context;
        public AdminService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<ProdutoModel> RegistrarProdutos(ProdutosViewModel produtoModel)
        {
            try
            {
                var NovoProduto = new ProdutoModel
                {
                    NomeDoProduto = produtoModel.NomeDoProduto,
                    DescricaoDoProduto = produtoModel.DescricaoDoProduto,
                    PrecoProduto = produtoModel.PrecoProduto,
                    QuantidadeActual = produtoModel.QuantidadeActual,
                    CategoriaId = produtoModel.CategoriaId,
                    EstadoProduto = true
                };

                _context.Produto.Add(NovoProduto);
                await _context.SaveChangesAsync();

                return NovoProduto;


            }catch(Exception erro)
            {
                throw;
            }
        }
    }
}
