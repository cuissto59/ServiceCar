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
    public class VehicleSpendingController : Controller
    {
        private readonly servicecarContext _context;

        public VehicleSpendingController(servicecarContext context)
        {
            _context = context;
        }

        // GET: VehicleSpending
        public async Task<IActionResult> Index()
        {
            if(HttpContext.Session.GetInt32("iduser") == 0)
            {
                return RedirectToAction("Login", "Home");
            }

            var servicecarContext = _context.VehicleSpending.Include(v => v.IdConductorSpNavigation).Include(v => v.IdVehicleSpNavigation);
            return View(await servicecarContext.ToListAsync());
        }

        // GET: VehicleSpending/Details/5
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

            var vehicleSpending = await _context.VehicleSpending
                .Include(v => v.IdConductorSpNavigation)
                .Include(v => v.IdVehicleSpNavigation)
                .FirstOrDefaultAsync(m => m.IdSp == id);
            if (vehicleSpending == null)
            {
                return NotFound();
            }

            return View(vehicleSpending);
        }

        // GET: VehicleSpending/Create
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

            ViewData["IdConductorSp"] = new SelectList(_context.Conductor, "User", "Adress");
            ViewData["IdVehicleSp"] = new SelectList(_context.Vehicle, "IdVehicle", "Description");
            return View();
        }

        // POST: VehicleSpending/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdSp,IdVehicleSp,IdConductorSp,DateSp,TimeSp,Type,Amount")] VehicleSpending vehicleSpending)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicleSpending);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdConductorSp"] = new SelectList(_context.Conductor, "User", "Adress", vehicleSpending.IdConductorSp);
            ViewData["IdVehicleSp"] = new SelectList(_context.Vehicle, "IdVehicle", "Description", vehicleSpending.IdVehicleSp);
            return View(vehicleSpending);
        }

        // GET: VehicleSpending/Edit/5
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

            var vehicleSpending = await _context.VehicleSpending.FindAsync(id);
            if (vehicleSpending == null)
            {
                return NotFound();
            }
            ViewData["IdConductorSp"] = new SelectList(_context.Conductor, "User", "Adress", vehicleSpending.IdConductorSp);
            ViewData["IdVehicleSp"] = new SelectList(_context.Vehicle, "IdVehicle", "Description", vehicleSpending.IdVehicleSp);
            return View(vehicleSpending);
        }

        // POST: VehicleSpending/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdSp,IdVehicleSp,IdConductorSp,DateSp,TimeSp,Type,Amount")] VehicleSpending vehicleSpending)
        {
            if (id != vehicleSpending.IdSp)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicleSpending);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleSpendingExists(vehicleSpending.IdSp))
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
            ViewData["IdConductorSp"] = new SelectList(_context.Conductor, "User", "Adress", vehicleSpending.IdConductorSp);
            ViewData["IdVehicleSp"] = new SelectList(_context.Vehicle, "IdVehicle", "Description", vehicleSpending.IdVehicleSp);
            return View(vehicleSpending);
        }

        // GET: VehicleSpending/Delete/5
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


            var vehicleSpending = await _context.VehicleSpending
                .Include(v => v.IdConductorSpNavigation)
                .Include(v => v.IdVehicleSpNavigation)
                .FirstOrDefaultAsync(m => m.IdSp == id);
            if (vehicleSpending == null)
            {
                return NotFound();
            }

            return View(vehicleSpending);
        }

        // POST: VehicleSpending/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicleSpending = await _context.VehicleSpending.FindAsync(id);
            _context.VehicleSpending.Remove(vehicleSpending);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleSpendingExists(int id)
        {
            return _context.VehicleSpending.Any(e => e.IdSp == id);
        }
    }
}
