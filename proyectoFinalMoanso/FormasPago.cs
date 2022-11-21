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
    public partial class FormasPago : Form
    {
        public FormasPago(string nombre,string apellidos)
        {
            InitializeComponent();
            this.labelNombre.Text = nombre;
            this.labelApellido.Text = apellidos;
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            btntarjeta.Enabled= false;
            panelEfectivo.Visible=true;
        }

        private void btntarjeta_Click(object sender, EventArgs e)
        {
            btnEfectivo.Enabled = false;
            panelTarjeta.Visible=true;
        }

    }
}
