using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Departamento : BaseEntity
    {
        public string Nombre { get; set; }
        [Required]
        public int IdPais { get; set; }
        public Pais Paises { get; set; }

        public ICollection<Municipio> Municipios { get; set; }
    }
}