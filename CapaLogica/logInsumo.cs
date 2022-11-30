using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logInsumo
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logInsumo _instancia = new logInsumo();
        //privado para evitar la instanciación directa
        public static logInsumo Instancia
        {
            get
            {
                return logInsumo._instancia;
            }
        }
        #endregion singleton
        public void InsertarInsumo(EntInsumos Cli)
        {
            DatInsumos.Instancia.InsertarInsumos(Cli);
        }
        public List<EntInsumos> ListarInsumos()
        {
            return DatInsumos.Instancia.ListarInsumo();
        }

        public List<EntInsumos> ListarInsumOrdenado()
        {
            return DatInsumos.Instancia.ListarInsumOrdenado();
        }

        public void DeshabilitarInsumo(int idinsumo)
        {
            DatInsumos.Instancia.DeshabilitarInsumo(idinsumo);
        }

    }
}
