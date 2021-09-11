using ITO.ResourceManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITO_ResourceManager.Common.Mappers
{
    public class DependenciaMapper
    {
        public static IEnumerable<DependenciaDTO> ToDTO(IEnumerable<Dependencium> entities)
        {
            return entities.Select(e => ToDTO(e)).ToList();
        }
        public static DependenciaDTO ToDTO(Dependencium entity)
        {
            return new DependenciaDTO()
            {
                Id = entity.Id,
                Nombre = entity.Nombre
            };
        }
        public static Dependencium ToEntity(DependenciaDTO dto)
        {
            return new Dependencium()
            {
                Id = dto.Id,
                Nombre = dto.Nombre
            };
        }
    }
}
