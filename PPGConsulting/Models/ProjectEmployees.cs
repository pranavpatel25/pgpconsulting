using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PPGConsulting.Models
{
    public class ProjectEmployees
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public Project Project { get; set; }
        public int ProjectId { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}