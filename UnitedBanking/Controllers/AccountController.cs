using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UnitedBanking.Context;
using UnitedBanking.Models;

namespace UnitedBanking.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Profile()
        {
            return View();
        }

        public async Task<IActionResult> Balance()
        {
            return View(await _context.Balance.ToListAsync());
        }
    }

   
}
