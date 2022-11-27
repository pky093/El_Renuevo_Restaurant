using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntPedido
    {
        public int idPedido { get; set; }
        public string Bebida { get; set; }
        public string Plato { get; set;}
        public float Monto { get; set; }
        public int idCliente { get; set; }
        public string FechaPedido { get; set; }
    }
}
