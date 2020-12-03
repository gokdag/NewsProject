using Microsoft.AspNetCore.Mvc;
using NewsProject.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsProject.Controllers
{
    public class ReportController : Controller
    {
        UnitOfWork unitOfWork = new UnitOfWork(new DatabaseContext());

        public IActionResult Index()
        {
            unitOfWork.ReportRepository.GetUptoDateReport();
            return View(unitOfWork.ReportRepository);
        }
     
    }
}
