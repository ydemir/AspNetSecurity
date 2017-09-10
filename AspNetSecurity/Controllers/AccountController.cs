using AspNetSecurity.Models.AccountViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;



namespace AspNetSecurity.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
       
        public AccountController(
            UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        
        //
        // GET: /Account/Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        //
        // POST: /Account/Register
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                //TODO: Register the user
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }
        //
        // GET: /Account/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        //
        // POST: /Account/Login
        [HttpPost]
        public IActionResult Login(LoginViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
              
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

    }
}
