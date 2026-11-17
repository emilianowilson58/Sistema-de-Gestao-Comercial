using SistemaDeGestaoDeEstoquePro.Models;

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
    }
}