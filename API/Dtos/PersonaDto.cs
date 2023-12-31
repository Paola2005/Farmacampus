using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class PersonaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateOnly FechaRegistro { get; set; }
        public int IdDocumento { get; set; }
        public int IdRolPersona { get; set; }
        public int IdTipoPersona { get; set; }
    }
}