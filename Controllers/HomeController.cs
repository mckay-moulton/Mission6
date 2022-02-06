using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {

        private TaskContext DataSource { get; set; }
        public HomeController(TaskContext tc)
        {
            DataSource = tc;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddTask()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTask(TaskForm task)
        {
            //when user submits the form, they will be taken to a confirmation page, and we can confirm the task they entered.
            return View("Confirmation", task);
        }

        public IActionResult Confirmaton()
        {
            
            return View();
        }


        public IActionResult ListView()
        {
            return View();
        }
        public IActionResult QuadView()
        {
            return View();
        }

    }
}
