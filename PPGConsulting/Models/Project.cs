using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PPGConsulting.Models
{

    public class Project
    {
        [Key]
        [Required]

        public int ProjectID { get; set; }
        public int StudyID { get; set; }
        public int EmployeeID { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy h:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy h:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Study Study { get; set; }
    }
}