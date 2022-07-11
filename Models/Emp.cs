using System;
using System.ComponentModel.DataAnnotations;

namespace GtihubApp.Models
{
    public class Emp
    {
        [Key]
        public int EId { get; set; } 
        public string EName { get; set; }
        public int EmployeeId { get; set; }
        public string EDesign { get; set; }
        public DateTime EDoj { get; set; }
    }
}
