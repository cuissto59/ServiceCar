﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using serviceCar.Models.DbModels;

namespace serviceCar.Controllers
{
    public class VehicleController : Controller
    {
        private readonly servicecarContext _context;

        public VehicleController(servicecarContext context)
        {
            _context = context;
        }

        // GET: Vehicle
        public async Task<IActionResult> Index()
        {
            if (TempData["iduser"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else if(!(bool)TempData["isadmin"])
            {
                var vehicle = await _context.Vehicle
                .Include(v => v.VehicleConductorNavigation)
                .FirstOrDefaultAsync(m => m.VehicleConductor == (int)TempData["iduser"]);

                return RedirectToAction("Details", "Conductor" , new { id=vehicle.IdVehicle });
            }
            var servicecarContext = _context.Vehicle.Include(v => v.VehicleConductorNavigation);
            return View(await servicecarContext.ToListAsync());
        }

        // GET: Vehicle/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var id0 = id;
            if (TempData["iduser"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (!(bool)TempData["isadmin"])
            {
                var vehicle0 = await _context.Vehicle
                .Include(v => v.VehicleConductorNavigation)
                .FirstOrDefaultAsync(m => m.VehicleConductor == (int)TempData["iduser"]);
                id0 = vehicle0.IdVehicle;
            }

            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle
                .Include(v => v.VehicleConductorNavigation)
                .FirstOrDefaultAsync(m => m.IdVehicle == id0);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // GET: Vehicle/Create
        public IActionResult Create()
        {
            if (TempData["iduser"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (!(bool)TempData["isadmin"])
            {
                return RedirectToAction("Profil", "Conductor", new { id = (int)TempData["iduser"]});
            }
            ViewData["VehicleConductor"] = new SelectList(_context.Conductor, "User", "Adress");
            return View();
        }

        // POST: Vehicle/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVehicle,VehicleConductor,Img,Description,InUse")] Vehicle vehicle)
        {
            if (TempData["iduser"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (!(bool)TempData["isadmin"])
            {
                return RedirectToAction("Profil", "Conductor", new { id = (int)TempData["iduser"] });
            }
            if (ModelState.IsValid)
            {
                _context.Add(vehicle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["VehicleConductor"] = new SelectList(_context.Conductor, "User", "Adress", vehicle.VehicleConductor);
            return View(vehicle);
        }

        // GET: Vehicle/Edit/5
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

            var vehicle = await _context.Vehicle.FindAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }
            ViewData["VehicleConductor"] = new SelectList(_context.Conductor, "User", "Adress", vehicle.VehicleConductor);
            return View(vehicle);
        }

        // POST: Vehicle/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdVehicle,VehicleConductor,Img,Description,InUse")] Vehicle vehicle)
        {
            if (id != vehicle.IdVehicle)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleExists(vehicle.IdVehicle))
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
            ViewData["VehicleConductor"] = new SelectList(_context.Conductor, "User", "Adress", vehicle.VehicleConductor);
            return View(vehicle);
        }

        // GET: Vehicle/Delete/5
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

            var vehicle = await _context.Vehicle
                .Include(v => v.VehicleConductorNavigation)
                .FirstOrDefaultAsync(m => m.IdVehicle == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // POST: Vehicle/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicle = await _context.Vehicle.FindAsync(id);
            _context.Vehicle.Remove(vehicle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleExists(int id)
        {
            return _context.Vehicle.Any(e => e.IdVehicle == id);
        }
    }
}
