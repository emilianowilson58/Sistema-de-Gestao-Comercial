namespace SistemaDeGestaoDeEstoquePro.Models
{
    public class PagamentoModel
    {
        public int Id { get; set; }
        public DateTime DataPagamento { get; set; }
        public double valorPago { get; set; }
        public string MetodoPagamento { get; set; } = string.Empty;
        //(como dinheiro, transferência ou multicaixa)
        public string EstadoPagamento { get; set; } = string.Empty;
        //(pago, pendente, ou parcial)
        public bool EstadoPgamento { get; set; }
        public string Observacao { get; set; } = string.Empty;
        public int CompraId { get; set; } /*Fk*/

    }
}
