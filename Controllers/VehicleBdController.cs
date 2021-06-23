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
    public class VehicleBdController : Controller
    {
        private readonly servicecarContext _context;

        public VehicleBdController(servicecarContext context)
        {
            _context = context;
        }

        // GET: VehicleBd
        public async Task<IActionResult> Index()
        {
            if (TempData["iduser"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            var servicecarContext = _context.VehicleBreakdown.Include(v => v.IdVehicleBdNavigation);
            return View(await servicecarContext.ToListAsync());
        }

        // GET: VehicleBd/Details/5
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

            var vehicleBreakdown = await _context.VehicleBreakdown
                .Include(v => v.IdVehicleBdNavigation)
                .FirstOrDefaultAsync(m => m.IdBreakdown == id);
            if (vehicleBreakdown == null)
            {
                return NotFound();
            }

            return View(vehicleBreakdown);
        }

        // GET: VehicleBd/Create
        public IActionResult Create()
        {
            if (TempData["iduser"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else if((bool)TempData["isadmin"]){
                return RedirectToAction("DisplayCon", "Admin",new {Id=(int)TempData["iduser"] });
            }
            
            ViewData["IdVehicleBd"] = new SelectList(_context.Vehicle, "IdVehicle", "Description");
            return View();
        }

        // POST: VehicleBd/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdBreakdown,IdVehicleBd,Problem,Description")] VehicleBreakdown vehicleBreakdown)
        {
            
            if (ModelState.IsValid)
            {
                _context.Add(vehicleBreakdown);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdVehicleBd"] = new SelectList(_context.Vehicle, "IdVehicle", "Description", vehicleBreakdown.IdVehicleBd);
            return View(vehicleBreakdown);
        }

        // GET: VehicleBd/Edit/5
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

            var vehicleBreakdown = await _context.VehicleBreakdown.FindAsync(id);
            if (vehicleBreakdown == null)
            {
                return NotFound();
            }
            ViewData["IdVehicleBd"] = new SelectList(_context.Vehicle, "IdVehicle", "Description", vehicleBreakdown.IdVehicleBd);
            return View(vehicleBreakdown);
        }

        // POST: VehicleBd/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdBreakdown,IdVehicleBd,Problem,Description")] VehicleBreakdown vehicleBreakdown)
        {
            if (id != vehicleBreakdown.IdBreakdown)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicleBreakdown);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleBreakdownExists(vehicleBreakdown.IdBreakdown))
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
            ViewData["IdVehicleBd"] = new SelectList(_context.Vehicle, "IdVehicle", "Description", vehicleBreakdown.IdVehicleBd);
            return View(vehicleBreakdown);
        }

        // GET: VehicleBd/Delete/5
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

            var vehicleBreakdown = await _context.VehicleBreakdown
                .Include(v => v.IdVehicleBdNavigation)
                .FirstOrDefaultAsync(m => m.IdBreakdown == id);
            if (vehicleBreakdown == null)
            {
                return NotFound();
            }

            return View(vehicleBreakdown);
        }

        // POST: VehicleBd/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicleBreakdown = await _context.VehicleBreakdown.FindAsync(id);
            _context.VehicleBreakdown.Remove(vehicleBreakdown);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleBreakdownExists(int id)
        {
            return _context.VehicleBreakdown.Any(e => e.IdBreakdown == id);
        }
    }
}
