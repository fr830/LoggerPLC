using System;
using System.ComponentModel.DataAnnotations;

namespace LoggerPLC.Models
{
    public class Task
    {
        public int TaskID { get; set; }

        [Required(ErrorMessage = "Pole wymagane, podaj prawidłową nazwę zdarzenia")]
        [RegularExpression("^[a-zA-Z0-9_.-]*$",ErrorMessage="Niedozwolony znak w nazwie")]
        public string TaskName { get; set; }

        [Required(ErrorMessage = "Pole wymagane, podaj prwidłowe IP PLC, w formacie XXX.XXX.XXX.XXX")]
        [RegularExpression("^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$", ErrorMessage = "Podaj prwidłowe IP PLC, w formacie XXX.XXX.XXX.XXX")]
        public string IpPLC { get; set; }

        [Required(ErrorMessage = "Pole wymagane, podaj prawidłową nazwę taga")]
        [RegularExpression("^[a-zA-Z0-9_.-]*$",ErrorMessage="Niedozwolony znak w nazwie")]
        public string TagName { get; set; }

        [Required(ErrorMessage = "Pole wymagane, podaj długość interwału")] 
        public int TaskInterval { get; set; }
        
        public bool IsActive {get;set;}
    }
}
