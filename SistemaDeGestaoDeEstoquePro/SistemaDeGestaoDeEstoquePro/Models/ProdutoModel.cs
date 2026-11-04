namespace SistemaDeGestaoDeEstoquePro.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string NomeDoProduto { get; set; } = string.Empty;
        public string DescricaoDoProduto { get; set; } = string.Empty;
        public double PrecoProduto { get; set; }

        public int QuantidadeActual { get; set; }
        public string ImagemProdutoUrl { get; set; } = string.Empty;
        public bool EstadoProduto { get; set; } = false;
        public int FornecedorId { get; set; } /*FK*/
        //chave estrageira
        public int CategoriaId { get; set; }/*FK*/
        //Propriedade de navegação
        public CategoriaModel? Categoria { get; set; } /*Navegation*/
        public IEnumerable<ItemCompraModel> itemCompraModels { get; set; }

    }
}
