namespace SistemaDeGestaoDeEstoquePro.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; } = string.Empty;
        public string EmailCliente { get; set; } = string.Empty;
        public string TelefoneCliente { get; set; } = string.Empty;
        public string EnderecoCliente { get; set; } = string.Empty;

    }
}
