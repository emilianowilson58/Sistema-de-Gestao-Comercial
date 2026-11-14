using Microsoft.EntityFrameworkCore;
using SistemaDeGestaoDeEstoquePro.Models;

namespace SistemaDeGestaoDeEstoquePro.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //gerar o acesso as entidade e a base de dados
        }

        //Permitir trabalhar com conjuntos de entidade (consulta e manipulação)

        public DbSet<CaixaModel> Caixa { get; set; }
        public DbSet<CategoriaModel> Categoria { get; set; }
        public DbSet<ClienteModel> Cliente { get; set; }
        public DbSet<CompraModel> Compra { get; set; }
        public DbSet<EstoqueModel> Estoque { get; set; }
        public DbSet<FornecedorModel> Fornecedor { get; set; }
        public DbSet<ItemCompraModel> ItemCompra { get; set; }
        public DbSet<ItemVendaModel> ItemVenda { get; set; }
        public DbSet<ProdutoModel> Produto { get; set; }
        public DbSet<PagamentoModel> Pagamento { get; set; }
        public DbSet<UsuarioModel> Usuario { get; set; }
        public DbSet<SessaoCaixaModel> SessaoCaixa { get; set; }
        public DbSet<VendaModel> Venda { get; set; }
        public DbSet<MovimentoEstoqueModel> MovimentoEstoque { get; set; }
    }
}
