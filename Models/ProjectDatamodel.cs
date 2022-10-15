using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assesment.Models
{
    public class ProjectDatamodel
    {

        [Required]
        public string Project_Name { get; set; }
        [Required]
        public string Project_Status { get; set; }
        [Required]

        public DateTime Project_Completed { get; set; }
        [Required]
        public string Project_Description { get; set; }

        public int Id { get; set; }



        public String Project_Completed_formated { get; set; }
    }
}
