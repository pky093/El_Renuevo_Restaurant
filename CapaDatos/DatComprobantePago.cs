using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatComprobantePago
    {
        #region sigleton
        EntComprobantePago Cli = null;
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly DatComprobantePago _instancia = new DatComprobantePago();
        //privado para evitar la instanciación directa
        public static DatComprobantePago Instancia
        {
            get
            {
                return DatComprobantePago._instancia;
            }
        }
        #endregion singleton


        public Boolean InsertarComprobante(EntComprobantePago Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaComprobante", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", Cli.idCliente);
                cmd.Parameters.AddWithValue("@idPedido", Cli.idPedido);
                cmd.Parameters.AddWithValue("@Monto", Cli.Monto);
                cmd.Parameters.AddWithValue("@Fecha", Cli.fecha);
                cmd.Parameters.AddWithValue("@MetodoPago", Cli.MetodoPago);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
    }
}
