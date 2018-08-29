using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Highsoft.Web.Mvc.Charts;
using LoggerPLC.Models;

namespace LoggerPLC.Helpers
{
    public static class Helper
    {
        public static Highcharts DrawChart(this Highcharts highChatrs, List<LoggerPLC.Models.Data> datas, string title, string subtitle, string titleAsseX, string seriesName)
        {
            List<LineSeriesData> myData = new List<LineSeriesData>();
            List<double> myValue = new List<double>();
            List<string> myCategory = new List<string>();
            
            foreach (LoggerPLC.Models.Data d in datas)
            {
                myValue.Add(d.Value);
                myCategory.Add(d.Date.ToShortTimeString());
            }

            myValue.ForEach(p => myData.Add(new LineSeriesData { Y = p }));
            
            Highcharts chart1 = new Highcharts
            {
                Title = new Title
                {
                    Text = title,
                    X = -20
                },
                Subtitle = new Subtitle
                {
                    Text = subtitle,
                    X = -20
                },
                XAxis = new List<XAxis>
            {
                new XAxis
                {
                    Categories = myCategory,

                }
            },
                YAxis = new List<YAxis>
            {
                new YAxis
                {
                    Title = new YAxisTitle
                    {
                        Text = titleAsseX
                    },
                    PlotLines = new List<YAxisPlotLines>
                    {
                            new YAxisPlotLines
                        {
                            Value = 0,
                            Width = 1,
                            Color = "#808080"
                        }
                    }
                }
            },
                Tooltip = new Tooltip
                {
                    PointFormat = "{point.y} - {point.custom1} - {point.custom2}",
                    //ValueSuffix = "°C"
                },
                Legend = new Legend
                {
                    Layout = LegendLayout.Vertical,
                    Align = LegendAlign.Right,
                    VerticalAlign = LegendVerticalAlign.Middle,
                    BorderWidth = 0
                },
                Series = new List<Series>
            {
                new LineSeries
                {
                    Name = seriesName,
                    Data = myData
                }
            }
            };
            
            return chart1;
        }
    }
}