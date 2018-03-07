using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnData.PruebaTecnicaHBA.Models
{
    public class category
    {
        

        public int id { get; set; }

        [Required]
        [StringLength(30)]
        public string name { get; set; }

        
        public virtual ICollection<container> containers { get; set; }
    }
}