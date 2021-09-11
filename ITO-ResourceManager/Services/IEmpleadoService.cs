using ITO_ResourceManager.Common;
using ITO_ResourceManager.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITO_ResourceManager.Services
{
    public interface IEmpleadoService
    {
        public IEnumerable<EmpleadoDTO> GetDependencias();
        public EmpleadoDTO GetDependencium(Guid id);
        public void PutDependencium(Guid id, EmpleadoDTO dto);
        public EmpleadoDTO PostDependencium(EmpleadoDTO dto);
        public void DeleteDependencium(Guid id);
    }
}