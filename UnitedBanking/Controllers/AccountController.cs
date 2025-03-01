using Microsoft.AspNetCore.Mvc;

namespace UnitedBanking.Controllers
{
    public class AccountController : Controller
    {      
        public IActionResult Profile()
        {
            return View();
        }
    }
}
