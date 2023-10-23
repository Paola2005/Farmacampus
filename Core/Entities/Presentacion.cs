using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Presentacion:BaseEntity
    {
        public string Nombre { get; set; }
        public ICollection<Inventario> Inventarios { get; set; }
    }
}