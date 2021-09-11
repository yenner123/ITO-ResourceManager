using System;
using System.Collections.Generic;

#nullable disable

namespace ITO.ResourceManager.Models
{
    public partial class Dependencium
    {
        public Dependencium()
        {
            Empleados = new HashSet<Empleado>();
        }

        public Guid Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
