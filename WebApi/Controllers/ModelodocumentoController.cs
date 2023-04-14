using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class ModelodocumentoController : Controller
    {
        // GET: ModelodocumentoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ModelodocumentoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ModelodocumentoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ModelodocumentoController/Create
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

        // GET: ModelodocumentoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ModelodocumentoController/Edit/5
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

        // GET: ModelodocumentoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ModelodocumentoController/Delete/5
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
