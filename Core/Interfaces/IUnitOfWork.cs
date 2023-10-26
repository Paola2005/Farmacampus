using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        ICiudad Ciudades { get;}
        IDepartamento Departamentos { get;}
        IPais Paises { get;}
        IContactoPersona ContactosPersonas { get;}
        IDetalleMovimientoInventario DetallesMovimientosInventarios { get;}
        IFactura Facturas { get;}
        IFormaPago FormasPagos { get;}
        IInventario Inventarios { get;}
        IMarca Marcas { get;}
        IMovimientoInventario MovimientosInventarios { get;}
        IPersona Personas { get;}
        IPresentacion Presentaciones { get;}
        IProducto Productos { get;}
        IRolPersona RolesPersonas { get;}
        ITipoContacto TiposContactos { get;}
        ITipoDocumento TiposDocumentos { get;}
        ITipoPersona TiposPersonas { get;}
        IUbicacionPersona UbicacionesPersonas { get;}
        ITipoMovimientoInventario TipoMovimiento { get;}
        Task<int>SaveAsync();
    }
}