namespace SistemaDeGestaoDeEstoquePro.Models
{
    public class EstoqueModel
    {
        public int Id { get; set; }
        public int ProdutosId { get; set; }/* FK*/
        public int QuantidadeAtual { get; set; }
        public int QuantidadeMinima { get; set; }
        public int QuantidadeMaxima { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public string Localizacao { get; set; } = string.Empty;
        public bool EstadoEstoque { get; set; }

    }
}
