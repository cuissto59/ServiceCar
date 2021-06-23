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
    public class VehicleFuelController : Controller
    {
        private readonly servicecarContext _context;

        public VehicleFuelController(servicecarContext context)
        {
            _context = context;
        }

        // GET: VehicleFuel
        public async Task<IActionResult> Index()
        {
            var servicecarContext = _context.VehicleFuel.Include(v => v.IdSpFuNavigation);
            return View(await servicecarContext.ToListAsync());
        }

        // GET: VehicleFuel/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleFuel = await _context.VehicleFuel
                .Include(v => v.IdSpFuNavigation)
                .FirstOrDefaultAsync(m => m.IdSpFu == id);
            if (vehicleFuel == null)
            {
                return NotFound();
            }

            return View(vehicleFuel);
        }

        // GET: VehicleFuel/Create
        public IActionResult Create()
        {
            ViewData["IdSpFu"] = new SelectList(_context.VehicleSpending, "IdSp", "Type");
            return View();
        }

        // POST: VehicleFuel/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdSpFu,Quantity")] VehicleFuel vehicleFuel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicleFuel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdSpFu"] = new SelectList(_context.VehicleSpending, "IdSp", "Type", vehicleFuel.IdSpFu);
            return View(vehicleFuel);
        }

        // GET: VehicleFuel/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleFuel = await _context.VehicleFuel.FindAsync(id);
            if (vehicleFuel == null)
            {
                return NotFound();
            }
            ViewData["IdSpFu"] = new SelectList(_context.VehicleSpending, "IdSp", "Type", vehicleFuel.IdSpFu);
            return View(vehicleFuel);
        }

        // POST: VehicleFuel/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdSpFu,Quantity")] VehicleFuel vehicleFuel)
        {
            if (id != vehicleFuel.IdSpFu)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicleFuel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleFuelExists(vehicleFuel.IdSpFu))
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
            ViewData["IdSpFu"] = new SelectList(_context.VehicleSpending, "IdSp", "Type", vehicleFuel.IdSpFu);
            return View(vehicleFuel);
        }

        // GET: VehicleFuel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleFuel = await _context.VehicleFuel
                .Include(v => v.IdSpFuNavigation)
                .FirstOrDefaultAsync(m => m.IdSpFu == id);
            if (vehicleFuel == null)
            {
                return NotFound();
            }

            return View(vehicleFuel);
        }

        // POST: VehicleFuel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicleFuel = await _context.VehicleFuel.FindAsync(id);
            _context.VehicleFuel.Remove(vehicleFuel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleFuelExists(int id)
        {
            return _context.VehicleFuel.Any(e => e.IdSpFu == id);
        }
    }
}
