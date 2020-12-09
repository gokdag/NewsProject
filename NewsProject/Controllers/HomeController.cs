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
        private readonly ILogger<HomeController> _logger;
        UnitOfWork unitOfWork = new UnitOfWork(new DatabaseContext());

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
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
