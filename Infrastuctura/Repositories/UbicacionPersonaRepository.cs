using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastuctura.Data;

namespace Infrastuctura.Repositories
{
    public class UbicacionPersonaRepository : GenericRepository<UbicacionPersona>, IUbicacionPersona
    {
        private readonly TiendaCampusContext _context;

        public UbicacionPersonaRepository(TiendaCampusContext context) : base(context)
        {
            _context = context;
        }
    }
}