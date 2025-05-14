using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistrationByASPdotNetCoreMVC.Data;
using RegistrationByASPdotNetCoreMVC.Models;

namespace RegistrationByASPdotNetCoreMVC.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly RegistrationDbConnect _context;

        // ✅ Constructor with proper dependency injection
        public RegistrationController(RegistrationDbConnect context)
        {
            _context = context;
        }

        // GET: Show registration form
        public IActionResult RegistrationForm()
        {
            return View();
        }

        // POST: Handle form submission
        [HttpPost]
        public IActionResult RegistrationForm(Registration registration)
        {

            _context.Registration.Add(registration);
            _context.SaveChanges();
            return RedirectToAction("Success");
        }

        // GET: Success page
        public IActionResult Success()
        {
            return View();
        }
    }
}
