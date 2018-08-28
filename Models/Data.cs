using System;
using System.Collections.Generic;
using LoggerPLC.Models;

namespace LoggerPLC.Models
{
     public class Data
    {
        public int DataID { get; set; }
        public DateTime Date { get; set; }
        public int Value { get; set; }
        public Task Task { get; set; }
    }
}