using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntInsumos
    {
        public int idInsumo { get; set; }
        public string Producto { get; set; }
        public int cantidad { get; set; }
        public string fechaIngreso { get; set; }
       public int habilitado { get; set; }   

    }
}
