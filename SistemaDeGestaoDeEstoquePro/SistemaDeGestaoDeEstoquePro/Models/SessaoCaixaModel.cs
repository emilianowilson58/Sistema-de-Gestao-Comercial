namespace SistemaDeGestaoDeEstoquePro.Models
{
    public class SessaoCaixaModel
    {
        public int Id { get; set; }
        public DateTime DataFechamento { get; set; }
        public DateTime DataAbertura { get; set; }
        public double SaldoInicial { get; set; }
        public double SaldoFinal { get; set; }
        public double TotalEntrada { get; set; }
        public double TotalVendas { get; set; }
        public double TotalDespesas { get; set; }
        public bool EstadoSessaoCaixa { get; set; } = false;


        public int CaixaId { get; set; } /*Fk*/
        public int UsuarioId { get; set; } /*Fk*/

    }
}
