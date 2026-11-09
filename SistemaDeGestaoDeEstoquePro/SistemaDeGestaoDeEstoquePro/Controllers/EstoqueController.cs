using Microsoft.AspNetCore.Mvc;

namespace SistemaDeGestaoDeEstoquePro.Controllers
{
    public class EstoqueController : Controller
    {
        public IActionResult Estoque()
        {
            return View();
        }

        public IActionResult RegistrarEntrarda()
        {
            return View();
        }

        public IActionResult RegistraSaida()
        {
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
        public IActionResult ConsultarEstoque()
        {
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