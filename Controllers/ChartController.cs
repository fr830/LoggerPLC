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
            var ddd =repository.Datas.Where(p => p.TaskID == id).ToList();
            ;


            return View(Chart.DrawChart(repository.Datas.Where(p => p.TaskID == id).ToList(), "Tytuł wykresu", "", "Value"));
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
