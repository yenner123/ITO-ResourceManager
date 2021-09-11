using ITO_ResourceManager.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITO_ResourceManager.Services
{
    public interface IDependenciaService
    {
        public IEnumerable<DependenciaDTO> GetDependencias();
        public DependenciaDTO GetDependencium(Guid id);
        public void PutDependencium(Guid id, DependenciaDTO dto);
        public DependenciaDTO PostDependencium(DependenciaDTO dto);
        public void DeleteDependencium(Guid id);
    }
}
