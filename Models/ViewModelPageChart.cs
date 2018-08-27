using System;
using System.Collections.Generic;
using Highsoft.Web.Mvc.Charts;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LoggerPLC.Models
{
    public class ViewModelPageChart
    {
        public ViewModelPageChart()
        {
            Highcharts Chart = new Highcharts();
            List<SelectListItem> ListItems = new List<SelectListItem>();
        }
        public Highcharts Chart { get; set; }
        public List<SelectListItem> ListItems { get; set; }
        public string SelectedItem { get; set; }
    }
}