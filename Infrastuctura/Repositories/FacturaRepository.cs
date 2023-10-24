using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastuctura.Data;

namespace Infrastuctura.Repositories
{
    public class FacturaRepository : GenericRepository<Factura>, IFactura
    {
        private readonly TiendaCampusContext context;

        public FacturaRepository(TiendaCampusContext context) : base(context)
        {
            this.context = context;
        }
    }
}