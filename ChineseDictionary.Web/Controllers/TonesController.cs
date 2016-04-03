using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using ChineseDictionary.Web.Models;

namespace ChineseDictionary.Web.Controllers
{
    public class TonesController : Controller
    {
        private ApplicationDbContext _context;

        public TonesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Tones
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tones.ToListAsync());
        }

        // GET: Tones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Tone tone = await _context.Tones.SingleAsync(m => m.Id == id);
            if (tone == null)
            {
                return HttpNotFound();
            }

            return View(tone);
        }

        // GET: Tones/Create
        public IActionResult Create()
        {
            ViewBag.Areas = new SelectList(_context.Areas, "Id", "Name");
            ViewBag.ToneTypes = new SelectList(_context.ToneTypes, "Id", "Name");
            return View();
        }

        // POST: Tones/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Tone tone)
        {
            if (ModelState.IsValid)
            {
                _context.Tones.Add(tone);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tone);
        }

        // GET: Tones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Tone tone = await _context.Tones.SingleAsync(m => m.Id == id);
            if (tone == null)
            {
                return HttpNotFound();
            }
            return View(tone);
        }

        // POST: Tones/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Tone tone)
        {
            if (ModelState.IsValid)
            {
                _context.Update(tone);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tone);
        }

        // GET: Tones/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Tone tone = await _context.Tones.SingleAsync(m => m.Id == id);
            if (tone == null)
            {
                return HttpNotFound();
            }

            return View(tone);
        }

        // POST: Tones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Tone tone = await _context.Tones.SingleAsync(m => m.Id == id);
            _context.Tones.Remove(tone);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
