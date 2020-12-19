using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NewsProject.data.concrete;
using NewsProject.data.Models;
using NewsProject.Filter;
using NewsProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
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

        [HttpGet]
        public IActionResult Update(int id)
        {
            var model = unitOfWork.ReportRepository.GetReportWithId(id);

            ReportViewModel gModel = new ReportViewModel();
            gModel.Id = model.Id;
            gModel.Title = model.Title;
            gModel.LongTitle = model.LongTitle;
            gModel.Content = model.Content;
            gModel.ReadOfNumber = model.ReadOfNumber;
            gModel.CategoryId = model.CategoryId;
            gModel.IsActive = model.IsActive;
            gModel.DateTime = model.DateTime;
            gModel.SourceUrl = model.SourceUrl;
            gModel.Category = model.Category;


            return View("Update", gModel);

        }

        [HttpPost]
        public IActionResult Update(Report model)
        {
            unitOfWork.ReportRepository.UpdateReport(model);
            
            unitOfWork.Complete();

            return RedirectToAction("Listele", "Home");
        }
        [HttpGet]
        public IActionResult CreateReport() {

            return View();
        }
        [HttpPost]
        public IActionResult CreateReport(Report model)
        {
            unitOfWork.ReportRepository.CreateReport(model);
            unitOfWork.Complete();
            return View("Listele",unitOfWork.ReportRepository);
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
