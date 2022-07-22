using Microsoft.AspNetCore.Mvc;

namespace Propuesta.Controllers
{
    public class ComentariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
