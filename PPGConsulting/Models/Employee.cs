using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace PPGConsulting.Models
{


    public class Employee
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string Title { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy h:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime HireDate { get; set; }
                [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        public virtual ICollection<Project> Projects { get; set; }
        public virtual OfficeAssignment OfficeAssignment { get; set; }
    }
}
