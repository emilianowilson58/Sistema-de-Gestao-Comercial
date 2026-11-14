using Microsoft.AspNetCore.Mvc;
using SistemaDeGestaoDeEstoquePro.Models;
using SistemaDeGestaoDeEstoquePro.Service.Admin;
using SistemaDeGestaoDeEstoquePro.ViewModel;

namespace SistemaDeGestaoDeEstoquePro.Controllers
{
    public class AdminController : Controller
    {
        private readonly AdminInterface _adminInterface;
        public AdminController(AdminInterface adminInterface)
        {
            _adminInterface = adminInterface;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegistrarProdutos()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegistrarProdutos(ProdutosViewModel produtoModel)
        {
            if (ModelState.IsValid)
            {
                var Registrar = await _adminInterface.RegistrarProdutos(produtoModel);

                return RedirectToAction("Estoque", "Estoque");
            }

            return View();
        }
    }
}