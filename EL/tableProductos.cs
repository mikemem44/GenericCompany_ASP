using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class tableProductos
    {
        [Key]
        public int IdProducto { get; set; }
        [Required]
        public string NombreProducto { get; set; }
        [Required]
        public string MarcaProducto { get; set; }
        [Required]
        public string PrecioProducto { get; set; }
        [Required]
        public int Stock { get;}
        [Required]
        public bool Activo { get; set; }  

        //edit to test branches and pull requests
    }
}
