using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace proyectoFinalMoanso
{
    public partial class MantenedorCliente : Form
    {
        public String nombreCliente, apellidoCliente,idCliente;
        Entcliente xd=null;

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

        public string retonarIDcliente(string id)
        {
            return laid.Text;
        }
   
        private void btnagregar2_Click(object sender, EventArgs e)
        {
            if(cajatextoidCLI.Text=="")
            {
                MessageBox.Show("no puede quedar el espacio en blanco");
            }
            else
            {
                xd = logCliente.Instancia.BuscarIDcliente(int.Parse(cajatextoidCLI.Text));

                laid.Text = xd.ClienteID.ToString();
                if (laid.Text == "0")
                {
                    laid.Visible = false;

                    MessageBox.Show("el cliente no existe en la base de datos");
                    this.Close();
                }
                else
                {
                    lano.Text = xd.Nombre;
                    laap.Text = xd.Apellido;
                    late.Text = xd.Telefono.ToString();
                    ladni.Text = xd.Dni.ToString();
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    button1.Visible = true;
                }


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.idCliente = laid.Text;
            this.nombreCliente = lano.Text;
            this.apellidoCliente = laap.Text;
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            cajaIDcliente.Text =string.Empty;
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
