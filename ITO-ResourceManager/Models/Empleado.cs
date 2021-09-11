using System;
using System.Collections.Generic;

#nullable disable

namespace ITO.ResourceManager.Models
{
    public partial class Empleado
    {
        public Guid Id { get; set; }
        public Guid DependenciaId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        public virtual Dependencium Dependencia { get; set; }
    }
}
