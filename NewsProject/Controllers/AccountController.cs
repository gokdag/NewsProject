using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using NewsProject.data.Models;
using NewsProject.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NewsProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        UnitOfWork unitOfWork = new UnitOfWork(new DatabaseContext());

        public AccountController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;

        }



        [HttpGet]
        public IActionResult Index()
        {
            var user =HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if(user==null)
            {
                return View();
            }
            return RedirectToAction ("Index","Home",new { area="User"});

        }
        [HttpPost]
        public async Task<IActionResult> IndexAsync(UserLoginModel loginModel)
        {

            //if (ModelState.IsValid)
            //{

            //    if (loginModel.UserName == "kgokdag")
            //    {


            //        var signInResult = _signInManager.PasswordSignInAsync(loginModel.UserName, loginModel.Password, loginModel.RememberMe, false).Result;

            //        if (signInResult.Succeeded)
            //        {
            //            return RedirectToAction("Index", "Home", new { area = "Admin" });
            //        }
            //    }
            //    else if (loginModel.UserName != "kgokdag" && loginModel.UserName != null)
            //    {
            //        var signInResult = _signInManager.PasswordSignInAsync(loginModel.UserName, loginModel.Password, loginModel.RememberMe, false).Result;
            //        if (signInResult.Succeeded)
            //        {
            //            var role=_roleManager.FindByNameAsync("User");
            //            role.

            //            return RedirectToAction("Index", "Home", new { area = "User" });
            //        }

            //    }

            //    ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı");
            //}

            //return View(new UserLoginModel());
            
            if (ModelState.IsValid)
                {
                 
                

                var result = await _signInManager.PasswordSignInAsync(loginModel.UserName,loginModel.Password,loginModel.RememberMe,false);
                if (result.Succeeded)
                {
                   
                    if ( loginModel.UserName=="kgokdag")
                    {
                        return RedirectToAction("Index", "Home", new { area = "Admin" });

                    }

                    return RedirectToAction("Index","Home",new { area="User"});
                }

                }
            return View();


        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            var user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (user==null)
            {
                return View();
            }
            return RedirectToAction("Index", "Home", new { area = "User" });
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> RegisterAsync(UserRegisterModel model)
        {

            if (ModelState.IsValid)
            {
                var user = new AppUser { UserName=model.userName};

                IdentityResult chkUser = await _userManager.CreateAsync(user,model.Password);


                    if (chkUser.Succeeded)
                    {
                    var result1 = await _userManager.AddToRoleAsync(user,"User");
                        return RedirectToAction("Index", "Account");
                    }




            }
            return View(model);

        }

        public async Task<IActionResult> LogoutAsync()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index","Account");
        }






    }
}
