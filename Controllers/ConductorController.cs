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
    public class ConductorController : Controller
    {
        private readonly servicecarContext _context;

        public ConductorController(servicecarContext context)
        {
            _context = context;
        }

        // GET: Conductor

        // GET: Conductor/Profil/1
        public async Task<IActionResult> Profil(int? id)
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

            var conductor = await _context.Conductor
                .Include(c => c.UserNavigation)
                .FirstOrDefaultAsync(m => m.User == id);
            if (conductor == null)
            {
                return NotFound();
            }

            return View(conductor);
        }

        private IActionResult Content(object v)
        {
            throw new NotImplementedException();
        }


        // POST: Conductor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        // GET: Conductor/Edit/5
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
            
            var conductor= await _context.Conductor.FirstOrDefaultAsync(m => m.User == id);
            conductor.UserNavigation=await _context.User.FirstOrDefaultAsync(m => m.IdUser==id);
            if (conductor == null)
            {
                return NotFound();
            }

            
            return View(conductor);
        }

        // POST: Conductor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Cin,TelephoneNumber,Adress,UserNavigation")] Conductor conductor)
        {

            
            if (ModelState.IsValid)
            {
                try
                {
                    
                    Conductor conductorC=await _context.Conductor
                    .Include(c => c.UserNavigation)
                    .FirstOrDefaultAsync(m => m.User == id);
                    conductorC.Cin=conductor.Cin;
                    conductorC.TelephoneNumber=conductor.TelephoneNumber;
                    conductorC.Adress=conductor.Adress;
                    conductorC.UserNavigation.Login=conductor.UserNavigation.Login;
                    conductorC.UserNavigation.Password=conductor.UserNavigation.Password;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConductorExists(conductor.User))
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
            ViewData["User"] = new SelectList(_context.User, "IdUser", "FName", conductor.User);
            return View(conductor);
        }

        private bool ConductorExists(int id)
        {
            return _context.Conductor.Any(e => e.User == id);
        }
    }
}
