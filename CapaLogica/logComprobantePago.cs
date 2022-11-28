using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logComprobantePago
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logComprobantePago _instancia = new logComprobantePago();
        //privado para evitar la instanciación directa
        public static logComprobantePago Instancia
        {
            get
            {
                return logComprobantePago._instancia;
            }
        }
        #endregion singleton
        public void InsertaComprobantePago(EntComprobantePago Cli)
        {
            DatComprobantePago.Instancia.InsertarComprobante(Cli);
        }
    }


}
