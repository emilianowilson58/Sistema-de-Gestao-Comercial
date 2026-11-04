namespace SistemaDeGestaoDeEstoquePro.Models
{
    public class ItemCompraModel
    {
        public int Id { get; set; }
        public int CompraId { get; set; } /*FK*/
        public int ProdutoId { get; set; } /*FK*/
        public int Quantidade { get; set; }
        public double PrecoCompra { get; set; }
        public int SubTotal { get; set; }

    }
}
