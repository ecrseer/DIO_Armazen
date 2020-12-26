using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DIO_Armazen.Models;

namespace DIO_Armazen.Controllers
{
    public class UtilitariosController : Controller
    {
        private readonly Context _context;

        public UtilitariosController(Context context)
        {
            _context = context;
        }

        // GET: Utilitarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Utilitarios.ToListAsync());
        }

        // GET: Utilitarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utilitario = await _context.Utilitarios
                .FirstOrDefaultAsync(m => m.id == id);
            if (utilitario == null)
            {
                return NotFound();
            }

            return View(utilitario);
        }

        // GET: Utilitarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Utilitarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,descricao")] Utilitario utilitario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(utilitario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(utilitario);
        }

        // GET: Utilitarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utilitario = await _context.Utilitarios.FindAsync(id);
            if (utilitario == null)
            {
                return NotFound();
            }
            return View(utilitario);
        }

        // POST: Utilitarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,descricao")] Utilitario utilitario)
        {
            if (id != utilitario.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(utilitario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UtilitarioExists(utilitario.id))
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
            return View(utilitario);
        }

        // GET: Utilitarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utilitario = await _context.Utilitarios
                .FirstOrDefaultAsync(m => m.id == id);
            if (utilitario == null)
            {
                return NotFound();
            }

            return View(utilitario);
        }

        // POST: Utilitarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var utilitario = await _context.Utilitarios.FindAsync(id);
            _context.Utilitarios.Remove(utilitario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UtilitarioExists(int id)
        {
            return _context.Utilitarios.Any(e => e.id == id);
        }
    }
}
