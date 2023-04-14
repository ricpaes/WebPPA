using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class TiposaidaController : Controller
    {
        // GET: TiposaidaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TiposaidaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TiposaidaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TiposaidaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TiposaidaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TiposaidaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TiposaidaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TiposaidaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
