using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Cliente : BaseEntity
    {
        [Required]
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        [Required]
        public int IdTipoPersona { get; set; }
        public TipoPersona TiposPersona { get; set; }
        public DateOnly FechaRegistro { get; set; }
        [Required]
        public int IdMuncipio { get; set; }
        public Municipio Municipios { get; set; }

        public ICollection<Venta> Ventas { get; set; }
        public ICollection<Orden> Ordenes { get; set; }
    }
}