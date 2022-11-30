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
    public class DatInsumos
    {
        #region sigleton
      
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly DatInsumos _instancia = new DatInsumos();
        //privado para evitar la instanciación directa
        public static DatInsumos Instancia
        {
            get
            {
                return DatInsumos._instancia;
            }
        }
        #endregion singleton

        public Boolean InsertarInsumos(EntInsumos Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaInsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Producto", Cli.Producto);
                cmd.Parameters.AddWithValue("@cantidad", Cli.cantidad);
                cmd.Parameters.AddWithValue("@fechaIngreso", Cli.fechaIngreso);
                cmd.Parameters.AddWithValue("@habilitado",1);
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

        public List<EntInsumos> ListarInsumo()
        {
            SqlCommand cmd = null;
            List<EntInsumos> lista = new List<EntInsumos>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarInsumos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntInsumos Cli = new EntInsumos();
                    Cli.idInsumo = Convert.ToInt32(dr["idInsumo"]);
                    Cli.Producto = dr["Producto"].ToString();
                    Cli.cantidad = Convert.ToInt32(dr["cantidad"]);
                    Cli.fechaIngreso = dr["fechaIngreso"].ToString();
                    Cli.habilitado = Convert.ToInt32(dr["habilitado"]);
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
        public List<EntInsumos> ListarInsumOrdenado()
        {
            SqlCommand cmd = null;
            List<EntInsumos> lista = new List<EntInsumos>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarInsumosOrdenado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntInsumos Cli = new EntInsumos();
                    Cli.idInsumo = Convert.ToInt32(dr["idInsumo"]);
                    Cli.Producto = dr["Producto"].ToString();
                    Cli.cantidad = Convert.ToInt32(dr["cantidad"]);
                    Cli.fechaIngreso = dr["fechaIngreso"].ToString();
                    Cli.habilitado = int.Parse(dr["habilitado"].ToString());
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
        public Boolean DeshabilitarInsumo(int idInsumo)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInabilitarInsumoNombre", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idInsumo", idInsumo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }

    }
}
