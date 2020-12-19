using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewsProject.data.Models;
using NewsProject.Models;
using System;
using System.Diagnostics;
using System.Security.Claims;

namespace NewsProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        UnitOfWork unitOfWork = new UnitOfWork(new DatabaseContext());
        private readonly UserManager<AppUser> _userManager;

        public HomeController(ILogger<HomeController> logger,UserManager<AppUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
         
        }

        public  IActionResult IndexAsync()
        {
            var userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (User != null)
            {
                return RedirectToAction("Index", "Home", new { area = "User" });

            }


            unitOfWork.ReportRepository.GetAll();

            unitOfWork.ReportRepository.GetTopReports();
            
            unitOfWork.Complete();
            return View(unitOfWork.ReportRepository);

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
