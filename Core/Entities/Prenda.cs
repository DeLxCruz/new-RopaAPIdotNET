using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Prenda :  BaseEntity
    {
        [Required]
        public int IdPrenda { get; set; }
        public string Nombre { get; set; }
        public double ValorUnitCOP { get; set; }
        public double ValorUnitUSD { get; set; }
        [Required]
        public int IdEstado { get; set; }
        public Estado Estados { get; set; }
        [Required]
        public int IdTipoProteccion { get; set; }
        public TipoProteccion TiposProteccion { get; set; }
        [Required]
        public int IdGenero { get; set; }
        public Genero Generos { get; set; }

        public ICollection<Inventario> Inventarios { get; set; }
        public ICollection<InsumoPrenda> InsumosPrenda { get; set; }
        public ICollection<DetalleOrden> DetallesOrden { get; set; }
    }
}