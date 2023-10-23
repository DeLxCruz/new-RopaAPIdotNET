using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Orden : BaseEntity
    {
        public DateOnly Fecha { get; set; }
        [Required]
        public int IdEmpleado { get; set; }
        public Empleado Empleados { get; set; }
        [Required]
        public int IdCliente { get; set; }
        public Cliente Clientes { get; set; }
        [Required]
        public int IdEstado { get; set; }
        public Estado Estados { get; set; }

        public ICollection<DetalleOrden> DetallesOrden { get; set; }
    }
}