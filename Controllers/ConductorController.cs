using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using serviceCar.Models.DbModels;

namespace serviceCar.Controllers
{
    public class ConductorController : Controller
    {
        private readonly servicecarContext _context;

        public ConductorController(servicecarContext context)
        {
            _context = context;
        }

        // GET: Conductor
        public async Task<IActionResult> Index()
        {
            var servicecarContext = _context.Conductor.Include(c => c.UserNavigation);
            return View(await servicecarContext.ToListAsync());
        }

        // GET: Conductor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conductor = await _context.Conductor
                .Include(c => c.UserNavigation)
                .FirstOrDefaultAsync(m => m.User == id);
            if (conductor == null)
            {
                return NotFound();
            }

            return View(conductor);
        }

        // GET: Conductor/Create
        public IActionResult Create()
        {
            ViewData["User"] = new SelectList(_context.User, "IdUser", "FName");
            return View();
        }

        // POST: Conductor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("User,Cin,TelephoneNumber,Adress,Active")] Conductor conductor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(conductor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["User"] = new SelectList(_context.User, "IdUser", "FName", conductor.User);
            return View(conductor);
        }

        // GET: Conductor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conductor = await _context.Conductor.FindAsync(id);
            if (conductor == null)
            {
                return NotFound();
            }
            ViewData["User"] = new SelectList(_context.User, "IdUser", "FName", conductor.User);
            return View(conductor);
        }

        // POST: Conductor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("User,Cin,TelephoneNumber,Adress,Active")] Conductor conductor)
        {
            if (id != conductor.User)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(conductor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConductorExists(conductor.User))
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
            ViewData["User"] = new SelectList(_context.User, "IdUser", "FName", conductor.User);
            return View(conductor);
        }

        // GET: Conductor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conductor = await _context.Conductor
                .Include(c => c.UserNavigation)
                .FirstOrDefaultAsync(m => m.User == id);
            if (conductor == null)
            {
                return NotFound();
            }

            return View(conductor);
        }

        // POST: Conductor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var conductor = await _context.Conductor.FindAsync(id);
            _context.Conductor.Remove(conductor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConductorExists(int id)
        {
            return _context.Conductor.Any(e => e.User == id);
        }
    }
}
