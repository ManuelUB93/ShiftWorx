using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShiftWorx.Data;
using ShiftWorx.Models;

namespace ShiftWorx.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _dbContext;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext dbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _dbContext = dbContext;
        }

        [HttpGet("/Account/LoginInternal")]
        [AllowAnonymous]
        public async Task<IActionResult> LoginInternal(string User, string Password, bool RememberMe)
        {
            var identityUser = await _userManager.FindByEmailAsync(User);
            var test = await _signInManager.PasswordSignInAsync(identityUser, Password, RememberMe, false);
            return Redirect("/");
        }
        [HttpGet("/Account/LogOut")]
        [AllowAnonymous]
        public async Task<IActionResult> LogOut(string token)
        {
            await _signInManager.SignOutAsync();
            return Redirect("/");
        }
        [HttpGet("/Account/Register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register()
        {
            //IdentityRole role = new()
            //{
            //    Name = "SysAdmin"
            //};
            //var res = await _roleManager.CreateAsync(role);
            //IdentityRole role2 = new()
            //{
            //    Name = "Administrator"
            //};
            //var res2 = await _roleManager.CreateAsync(role2);
            //IdentityRole role3 = new()
            //{
            //    Name = "User"
            //};
            //var res3 = await _roleManager.CreateAsync(role3);
            //User User = new User
            //{
            //    UserName = "ManuelUB",
            //    Email = "test@gmail.com",
            //    EmailConfirmed = true
            //};
            //var res4 = await _userManager.CreateAsync(User, "Testing123*");
            //var res5 = await _userManager.AddToRoleAsync(User, "SysAdmin");
            //var identityUser = await _userManager.FindByEmailAsync("test@gmail.com");
            //var test = await _signInManager.PasswordSignInAsync(identityUser, "Testing123*", true, false);
            return Redirect("/");
        }

    }
}
