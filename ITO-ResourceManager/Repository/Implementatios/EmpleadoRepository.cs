using ITO.ResourceManager.Models;
using ITO_ResourceManager.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITO_ResourceManager.Repository.Implementatios
{
    public class EmpleadoRepository: IEmpleadoRepository
    {

        private readonly ITORMContext _context;

        public EmpleadoRepository(ITORMContext context)
        {
            _context = context;
        }

        void IEmpleadoRepository.DeleteEmpleado(Guid id)
        {
            var Empleado = _context.Empleados.Find(id);
            if (Empleado != null)
            {
                _context.Empleados.Remove(Empleado);
                _context.SaveChangesAsync();
            }
        }

        IEnumerable<Empleado> IEmpleadoRepository.GetEmpleados()
        {
            return _context.Empleados.ToList();
        }

        Empleado IEmpleadoRepository.GetEmpleado(Guid id)
        {
            return _context.Empleados.Find(id);
        }

        Empleado IEmpleadoRepository.PostEmpleado(Empleado Empleado)
        {
            _context.Empleados.Add(Empleado);
            _context.SaveChanges();
            return Empleado;
        }

        void IEmpleadoRepository.PutEmpleado(Guid id, Empleado Empleado)
        {
            if (_context.Empleados.Any(e => e.Id == id))
            {
                _context.Entry(Empleado).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}
