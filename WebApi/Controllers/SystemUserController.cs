using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class SystemUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
