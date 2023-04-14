using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class PessoaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
