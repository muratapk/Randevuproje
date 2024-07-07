using denemproje.Data;
using denemproje.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace denemproje.Controllers
{
    public class RenklerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RenklerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RenklersController
        public ActionResult Index()
        {
            var liste = _context.Renklers.ToList();
            return View(liste);
        }

        // GET: RenklersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RenklersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RenklersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Renkler gelen)
        {
            try
            {
                _context.Renklers.Add(gelen);
                _context.SaveChanges();
                TempData["Success"] = "Success";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                TempData["Error"] = "Error";
                return View();
            }
        }

        // GET: RenklersController/Edit/5
        public ActionResult Edit(int id)
        {
            var getir = _context.Renklers.Find(id);
            return View(getir);
        }

        // POST: RenklersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Renkler gelen)
        {
            try
            {
                //var bul = _context.Renklers.Where(x => x.KategoriId == gelen.KategoriId).FirstOrDefault();
                _context.Renklers.Update(gelen);
                _context.SaveChanges();
                TempData["Success"] = "Success";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                TempData["Error"] = "Error";
                return View();
            }
        }

        // GET: RenklersController/Delete/5
        public ActionResult Delete(int id)
        {
            var bul = _context.Renklers.Find(id);
            return View(bul);
        }

        // POST: RenklersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Renkler gelen)
        {
            try
            {
                _context.Renklers.Remove(gelen);
                _context.SaveChanges();
                TempData["Success"] = "Success";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                TempData["Error"] = "Error";
                return View();
            }
        }
    }
}
