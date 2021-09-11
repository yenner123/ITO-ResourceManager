using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITO_ResourceManager.Common.Dtos
{
    public class EmpleadoDTO
    {
        public Guid Id { get; set; }
        public Guid DependenciaId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
    }
}