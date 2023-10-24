using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastuctura.Data;

namespace Infrastuctura.Repositories
{
    public class MarcaRepository : GenericRepository<Marca>, IMarca
    {
        private readonly TiendaCampusContext _context;

        public MarcaRepository(TiendaCampusContext context) : base(context)
        {
            _context = context;
        }
    }
}