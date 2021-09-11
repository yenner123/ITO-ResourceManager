using ITO_ResourceManager.Common;
using ITO_ResourceManager.Common.Mappers;
using ITO_ResourceManager.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace ITO_ResourceManager.Services
{

    public class DependenciaService : IDependenciaService
    {
        private readonly IDependenciaRepository _dependenciaRepository;

        public DependenciaService(IDependenciaRepository dependenciaRepository)
        {
            _dependenciaRepository = dependenciaRepository;
        }

        public IEnumerable<DependenciaDTO> GetDependencias()
        {
            return DependenciaMapper.ToDTO(_dependenciaRepository.GetDependencias());
        }

        public DependenciaDTO GetDependencium(Guid id)
        {
            return DependenciaMapper.ToDTO(_dependenciaRepository.GetDependencium(id));
        }

        public void PutDependencium(Guid id, DependenciaDTO dto)
        {
            var dependencia = DependenciaMapper.ToEntity(dto);
            _dependenciaRepository.PutDependencium(id, dependencia);
        }

        public DependenciaDTO PostDependencium(DependenciaDTO dto)
        {
            var dependencia = DependenciaMapper.ToEntity(dto);
            return DependenciaMapper.ToDTO(_dependenciaRepository.PostDependencium(dependencia));
        }

        public void DeleteDependencium(Guid id)
        {
            _dependenciaRepository.DeleteDependencium(id);
        }
    }
}
