using Gerenciador_de_tarefas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Gerenciador_de_tarefas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult Apagar()
        {
            return View();
        }
    }
}
