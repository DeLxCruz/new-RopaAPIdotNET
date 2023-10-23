using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class DetalleVenta : BaseEntity
    {
        [Required]
        public int IdVenta { get; set; }
        public Venta Ventas { get; set; }
        [Required]
        public int IdProducto { get; set; }
        public Inventario Inventarios { get; set; }
        [Required]
        public int IdTalla { get; set; }
        public Talla Tallas { get; set; }
        public int Cantidad { get; set; }
        public double ValorUnit { get; set; }
    }
}