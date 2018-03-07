
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace OnData.PruebaTecnicaHBA.Models
{
    public class type_container
    {
        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string type { get; set; }
        public virtual ICollection<container> containers { get; set; }

    }
}