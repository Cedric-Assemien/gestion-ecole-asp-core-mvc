using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GRP7_GestionEcole.Data;
using GRP7_GestionEcole.Models.ENTITIES;

namespace GRP7_GestionEcole.Views
{
    public class CahierdetextesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CahierdetextesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cahierdetextes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cahierdetexte.ToListAsync());
        }

        // GET: Cahierdetextes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cahierdetexte = await _context.Cahierdetexte
                .FirstOrDefaultAsync(m => m.IDCahierdeTexte == id);
            if (cahierdetexte == null)
            {
                return NotFound();
            }

            return View(cahierdetexte);
        }

        // GET: Cahierdetextes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cahierdetextes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDCahierdeTexte,NomProf,NomCours,HeureCours")] Cahierdetexte cahierdetexte)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cahierdetexte);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cahierdetexte);
        }

        // GET: Cahierdetextes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cahierdetexte = await _context.Cahierdetexte.FindAsync(id);
            if (cahierdetexte == null)
            {
                return NotFound();
            }
            return View(cahierdetexte);
        }

        // POST: Cahierdetextes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDCahierdeTexte,NomProf,NomCours,HeureCours")] Cahierdetexte cahierdetexte)
        {
            if (id != cahierdetexte.IDCahierdeTexte)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cahierdetexte);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CahierdetexteExists(cahierdetexte.IDCahierdeTexte))
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
            return View(cahierdetexte);
        }

        // GET: Cahierdetextes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cahierdetexte = await _context.Cahierdetexte
                .FirstOrDefaultAsync(m => m.IDCahierdeTexte == id);
            if (cahierdetexte == null)
            {
                return NotFound();
            }

            return View(cahierdetexte);
        }

        // POST: Cahierdetextes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cahierdetexte = await _context.Cahierdetexte.FindAsync(id);
            if (cahierdetexte != null)
            {
                _context.Cahierdetexte.Remove(cahierdetexte);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CahierdetexteExists(int id)
        {
            return _context.Cahierdetexte.Any(e => e.IDCahierdeTexte == id);
        }
    }
}
