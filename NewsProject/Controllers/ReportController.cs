using Microsoft.AspNetCore.Mvc;
using NewsProject.data.Models;
using NewsProject.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsProject.Controllers
{  [ActionFilterSessionCheck]
    public class ReportController : Controller
    {
        UnitOfWork unitOfWork = new UnitOfWork(new DatabaseContext());

        public IActionResult Index()
        {
            unitOfWork.ReportRepository.GetUptoDateReport();
            unitOfWork.ReportRepository.getTopRead();
            return View(unitOfWork.ReportRepository);
        }
        public IActionResult News(int id)
        {
            unitOfWork.ReportRepository.GetReportWithId(id);
            unitOfWork.ReportRepository.IncreaseReadNumber(id);            
            unitOfWork.Complete();
            ViewBag.IdNumber = id;
            return View("News",unitOfWork.ReportRepository);
         }
        
        public IActionResult List(int id)
        {
            ViewBag.CategoryId = id;
            unitOfWork.ReportRepository.ListWithCategoryId(id);
            return View("List",unitOfWork.ReportRepository);
        }

     
    }
}
