using SistemaDeGestaoDeEstoquePro.Models;

namespace SistemaDeGestaoDeEstoquePro.ViewModel
{
    public class ProdutosViewModel
    {
        public string NomeDoProduto { get; set; } = string.Empty;
        public string DescricaoDoProduto { get; set; } = string.Empty;
        public double PrecoProduto { get; set; }
        public int QuantidadeActual { get; set; }
        public int QuantidadeMinima { get; set; }
        public string Pesquisar { get; set; } = string.Empty;
        public ICollection<ProdutoModel> Produtos { get; set; } = new List<ProdutoModel>();
        public ICollection<CategoriaModel> Categorias { get; set; } = new List<CategoriaModel>();
        public bool EstadoProduto { get; set; } = false;
        public int CategoriaId { get; set; }/*FK*/
        //Propriedade de navegação
        //public CategoriaModel? Categoria { get; set; } /*Navegation*/
    }
}

//public string Nome_Produto { get; set; } = string.Empty;
//public int TotalProdutos { get; set; }



