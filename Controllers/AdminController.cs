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
    public class AdminController : Controller
    {
        private readonly servicecarContext _context;

        public AdminController(servicecarContext context)
        {
            _context = context;
            
        }



        /*
         var servicecarContext = _context.Conductor.Include(c => c.UserNavigation);
            return View(await servicecarContext.ToListAsync());
         */

        // GET: Admin
        public ActionResult Index()
        {
            if (TempData["iduser"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            return View();
        }
        //ConductorDB();

        public async Task<ActionResult> DisplayConAsync()
        {
            if (TempData["iduser"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            
            var servicecarContext = _context.Conductor.Include(c => c.UserNavigation);
            return View(await servicecarContext.ToListAsync());

        }

        public ActionResult AddCon()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddCon(Conductor cond)
        {
            //Add Conductor
            var servicecarContext = _context.Conductor.Add(cond);
            _context.SaveChanges();


            //------------------------------------------------------------------------
            return RedirectToAction("DisplayCon");
        }
        public async Task<IActionResult> EditConAsync(int id)
        {
            //var cond = ConductorList.Where(c => c.id_user == id).FirstOrDefault();
            /*
            if (id == null)
            {
                return NotFound();
            }
            */
            if (id == null)
            {
                return NotFound();
            }

            var conductor = await _context.Conductor.FirstOrDefaultAsync(m => m.User == id);
            conductor.UserNavigation = await _context.User.FirstOrDefaultAsync(m => m.IdUser == id);
            if (conductor == null)
            {
                return NotFound();
            }


            return View(conductor);


        }
        [HttpPost]
        public async Task<ActionResult> EditConAsync(int id, Conductor condNew)
        {
            //var cond_prev = ConductorList.Where(c => c.id_user == condNew.id_user).FirstOrDefault();
            //ConductorList.Remove(cond_prev);
            //ConductorList.Add(condNew);

            //SaveProduct(Product product, string userID)

            if (ModelState.IsValid)
            {
                try
                {

                    Conductor conductorC = await _context.Conductor
                    .Include(c => c.UserNavigation)
                    .FirstOrDefaultAsync(m => m.User == id);

                    
                    conductorC.Cin = condNew.Cin;
                    conductorC.TelephoneNumber = condNew.TelephoneNumber;
                    conductorC.Adress = condNew.Adress;
                    conductorC.Active= condNew.Active;

                    conductorC.UserNavigation.FName = condNew.UserNavigation.FName;
                    conductorC.UserNavigation.LName = condNew.UserNavigation.LName;
                    conductorC.UserNavigation.Login = condNew.UserNavigation.Login;
                    conductorC.UserNavigation.Password = condNew.UserNavigation.Password;
                    conductorC.UserNavigation.IsAdmin = condNew.UserNavigation.IsAdmin;

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConductorExists(condNew.User))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("DisplayCon");
            }






            return RedirectToAction("DisplayCon");
        }

        private bool ConductorExists(object user)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult> DeleteConAsync(int id)
        {
            //var condToDelete = ConductorList.Where(c => c.id_user == id).FirstOrDefault();


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
        [HttpPost]
        public ActionResult DeleteCon(int id)
        {
            //var condToDelete = ConductorList.Where(c => c.id_user == id).FirstOrDefault();
            //ConductorList.Remove(condToDelete);

            var con = new Conductor()
            {
                User = id
            };
            _context.Remove<Conductor>(con);
            var user0 = new User()
            {
                IdUser = id
            };
            _context.Remove<User>(user0);
            _context.SaveChanges();


            return RedirectToAction("DisplayCon");
        }












        //-----------------------------


        

    }
}
