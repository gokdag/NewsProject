using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NewsProject.data.Models;
using NewsProject.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    [ActionFilterSessionCheck]
    public class HomeController : Controller
    {
        UnitOfWork unitOfWork = new UnitOfWork(new DatabaseContext());
        RoleManager<IdentityRole> roleManager;

        public HomeController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        public IActionResult Listele()
        {
            unitOfWork.ReportRepository.GetAllWithCategory();

            return View(unitOfWork.ReportRepository);
        }
        public IActionResult DeleteReport(int Id)
        {
            unitOfWork.ReportRepository.DeleteById(Id);
            unitOfWork.Complete();
            return RedirectToAction("Listele", "Home", new { area = "Admin" });
        }
    
        
        /*Roles*/
        public IActionResult Index()
        {
            var roles = roleManager.Roles.ToList();
            return View(roles);
        }

        public IActionResult Create()
        {
            return View(new IdentityRole());
        }

        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            await roleManager.CreateAsync(role);
            return RedirectToAction("Index");
        }
    }
}
