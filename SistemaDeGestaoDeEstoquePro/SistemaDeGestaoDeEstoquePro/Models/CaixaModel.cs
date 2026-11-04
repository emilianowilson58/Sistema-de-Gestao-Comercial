namespace SistemaDeGestaoDeEstoquePro.Models
{
    public class CaixaModel
    {
        public int Id { get; set; }
        //(qual caixa está a ser usado exemplo caixa 2)
        public string NomeCaixa { get; set; } = string.Empty;
        //(exemplo CX002 ou CX003)
        public string Codigo { get; set; } = string.Empty;
        public string Localizacao { get; set; } = string.Empty;
        public bool EstadoCaixa { get; set; } = false;

    }
}
