using Microsoft.AspNetCore.Mvc;
using CalculadoraContaminacionRios.Models;
using CalculadoraContaminacionRios.Services;

namespace CalculadoraContaminacionRios.Controllers
{
    public class HomeController : Controller
    {
        private readonly ContaminacionService _contaminacionService;

        public HomeController(ContaminacionService contaminacionService)
        {
            _contaminacionService = contaminacionService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(ContaminacionModel model)
        {
            if (ModelState.IsValid)
            {
                var resultado = _contaminacionService.CalcularContaminacion(model);
                return View("Index", resultado);
            }
            return View("Index", model);
        }
    }
}