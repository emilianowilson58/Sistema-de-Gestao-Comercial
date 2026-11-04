namespace SistemaDeGestaoDeEstoquePro.Models
{
    public class CategoriaModel
    {
        public int Id { get; set; }
        public string NomeCategoria { get; set; } = string.Empty;
        public bool EstadoCategoria { get; set; } = false;

        //Propriedade de navegação
        public IEnumerable<ProdutoModel> Produto { get; set; }

    }
}
