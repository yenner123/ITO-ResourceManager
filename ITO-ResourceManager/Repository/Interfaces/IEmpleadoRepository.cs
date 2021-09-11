using ITO.ResourceManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITO_ResourceManager.Repository.Interfaces
{
    public interface IEmpleadoRepository
    {
        public IEnumerable<Empleado> GetEmpleados();
        public Empleado GetEmpleado(Guid id);
        public void PutEmpleado(Guid id, Empleado dependencium);
        public Empleado PostEmpleado(Empleado dependencium);
        public void DeleteEmpleado(Guid id);
    }
}