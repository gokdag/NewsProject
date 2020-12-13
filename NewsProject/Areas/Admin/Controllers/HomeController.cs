using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {
            return View();
        }
    }
}
