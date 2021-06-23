using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using serviceCar.Models.DbModels;

namespace serviceCar.Controllers
{
    public class VehicleAccidentController : Controller
    {
        private readonly servicecarContext _context;

        public VehicleAccidentController(servicecarContext context)
        {
            _context = context;
        }

        // GET: VehicleAccident
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetInt32("iduser") == 0)
            {
                return RedirectToAction("Login", "Home");
            }
            
            var servicecarContext = _context.VehicleAccident.Include(v => v.IdVehicleAcNavigation);
            return View(await servicecarContext.ToListAsync());
        }

        // GET: VehicleAccident/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (HttpContext.Session.GetInt32("iduser") == 0)
            {
                return RedirectToAction("Login", "Home");
            }
            

            if (id == null)
            {
                return NotFound();
            }

            var vehicleAccident = await _context.VehicleAccident
                .Include(v => v.IdVehicleAcNavigation)
                .FirstOrDefaultAsync(m => m.IdVehicleAc == id);
            if (vehicleAccident == null)
            {
                return NotFound();
            }

            return View(vehicleAccident);
        }

        // GET: VehicleAccident/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.GetInt32("iduser") == 0)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (HttpContext.Session.GetString("isadmin") == "True")
            {

                return RedirectToAction("DisplayCon", "Admin", new { Id = HttpContext.Session.GetInt32("iduser") });
            
            }
            ViewData["IdVehicleAc"] = new SelectList(_context.Vehicle, "IdVehicle", "Description");
            return View();
        }

        // POST: VehicleAccident/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVehicleAc,Type,DamageDescription,WasInsured,Date")] VehicleAccident vehicleAccident)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicleAccident);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdVehicleAc"] = new SelectList(_context.Vehicle, "IdVehicle", "Description", vehicleAccident.IdVehicleAc);
            return View(vehicleAccident);
        }

        // GET: VehicleAccident/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

            if (HttpContext.Session.GetInt32("iduser") == 0)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (HttpContext.Session.GetString("isadmin") == "True")
            {

                return RedirectToAction("DisplayCon", "Admin", new { Id = HttpContext.Session.GetInt32("iduser") });

            }

            if (id == null)
            {
                return NotFound();
            }

            var vehicleAccident = await _context.VehicleAccident.FindAsync(id);
            if (vehicleAccident == null)
            {
                return NotFound();
            }
            ViewData["IdVehicleAc"] = new SelectList(_context.Vehicle, "IdVehicle", "Description", vehicleAccident.IdVehicleAc);
            return View(vehicleAccident);
        }

        // POST: VehicleAccident/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdVehicleAc,Type,DamageDescription,WasInsured,Date")] VehicleAccident vehicleAccident)
        {
            if (id != vehicleAccident.IdVehicleAc)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicleAccident);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleAccidentExists(vehicleAccident.IdVehicleAc))
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
            ViewData["IdVehicleAc"] = new SelectList(_context.Vehicle, "IdVehicle", "Description", vehicleAccident.IdVehicleAc);
            return View(vehicleAccident);
        }

        // GET: VehicleAccident/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetInt32("iduser") == 0)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (HttpContext.Session.GetString("isadmin") == "True")
            {

                return RedirectToAction("DisplayCon", "Admin", new { Id = HttpContext.Session.GetInt32("iduser") });

            }

            if (id == null)
            {
                return NotFound();
            }

            var vehicleAccident = await _context.VehicleAccident
                .Include(v => v.IdVehicleAcNavigation)
                .FirstOrDefaultAsync(m => m.IdVehicleAc == id);
            if (vehicleAccident == null)
            {
                return NotFound();
            }

            return View(vehicleAccident);
        }

        // POST: VehicleAccident/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicleAccident = await _context.VehicleAccident.FindAsync(id);
            _context.VehicleAccident.Remove(vehicleAccident);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleAccidentExists(int id)
        {
            return _context.VehicleAccident.Any(e => e.IdVehicleAc == id);
        }
    }
}
