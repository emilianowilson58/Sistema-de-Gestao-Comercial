using SistemaDeGestaoDeEstoquePro.Models;

namespace SistemaDeGestaoDeEstoquePro.Service.Estoque
{
    public interface EstoqueInterface
    {
        Task<int> TotalProdutos();
        Task<int> TotalProdutosEstoqueBaixo();
        Task<int> TotalEstoqueEsgotado();
        Task<int> TotalUnidades();
    }
}
