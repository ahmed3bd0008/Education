using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EducationMvc.Models;
using Services.Interface;
using Entity.Dto;

namespace EducationMvc.Controllers
{
    public class ExamController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IExamModalService _examModalService;

        public ExamController(ILogger<HomeController> logger,IExamModalService examModalService)
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
            return View();
        }
       [HttpPost]
         public IActionResult addExam( addExamDto addExamDto)
        {
            _examModalService.AddExam(addExamDto);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
