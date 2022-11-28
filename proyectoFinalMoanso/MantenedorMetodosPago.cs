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
    public partial class MantenedorMetodosPago : Form
    {
        EntPedido pe ;
        int idcliente, idpedido;
        float monto;
        string tipoPago;
        string fecha1;
        public MantenedorMetodosPago(string nombre,string apellidos,string pago,string fecha, string idCliente)
        {
            InitializeComponent();
            this.labelNombre.Text = nombre;
            this.labelApellido.Text = apellidos;
            this.labelTotal.Text = pago;
            pe = logPedido.Instancia.BuscarPedido(fecha,int.Parse(idCliente));
            labelIDpedido.Text = pe.idPedido.ToString();
            //
            this.idcliente = int.Parse(idCliente);
            this.idpedido = pe.idPedido;
            this.monto = float.Parse(pago);
            this.fecha1= fecha;
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

        private void btnEfectivo_MouseClick(object sender, MouseEventArgs e)
        {
            this.tipoPago = "efectivo";
        }

        private void btntarjeta_MouseClick(object sender, MouseEventArgs e)
        {
            this.tipoPago = "tarjeta";
        }

        private void btnComprobantePago_Click(object sender, EventArgs e)
        {
           
            ComprantePago mm = new ComprantePago(this.idcliente,this.idpedido,this.monto,this.fecha1,this.tipoPago);
            mm.Visible=true;
        }
    }
}
