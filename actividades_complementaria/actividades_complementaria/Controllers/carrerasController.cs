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
    public class carrerasController : Controller
    {
        private readonly actividades_complementariaContext _context;

        public carrerasController(actividades_complementariaContext context)
        {
            _context = context;
        }

        // GET: carreras
        public async Task<IActionResult> Index()
        {
            return View(await _context.carrera.ToListAsync());
        }

        // GET: carreras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrera = await _context.carrera
                .SingleOrDefaultAsync(m => m.idcarrera == id);
            if (carrera == null)
            {
                return NotFound();
            }

            return View(carrera);
        }

        // GET: carreras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: carreras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idcarrera,Carrera,reticula,nivel_escolar,clave_oficial,nombre_carrera,nombre_reducido,carga_maxima,creditos_totales,nivel,modalidad")] Carrera carrera)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carrera);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carrera);
        }

        // GET: carreras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrera = await _context.carrera.SingleOrDefaultAsync(m => m.idcarrera == id);
            if (carrera == null)
            {
                return NotFound();
            }
            return View(carrera);
        }

        // POST: carreras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idcarrera,Carrera,reticula,nivel_escolar,clave_oficial,nombre_carrera,nombre_reducido,carga_maxima,creditos_totales,nivel,modalidad")] Carrera carrera)
        {
            if (id != carrera.idcarrera)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carrera);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!carreraExists(carrera.idcarrera))
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
            return View(carrera);
        }

        // GET: carreras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrera = await _context.carrera
                .SingleOrDefaultAsync(m => m.idcarrera == id);
            if (carrera == null)
            {
                return NotFound();
            }

            return View(carrera);
        }

        // POST: carreras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carrera = await _context.carrera.SingleOrDefaultAsync(m => m.idcarrera == id);
            _context.carrera.Remove(carrera);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool carreraExists(int id)
        {
            return _context.carrera.Any(e => e.idcarrera == id);
        }
    }
}
