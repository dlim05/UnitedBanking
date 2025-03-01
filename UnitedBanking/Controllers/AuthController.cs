using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UnitedBanking.Context;
using UnitedBanking.Models;

namespace UnitedBanking.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        //private readonly ApplicationDbContext _context;

        private readonly SignInManager<IdentityUser> _signInManager;

        public AuthController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }



        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>Signup(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);

            }

            if (model.Password != model.ConfirmPassword)
            {
                ModelState.AddModelError("", "The password and confirmation password do not match.");
                return View(model); // Return with an error if the passwords don't match
            }

            var user=new IdentityUser { UserName=model.Username, Email=model.Email};
            var result=await _userManager.CreateAsync(user,model.Password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("Index", "Home"); // Redirect to home page
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description); // Add errors to the model state
            }

            return View(model); // Return the view with the errors
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Login", model);
            }

            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, false);
            if (result.Succeeded)
                return RedirectToAction("Index", "Home");
            ModelState.AddModelError("", "Your Username or Password is Incorrect");
            return View("Login", model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
            
    }
}
