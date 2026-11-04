namespace SistemaDeGestaoDeEstoquePro.Models
{
    public class CompraModel
    {
        public int Id { get; set; }
        public DateTime DataCompra { get; set; }
        public double ValorTotal { get; set; }
        public bool EstadoCompra { get; set; } = false;
        public string Observacao { get; set; } = string.Empty;
        public int FornecedorId { get; set; } /*FK*/
        public int UsuarioId { get; set; } /*FK*/

        public IEnumerable<ItemCompraModel> itemCompraModels { get; set; }

    }
}
