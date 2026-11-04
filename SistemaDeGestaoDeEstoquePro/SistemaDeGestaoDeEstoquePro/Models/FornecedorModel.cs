namespace SistemaDeGestaoDeEstoquePro.Models
{
    public class FornecedorModel
    {
        public int Id { get; set; }
        public string NomeFornecedor { get; set; } = string.Empty;
        public string TelefoneFornecedor { get; set; } = string.Empty;
        public string EmailFornecedor { get; set; } = string.Empty;

        //Propriedade de navegação
        public IEnumerable<CompraModel> Compra { get; set; }

    }
}
