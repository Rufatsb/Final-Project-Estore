using Estore.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Estore.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _manager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IWebHostEnvironment _env;

        public AccountController(IWebHostEnvironment env, UserManager<AppUser> manager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _manager = manager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _env = env;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region Add Role
        public async Task<IActionResult> AddRole()
        {
            if (!await _roleManager.RoleExistsAsync("Admin"))
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = "Admin" });
            }
            //if (!await _roleManager.RoleExistsAsync("Member"))
            //{
            //    await _roleManager.CreateAsync(new IdentityRole { Name = "Member" });
            //}
            //if (!await _roleManager.RoleExistsAsync("User"))
            //{
            //    await _roleManager.CreateAsync(new IdentityRole { Name = "User" });
            //}

            return Content("Role Yarandi");
        }
        #endregion
    }
}
