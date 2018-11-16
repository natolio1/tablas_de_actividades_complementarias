using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using actividades_complementaria.Models;

namespace actividades_complementaria.Controllers
{
    public class OrganigramasController : Controller
    {
        private readonly actividades_complementariaContext _context;

        public OrganigramasController(actividades_complementariaContext context)
        {
            _context = context;
        }

        // GET: Organigramas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Organigrama.ToListAsync());
        }

        // GET: Organigramas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var organigrama = await _context.Organigrama
                .SingleOrDefaultAsync(m => m.idorganigrama == id);
            if (organigrama == null)
            {
                return NotFound();
            }

            return View(organigrama);
        }

        // GET: Organigramas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Organigramas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idorganigrama,area,descripcion,area_depende,nivel,tipo_area,titular")] Organigrama organigrama)
        {
            if (ModelState.IsValid)
            {
                _context.Add(organigrama);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(organigrama);
        }

        // GET: Organigramas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var organigrama = await _context.Organigrama.SingleOrDefaultAsync(m => m.idorganigrama == id);
            if (organigrama == null)
            {
                return NotFound();
            }
            return View(organigrama);
        }

        // POST: Organigramas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idorganigrama,area,descripcion,area_depende,nivel,tipo_area,titular")] Organigrama organigrama)
        {
            if (id != organigrama.idorganigrama)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(organigrama);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrganigramaExists(organigrama.idorganigrama))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(organigrama);
        }

        // GET: Organigramas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var organigrama = await _context.Organigrama
                .SingleOrDefaultAsync(m => m.idorganigrama == id);
            if (organigrama == null)
            {
                return NotFound();
            }

            return View(organigrama);
        }

        // POST: Organigramas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var organigrama = await _context.Organigrama.SingleOrDefaultAsync(m => m.idorganigrama == id);
            _context.Organigrama.Remove(organigrama);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrganigramaExists(int id)
        {
            return _context.Organigrama.Any(e => e.idorganigrama == id);
        }
    }
}
