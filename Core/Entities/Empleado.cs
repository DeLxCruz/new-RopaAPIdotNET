using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Empleado : BaseEntity
    {
        public int IdEmp { get; set; }
        public string Nombre { get; set; }
        [Required]
        public int IdCargo { get; set; }
        public Cargo Cargos { get; set; }
        public DateOnly FechaIngreso { get; set; }
        [Required]
        public int IdMunicipio { get; set; }
        public Municipio Municipios { get; set; }

        public ICollection<Venta> Ventas { get; set; }
        public ICollection<Orden> Ordenes { get; set; }
    }
}