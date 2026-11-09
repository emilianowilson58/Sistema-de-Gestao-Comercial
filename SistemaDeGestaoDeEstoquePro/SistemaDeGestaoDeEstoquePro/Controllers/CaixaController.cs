using Microsoft.AspNetCore.Mvc;

namespace SistemaDeGestaoDeEstoquePro.Controllers
{
    public class CaixaController : Controller
    {
        public IActionResult HomeCaixa()
        {
            return View();
        }

        public IActionResult NovaVenda()
        {
            return View();
        }
    }
}
