using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Inventario :  BaseEntity
    {
        public int CodInv { get; set; }
        [Required]
        public int IdPrenda { get; set; }
        public Prenda Prendas { get; set; }
        public double ValorVtaCOP { get; set; }
        public double ValorVtaUSD { get; set; }

        public ICollection<InventarioTalla> InventariosTalla { get; set; }
        public ICollection<DetalleVenta> DetallesVenta { get; set; }
    }
}