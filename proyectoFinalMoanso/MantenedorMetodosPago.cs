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
    public partial class MantenedorMetodosPago : Form
    {
        public MantenedorMetodosPago(string nombre,string apellidos,string pago)
        {
            InitializeComponent();
            this.labelNombre.Text = nombre;
            this.labelApellido.Text = apellidos;
            this.labelTotal.Text = pago;
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            btntarjeta.Enabled= false;
            panelEfectivo.Visible=true;
            btnComprobantePago.Visible = true;
        }

        private void btntarjeta_Click(object sender, EventArgs e)
        {
            btnEfectivo.Enabled = false;
            panelTarjeta.Visible=true;
            btnComprobantePago.Visible = true;

        }

        private void btnComprobantePago_Click(object sender, EventArgs e)
        {
            ComprantePago mm = new ComprantePago();
            mm.Visible=true;
        }
    }
}
