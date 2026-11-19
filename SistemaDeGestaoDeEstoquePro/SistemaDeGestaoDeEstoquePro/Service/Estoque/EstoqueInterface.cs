using SistemaDeGestaoDeEstoquePro.Models;
using SistemaDeGestaoDeEstoquePro.ViewModel;

namespace SistemaDeGestaoDeEstoquePro.Service.Estoque
{
    public interface EstoqueInterface
    {
        Task<List<ProdutoModel>> TodosProdutos();
        Task<int> TotalProdutos();
        Task<int> TotalProdutosEstoqueBaixo();
        Task<int> TotalEstoqueEsgotado();
        Task<int> TotalUnidades();
        Task<List<CategoriaModel>> Categorias();
        Task <List<ProdutoModel>> ListaDosProdutosBaixo();

        Task<ProdutoModel?> RegistrarEntradas(ProdutosViewModel DadosProduto);
    }
}