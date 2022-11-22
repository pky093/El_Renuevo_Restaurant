using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace proyectoFinalMoanso
{
    public partial class MantenedorCliente : Form
    {
        public String nombreCliente, apellidoCliente;

        public MantenedorCliente(string nombre, string apellidoCliente)
        {
            InitializeComponent();
            this.nombreCliente = nombre;
            this.apellidoCliente = apellidoCliente;
        }

        private void btnContinuo_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panelCN.Visible = false;
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
            cajaNombre.Text = string.Empty;
            cajaApellido.Text = string.Empty;
            cajaDni.Text = string.Empty;
            cajaTelefono.Text = string.Empty;
            this.Close();
        }
    }
}
