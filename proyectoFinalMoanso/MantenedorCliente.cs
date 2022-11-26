using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace proyectoFinalMoanso
{
    public partial class MantenedorCliente : Form
    {
        public String nombreCliente, apellidoCliente,idCliente;

        public MantenedorCliente(string nombre, string apellidoCliente, string idCliente)
        {
            InitializeComponent();
            this.nombreCliente = nombre;
            this.apellidoCliente = apellidoCliente;
            this.idCliente= idCliente;
            generarAleatoria();
        }

        private void btnContinuo_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panelCN.Visible = false;
        }
        public void generarAleatoria()
        {
            Random rnd = new Random();
            string numeritos = "";

            for (int i = 0; i < 4; i++)
            {
                int num = rnd.Next(1,10);
                numeritos= numeritos + num.ToString();
            }
            cajaIDcliente.Text = numeritos;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            panelF.Visible = true;
            panelCN.Visible = false;
        }
        public string retornarNombre()
        {
            return this.nombreCliente;
        }

        public string retornarApellido()
        {
            return this.apellidoCliente;
        }
        public string retornarIDcliente()
        {
            return this.idCliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.idCliente = cajaIDcliente.Text;
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=MIGUEL; Initial Catalog = ElRenuevo;Integrated Security=true");
                con.Open();
                SqlCommand cmd = new SqlCommand("consultarDni", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", cajatextoDNI.Text);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        MessageBox.Show("puede continuar con la ventana pedido");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("EL DNI  NO EXISTE");
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            cajaNombre.Text = string.Empty;
            cajaApellido.Text = string.Empty;
            cajaDni.Text = string.Empty;    
            cajaTelefono.Text = string.Empty;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                Entcliente c = new Entcliente();
                c.ClienteID =int.Parse(cajaIDcliente.Text.Trim());
                c.Nombre = cajaNombre.Text.Trim();
                c.Apellido= cajaApellido.Text.Trim();
                c.Telefono = int.Parse(cajaTelefono.Text.Trim());
                c.Dni = int.Parse(cajaDni.Text.Trim());
                logCliente.Instancia.InsertaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
           
            
           // listarCliente();

            this.nombreCliente = cajaNombre.Text;
            this.apellidoCliente = cajaApellido.Text;
            this.idCliente = cajaIDcliente.Text;
            cajaNombre.Text = string.Empty;
            cajaApellido.Text = string.Empty;
            cajaDni.Text = string.Empty;
            cajaTelefono.Text = string.Empty;
            this.Close();
        }
    }
}
