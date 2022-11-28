using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntComprobantePago
    {
        public int idComprobantePago { get; set; }
        public int idCliente { get; set; }
        public int idPedido { get; set; }
        public float Monto { get; set; }
        public string fecha { get; set; }
        public  string MetodoPago { get; set; }
    }
}
