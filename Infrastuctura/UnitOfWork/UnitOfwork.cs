using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastructure.Repositories;
using Infrastuctura.Data;

namespace Infrastuctura.UnityOfWork
{
    public class UnitOfwork : IUnitOfWork, IDisposable
    {
        private readonly TiendaCampusContext _context;
        public ICiudad _ciudades;
        public IDepartamento _departamentos;
        public IPais _paises;
        public UnitOfwork(TiendaCampusContext context)
        {
            _context = context;
        }
        public IPais Paises
        {
            get
            {
                if (_paises == null)
                {
                    _paises = new PaisRepository(_context);
                }
                return _paises;

            }
        }
        public IDepartamento Departamentos
        {
            get
            {
                if (_departamentos == null)
                {
                    _departamentos = new DepartamentoRepository(_context);
                }
                return _departamentos;

            }
        }
        public ICiudad Ciudades
        {
            get
            {
                if (_ciudades == null)
                {
                    _ciudades = new CiudadRepository(_context);
                }
                return _ciudades;

            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
        public Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}