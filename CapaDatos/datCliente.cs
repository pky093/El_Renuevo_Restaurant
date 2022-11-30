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
    public class datCliente
    {
        #region sigleton
        
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datCliente _instancia = new datCliente();
        //privado para evitar la instanciación directa
        public static datCliente Instancia
        {
            get
            {
                return datCliente._instancia;
            }
        }
        #endregion singleton


        ////////////////////listado de Clientes
        public Boolean InsertarCliente(Entcliente Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", Cli.ClienteID);
                cmd.Parameters.AddWithValue("@nombre", Cli.Nombre);
                cmd.Parameters.AddWithValue("@apellido", Cli.Apellido);
                cmd.Parameters.AddWithValue("@telefono", Cli.Telefono);
                cmd.Parameters.AddWithValue("@dni", Cli.Dni);
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

        public Entcliente BuscaridCliente(int idcliente)
        {
            SqlCommand cmd = null;
             Entcliente Cli = new Entcliente();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("consultarIDCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", idcliente);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Cli.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    Cli.Nombre = dr["nombre"].ToString();
                    Cli.Apellido = dr["apellido"].ToString();
                    Cli.Telefono = Convert.ToInt32(dr["Telefono"]);
                    Cli.Dni = Convert.ToInt32(dr["dni"]);

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

            return Cli;

        }

        public List<Entcliente> ListarPersona()
        {
            SqlCommand cmd = null;
            List<Entcliente> lista = new List<Entcliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaClientes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Entcliente Cli = new Entcliente();
                    Cli.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    Cli.Nombre = dr["nombre"].ToString();
                    Cli.Apellido = dr["apellido"].ToString();
                    Cli.Telefono = Convert.ToInt32(dr["Telefono"]);
                    Cli.Dni = Convert.ToInt32(dr["dni"]);
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

