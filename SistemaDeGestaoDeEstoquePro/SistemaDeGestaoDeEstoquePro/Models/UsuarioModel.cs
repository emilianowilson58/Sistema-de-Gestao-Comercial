using Microsoft.EntityFrameworkCore;

namespace SistemaDeGestaoDeEstoquePro.Models
{
    [Index(nameof(NomeUsuario), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    [Index(nameof(Telefone), IsUnique = true)]
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string NomeUsuario { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public byte SenhaHash { get; set; }
        public byte SenhaSolt { get; set; }
        public string Foto { get; set; } = string.Empty;
        public DateTime DataCadastro { get; set; }
        public string Role { get; set; } = string.Empty;
        public bool EstadoUsuario { get; set; } = false;
    }
}
