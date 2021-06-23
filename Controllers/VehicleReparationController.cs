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
    public class VehicleReparationController : Controller
    {
        private readonly servicecarContext _context;

        public VehicleReparationController(servicecarContext context)
        {
            _context = context;
        }

        // GET: VehicleReparation
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetInt32("iduser") == 0)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (HttpContext.Session.GetString("isadmin") != "True")
            {
                var vehiclefRepa = await _context.VehicleReparation
                .Include(v => v.IdVehicleReNavigation)
                .FirstOrDefaultAsync(m => m.IdVehicleReNavigation.VehicleConductor == HttpContext.Session.GetInt32("iduser"));
               if(vehiclefRepa.IdVehicleRe!=0)
                {                
                    return RedirectToAction("Details", "VehicleReparation", new { id = vehiclefRepa.IdVehicleRe });
                }
                else
                {
                    return RedirectToAction("Profil", "Conductor");
                }
            }


            var servicecarContext = _context.VehicleReparation.Include(v => v.IdVehicleReNavigation);
            return View(await servicecarContext.ToListAsync());
        }

        // GET: VehicleReparation/Details/5
        public async Task<IActionResult> Details(int id)
        {
            int id0 = id;
            if (HttpContext.Session.GetInt32("iduser") == 0)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (HttpContext.Session.GetString("isadmin") != "True")
            {
                var vehiclefRepa = await _context.VehicleReparation
               .Include(v => v.IdVehicleReNavigation)
               .FirstOrDefaultAsync(m => m.IdVehicleReNavigation.VehicleConductor == HttpContext.Session.GetInt32("iduser"));
                id0 = vehiclefRepa.IdVehicleRe;

            }

            if (id0 == null)
            {
                return NotFound();
            }

            var vehicleReparation = await _context.VehicleReparation
                .Include(v => v.IdVehicleReNavigation)
                .FirstOrDefaultAsync(m => m.IdVehicleRe == id0);
            if (vehicleReparation == null)
            {
                return NotFound();
            }

            return View(vehicleReparation);
        }

        // GET: VehicleReparation/Create
        public IActionResult Create()
        {
            if(HttpContext.Session.GetInt32("iduser") == 0)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (HttpContext.Session.GetString("isadmin") == "True")
            {

                return RedirectToAction("DisplayCon", "Admin", new { Id = HttpContext.Session.GetInt32("iduser") });
            }

            ViewData["IdVehicleRe"] = new SelectList(_context.Vehicle, "IdVehicle", "Description");
            return View();
        }

        // POST: VehicleReparation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVehicleRe,Amount,Date")] VehicleReparation vehicleReparation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicleReparation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdVehicleRe"] = new SelectList(_context.Vehicle, "IdVehicle", "Description", vehicleReparation.IdVehicleRe);
            return View(vehicleReparation);
        }

        // GET: VehicleReparation/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if(HttpContext.Session.GetInt32("iduser") == 0)
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

            var vehicleReparation = await _context.VehicleReparation.FindAsync(id);
            if (vehicleReparation == null)
            {
                return NotFound();
            }
            ViewData["IdVehicleRe"] = new SelectList(_context.Vehicle, "IdVehicle", "Description", vehicleReparation.IdVehicleRe);
            return View(vehicleReparation);
        }

        // POST: VehicleReparation/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdVehicleRe,Amount,Date")] VehicleReparation vehicleReparation)
        {
            if (id != vehicleReparation.IdVehicleRe)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicleReparation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleReparationExists(vehicleReparation.IdVehicleRe))
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
            ViewData["IdVehicleRe"] = new SelectList(_context.Vehicle, "IdVehicle", "Description", vehicleReparation.IdVehicleRe);
            return View(vehicleReparation);
        }

        // GET: VehicleReparation/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if(HttpContext.Session.GetInt32("iduser") == 0)
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

            var vehicleReparation = await _context.VehicleReparation
                .Include(v => v.IdVehicleReNavigation)
                .FirstOrDefaultAsync(m => m.IdVehicleRe == id);
            if (vehicleReparation == null)
            {
                return NotFound();
            }

            return View(vehicleReparation);
        }

        // POST: VehicleReparation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicleReparation = await _context.VehicleReparation.FindAsync(id);
            _context.VehicleReparation.Remove(vehicleReparation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleReparationExists(int id)
        {
            return _context.VehicleReparation.Any(e => e.IdVehicleRe == id);
        }
    }
}
