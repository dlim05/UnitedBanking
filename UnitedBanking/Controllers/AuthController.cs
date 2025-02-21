using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UnitedBanking.Context;
using UnitedBanking.Models;

namespace UnitedBanking.Controllers
{
    public class AuthController : Controller
    {
        //private readonly UserManager<ApplicationUser> _userManager;
        //private readonly ApplicationDbContext _context;


        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }
    }
}
