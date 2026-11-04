using SistemaDeGestaoDeEstoquePro.Models;
using SistemaDeGestaoDeEstoquePro.ViewModel;

namespace SistemaDeGestaoDeEstoquePro.Service.Admin
{
    public interface AdminInterface
    {
        Task<ProdutoModel> RegistrarProdutos(ProdutosViewModel produtoModel);
    }
}
