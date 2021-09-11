using ITO.ResourceManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITO_ResourceManager.Repository.Interfaces
{
    public interface IDependenciaRepository
    {
        public IEnumerable<Dependencium> GetDependencias();
        public Dependencium GetDependencium(Guid id);
        public void PutDependencium(Guid id, Dependencium dependencium);
        public Dependencium PostDependencium(Dependencium dependencium);
        public void DeleteDependencium(Guid id);
    }
}