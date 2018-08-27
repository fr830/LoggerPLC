using System;

namespace LoggerPLC.Models
{
    public class Error
    {
        public Error()
        {
            Task = new Task();
        }
        public int ErrorID { get; set; }
        public Task Task { get; set; }
        public string Descryption { get; set; } 
    }
}