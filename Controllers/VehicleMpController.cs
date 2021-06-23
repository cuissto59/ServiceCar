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
    public class VehicleMpController : Controller
    {
        private readonly servicecarContext _context;

        public VehicleMpController(servicecarContext context)
        {
            _context = context;
        }

        // GET: VehicleMp
        public async Task<IActionResult> Index()
        {
            if (TempData["iduser"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            
            var servicecarContext = _context.VehicleMaintenancePlan.Include(v => v.IdVehicleMpNavigation);
            return View(await servicecarContext.ToListAsync());
        }

        // GET: VehicleMp/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (TempData["iduser"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            if (id == null)
            {
                return NotFound();
            }

            var vehicleMaintenancePlan = await _context.VehicleMaintenancePlan
                .Include(v => v.IdVehicleMpNavigation)
                .FirstOrDefaultAsync(m => m.IdVehicleMp == id);
            if (vehicleMaintenancePlan == null)
            {
                return NotFound();
            }

            return View(vehicleMaintenancePlan);
        }

        // GET: VehicleMp/Create
        public IActionResult Create()
        {
            if (TempData["iduser"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else if((bool)TempData["isadmin"]){
                return RedirectToAction("DisplayCon", "Admin",new {Id=(int)TempData["iduser"] });
            }
            ViewData["IdVehicleMp"] = new SelectList(_context.Vehicle, "IdVehicle", "Description");
            return View();
        }

        // POST: VehicleMp/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVehicleMp,Description")] VehicleMaintenancePlan vehicleMaintenancePlan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicleMaintenancePlan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdVehicleMp"] = new SelectList(_context.Vehicle, "IdVehicle", "Description", vehicleMaintenancePlan.IdVehicleMp);
            return View(vehicleMaintenancePlan);
        }

        // GET: VehicleMp/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (TempData["iduser"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else if((bool)TempData["isadmin"]){
                return RedirectToAction("DisplayCon", "Admin",new {Id=(int)TempData["iduser"] });
            }
            if (id == null)
            {
                return NotFound();
            }

            var vehicleMaintenancePlan = await _context.VehicleMaintenancePlan.FindAsync(id);
            if (vehicleMaintenancePlan == null)
            {
                return NotFound();
            }
            ViewData["IdVehicleMp"] = new SelectList(_context.Vehicle, "IdVehicle", "Description", vehicleMaintenancePlan.IdVehicleMp);
            return View(vehicleMaintenancePlan);
        }

        // POST: VehicleMp/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdVehicleMp,Description")] VehicleMaintenancePlan vehicleMaintenancePlan)
        {
            if (id != vehicleMaintenancePlan.IdVehicleMp)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicleMaintenancePlan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleMaintenancePlanExists(vehicleMaintenancePlan.IdVehicleMp))
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
            ViewData["IdVehicleMp"] = new SelectList(_context.Vehicle, "IdVehicle", "Description", vehicleMaintenancePlan.IdVehicleMp);
            return View(vehicleMaintenancePlan);
        }

        // GET: VehicleMp/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (TempData["iduser"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else if((bool)TempData["isadmin"]){
                return RedirectToAction("DisplayCon", "Admin",new {Id=(int)TempData["iduser"] });
            }
            if (id == null)
            {
                return NotFound();
            }

            var vehicleMaintenancePlan = await _context.VehicleMaintenancePlan
                .Include(v => v.IdVehicleMpNavigation)
                .FirstOrDefaultAsync(m => m.IdVehicleMp == id);
            if (vehicleMaintenancePlan == null)
            {
                return NotFound();
            }

            return View(vehicleMaintenancePlan);
        }

        // POST: VehicleMp/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicleMaintenancePlan = await _context.VehicleMaintenancePlan.FindAsync(id);
            _context.VehicleMaintenancePlan.Remove(vehicleMaintenancePlan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool VehicleMaintenancePlanExists(int id)
        {
            return _context.VehicleMaintenancePlan.Any(e => e.IdVehicleMp == id);
        }
    }
}
