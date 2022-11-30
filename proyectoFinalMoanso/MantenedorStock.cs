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
    public partial class MantenedorStock : Form
    {
        public MantenedorStock()
        {
            InitializeComponent();
            labelFecha.Text = DateTime.Now.ToShortDateString().ToString();
            listar();


        }

        
        public void listar()
        {
            dgvInsumos.DataSource = logInsumo.Instancia.ListarInsumos();
        }
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            panelBorrar.Visible = false;
            panelCajas.Visible = true;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(cajaCantidad.Text) <= 0)
            {
                MessageBox.Show("no puede ingresar 0 ni negativos");
            }
            else
            {
                try
                {
                    EntInsumos c = new EntInsumos();
                    c.Producto = CajaProducto.Text.Trim();
                    c.cantidad = int.Parse(cajaCantidad.Text.Trim());
                    c.fechaIngreso = labelFecha.Text.Trim();
                    c.habilitado = 1;
                    logInsumo.Instancia.InsertarInsumo(c);
                    MessageBox.Show("insumo registrado con exito.");
                    CajaProducto.Text = string.Empty;
                    cajaCantidad.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.." + ex);
                }
            }
         
            listar();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            panelCajas.Visible = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            panelBorrar.Visible = true;
            panelCajas.Visible = false;

        }

        private void BtnListar_Click_1(object sender, EventArgs e)
        {
            panelCajas.Visible = false;
            dgvInsumos.DataSource = logInsumo.Instancia.ListarInsumOrdenado();
        }

        private void borrarProducto2_Click(object sender, EventArgs e)
        {
            logInsumo.Instancia.DeshabilitarInsumo(int.Parse(cajaBorrar.Text.Trim()));
            cajaBorrar.Text = string.Empty;
            listar();
            
        }
    }
}
