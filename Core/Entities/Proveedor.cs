using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Proveedor : BaseEntity
    {
        public int NitProveedor { get; set; }
        public string Nombre { get; set; }
        [Required]
        public int IdTipoPersona { get; set; }
        public TipoPersona TiposPersona { get; set; }
        [Required]
        public int IdMunicipio { get; set; }
        public Municipio Municipios { get; set; }

        public ICollection<InsumoProveedor> InsumosProveedor { get; set; }
    }
}