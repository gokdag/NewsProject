using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewsProject.data.Models;
using NewsProject.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsProject.Areas.User.Controllers
{
    [Area("User")]
    [Authorize(Roles ="User")]
    [ActionFilterSessionCheck]
    public class HomeController : Controller
    {
        UnitOfWork unitOfWork = new UnitOfWork(new DatabaseContext());

        [Area("User")]
        [Authorize]
        [ActionFilterSessionCheck]
        public IActionResult Index()
        {
            unitOfWork.ReportRepository.GetTopReports();
            return View(unitOfWork.ReportRepository);
        }
    }
}
