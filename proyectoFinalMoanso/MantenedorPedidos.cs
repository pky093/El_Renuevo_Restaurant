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
    public partial class MantenedorPedidos : Form
    {
        float platito;
        float bebidita;
        float total = 0;
        public MantenedorPedidos(string idCliente)
        {
            InitializeComponent();
            labelDNI.Text = idCliente.ToString();
            labelFecha.Text = DateTime.Now.ToShortDateString().ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "cabrito")
            {
                labelPlato.Text = "14.00";
            }
            if (comboBox1.Text == "arroz con pollo")
            {
                labelPlato.Text = "10.00";
            }
           
            platito = float.Parse(labelPlato.Text);
            TotalPagar();
        }
        public void setTotal(float total)
        {
            this.total = total;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox2.Text == "gaseosas personales")
            {
                labelBebida.Text = "2.00";
            }
            if (comboBox2.Text == "inka de litro")
            {
                labelBebida.Text = "3.00";
            }
            bebidita = float.Parse(labelBebida.Text);
            TotalPagar();

        }
        private void TotalPagar()
        {
            float total = platito + bebidita;
            labelMonto.Text = total.ToString();
            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                EntPedido c = new EntPedido();
                c.Plato = comboBox1.Text.Trim();
                c.Bebida = comboBox2.Text.Trim();
                c.Monto = float.Parse(labelMonto.Text.Trim());
                setTotal(float.Parse(labelMonto.Text.Trim()));
                c.clienteDNI = int.Parse(labelDNI.Text.Trim());
                logPedido.Instancia.InsertaPedido(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            this.Close();

        }

        public string returnPago()
        {
            return this.total.ToString();
        }
    }
}
