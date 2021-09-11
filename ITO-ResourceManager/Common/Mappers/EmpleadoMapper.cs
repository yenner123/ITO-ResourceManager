using ITO.ResourceManager.Models;
using ITO_ResourceManager.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITO_ResourceManager.Common.Mappers
{
    public class EmpleadoMapper
    {
        public static IEnumerable<EmpleadoDTO> ToDTO(IEnumerable<Empleado> entities)
        {
            return entities.Select(e => ToDTO(e)).ToList();
        }
        public static EmpleadoDTO ToDTO(Empleado entity)
        {
            return new EmpleadoDTO()
            {
                Id = entity.Id,
                Nombres = entity.Nombres
            };
        }
        public static Empleado ToEntity(EmpleadoDTO dto)
        {
            return new Empleado()
            {
                Id = dto.Id,
                Nombres = dto.Nombres
            };
        }
    }
}
