using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class TipoparametromodeloController : Controller
    {
        // GET: TipoparametromodeloController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TipoparametromodeloController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TipoparametromodeloController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoparametromodeloController/Create
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

        // GET: TipoparametromodeloController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoparametromodeloController/Edit/5
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

        // GET: TipoparametromodeloController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoparametromodeloController/Delete/5
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
