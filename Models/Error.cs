using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoggerPLC.Models
{
    public class Error
    {
        public int ErrorID { get; set; }
        public string Descryption { get; set; }
        public int TaskID { get; set; }
    }
}