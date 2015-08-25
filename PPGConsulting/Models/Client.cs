using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PPGConsulting.Models
{
    public class Client
    {
        [Key]
        public int ID { get; set; }


        [Required]
        [Display(Name = "Client Name")]
        [StringLength(50)]
        public string ClientName { get; set; }

        [Required]
        [Column("ClientContactName")]
        [Display(Name = "Client Contact Name")]
        [StringLength(50)]
        public string ClientContactName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "OnBoard Date")]
        public DateTime OnBoardDate { get; set; }

        
        public virtual ICollection<Project> Projects { get; set; }
    }
}