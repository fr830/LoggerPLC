using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Highsoft.Web.Mvc.Charts;
using LoggerPLC.Models;
using LoggerPLC.Helpers;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LoggerPLC.Controllers
{
    public class ChartController : Controller
    {
        private IRepository repository;

        public ChartController(IRepository repo)
        {
            repository = repo;
        }

        public IActionResult Draw(int id)
        {
            Highcharts Chart = new Highcharts();
            var data = repository.Datas.Where(p => p.Task.TaskID == id).ToList();
            if (data.Count != 0)
            {
                string title = "Task:  " + data.First().Task.TaskName;
                string subtitle = "IP PLC:  " + data.First().Task.IpPLC + "         Interwał:  " + data.First().Task.TaskInterval + "[s]";
                string value = "Tag PLC:   " + data.First().Task.TagName;
                return View(Chart.DrawChart(data, title, subtitle, value, data.First().Task.TagName));
            }
            else
            {
                return RedirectToAction("Error");
            }
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
