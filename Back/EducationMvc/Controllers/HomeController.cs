using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EducationMvc.Models;
using Services.Interface;

namespace EducationMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IExamModalService _examModalService;

        public HomeController(ILogger<HomeController> logger,IExamModalService examModalService)
        {
            _logger = logger;
            _examModalService=examModalService;
        }

        public IActionResult Index()
        {
            DateTime  xx=DateTime.Now;
            return View();
        }

        public IActionResult Privacy()
        {
            _examModalService.GetExam();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
