using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logPedido
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logPedido _instancia = new logPedido();
        //privado para evitar la instanciación directa
        public static logPedido Instancia
        {
            get
            {
                return logPedido._instancia;
            }
        }
        #endregion singleton
        public void InsertaPedido(EntPedido pi)
        {
            datPedido.Instancia.InsertarPedido(pi);
        }

        public EntPedido BuscarPedido(string fecha, int id)
        {
            return datPedido.Instancia.BuscaridPedido(fecha, id);
        }

    }
}
