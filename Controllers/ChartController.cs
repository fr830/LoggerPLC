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
        
        [HttpPost]
        public IActionResult Draw(ViewModelPageChart vc)
        {
            string selectedItem = vc.SelectedItem;
            List<SelectListItem> listItems = new List<SelectListItem>();

            foreach (LoggerPLC.Models.Task t in repository.Tasks)
            {
                listItems.Add(new SelectListItem
                {
                    Text = t.TaskName,
                    Value = t.TaskName
                });
            }

            ViewModelPageChart viewChart = new ViewModelPageChart();
            var ff = repository.Datas.Where(p => p.Task.TaskName == selectedItem).ToList();
            viewChart.Chart = viewChart.Chart.DrawChart(repository.Datas.Where(p => p.Task.TaskName == selectedItem).ToList(), selectedItem, "", "Value");

            viewChart.ListItems = listItems;
            return View(viewChart);
        }

        [HttpGet]
        public IActionResult Draw(string id)
        {
            var tasks = repository.Tasks.ToList();
            List<SelectListItem> listItems = new List<SelectListItem>();

            foreach (LoggerPLC.Models.Task t in repository.Tasks)
            {
                listItems.Add(new SelectListItem
                {
                    Text = t.TaskName,
                    Value = t.TaskName
                });
            }

            var ff = repository.Datas.Where(p => p.Task.TaskName == id).ToList();
            ViewModelPageChart viewChart = new ViewModelPageChart();
            viewChart.Chart = viewChart.Chart.DrawChart(repository.Datas.Where(p => p.Task.TaskName == id).ToList(), id, "", "Value");
            viewChart.ListItems = listItems;
            return View(viewChart);
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
