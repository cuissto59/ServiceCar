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
    public class VehicleBcController : Controller
    {
        private readonly servicecarContext _context;

        public VehicleBcController(servicecarContext context)
        {
            _context = context;
        }

        // GET: VehicleBc
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetInt32("iduser") == 0)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (HttpContext.Session.GetString("isadmin") != "True")
            {

                return RedirectToAction("Profil", "Conductor", new { Id = HttpContext.Session.GetInt32("iduser") });
            }

            var servicecarContext = _context.VehicleBuyContract.Include(v => v.IdVehicleBcNavigation);
            return View(await servicecarContext.ToListAsync());
        }

        // GET: VehicleBc/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (HttpContext.Session.GetInt32("iduser") == 0)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (HttpContext.Session.GetString("isadmin") != "True")
            {

                return RedirectToAction("Profil", "Conductor", new { Id = HttpContext.Session.GetInt32("iduser") });
            }
            if (id == null)
            {
                return NotFound();
            }

            var vehicleBuyContract = await _context.VehicleBuyContract
                .Include(v => v.IdVehicleBcNavigation)
                .FirstOrDefaultAsync(m => m.IdVehicleBc == id);
            if (vehicleBuyContract == null)
            {
                return NotFound();
            }

            return View(vehicleBuyContract);
        }

        // GET: VehicleBc/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.GetInt32("iduser") == 0)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (HttpContext.Session.GetString("isadmin") != "True")
            {

                return RedirectToAction("Profil", "Conductor", new { Id = HttpContext.Session.GetInt32("iduser") });
            }
            ViewData["IdVehicleBc"] = new SelectList(_context.Vehicle, "IdVehicle", "Description");
            return View();
        }

        // POST: VehicleBc/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVehicleBc,Provider,BuyDate,ContractNumber,WarrantyYears,Amount,Tva")] VehicleBuyContract vehicleBuyContract)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicleBuyContract);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdVehicleBc"] = new SelectList(_context.Vehicle, "IdVehicle", "Description", vehicleBuyContract.IdVehicleBc);
            return View(vehicleBuyContract);
        }

        // GET: VehicleBc/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (HttpContext.Session.GetInt32("iduser") == 0)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (HttpContext.Session.GetString("isadmin") != "True")
            {

                return RedirectToAction("Profil", "Conductor", new { Id = HttpContext.Session.GetInt32("iduser") });
            }

            if (id == null)
            {
                return NotFound();
            }

            var vehicleBuyContract = await _context.VehicleBuyContract.FindAsync(id);
            if (vehicleBuyContract == null)
            {
                return NotFound();
            }
            ViewData["IdVehicleBc"] = new SelectList(_context.Vehicle, "IdVehicle", "Description", vehicleBuyContract.IdVehicleBc);
            return View(vehicleBuyContract);
        }

        // POST: VehicleBc/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdVehicleBc,Provider,BuyDate,ContractNumber,WarrantyYears,Amount,Tva")] VehicleBuyContract vehicleBuyContract)
        {
            if (id != vehicleBuyContract.IdVehicleBc)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicleBuyContract);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleBuyContractExists(vehicleBuyContract.IdVehicleBc))
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
            ViewData["IdVehicleBc"] = new SelectList(_context.Vehicle, "IdVehicle", "Description", vehicleBuyContract.IdVehicleBc);
            return View(vehicleBuyContract);
        }

        // GET: VehicleBc/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetInt32("iduser") == 0)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (HttpContext.Session.GetString("isadmin") != "True")
            {

                return RedirectToAction("Profil", "Conductor", new { Id = HttpContext.Session.GetInt32("iduser") });
            }

            if (id == null)
            {
                return NotFound();
            }

            var vehicleBuyContract = await _context.VehicleBuyContract
                .Include(v => v.IdVehicleBcNavigation)
                .FirstOrDefaultAsync(m => m.IdVehicleBc == id);
            if (vehicleBuyContract == null)
            {
                return NotFound();
            }

            return View(vehicleBuyContract);
        }

        // POST: VehicleBc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (HttpContext.Session.GetInt32("iduser") == 0)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (HttpContext.Session.GetString("isadmin") != "True")
            {

                return RedirectToAction("Profil", "Conductor", new { Id = HttpContext.Session.GetInt32("iduser") });
            }

            var vehicleBuyContract = await _context.VehicleBuyContract.FindAsync(id);
            _context.VehicleBuyContract.Remove(vehicleBuyContract);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleBuyContractExists(int id)
        {
            return _context.VehicleBuyContract.Any(e => e.IdVehicleBc == id);
        }
    }
}
