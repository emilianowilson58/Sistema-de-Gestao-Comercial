namespace SistemaDeGestaoDeEstoquePro.Models
{
    public class MovimentoEstoqueModel
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public string TipoMovimento { get; set; } = string.Empty;
        public string Observacao { get; set; } = string.Empty;
        /*Observação(explicar o motivo do ajuste ou de um movimento de uma saída extraordinária)*/
        public DateTime DataMovimento { get; set; }
        public int ProdutoId { get; set; } /*Fk*/
        public int UsuarioId { get; set; } /*Fk*/

    }
}
