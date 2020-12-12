using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewsProject.data.Models;
using NewsProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NewsProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly ILogger<HomeController> _logger;
        UnitOfWork unitOfWork = new UnitOfWork(new DatabaseContext());

        public HomeController(ILogger<HomeController> logger,SignInManager<AppUser> signInManager,UserManager<AppUser> userManager,RoleManager<IdentityRole> roleManager)
        {
            _logger = logger;
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            
            unitOfWork.ReportRepository.GetAll();

            unitOfWork.ReportRepository.GetTopReports();
            
            unitOfWork.Complete();
            return View(unitOfWork.ReportRepository);

        }
        [HttpGet]
        public IActionResult Register() {
            return View("Register");
        }
        [HttpPost]
        public IActionResult Register(UserRegisterModel model)
        {

            if (ModelState.IsValid)
            {
                IdentityRole newrole = new IdentityRole { Name = "User" };
                var user = new AppUser { UserName = model.userName};
                var result =  _userManager.CreateAsync(user,model.Password).Result;
                IdentityResult resultIdentity = _roleManager.CreateAsync(new IdentityRole(newrole.Name)).Result;
                if (resultIdentity.Succeeded) {
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home", new { area = "User" });
                    }
                }
                
            }
            return View(new UserRegisterModel());

        }

        public IActionResult Login(UserLoginModel loginModel)
        {
            if (ModelState.IsValid)
            {

                if (loginModel.UserName == "kgokdag")
                {
                    var signInResult = _signInManager.PasswordSignInAsync(loginModel.UserName, loginModel.Password, loginModel.RememberMe, false).Result;

                    if (signInResult.Succeeded)
                    {
                        return RedirectToAction("Index", "Home", new { area = "Admin" });
                    }
                }
                else if (loginModel.UserName != "kgokdag" && loginModel.UserName != null)
                {
                    var signInResult = _signInManager.PasswordSignInAsync(loginModel.UserName, loginModel.Password, loginModel.RememberMe,false).Result;
                    if (signInResult.Succeeded)
                    {
                        return RedirectToAction("Index","Home", new { area="User"});
                    }
                }

                ModelState.AddModelError("","Kullanıcı adı veya şifre hatalı");
            }

            return View(new UserLoginModel());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
