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
    public class VehicleServicesController : Controller
    {
        private readonly servicecarContext _context;

        public VehicleServicesController(servicecarContext context)
        {
            _context = context;
        }

        // GET: VehicleServices
        public async Task<IActionResult> Index()
        {
            if(HttpContext.Session.GetInt32("iduser") == 0)
            {
                return RedirectToAction("Login", "Home");
            }
            var servicecarContext = _context.VehicleServices.Include(v => v.IdVehicleSeNavigation);
            return View(await servicecarContext.ToListAsync());
        }

        private void f(bool v)
        {
            throw new NotImplementedException();
        }

        // GET: VehicleServices/Details/5
        public async Task<IActionResult> Details(int? id)
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

            var vehicleServices = await _context.VehicleServices
                .Include(v => v.IdVehicleSeNavigation)
                .FirstOrDefaultAsync(m => m.IdVehicleSe == id);
            if (vehicleServices == null)
            {
                return NotFound();
            }

            return View(vehicleServices);
        }

        // GET: VehicleServices/Create
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


            ViewData["IdVehicleSe"] = new SelectList(_context.Vehicle, "IdVehicle", "Description");
            return View();
        }

        // POST: VehicleServices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVehicleSe,Type,Km,Amount,StartDate,EndDate")] VehicleServices vehicleServices)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicleServices);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdVehicleSe"] = new SelectList(_context.Vehicle, "IdVehicle", "Description", vehicleServices.IdVehicleSe);
            return View(vehicleServices);
        }

        // GET: VehicleServices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (TempData["iduser"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else if ((bool)TempData["isadmin"])
            {
                return RedirectToAction("DisplayCon", "Admin");
            }

            if (id == null)
            {
                return NotFound();
            }

            var vehicleServices = await _context.VehicleServices.FindAsync(id);
            if (vehicleServices == null)
            {
                return NotFound();
            }
            ViewData["IdVehicleSe"] = new SelectList(_context.Vehicle, "IdVehicle", "Description", vehicleServices.IdVehicleSe);
            return View(vehicleServices);
        }

        // POST: VehicleServices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdVehicleSe,Type,Km,Amount,StartDate,EndDate")] VehicleServices vehicleServices)
        {
            if (id != vehicleServices.IdVehicleSe)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicleServices);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleServicesExists(vehicleServices.IdVehicleSe))
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
            ViewData["IdVehicleSe"] = new SelectList(_context.Vehicle, "IdVehicle", "Description", vehicleServices.IdVehicleSe);
            return View(vehicleServices);
        }

        // GET: VehicleServices/Delete/5
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

            var vehicleServices = await _context.VehicleServices
                .Include(v => v.IdVehicleSeNavigation)
                .FirstOrDefaultAsync(m => m.IdVehicleSe == id);
            if (vehicleServices == null)
            {
                return NotFound();
            }

            return View(vehicleServices);
        }

        // POST: VehicleServices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicleServices = await _context.VehicleServices.FindAsync(id);
            _context.VehicleServices.Remove(vehicleServices);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleServicesExists(int id)
        {
            return _context.VehicleServices.Any(e => e.IdVehicleSe == id);
        }
    }
}
