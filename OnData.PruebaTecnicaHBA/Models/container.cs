using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnData.PruebaTecnicaHBA.Models
{
    public class container
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public int type_containers_id { get; set; }

        [Required]
        [StringLength(1000)]
        public string content { get; set; }

        public virtual type_container type_containers { get; set; }

        
        public virtual ICollection<category> categories { get; set; }
    }
}