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
    public class VehicleGiController : Controller
    {
        private readonly servicecarContext _context;

        public VehicleGiController(servicecarContext context)
        {
            _context = context;
        }

        // GET: VehicleGi
        public async Task<IActionResult> Index()
        {
            if (TempData["iduser"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (!(bool)TempData["isadmin"])
            {
                return RedirectToAction("Profil", "Conductor", new { id = (int)TempData["iduser"] });
            }

            var servicecarContext = _context.VehicleGeneralInfo.Include(v => v.IdVehicleGiNavigation);
            return View(await servicecarContext.ToListAsync());
        }

        // GET: VehicleGi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (TempData["iduser"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (!(bool)TempData["isadmin"])
            {
                return RedirectToAction("Profil", "Conductor", new { id = (int)TempData["iduser"] });
            }

            if (id == null)
            {
                return NotFound();
            }

            var vehicleGeneralInfo = await _context.VehicleGeneralInfo
                .Include(v => v.IdVehicleGiNavigation)
                .FirstOrDefaultAsync(m => m.IdVehicleGi == id);
            if (vehicleGeneralInfo == null)
            {
                return NotFound();
            }

            return View(vehicleGeneralInfo);
        }

        // GET: VehicleGi/Create
        public IActionResult Create()
        {
            if (TempData["iduser"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (!(bool)TempData["isadmin"])
            {
                return RedirectToAction("Profil", "Conductor", new { id = (int)TempData["iduser"] });
            }

            ViewData["IdVehicleGi"] = new SelectList(_context.Vehicle, "IdVehicle", "Description");
            return View();
        }

        // POST: VehicleGi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVehicleGi,MatriculNumber,Code,GreyCard,ChassisNumber,VehicleType,Acquisition,Mark,Model,ModelYear,InUseYr,Km,BodyType,FuelType")] VehicleGeneralInfo vehicleGeneralInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicleGeneralInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdVehicleGi"] = new SelectList(_context.Vehicle, "IdVehicle", "Description", vehicleGeneralInfo.IdVehicleGi);
            return View(vehicleGeneralInfo);
        }

        // GET: VehicleGi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (TempData["iduser"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (!(bool)TempData["isadmin"])
            {
                return RedirectToAction("Profil", "Conductor", new { id = (int)TempData["iduser"] });
            }

            if (id == null)
            {
                return NotFound();
            }

            var vehicleGeneralInfo = await _context.VehicleGeneralInfo.FindAsync(id);
            if (vehicleGeneralInfo == null)
            {
                return NotFound();
            }
            ViewData["IdVehicleGi"] = new SelectList(_context.Vehicle, "IdVehicle", "Description", vehicleGeneralInfo.IdVehicleGi);
            return View(vehicleGeneralInfo);
        }

        // POST: VehicleGi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdVehicleGi,MatriculNumber,Code,GreyCard,ChassisNumber,VehicleType,Acquisition,Mark,Model,ModelYear,InUseYr,Km,BodyType,FuelType")] VehicleGeneralInfo vehicleGeneralInfo)
        {
            if (id != vehicleGeneralInfo.IdVehicleGi)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicleGeneralInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleGeneralInfoExists(vehicleGeneralInfo.IdVehicleGi))
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
            ViewData["IdVehicleGi"] = new SelectList(_context.Vehicle, "IdVehicle", "Description", vehicleGeneralInfo.IdVehicleGi);
            return View(vehicleGeneralInfo);
        }

        // GET: VehicleGi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (TempData["iduser"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (!(bool)TempData["isadmin"])
            {
                return RedirectToAction("Profil", "Conductor", new { id = (int)TempData["iduser"] });
            }

            if (id == null)
            {
                return NotFound();
            }

            var vehicleGeneralInfo = await _context.VehicleGeneralInfo
                .Include(v => v.IdVehicleGiNavigation)
                .FirstOrDefaultAsync(m => m.IdVehicleGi == id);
            if (vehicleGeneralInfo == null)
            {
                return NotFound();
            }

            return View(vehicleGeneralInfo);
        }

        // POST: VehicleGi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicleGeneralInfo = await _context.VehicleGeneralInfo.FindAsync(id);
            _context.VehicleGeneralInfo.Remove(vehicleGeneralInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleGeneralInfoExists(int id)
        {
            return _context.VehicleGeneralInfo.Any(e => e.IdVehicleGi == id);
        }
    }
}
