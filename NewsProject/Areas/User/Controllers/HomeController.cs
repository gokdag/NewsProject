using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewsProject.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsProject.Areas.User.Controllers
{
    public class HomeController : Controller
    {
        [Area("User")]
        [Authorize]
        [ActionFilterSessionCheck]
        public IActionResult Index()
        {
            return View();
        }
    }
}
