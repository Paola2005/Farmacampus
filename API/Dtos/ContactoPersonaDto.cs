using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ContactoPersonaDto
    {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public int IdTipoContacto { get; set; }
    }
}