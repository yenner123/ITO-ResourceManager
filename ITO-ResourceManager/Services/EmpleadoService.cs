using ITO_ResourceManager.Common;
using ITO_ResourceManager.Common.Dtos;
using ITO_ResourceManager.Common.Mappers;
using ITO_ResourceManager.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace ITO_ResourceManager.Services
{

    public class EmpleadoService : IEmpleadoService
    {
        private readonly IEmpleadoRepository _empleadoRepository;

        public EmpleadoService(IEmpleadoRepository empleadoRepository)
        {
            _empleadoRepository = empleadoRepository;
        }

        public IEnumerable<EmpleadoDTO> GetDependencias()
        {
            return EmpleadoMapper.ToDTO(_empleadoRepository.GetEmpleados());
        }

        public EmpleadoDTO GetDependencium(Guid id)
        {
            return EmpleadoMapper.ToDTO(_empleadoRepository.GetEmpleado(id));
        }

        public void PutDependencium(Guid id, EmpleadoDTO dto)
        {
            var empleado = EmpleadoMapper.ToEntity(dto);
            _empleadoRepository.PutEmpleado(id, empleado);
        }

        public EmpleadoDTO PostDependencium(EmpleadoDTO dto)
        {
            var empleado = EmpleadoMapper.ToEntity(dto);
            return EmpleadoMapper.ToDTO(_empleadoRepository.PostEmpleado(empleado));
        }

        public void DeleteDependencium(Guid id)
        {
            _empleadoRepository.DeleteEmpleado(id);
        }
    }
}
