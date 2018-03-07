
using OnData.PruebaTecnicaHBA.Models;
using System.Data.Entity;

namespace OnData.PruebaTecnicaHBA.Context
{
    public class StoreContext : DbContext
    {
        public virtual DbSet<type_container> type_containers { get; set; }
        public virtual DbSet<category> categories{ get; set; }
        public virtual DbSet<container> containers{ get; set; }
    }
}