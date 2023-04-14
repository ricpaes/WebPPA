using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class TipolinhaprodutoController : Controller
    {
        // GET: TipolinhaprodutoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TipolinhaprodutoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TipolinhaprodutoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipolinhaprodutoController/Create
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

        // GET: TipolinhaprodutoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipolinhaprodutoController/Edit/5
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

        // GET: TipolinhaprodutoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipolinhaprodutoController/Delete/5
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
