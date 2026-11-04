namespace SistemaDeGestaoDeEstoquePro.Models
{
    public class ItemVendaModel
    {
        public int Id { get; set; }
        public int VendaId { get; set; } /*FK*/
        public int ProdutoId { get; set; } /*FK*/
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }
        public int Subtotal { get; set; }

    }
}
