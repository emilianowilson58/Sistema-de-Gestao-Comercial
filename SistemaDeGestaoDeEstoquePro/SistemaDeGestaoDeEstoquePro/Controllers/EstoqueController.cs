using Microsoft.AspNetCore.Mvc;
using SistemaDeGestaoDeEstoquePro.Service.Estoque;
using SistemaDeGestaoDeEstoquePro.ViewModel;

namespace SistemaDeGestaoDeEstoquePro.Controllers
{
    public class EstoqueController : Controller
    {
        private readonly EstoqueInterface _estoqueInterface;
        public EstoqueController(EstoqueInterface estoqueInterface)
        {
            _estoqueInterface = estoqueInterface;
        }
        public async Task<IActionResult> Estoque()
        {
            ViewBag.TotalProdutos = await _estoqueInterface.TotalProdutos();
            ViewBag.TotalEstoqueBaixo = await _estoqueInterface.TotalProdutosEstoqueBaixo();
            ViewBag.TotalEsgotado = await _estoqueInterface.TotalEstoqueEsgotado();
            ViewBag.TotalUnidades = await _estoqueInterface.TotalUnidades();
            ViewBag.ProdutosBaixo = await _estoqueInterface.ListaDosProdutosBaixo();


            return View();
        }

        public IActionResult RegistrarEntrarda()
        {
            return View();
        }



        public async Task<IActionResult> RegistraSaida()
        {
            ViewBag.TotalProdutos = await _estoqueInterface.TotalProdutos();
            ViewBag.TotalEstoqueBaixo = await _estoqueInterface.TotalProdutosEstoqueBaixo();
            ViewBag.TotalEsgotado = await _estoqueInterface.TotalEstoqueEsgotado();
            ViewBag.TotalUnidades = await _estoqueInterface.TotalUnidades();

            

            return View();
        }

        public IActionResult MovimentacaoEntrarda()
        {
            return View();
        }

        public IActionResult MovimentacaoSaida()
        {
            return View();
        }

        public IActionResult MovimentacaoAjuste()
        {
            return View();
        }
        public async Task<IActionResult> ConsultarEstoque(string Pesquisar, int categoriaid)
        {
            var listarItems = await _estoqueInterface.TodosProdutos();

            //Cartões de resumo de dados
            ViewBag.TotalProdutos = await _estoqueInterface.TotalProdutos();
            ViewBag.TotalEstoqueBaixo = await _estoqueInterface.TotalProdutosEstoqueBaixo();
            ViewBag.TotalEsgotado = await _estoqueInterface.TotalEstoqueEsgotado();
            ViewBag.TotalUnidades = await _estoqueInterface.TotalUnidades();

            //Categoria da tela de produtos
            ViewBag.Categorias = await _estoqueInterface.Categorias();

            var ViewModel = new ProdutosViewModel();

            if (!string.IsNullOrEmpty(Pesquisar))
            {
                listarItems = listarItems.Where(produto => produto.NomeDoProduto.Contains(Pesquisar) && produto.Categoria.Id == (categoriaid)).ToList();
            }

            ViewModel.Pesquisar = Pesquisar;
            ViewModel.Produtos = listarItems;
            return View(ViewModel);

        }

        public IActionResult EstoqueBaixo()
        {
            return View();
        }

        public IActionResult AjusteEstoque()
        {
            return View();
        }


        //HttpPost
        [HttpPost]
        public async Task<IActionResult> RegistrarEntrarda(ProdutosViewModel DadosProduto)
        {
            if (!ModelState.IsValid)
            {
                return View(DadosProduto);
            }

            var update = await _estoqueInterface.RegistrarEntradas(DadosProduto);
            return View();
        }
    }
}