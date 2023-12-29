using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class tableClient
    {
        [Key]
        public int IdCliente { get; set; }

        [Required]
        public string NombreCliente { get; set; }
        [Required]
        public string ApellidoCliente { get;set; }

        public string Celular { get; set; }

        public string Direccion { get; set; }
        [Required]
        public bool Activo { get; set; }

    }
}
