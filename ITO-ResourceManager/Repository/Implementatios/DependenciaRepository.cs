using ITO.ResourceManager.Models;
using ITO_ResourceManager.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITO_ResourceManager.Repository.Implementatios
{
    public class DependenciaRepository : IDependenciaRepository
    {
        private readonly ITORMContext _context;

        public DependenciaRepository(ITORMContext context)
        {
            _context = context;
        }

        void IDependenciaRepository.DeleteDependencium(Guid id)
        {
            var dependencium = _context.Dependencia.Find(id);
            if (dependencium != null)
            {
                _context.Dependencia.Remove(dependencium);
                _context.SaveChangesAsync();
            }
        }

        IEnumerable<Dependencium> IDependenciaRepository.GetDependencias()
        {
            return _context.Dependencia.ToList();
        }

        Dependencium IDependenciaRepository.GetDependencium(Guid id)
        {
            return _context.Dependencia.Find(id);
        }

        Dependencium IDependenciaRepository.PostDependencium(Dependencium dependencium)
        {
            _context.Dependencia.Add(dependencium);
            _context.SaveChanges();
            return dependencium;
        }

        void IDependenciaRepository.PutDependencium(Guid id, Dependencium dependencium)
        {
            if (_context.Dependencia.Any(e => e.Id == id))
            {
                _context.Entry(dependencium).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}
