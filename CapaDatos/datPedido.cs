using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CapaDatos
{
    public class datPedido
    {
        #region sigleton
        
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datPedido _instancia = new datPedido();
        //privado para evitar la instanciación directa
        public static datPedido Instancia
        {
            get
            {
                return datPedido._instancia;
            }
        }
        #endregion singleton


        ////////////////////listado de Clientes
        public Boolean InsertarPedido(EntPedido pi)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Bebida", pi.Bebida);
                cmd.Parameters.AddWithValue("@Plato", pi.Plato);
                cmd.Parameters.AddWithValue("@Monto", pi.Monto);
                cmd.Parameters.AddWithValue("@idCliente", pi.idCliente);
                cmd.Parameters.AddWithValue("@FechaPedido", pi.FechaPedido);
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

        public EntPedido BuscaridPedido(string fecha,int id)
        {
            SqlCommand cmd = null;
            EntPedido pe = new EntPedido();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("consultarIDPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaPedido", fecha);
                cmd.Parameters.AddWithValue("@idCliente", id);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    pe.idPedido = Convert.ToInt32(dr["idPedido"]);
                    pe.Bebida = dr["Bebida"].ToString();
                    pe.Plato = dr["Plato"].ToString();
                    pe.Monto = float.Parse(dr["Monto"].ToString());
                    pe.idCliente = Convert.ToInt32(dr["idCliente"]);
                    pe.FechaPedido = dr["FechaPedido"].ToString();

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

            return pe;

        }

    }

}

