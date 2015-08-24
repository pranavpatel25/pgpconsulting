using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PPGConsulting.Models
{

    public class Study
    {
        [Key]
        [Required]
        public int StudyID { get; set; }
        public string ProjectCode { get; set; }
        public string ClientName { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}