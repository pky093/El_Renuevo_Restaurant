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

        public List<EntComprobantePago> ListarComprobantePago()
        {
            SqlCommand cmd = null;
            List<EntComprobantePago> lista = new List<EntComprobantePago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaComprobante", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntComprobantePago Cli = new EntComprobantePago();
                    Cli.idComprobantePago = Convert.ToInt32(dr["idComprobantePago"]);
                    Cli.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Cli.idPedido = Convert.ToInt32(dr["idPedido"]);
                    Cli.Monto = float.Parse(dr["Monto"].ToString());
                    Cli.fecha = dr["Fecha"].ToString();
                    Cli.MetodoPago = dr["MetodoPago"].ToString();
                    lista.Add(Cli);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }


    }
}
