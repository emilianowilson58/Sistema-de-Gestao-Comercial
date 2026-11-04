namespace SistemaDeGestaoDeEstoquePro.Models
{
    public class VendaModel
    {
        public int Id { get; set; }
        public int ClienteId { get; set; } /*FK*/
        public DateTime DataVenda { get; set; }
        public int UsuarioId { get; set; } /*FK*/
        public double ValorTotal { get; set; }
        public bool Estadovenda { get; set; } = false;
        public IEnumerable<ItemVendaModel> ItemVenda { get; set; }

    }
}
