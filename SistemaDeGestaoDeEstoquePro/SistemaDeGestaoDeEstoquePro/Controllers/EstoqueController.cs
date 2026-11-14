using Microsoft.AspNetCore.Mvc;
using SistemaDeGestaoDeEstoquePro.Service.Estoque;

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
        public async Task<IActionResult> ConsultarEstoque()
        {
            ViewBag.TotalProdutos = await _estoqueInterface.TotalProdutos();
            ViewBag.TotalEstoqueBaixo = await _estoqueInterface.TotalProdutosEstoqueBaixo();
            ViewBag.TotalEsgotado = await _estoqueInterface.TotalEstoqueEsgotado();
            ViewBag.TotalUnidades = await _estoqueInterface.TotalUnidades();
            return View();
        }

        public IActionResult EstoqueBaixo()
        {
            return View();
        }

        public IActionResult AjusteEstoque()
        {
            return View();
        }
    }
}