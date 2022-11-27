using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logCliente _instancia = new logCliente();
        //privado para evitar la instanciación directa
        public static logCliente Instancia
        {
            get
            {
                return logCliente._instancia;
            }
        }
        #endregion singleton
        public void InsertaCliente(Entcliente Cli)
        {
            datCliente.Instancia.InsertarCliente(Cli);
        }

        public Entcliente BuscarIDcliente(int idcliente)
        {
            return datCliente.Instancia.BuscaridCliente(idcliente);
        }

    }
}
