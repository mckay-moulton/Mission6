using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.Categories = DataSource.Categories.ToList();
            return View();


        }

        [HttpPost]
        public IActionResult AddTask(TaskForm task)
        {
            DataSource.Add(task);
            DataSource.SaveChanges();

            return View("Confirmation", task);
        }


        public IActionResult Confirmaton()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ListView()
        {
            var alltasks = DataSource.Tasks
                .Include(x => x.Category)
                .ToList();
            return View(alltasks);
        }
        [HttpGet]
        public IActionResult QuadView()
        {
            var alltasks = DataSource.Tasks
                .Include(x => x.Category)
                .ToList();
            return View(alltasks);
        }

    }
}
